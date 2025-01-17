//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrmEarlyBound
{
	
	/// <summary>
	/// Data Performance Dashboard.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dataperformance")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class DataPerformance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DataPerformance() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "dataperformance";
		
		public const string EntitySchemaName = "DataPerformance";
		
		public const string PrimaryIdAttribute = "dataperformanceid";
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// An internal state which indicates whether at least one optimization is applied.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anyoptimizationapplied")]
		public System.Nullable<bool> AnyOptimizationApplied
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("anyoptimizationapplied");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AnyOptimizationApplied");
				this.SetAttributeValue("anyoptimizationapplied", value);
				this.OnPropertyChanged("AnyOptimizationApplied");
			}
		}
		
		/// <summary>
		/// An internal state which indicates whether at least one optimization is available for this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anyoptimizationavailable")]
		public System.Nullable<bool> AnyOptimizationAvailable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("anyoptimizationavailable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AnyOptimizationAvailable");
				this.SetAttributeValue("anyoptimizationavailable", value);
				this.OnPropertyChanged("AnyOptimizationAvailable");
			}
		}
		
		/// <summary>
		/// Name of the component
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("component")]
		public string Component
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("component");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Component");
				this.SetAttributeValue("component", value);
				this.OnPropertyChanged("Component");
			}
		}
		
		/// <summary>
		/// Number of times a queries were executed (Aggregated)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("count")]
		public System.Nullable<int> Count
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("count");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Count");
				this.SetAttributeValue("count", value);
				this.OnPropertyChanged("Count");
			}
		}
		
		/// <summary>
		/// Unique identifier of the performance suggestion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dataperformanceid")]
		public System.Nullable<System.Guid> DataPerformanceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dataperformanceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DataPerformanceId");
				this.SetAttributeValue("dataperformanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("DataPerformanceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dataperformanceid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.DataPerformanceId = value;
			}
		}
		
		/// <summary>
		/// Primary entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entity")]
		public string Entity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Entity");
				this.SetAttributeValue("entity", value);
				this.OnPropertyChanged("Entity");
			}
		}
		
		/// <summary>
		/// The expected average cost benefit of an optimization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedoptimizationimpact")]
		public System.Nullable<decimal> EstimatedOptimizationImpact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("estimatedoptimizationimpact");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EstimatedOptimizationImpact");
				this.SetAttributeValue("estimatedoptimizationimpact", value);
				this.OnPropertyChanged("EstimatedOptimizationImpact");
			}
		}
		
		/// <summary>
		/// The execution period for which the performance metrics are calculated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executionperiod")]
		public string ExecutionPeriod
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("executionperiod");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExecutionPeriod");
				this.SetAttributeValue("executionperiod", value);
				this.OnPropertyChanged("ExecutionPeriod");
			}
		}
		
		/// <summary>
		/// An internal state which shows the result of the last action that was taken on this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastactionresult")]
		public string LastActionResult
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lastactionresult");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastActionResult");
				this.SetAttributeValue("lastactionresult", value);
				this.OnPropertyChanged("LastActionResult");
			}
		}
		
		/// <summary>
		/// Last time an optimization was applied.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastoptimizationdate")]
		public System.Nullable<System.DateTime> LastOptimizationDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastoptimizationdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LastOptimizationDate");
				this.SetAttributeValue("lastoptimizationdate", value);
				this.OnPropertyChanged("LastOptimizationDate");
			}
		}
		
		/// <summary>
		/// Maximum execution time in seconds. (Aggregated)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxtime")]
		public System.Nullable<decimal> MaxTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("maxtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MaxTime");
				this.SetAttributeValue("maxtime", value);
				this.OnPropertyChanged("MaxTime");
			}
		}
		
		/// <summary>
		/// Average execution time in seconds. (Aggregated)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mediantime")]
		public System.Nullable<decimal> MedianTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("mediantime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MedianTime");
				this.SetAttributeValue("mediantime", value);
				this.OnPropertyChanged("MedianTime");
			}
		}
		
		/// <summary>
		/// Minimum execution time in seconds. (Aggregated)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mintime")]
		public System.Nullable<decimal> MinTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("mintime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MinTime");
				this.SetAttributeValue("mintime", value);
				this.OnPropertyChanged("MinTime");
			}
		}
		
		/// <summary>
		/// Data operation that triggered the query (Retrieve Multiple, etc.)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operation")]
		public string Operation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("operation");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Operation");
				this.SetAttributeValue("operation", value);
				this.OnPropertyChanged("Operation");
			}
		}
		
		/// <summary>
		/// Current optimization status of the record, showed to the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("optimizationstatus")]
		public string OptimizationStatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("optimizationstatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OptimizationStatus");
				this.SetAttributeValue("optimizationstatus", value);
				this.OnPropertyChanged("OptimizationStatus");
			}
		}
		
		/// <summary>
		/// Storage consumed by the optimization. (MB)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("optimizationstorage")]
		public System.Nullable<decimal> OptimizationStorage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("optimizationstorage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OptimizationStorage");
				this.SetAttributeValue("optimizationstorage", value);
				this.OnPropertyChanged("OptimizationStorage");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OrganizationId");
				this.SetAttributeValue("organizationid", value);
				this.OnPropertyChanged("OrganizationId");
			}
		}
		
		/// <summary>
		/// Actual performance change after taking an optimization action on the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("realizedoptimizationimpact")]
		public string RealizedOptimizationImpact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("realizedoptimizationimpact");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RealizedOptimizationImpact");
				this.SetAttributeValue("realizedoptimizationimpact", value);
				this.OnPropertyChanged("RealizedOptimizationImpact");
			}
		}
		
		/// <summary>
		/// Name of the solution that owns the component
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solution")]
		public string Solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("solution");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Solution");
				this.SetAttributeValue("solution", value);
				this.OnPropertyChanged("Solution");
			}
		}
		
		/// <summary>
		/// Query Weight of the component. Factored with the Optimization Impact to determine the overall importance of applying an optimization. (P2)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("weight")]
		public System.Nullable<decimal> Weight
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("weight");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Weight");
				this.SetAttributeValue("weight", value);
				this.OnPropertyChanged("Weight");
			}
		}
		
		/// <summary>
		/// N:1 lk_dataperformance_organizationid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_dataperformance_organizationid")]
		public CrmEarlyBound.Organization lk_dataperformance_organizationid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("lk_dataperformance_organizationid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_dataperformance_organizationid");
				this.SetRelatedEntity<CrmEarlyBound.Organization>("lk_dataperformance_organizationid", null, value);
				this.OnPropertyChanged("lk_dataperformance_organizationid");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DataPerformance(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["dataperformanceid"] = base.Id;
                        break;
                    case "dataperformanceid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}