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
	public enum lux_factoryewscState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 水电损耗摊提费用
	///管理BU期间的水、电、备品备件、易耗品的费用模板，在报价创建工序时带到报价工序。
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lux_factoryewsc")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class lux_factoryewsc : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_factoryewsc() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "lux_factoryewsc";
		
		public const string EntitySchemaName = "lux_factoryewsc";
		
		public const string PrimaryIdAttribute = "lux_factoryewscid";
		
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
		/// Business Unit Id
///組織名稱
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference lux_businessunitid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("lux_businessunitid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_businessunitid");
				this.SetAttributeValue("lux_businessunitid", value);
				this.OnPropertyChanged("lux_businessunitid");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_factoryewscid")]
		public System.Nullable<System.Guid> lux_factoryewscId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("lux_factoryewscid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_factoryewscId");
				this.SetAttributeValue("lux_factoryewscid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("lux_factoryewscId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_factoryewscid")]
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
				this.lux_factoryewscId = value;
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
///水电损耗名称
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
		/// Remark
///摘要
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_remark")]
		public string lux_remark
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_remark");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_remark");
				this.SetAttributeValue("lux_remark", value);
				this.OnPropertyChanged("lux_remark");
			}
		}
		
		/// <summary>
		/// Total Cosumable Parts Cost Year
///消耗总费用/年
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_totalcosumablepartscosty")]
		public System.Nullable<decimal> lux_totalcosumablepartscosty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("lux_totalcosumablepartscosty");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_totalcosumablepartscosty");
				this.SetAttributeValue("lux_totalcosumablepartscosty", value);
				this.OnPropertyChanged("lux_totalcosumablepartscosty");
			}
		}
		
		/// <summary>
		/// Total Electricity Cost Year
///用电总费用/年
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_totalelectricitycosty")]
		public System.Nullable<decimal> lux_totalelectricitycosty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("lux_totalelectricitycosty");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_totalelectricitycosty");
				this.SetAttributeValue("lux_totalelectricitycosty", value);
				this.OnPropertyChanged("lux_totalelectricitycosty");
			}
		}
		
		/// <summary>
		/// Total Spare Parts Cost Year
///备件总费用/年
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_totalsparepartscosty")]
		public System.Nullable<decimal> lux_totalsparepartscosty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("lux_totalsparepartscosty");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_totalsparepartscosty");
				this.SetAttributeValue("lux_totalsparepartscosty", value);
				this.OnPropertyChanged("lux_totalsparepartscosty");
			}
		}
		
		/// <summary>
		/// Total Water Cost Year
///用水总费用/年
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_totalwatercosty")]
		public System.Nullable<decimal> lux_totalwatercosty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("lux_totalwatercosty");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_totalwatercosty");
				this.SetAttributeValue("lux_totalwatercosty", value);
				this.OnPropertyChanged("lux_totalwatercosty");
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
		/// Status of the Factory Eelectricity Water Spare Consumble
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.lux_factoryewscState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.lux_factoryewscState)(System.Enum.ToObject(typeof(CrmEarlyBound.lux_factoryewscState), optionSet.Value)));
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
		/// Reason for the status of the Factory Eelectricity Water Spare Consumble
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
		/// Reason for the status of the Factory Eelectricity Water Spare Consumble
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual lux_factoryewsc_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((lux_factoryewsc_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
		/// 1:N lux_factoryewsc_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_factoryewsc_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> lux_factoryewsc_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_factoryewsc_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_factoryewsc_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_factoryewsc_AsyncOperations", null, value);
				this.OnPropertyChanged("lux_factoryewsc_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N lux_factoryewsc_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_factoryewsc_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_factoryewsc_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_factoryewsc_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_factoryewsc_DuplicateBaseRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_factoryewsc_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("lux_factoryewsc_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_factoryewsc_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_factoryewsc_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_factoryewsc_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_factoryewsc_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_factoryewsc_DuplicateMatchingRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_factoryewsc_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("lux_factoryewsc_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_factoryewsc_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_factoryewsc_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> lux_factoryewsc_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_factoryewsc_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_factoryewsc_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_factoryewsc_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("lux_factoryewsc_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N lux_factoryewsc_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_factoryewsc_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> lux_factoryewsc_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_factoryewsc_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_factoryewsc_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_factoryewsc_ProcessSession", null, value);
				this.OnPropertyChanged("lux_factoryewsc_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N lux_factoryewsc_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_factoryewsc_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> lux_factoryewsc_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_factoryewsc_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_factoryewsc_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_factoryewsc_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("lux_factoryewsc_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_factoryewsc_lux_quotemiscother_factoryewscid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_factoryewsc_lux_quotemiscother_factoryewscid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_quotemiscother> lux_lux_factoryewsc_lux_quotemiscother_factoryewscid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_quotemiscother>("lux_lux_factoryewsc_lux_quotemiscother_factoryewscid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_factoryewsc_lux_quotemiscother_factoryewscid");
				this.SetRelatedEntities<CrmEarlyBound.lux_quotemiscother>("lux_lux_factoryewsc_lux_quotemiscother_factoryewscid", null, value);
				this.OnPropertyChanged("lux_lux_factoryewsc_lux_quotemiscother_factoryewscid");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_lux_factoryewsc
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_lux_factoryewsc")]
		public CrmEarlyBound.BusinessUnit business_unit_lux_factoryewsc
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_lux_factoryewsc", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_lux_factoryewsc");
				this.SetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_lux_factoryewsc", null, value);
				this.OnPropertyChanged("business_unit_lux_factoryewsc");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_factoryewsc_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_factoryewsc_createdby")]
		public CrmEarlyBound.SystemUser lk_lux_factoryewsc_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_factoryewsc_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_createdby", null, value);
				this.OnPropertyChanged("lk_lux_factoryewsc_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_factoryewsc_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_factoryewsc_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_factoryewsc_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_factoryewsc_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_factoryewsc_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_factoryewsc_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_factoryewsc_modifiedby")]
		public CrmEarlyBound.SystemUser lk_lux_factoryewsc_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_factoryewsc_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_modifiedby", null, value);
				this.OnPropertyChanged("lk_lux_factoryewsc_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_factoryewsc_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_factoryewsc_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_factoryewsc_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_factoryewsc_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_factoryewsc_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_factoryewsc_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lux_businessunit_lux_factoryewsc_businessunitid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_businessunit_lux_factoryewsc_businessunitid")]
		public CrmEarlyBound.BusinessUnit lux_businessunit_lux_factoryewsc_businessunitid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("lux_businessunit_lux_factoryewsc_businessunitid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_businessunit_lux_factoryewsc_businessunitid");
				this.SetRelatedEntity<CrmEarlyBound.BusinessUnit>("lux_businessunit_lux_factoryewsc_businessunitid", null, value);
				this.OnPropertyChanged("lux_businessunit_lux_factoryewsc_businessunitid");
			}
		}
		
		/// <summary>
		/// N:1 team_lux_factoryewsc
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_lux_factoryewsc")]
		public CrmEarlyBound.Team team_lux_factoryewsc
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_lux_factoryewsc", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_lux_factoryewsc");
				this.SetRelatedEntity<CrmEarlyBound.Team>("team_lux_factoryewsc", null, value);
				this.OnPropertyChanged("team_lux_factoryewsc");
			}
		}
		
		/// <summary>
		/// N:1 user_lux_factoryewsc
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_lux_factoryewsc")]
		public CrmEarlyBound.SystemUser user_lux_factoryewsc
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("user_lux_factoryewsc", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_lux_factoryewsc");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("user_lux_factoryewsc", null, value);
				this.OnPropertyChanged("user_lux_factoryewsc");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_factoryewsc(object anonymousType) : 
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
                        Attributes["lux_factoryewscid"] = base.Id;
                        break;
                    case "lux_factoryewscid":
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