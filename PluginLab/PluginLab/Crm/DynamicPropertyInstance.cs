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
	/// Instance of a property with its value.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicpropertyinstance")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class DynamicPropertyInstance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DynamicPropertyInstance() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "dynamicpropertyinstance";
		
		public const string EntitySchemaName = "DynamicPropertyInstance";
		
		public const string PrimaryIdAttribute = "dynamicpropertyinstanceid";
		
		public const string PrimaryNameAttribute = "name";
		
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
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dmtimportstate")]
		public System.Nullable<int> DMTImportState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dmtimportstate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DMTImportState");
				this.SetAttributeValue("dmtimportstate", value);
				this.OnPropertyChanged("DMTImportState");
			}
		}
		
		/// <summary>
		/// Shows the property that this record is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
		public Microsoft.Xrm.Sdk.EntityReference DynamicPropertyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("dynamicpropertyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicPropertyId");
				this.SetAttributeValue("dynamicpropertyid", value);
				this.OnPropertyChanged("DynamicPropertyId");
			}
		}
		
		/// <summary>
		/// Shows the unique identifier of the property instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
		public System.Nullable<System.Guid> DynamicPropertyInstanceid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyinstanceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicPropertyInstanceid");
				this.SetAttributeValue("dynamicpropertyinstanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("DynamicPropertyInstanceid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
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
				this.DynamicPropertyInstanceid = value;
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExchangeRate");
				this.SetAttributeValue("exchangerate", value);
				this.OnPropertyChanged("ExchangeRate");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningBusinessUnit");
				this.SetAttributeValue("owningbusinessunit", value);
				this.OnPropertyChanged("OwningBusinessUnit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningTeam");
				this.SetAttributeValue("owningteam", value);
				this.OnPropertyChanged("OwningTeam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// Shows the object that the property is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Shows the currency associated with the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Shows whether the property value is valid.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validationstatus")]
		public System.Nullable<bool> validationstatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("validationstatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("validationstatus");
				this.SetAttributeValue("validationstatus", value);
				this.OnPropertyChanged("validationstatus");
			}
		}
		
		/// <summary>
		/// Shows the decimal value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuedecimal")]
		public System.Nullable<decimal> ValueDecimal
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("valuedecimal");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueDecimal");
				this.SetAttributeValue("valuedecimal", value);
				this.OnPropertyChanged("ValueDecimal");
			}
		}
		
		/// <summary>
		/// Shows the double value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuedouble")]
		public System.Nullable<double> ValueDouble
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("valuedouble");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueDouble");
				this.SetAttributeValue("valuedouble", value);
				this.OnPropertyChanged("ValueDouble");
			}
		}
		
		/// <summary>
		/// Shows the integer value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valueinteger")]
		public System.Nullable<int> ValueInteger
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("valueinteger");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueInteger");
				this.SetAttributeValue("valueinteger", value);
				this.OnPropertyChanged("ValueInteger");
			}
		}
		
		/// <summary>
		/// Shows the string value of the property.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuestring")]
		public string ValueString
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("valuestring");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ValueString");
				this.SetAttributeValue("valuestring", value);
				this.OnPropertyChanged("ValueString");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("VersionNumber");
				this.SetAttributeValue("versionnumber", value);
				this.OnPropertyChanged("VersionNumber");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyinstance_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyinstance_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> dynamicpropertyinstance_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("dynamicpropertyinstance_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("dynamicpropertyinstance_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("dynamicpropertyinstance_AsyncOperations", null, value);
				this.OnPropertyChanged("dynamicpropertyinstance_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyinstance_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyinstance_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> dynamicpropertyinstance_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("dynamicpropertyinstance_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("dynamicpropertyinstance_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("dynamicpropertyinstance_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("dynamicpropertyinstance_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyinstance_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyinstance_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> dynamicpropertyinstance_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("dynamicpropertyinstance_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("dynamicpropertyinstance_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("dynamicpropertyinstance_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("dynamicpropertyinstance_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_dynamicproperyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_dynamicproperyinstance")]
		public CrmEarlyBound.BusinessUnit business_unit_dynamicproperyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_dynamicproperyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_dynamicproperyinstance");
				this.SetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_dynamicproperyinstance", null, value);
				this.OnPropertyChanged("business_unit_dynamicproperyinstance");
			}
		}
		
		/// <summary>
		/// N:1 DynamicProperty_DynamicPropertyInstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicProperty_DynamicPropertyInstance")]
		public CrmEarlyBound.DynamicProperty DynamicProperty_DynamicPropertyInstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.DynamicProperty>("DynamicProperty_DynamicPropertyInstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DynamicProperty_DynamicPropertyInstance");
				this.SetRelatedEntity<CrmEarlyBound.DynamicProperty>("DynamicProperty_DynamicPropertyInstance", null, value);
				this.OnPropertyChanged("DynamicProperty_DynamicPropertyInstance");
			}
		}
		
		/// <summary>
		/// N:1 Dynamicpropertyinsatance_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Dynamicpropertyinsatance_createdby")]
		public CrmEarlyBound.SystemUser Dynamicpropertyinsatance_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("Dynamicpropertyinsatance_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Dynamicpropertyinsatance_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("Dynamicpropertyinsatance_createdby", null, value);
				this.OnPropertyChanged("Dynamicpropertyinsatance_createdby");
			}
		}
		
		/// <summary>
		/// N:1 InvoiceDetail_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("InvoiceDetail_Dynamicpropertyinstance")]
		public CrmEarlyBound.InvoiceDetail InvoiceDetail_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.InvoiceDetail>("InvoiceDetail_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InvoiceDetail_Dynamicpropertyinstance");
				this.SetRelatedEntity<CrmEarlyBound.InvoiceDetail>("InvoiceDetail_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("InvoiceDetail_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_Dynamicpropertyinsatanceattribute_ModifiedBy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedBy")]
		public CrmEarlyBound.SystemUser lk_Dynamicpropertyinsatanceattribute_ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_Dynamicpropertyinsatanceattribute_ModifiedBy");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null, value);
				this.OnPropertyChanged("lk_Dynamicpropertyinsatanceattribute_ModifiedBy");
			}
		}
		
		/// <summary>
		/// N:1 lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy")]
		public CrmEarlyBound.SystemUser lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null, value);
				this.OnPropertyChanged("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// N:1 OpportunityProduct_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_Dynamicpropertyinstance")]
		public CrmEarlyBound.OpportunityProduct OpportunityProduct_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.OpportunityProduct>("OpportunityProduct_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OpportunityProduct_Dynamicpropertyinstance");
				this.SetRelatedEntity<CrmEarlyBound.OpportunityProduct>("OpportunityProduct_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("OpportunityProduct_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 OwningUser_Dynamicpropertyinsatance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwningUser_Dynamicpropertyinsatance")]
		public CrmEarlyBound.SystemUser OwningUser_Dynamicpropertyinsatance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("OwningUser_Dynamicpropertyinsatance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser_Dynamicpropertyinsatance");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("OwningUser_Dynamicpropertyinsatance", null, value);
				this.OnPropertyChanged("OwningUser_Dynamicpropertyinsatance");
			}
		}
		
		/// <summary>
		/// N:1 QuoteDetail_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_Dynamicpropertyinstance")]
		public CrmEarlyBound.QuoteDetail QuoteDetail_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.QuoteDetail>("QuoteDetail_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("QuoteDetail_Dynamicpropertyinstance");
				this.SetRelatedEntity<CrmEarlyBound.QuoteDetail>("QuoteDetail_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("QuoteDetail_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 SalesOrderDetail_Dynamicpropertyinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_Dynamicpropertyinstance")]
		public CrmEarlyBound.SalesOrderDetail SalesOrderDetail_Dynamicpropertyinstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SalesOrderDetail>("SalesOrderDetail_Dynamicpropertyinstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesOrderDetail_Dynamicpropertyinstance");
				this.SetRelatedEntity<CrmEarlyBound.SalesOrderDetail>("SalesOrderDetail_Dynamicpropertyinstance", null, value);
				this.OnPropertyChanged("SalesOrderDetail_Dynamicpropertyinstance");
			}
		}
		
		/// <summary>
		/// N:1 team_DynamicPropertyInstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_DynamicPropertyInstance")]
		public CrmEarlyBound.Team team_DynamicPropertyInstance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_DynamicPropertyInstance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_DynamicPropertyInstance");
				this.SetRelatedEntity<CrmEarlyBound.Team>("team_DynamicPropertyInstance", null, value);
				this.OnPropertyChanged("team_DynamicPropertyInstance");
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_Dynamicpropertyinsatance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Dynamicpropertyinsatance")]
		public CrmEarlyBound.TransactionCurrency TransactionCurrency_Dynamicpropertyinsatance
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.TransactionCurrency>("TransactionCurrency_Dynamicpropertyinsatance", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrency_Dynamicpropertyinsatance");
				this.SetRelatedEntity<CrmEarlyBound.TransactionCurrency>("TransactionCurrency_Dynamicpropertyinsatance", null, value);
				this.OnPropertyChanged("TransactionCurrency_Dynamicpropertyinsatance");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public DynamicPropertyInstance(object anonymousType) : 
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
                        Attributes["dynamicpropertyinstanceid"] = base.Id;
                        break;
                    case "dynamicpropertyinstanceid":
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