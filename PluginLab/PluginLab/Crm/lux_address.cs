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
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public enum lux_addressState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lux_address")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class lux_address : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_address() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "lux_address";
		
		public const string EntitySchemaName = "lux_address";
		
		public const string PrimaryIdAttribute = "lux_addressid";
		
		public const string PrimaryNameAttribute = "lux_name";
		
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_account")]
		public Microsoft.Xrm.Sdk.EntityReference lux_account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("lux_account");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_account");
				this.SetAttributeValue("lux_account", value);
				this.OnPropertyChanged("lux_account");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_accountaddress")]
		public Microsoft.Xrm.Sdk.EntityReference lux_accountaddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("lux_accountaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_accountaddress");
				this.SetAttributeValue("lux_accountaddress", value);
				this.OnPropertyChanged("lux_accountaddress");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_addressid")]
		public System.Nullable<System.Guid> lux_addressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("lux_addressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_addressId");
				this.SetAttributeValue("lux_addressid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("lux_addressId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_addressid")]
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
				this.lux_addressId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_addresstype")]
		public Microsoft.Xrm.Sdk.OptionSetValue lux_addresstype
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("lux_addresstype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_addresstype");
				this.SetAttributeValue("lux_addresstype", value);
				this.OnPropertyChanged("lux_addresstype");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_addresstype")]
		public virtual lux_AddressType? lux_addresstypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((lux_AddressType?)(EntityOptionSetEnum.GetEnum(this, "lux_addresstype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_addresstype");
				this.SetAttributeValue("lux_addresstype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("lux_addresstype");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_contact")]
		public Microsoft.Xrm.Sdk.EntityReference lux_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("lux_contact");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_contact");
				this.SetAttributeValue("lux_contact", value);
				this.OnPropertyChanged("lux_contact");
			}
		}
		
		/// <summary>
		/// 完整地址
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_fulladdress")]
		public string lux_fulladdress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_fulladdress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_fulladdress");
				this.SetAttributeValue("lux_fulladdress", value);
				this.OnPropertyChanged("lux_fulladdress");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_name")]
		public string lux_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_name");
				this.SetAttributeValue("lux_name", value);
				this.OnPropertyChanged("lux_name");
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
		/// Status of the Address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.lux_addressState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.lux_addressState)(System.Enum.ToObject(typeof(CrmEarlyBound.lux_addressState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual lux_address_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((lux_address_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("StatusCode");
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
		/// 1:N lux_address_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> lux_address_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_address_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_address_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_address_AsyncOperations", null, value);
				this.OnPropertyChanged("lux_address_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N lux_address_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_address_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_address_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_address_DuplicateBaseRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_address_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("lux_address_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_address_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_address_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_address_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_address_DuplicateMatchingRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_address_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("lux_address_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_address_lux_address_accountaddress
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_lux_address_accountaddress", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_address> Referencedlux_address_lux_address_accountaddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_address>("lux_address_lux_address_accountaddress", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedlux_address_lux_address_accountaddress");
				this.SetRelatedEntities<CrmEarlyBound.lux_address>("lux_address_lux_address_accountaddress", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedlux_address_lux_address_accountaddress");
			}
		}
		
		/// <summary>
		/// 1:N lux_address_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> lux_address_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_address_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_address_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_address_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("lux_address_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N lux_address_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> lux_address_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_address_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_address_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_address_ProcessSession", null, value);
				this.OnPropertyChanged("lux_address_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N lux_address_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> lux_address_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_address_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_address_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_address_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("lux_address_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_lux_address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_lux_address")]
		public CrmEarlyBound.BusinessUnit business_unit_lux_address
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_lux_address", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_lux_address");
				this.SetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_lux_address", null, value);
				this.OnPropertyChanged("business_unit_lux_address");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_address_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_address_createdby")]
		public CrmEarlyBound.SystemUser lk_lux_address_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_address_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_createdby", null, value);
				this.OnPropertyChanged("lk_lux_address_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_address_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_address_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_address_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_address_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_address_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_address_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_address_modifiedby")]
		public CrmEarlyBound.SystemUser lk_lux_address_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_address_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_modifiedby", null, value);
				this.OnPropertyChanged("lk_lux_address_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_address_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_address_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_address_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_address_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_address_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_address_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lux_account_lux_address_Account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_account")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_account_lux_address_Account")]
		public CrmEarlyBound.Account lux_account_lux_address_Account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Account>("lux_account_lux_address_Account", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_account_lux_address_Account");
				this.SetRelatedEntity<CrmEarlyBound.Account>("lux_account_lux_address_Account", null, value);
				this.OnPropertyChanged("lux_account_lux_address_Account");
			}
		}
		
		/// <summary>
		/// N:1 lux_address_lux_address_accountaddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_accountaddress")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_address_lux_address_accountaddress", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public CrmEarlyBound.lux_address Referencinglux_address_lux_address_accountaddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.lux_address>("lux_address_lux_address_accountaddress", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencinglux_address_lux_address_accountaddress");
				this.SetRelatedEntity<CrmEarlyBound.lux_address>("lux_address_lux_address_accountaddress", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencinglux_address_lux_address_accountaddress");
			}
		}
		
		/// <summary>
		/// N:1 lux_contact_lux_address_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_contact")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_contact_lux_address_contact")]
		public CrmEarlyBound.Contact lux_contact_lux_address_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Contact>("lux_contact_lux_address_contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_contact_lux_address_contact");
				this.SetRelatedEntity<CrmEarlyBound.Contact>("lux_contact_lux_address_contact", null, value);
				this.OnPropertyChanged("lux_contact_lux_address_contact");
			}
		}
		
		/// <summary>
		/// N:1 team_lux_address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_lux_address")]
		public CrmEarlyBound.Team team_lux_address
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_lux_address", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_lux_address");
				this.SetRelatedEntity<CrmEarlyBound.Team>("team_lux_address", null, value);
				this.OnPropertyChanged("team_lux_address");
			}
		}
		
		/// <summary>
		/// N:1 user_lux_address
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_lux_address")]
		public CrmEarlyBound.SystemUser user_lux_address
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("user_lux_address", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_lux_address");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("user_lux_address", null, value);
				this.OnPropertyChanged("user_lux_address");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_address(object anonymousType) : 
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
                        Attributes["lux_addressid"] = base.Id;
                        break;
                    case "lux_addressid":
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