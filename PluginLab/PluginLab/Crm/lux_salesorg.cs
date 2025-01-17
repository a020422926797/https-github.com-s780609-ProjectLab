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
	public enum lux_salesorgState
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
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lux_salesorg")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class lux_salesorg : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_salesorg() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "lux_salesorg";
		
		public const string EntitySchemaName = "lux_salesorg";
		
		public const string PrimaryIdAttribute = "lux_salesorgid";
		
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_description")]
		public string lux_description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_description");
				this.SetAttributeValue("lux_description", value);
				this.OnPropertyChanged("lux_description");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_description_en")]
		public string lux_description_en
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_description_en");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_description_en");
				this.SetAttributeValue("lux_description_en", value);
				this.OnPropertyChanged("lux_description_en");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_description_vi")]
		public string lux_description_vi
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_description_vi");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_description_vi");
				this.SetAttributeValue("lux_description_vi", value);
				this.OnPropertyChanged("lux_description_vi");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_description_zf")]
		public string lux_description_zf
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_description_zf");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_description_zf");
				this.SetAttributeValue("lux_description_zf", value);
				this.OnPropertyChanged("lux_description_zf");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_languagekey")]
		public Microsoft.Xrm.Sdk.OptionSetValue lux_languagekey
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("lux_languagekey");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_languagekey");
				this.SetAttributeValue("lux_languagekey", value);
				this.OnPropertyChanged("lux_languagekey");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_languagekey")]
		public virtual lux_LanguageKey? lux_languagekeyEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((lux_LanguageKey?)(EntityOptionSetEnum.GetEnum(this, "lux_languagekey")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_languagekey");
				this.SetAttributeValue("lux_languagekey", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("lux_languagekey");
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_salesorgid")]
		public System.Nullable<System.Guid> lux_salesorgId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("lux_salesorgid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_salesorgId");
				this.SetAttributeValue("lux_salesorgid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("lux_salesorgId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_salesorgid")]
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
				this.lux_salesorgId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_sapclientid")]
		public string lux_sapclientid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_sapclientid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_sapclientid");
				this.SetAttributeValue("lux_sapclientid", value);
				this.OnPropertyChanged("lux_sapclientid");
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
		/// Unique identifier for the organization
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
		/// Status of the Sales Organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.lux_salesorgState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.lux_salesorgState)(System.Enum.ToObject(typeof(CrmEarlyBound.lux_salesorgState), optionSet.Value)));
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
		/// Reason for the status of the Sales Organization
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
		/// Reason for the status of the Sales Organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual lux_salesorg_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((lux_salesorg_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
		/// 1:N lux_lux_salesorg_account_salesorg
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_salesorg_account_salesorg")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Account> lux_lux_salesorg_account_salesorg
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Account>("lux_lux_salesorg_account_salesorg", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_salesorg_account_salesorg");
				this.SetRelatedEntities<CrmEarlyBound.Account>("lux_lux_salesorg_account_salesorg", null, value);
				this.OnPropertyChanged("lux_lux_salesorg_account_salesorg");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_salesorg_lux_customermealapplication_companyaddressid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_salesorg_lux_customermealapplication_companyaddressid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_customermealapplication> lux_lux_salesorg_lux_customermealapplication_companyaddressid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_customermealapplication>("lux_lux_salesorg_lux_customermealapplication_companyaddressid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_salesorg_lux_customermealapplication_companyaddressid");
				this.SetRelatedEntities<CrmEarlyBound.lux_customermealapplication>("lux_lux_salesorg_lux_customermealapplication_companyaddressid", null, value);
				this.OnPropertyChanged("lux_lux_salesorg_lux_customermealapplication_companyaddressid");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_salesorg_lux_labmaster_plant
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_salesorg_lux_labmaster_plant")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_labmaster> lux_lux_salesorg_lux_labmaster_plant
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_labmaster>("lux_lux_salesorg_lux_labmaster_plant", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_salesorg_lux_labmaster_plant");
				this.SetRelatedEntities<CrmEarlyBound.lux_labmaster>("lux_lux_salesorg_lux_labmaster_plant", null, value);
				this.OnPropertyChanged("lux_lux_salesorg_lux_labmaster_plant");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_salesorg_lux_plmcustpartcode_salesorg
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_salesorg_lux_plmcustpartcode_salesorg")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_plmcustpartcode> lux_lux_salesorg_lux_plmcustpartcode_salesorg
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_plmcustpartcode>("lux_lux_salesorg_lux_plmcustpartcode_salesorg", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_salesorg_lux_plmcustpartcode_salesorg");
				this.SetRelatedEntities<CrmEarlyBound.lux_plmcustpartcode>("lux_lux_salesorg_lux_plmcustpartcode_salesorg", null, value);
				this.OnPropertyChanged("lux_lux_salesorg_lux_plmcustpartcode_salesorg");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_salesorg_lux_pricelistitem_new_salesorg
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_salesorg_lux_pricelistitem_new_salesorg")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_pricelistitem_new> lux_lux_salesorg_lux_pricelistitem_new_salesorg
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_pricelistitem_new>("lux_lux_salesorg_lux_pricelistitem_new_salesorg", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_salesorg_lux_pricelistitem_new_salesorg");
				this.SetRelatedEntities<CrmEarlyBound.lux_pricelistitem_new>("lux_lux_salesorg_lux_pricelistitem_new_salesorg", null, value);
				this.OnPropertyChanged("lux_lux_salesorg_lux_pricelistitem_new_salesorg");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_salesorg_lux_requestforquotation_salesorg
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_salesorg_lux_requestforquotation_salesorg")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_requestforquotation> lux_lux_salesorg_lux_requestforquotation_salesorg
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_requestforquotation>("lux_lux_salesorg_lux_requestforquotation_salesorg", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_salesorg_lux_requestforquotation_salesorg");
				this.SetRelatedEntities<CrmEarlyBound.lux_requestforquotation>("lux_lux_salesorg_lux_requestforquotation_salesorg", null, value);
				this.OnPropertyChanged("lux_lux_salesorg_lux_requestforquotation_salesorg");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_salesorg_lux_vipcustomerhotelmaster_salesorg
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_salesorg_lux_vipcustomerhotelmaster_salesorg")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_vipcustomerhotelmaster> lux_lux_salesorg_lux_vipcustomerhotelmaster_salesorg
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_vipcustomerhotelmaster>("lux_lux_salesorg_lux_vipcustomerhotelmaster_salesorg", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_salesorg_lux_vipcustomerhotelmaster_salesorg");
				this.SetRelatedEntities<CrmEarlyBound.lux_vipcustomerhotelmaster>("lux_lux_salesorg_lux_vipcustomerhotelmaster_salesorg", null, value);
				this.OnPropertyChanged("lux_lux_salesorg_lux_vipcustomerhotelmaster_salesorg");
			}
		}
		
		/// <summary>
		/// 1:N lux_salesorg_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_salesorg_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> lux_salesorg_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_salesorg_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_salesorg_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_salesorg_AsyncOperations", null, value);
				this.OnPropertyChanged("lux_salesorg_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N lux_salesorg_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_salesorg_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_salesorg_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_salesorg_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_salesorg_DuplicateBaseRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_salesorg_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("lux_salesorg_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_salesorg_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_salesorg_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_salesorg_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_salesorg_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_salesorg_DuplicateMatchingRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_salesorg_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("lux_salesorg_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_salesorg_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_salesorg_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> lux_salesorg_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_salesorg_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_salesorg_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_salesorg_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("lux_salesorg_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N lux_salesorg_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_salesorg_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> lux_salesorg_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_salesorg_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_salesorg_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_salesorg_ProcessSession", null, value);
				this.OnPropertyChanged("lux_salesorg_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N lux_salesorg_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_salesorg_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> lux_salesorg_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_salesorg_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_salesorg_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_salesorg_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("lux_salesorg_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_salesorg_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_salesorg_createdby")]
		public CrmEarlyBound.SystemUser lk_lux_salesorg_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_salesorg_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_createdby", null, value);
				this.OnPropertyChanged("lk_lux_salesorg_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_salesorg_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_salesorg_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_salesorg_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_salesorg_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_salesorg_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_salesorg_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_salesorg_modifiedby")]
		public CrmEarlyBound.SystemUser lk_lux_salesorg_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_salesorg_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_modifiedby", null, value);
				this.OnPropertyChanged("lk_lux_salesorg_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_salesorg_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_salesorg_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_salesorg_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_salesorg_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_salesorg_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_salesorg_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_lux_salesorg
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_lux_salesorg")]
		public CrmEarlyBound.Organization organization_lux_salesorg
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_lux_salesorg", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("organization_lux_salesorg");
				this.SetRelatedEntity<CrmEarlyBound.Organization>("organization_lux_salesorg", null, value);
				this.OnPropertyChanged("organization_lux_salesorg");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_salesorg(object anonymousType) : 
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
                        Attributes["lux_salesorgid"] = base.Id;
                        break;
                    case "lux_salesorgid":
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