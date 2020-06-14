using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using CrmEarlyBound;
using System.ServiceModel;


namespace Luxshare.Crm.Bu17.Plugins.QuoteRoute
{
    /// <summary>
    /// Update Attribute From BaseData When CreateQuote
    /// install in post Operation , Message Create
    /// </summary>
    public class Class1 : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the tracing service
            ITracingService tracingService =
                (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            // Obtain the execution context from the service provider.  
            IPluginExecutionContext context = (IPluginExecutionContext)
                serviceProvider.GetService(typeof(IPluginExecutionContext));

            // The InputParameters collection contains all the data passed in the message request.  
            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is Entity)
            {
                // Obtain the target entity from the input parameters.  
                Entity entity = (Entity)context.InputParameters["Target"];

                // Obtain the organization service reference which you will need for  
                // web service calls.  
                IOrganizationServiceFactory serviceFactory =
                    (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                try
                {
                    tracingService.Trace("1. crmDb");
                    CrmServiceContext crmDb = new CrmServiceContext(service);
                    lux_quoteroute quoteRoute = crmDb.lux_quoterouteSet.SingleOrDefault(x => x.Id.Equals(entity.Id));
                    if (quoteRoute is null)
                    {
                        tracingService.Trace($"quoteRoute is null");
                        throw new Exception("quoteRoute is null");
                    }
                    else
                    {
                        tracingService.Trace($"quoteroute not null - {quoteRoute}");
                    }
                    if (quoteRoute.lux_oprid is null)
                    {
                        tracingService.Trace($"quoteRoute.lux_oprid is null");
                        throw new Exception();
                    }

                    lux_salesparameter salesParameter = crmDb.lux_salesparameterSet.FirstOrDefault();
                    //QuoteRouteService quoteRouteService = new QuoteRouteService(service, tracingService, quoteRoute);
                    tracingService.Trace("1. read data from baseData ");
                    // 1. read data from baseData 
                    decimal totalOps = 0;
                    decimal outputUPH = 0;
                    decimal laborCostBase = 0;
                    decimal laborCostUsd = 0;
                    decimal genericMachineCostBase = 0;
                    decimal genericMachineCostUsd = 0;
                    decimal customizedEquipmentCostBase = 0;
                    decimal customizedEquipmentCostUsd = 0;
                    decimal fixtureCostBase = 0;
                    decimal fixtureCostUsd = 0;
                    decimal partiiCostBase = 0;
                    decimal partiiCostUsd = 0;
                    decimal totalCostBase = 0;
                    decimal totalCostUsd = 0;
                    decimal paintCostBase = 0;
                    decimal paintCostUsd = 0;

                    lux_routeoprtable operation = crmDb.lux_routeoprtableSet.SingleOrDefault(x => x.Id.Equals(quoteRoute.lux_oprid.Id));
                    List<lux_routeoprmc> operationMCs = crmDb.lux_routeoprmcSet.Where(x => x.Id.Equals(operation.Id)).ToList();
                    List<lux_operationsmcequipment> operationsMCEquipments = new List<lux_operationsmcequipment>();
                    foreach (lux_routeoprmc operationMC in operationMCs)
                    {
                        List<lux_operationsmcequipment> tempList =
                            crmDb.lux_operationsmcequipmentSet.Where(x => x.Id.Equals(operationMC.Id)).ToList();
                        operationsMCEquipments.AddRange(tempList);
                    }

                    // one
                    operationMCs.ForEach(operationMC =>
                    {
                        totalOps += (decimal)operationMC.lux_op;
                    });

                    // two
                    operationMCs.ForEach(operationMC =>
                    {
                        outputUPH += (decimal)operationMC.lux_balanceduph;
                    });

                    outputUPH = outputUPH * (decimal)quoteRoute.lux_estimateeffciency * (decimal)quoteRoute.lux_estimateyield;

                    // three
                    laborCostBase = totalOps * (decimal)quoteRoute.lux_laborcosthbase * outputUPH;

                    // four
                    laborCostUsd = laborCostBase * (decimal)quoteRoute.lux_exchangerate;

                    // six
                    operationsMCEquipments.ForEach(operationMCEquipment =>
                    {
                        if (operationMCEquipment.lux_equipmentcategoryEnum == lux_EquipmentCategory.CommonEquipment)
                        {
                            genericMachineCostBase += (decimal)operationMCEquipment.lux_amountbase;
                        }
                    });

                    if (salesParameter.lux_gmcyear == 0 || salesParameter.lux_gmcmonth == 0 || salesParameter.lux_gmcday == 0 || salesParameter.lux_gmchour == 0 || outputUPH == 0)
                    {
                        tracingService.Trace("devided by zero: salesParameter.lux_gmcyear, salesParameter.lux_gmcmonth, salesParameter.lux_gmcday, salesParameter.lux_gmchour, outputUPH");
                        genericMachineCostBase = 0;
                    }
                    else
                    {
                        genericMachineCostBase = genericMachineCostBase
                                / (decimal)salesParameter.lux_gmcyear / (decimal)salesParameter.lux_gmcmonth
                                / (decimal)salesParameter.lux_gmcday / (decimal)salesParameter.lux_gmchour
                                / (decimal)outputUPH;
                    }

                    // seven
                    genericMachineCostUsd = genericMachineCostBase * (decimal)quoteRoute.lux_exchangerate;

                    //eight

                    operationsMCEquipments.ForEach(operationMCEquipment =>
                                     {
                                         if (operationMCEquipment.lux_equipmentcategoryEnum == lux_EquipmentCategory.CustomizeEquipment)
                                         {
                                             customizedEquipmentCostBase += (decimal)operationMCEquipment.lux_amountbase;
                                         }
                                     });


                    tracingService.Trace("eight: operationMCEquipment.lux_equipmentcategoryEnum");



                    customizedEquipmentCostBase = customizedEquipmentCostBase / (decimal)quoteRoute.lux_estimatetotalvolum;

                    // nine
                    customizedEquipmentCostUsd = customizedEquipmentCostBase * (decimal)quoteRoute.lux_exchangerate;
                    tracingService.Trace("nine");

                    //ten
                    operationsMCEquipments.ForEach(operationsMCEquipment =>
                    {
                        if (operationsMCEquipment.lux_equipmentcategoryEnum == lux_EquipmentCategory.FixtureConsummablespareparts && operationsMCEquipment.lux_amountbase != null)
                        {
                            fixtureCostBase += (decimal)operationsMCEquipment.lux_amountbase;
                        }
                    });

                    fixtureCostBase = fixtureCostBase / (decimal)quoteRoute.lux_estimatetotalvolum;
                    fixtureCostUsd = fixtureCostBase * (decimal)quoteRoute.lux_exchangerate;
                    tracingService.Trace("ten");
                    // eleven
                    if (quoteRoute.lux_quoterouteversion is null)
                    {
                        tracingService.Trace("quoteRoute.lux_quoterouteversion is null");
                    }
                    else
                    {
                        lux_quoterouteversion quoteRouteVersionDro = crmDb.lux_quoterouteversionSet.SingleOrDefault(x => x.Id.Equals(quoteRoute.lux_quoterouteversion.Id));
                        Quote quoteDro = crmDb.QuoteSet.SingleOrDefault(x => x.Id.Equals(quoteRouteVersionDro.lux_quoteid.Id));
                        lux_quotemisc quotemiscDro = crmDb.lux_quotemiscSet.FirstOrDefault(x => x.lux_quote.Id.Equals(quoteDro.Id));
                        lux_quotemiscother quotemiscotherDro = crmDb.lux_quotemiscotherSet.FirstOrDefault(x => x.lux_quotemisc.Id.Equals(quotemiscDro.Id));
                        partiiCostBase = (decimal)quotemiscotherDro.lux_totalelectricity / (decimal)quotemiscotherDro.lux_totalwatercosty / (decimal)quotemiscotherDro.lux_totalspareparts / (decimal)quotemiscotherDro.lux_totalcosumablepartscost;
                    }

                    // twelve
                    partiiCostUsd = partiiCostBase * (decimal)quoteRoute.lux_exchangerate;

                    // thirteen
                    totalCostBase = laborCostBase + genericMachineCostBase + customizedEquipmentCostBase + fixtureCostBase + partiiCostBase + paintCostBase;

                    // forteen
                    totalCostUsd = totalCostBase * (decimal)quoteRoute.lux_exchangerate;

                    // fifteen

                    lux_quoteroutepmd quoteRoutePmd = crmDb.lux_quoteroutepmdSet.FirstOrDefault(x => x.Id.Equals(((lux_quoteroutepmd)quoteRoute.Attributes["lux_quoteroutepaintmaterialdosageid"]).Id));
                    lux_quoteroutepc quoteRoutePc = crmDb.lux_quoteroutepcSet.FirstOrDefault(x => x.Id.Equals(quoteRoutePmd.Id));
                    paintCostBase = (decimal)quoteRoutePc.Attributes["lux_costbase"];


                    tracingService.Trace("Get paint Cost base fail");



                    // sixteen
                    paintCostUsd = paintCostBase * (decimal)quoteRoute.lux_exchangerate;
                    tracingService.Trace("2. mapping data to quoteRoute created");

                    // 2. mapping data to quoteRoute created
                    quoteRoute.lux_ops = totalOps;
                    quoteRoute.lux_outputuph = outputUPH;
                    quoteRoute.lux_laborcostbase = laborCostBase;
                    quoteRoute.lux_laborcostusd = laborCostUsd;
                    quoteRoute.lux_genericmachinecostbase = genericMachineCostBase;
                    quoteRoute.lux_genericmachinecostusd = genericMachineCostUsd;
                    quoteRoute.lux_customizedequipmentcostbase = customizedEquipmentCostBase;
                    quoteRoute.lux_customizedequipmentcostusd = customizedEquipmentCostUsd;
                    quoteRoute.lux_fixturecostbase = fixtureCostBase;
                    quoteRoute.lux_fixturecostusd = fixtureCostUsd;
                    quoteRoute.lux_partiicostbase = partiiCostBase;
                    quoteRoute.lux_partiicostusd = partiiCostUsd;
                    quoteRoute.lux_totalcostbase = totalCostBase;
                    quoteRoute.lux_totalcostusd = totalCostUsd;
                    quoteRoute.Attributes["lux_paintcostbase"] = paintCostBase;
                    quoteRoute.Attributes["lux_paintcostusd"] = paintCostUsd;

                    tracingService.Trace("Update QuoteRoute");
                    // Update QuoteRoute
                    service.Update(quoteRoute);

                    throw new Exception("故意的");
                }

                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in QuoteRoute - Plugin.", ex);
                }

                catch (Exception ex)
                {
                    tracingService.Trace("QuoteRoute - Plugin: {0}, {1}", ex.ToString(), ex.Message);
                    throw;
                }
            }
        }
    }
}
