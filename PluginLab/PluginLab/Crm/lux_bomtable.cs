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
	public enum lux_bomtableState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 物料清单 Bill Of Materials
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lux_bomtable")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class lux_bomtable : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_bomtable() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "lux_bomtable";
		
		public const string EntitySchemaName = "lux_bomtable";
		
		public const string PrimaryIdAttribute = "lux_bomtableid";
		
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
		/// 物料清单ID
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_bomnumber")]
		public string lux_bomnumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("lux_bomnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomnumber");
				this.SetAttributeValue("lux_bomnumber", value);
				this.OnPropertyChanged("lux_bomnumber");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_bomtableid")]
		public System.Nullable<System.Guid> lux_bomtableId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("lux_bomtableid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomtableId");
				this.SetAttributeValue("lux_bomtableid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("lux_bomtableId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_bomtableid")]
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
				this.lux_bomtableId = value;
			}
		}
		
		/// <summary>
		/// 業務單位
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
		/// 材料组
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_materialgroup")]
		public Microsoft.Xrm.Sdk.EntityReference lux_materialgroup
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("lux_materialgroup");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_materialgroup");
				this.SetAttributeValue("lux_materialgroup", value);
				this.OnPropertyChanged("lux_materialgroup");
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
		/// 产品
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_product")]
		public Microsoft.Xrm.Sdk.EntityReference lux_product
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("lux_product");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_product");
				this.SetAttributeValue("lux_product", value);
				this.OnPropertyChanged("lux_product");
			}
		}
		
		/// <summary>
		/// 始于 (日)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_validfromdate")]
		public System.Nullable<System.DateTime> lux_validfromdate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lux_validfromdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_validfromdate");
				this.SetAttributeValue("lux_validfromdate", value);
				this.OnPropertyChanged("lux_validfromdate");
			}
		}
		
		/// <summary>
		/// 止于 (日)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_validtodate")]
		public System.Nullable<System.DateTime> lux_validtodate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lux_validtodate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_validtodate");
				this.SetAttributeValue("lux_validtodate", value);
				this.OnPropertyChanged("lux_validtodate");
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
		/// Status of the BOM Table
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.lux_bomtableState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.lux_bomtableState)(System.Enum.ToObject(typeof(CrmEarlyBound.lux_bomtableState), optionSet.Value)));
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
		/// Reason for the status of the BOM Table
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
		/// Reason for the status of the BOM Table
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual lux_bomtable_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((lux_bomtable_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
		/// 1:N lux_bomtable_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_bomtable_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> lux_bomtable_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_bomtable_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomtable_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("lux_bomtable_AsyncOperations", null, value);
				this.OnPropertyChanged("lux_bomtable_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N lux_bomtable_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_bomtable_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_bomtable_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_bomtable_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomtable_DuplicateBaseRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_bomtable_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("lux_bomtable_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_bomtable_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_bomtable_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> lux_bomtable_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_bomtable_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomtable_DuplicateMatchingRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("lux_bomtable_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("lux_bomtable_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N lux_bomtable_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_bomtable_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> lux_bomtable_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_bomtable_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomtable_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("lux_bomtable_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("lux_bomtable_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N lux_bomtable_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_bomtable_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> lux_bomtable_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_bomtable_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomtable_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("lux_bomtable_ProcessSession", null, value);
				this.OnPropertyChanged("lux_bomtable_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N lux_bomtable_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_bomtable_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> lux_bomtable_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_bomtable_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_bomtable_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("lux_bomtable_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("lux_bomtable_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_bomtable_lux_bom_bomtableid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_bomtable_lux_bom_bomtableid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_bom> lux_lux_bomtable_lux_bom_bomtableid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_bom>("lux_lux_bomtable_lux_bom_bomtableid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_bomtable_lux_bom_bomtableid");
				this.SetRelatedEntities<CrmEarlyBound.lux_bom>("lux_lux_bomtable_lux_bom_bomtableid", null, value);
				this.OnPropertyChanged("lux_lux_bomtable_lux_bom_bomtableid");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_bomtable_lux_bom_itembomtableid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_bomtable_lux_bom_itembomtableid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_bom> lux_lux_bomtable_lux_bom_itembomtableid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_bom>("lux_lux_bomtable_lux_bom_itembomtableid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_bomtable_lux_bom_itembomtableid");
				this.SetRelatedEntities<CrmEarlyBound.lux_bom>("lux_lux_bomtable_lux_bom_itembomtableid", null, value);
				this.OnPropertyChanged("lux_lux_bomtable_lux_bom_itembomtableid");
			}
		}
		
		/// <summary>
		/// 1:N lux_lux_bomtable_lux_quotebomversion_bomtableid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_bomtable_lux_quotebomversion_bomtableid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.lux_quotebomversion> lux_lux_bomtable_lux_quotebomversion_bomtableid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.lux_quotebomversion>("lux_lux_bomtable_lux_quotebomversion_bomtableid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_bomtable_lux_quotebomversion_bomtableid");
				this.SetRelatedEntities<CrmEarlyBound.lux_quotebomversion>("lux_lux_bomtable_lux_quotebomversion_bomtableid", null, value);
				this.OnPropertyChanged("lux_lux_bomtable_lux_quotebomversion_bomtableid");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_lux_bomtable
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_lux_bomtable")]
		public CrmEarlyBound.BusinessUnit business_unit_lux_bomtable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_lux_bomtable", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_lux_bomtable");
				this.SetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_lux_bomtable", null, value);
				this.OnPropertyChanged("business_unit_lux_bomtable");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_bomtable_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_bomtable_createdby")]
		public CrmEarlyBound.SystemUser lk_lux_bomtable_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_bomtable_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_createdby", null, value);
				this.OnPropertyChanged("lk_lux_bomtable_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_bomtable_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_bomtable_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_bomtable_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_bomtable_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_bomtable_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_bomtable_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_bomtable_modifiedby")]
		public CrmEarlyBound.SystemUser lk_lux_bomtable_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_bomtable_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_modifiedby", null, value);
				this.OnPropertyChanged("lk_lux_bomtable_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_lux_bomtable_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lux_bomtable_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_lux_bomtable_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_lux_bomtable_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_lux_bomtable_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_lux_bomtable_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lux_businessunit_lux_bomtable_businessunitid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_businessunit_lux_bomtable_businessunitid")]
		public CrmEarlyBound.BusinessUnit lux_businessunit_lux_bomtable_businessunitid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("lux_businessunit_lux_bomtable_businessunitid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_businessunit_lux_bomtable_businessunitid");
				this.SetRelatedEntity<CrmEarlyBound.BusinessUnit>("lux_businessunit_lux_bomtable_businessunitid", null, value);
				this.OnPropertyChanged("lux_businessunit_lux_bomtable_businessunitid");
			}
		}
		
		/// <summary>
		/// N:1 lux_lux_materialgroup_lux_bomtable_materialgroup
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_materialgroup")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_lux_materialgroup_lux_bomtable_materialgroup")]
		public CrmEarlyBound.lux_materialgroup lux_lux_materialgroup_lux_bomtable_materialgroup
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.lux_materialgroup>("lux_lux_materialgroup_lux_bomtable_materialgroup", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_lux_materialgroup_lux_bomtable_materialgroup");
				this.SetRelatedEntity<CrmEarlyBound.lux_materialgroup>("lux_lux_materialgroup_lux_bomtable_materialgroup", null, value);
				this.OnPropertyChanged("lux_lux_materialgroup_lux_bomtable_materialgroup");
			}
		}
		
		/// <summary>
		/// N:1 lux_product_lux_bomtable_product
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lux_product")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_product_lux_bomtable_product")]
		public CrmEarlyBound.Product lux_product_lux_bomtable_product
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Product>("lux_product_lux_bomtable_product", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_product_lux_bomtable_product");
				this.SetRelatedEntity<CrmEarlyBound.Product>("lux_product_lux_bomtable_product", null, value);
				this.OnPropertyChanged("lux_product_lux_bomtable_product");
			}
		}
		
		/// <summary>
		/// N:1 team_lux_bomtable
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_lux_bomtable")]
		public CrmEarlyBound.Team team_lux_bomtable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_lux_bomtable", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_lux_bomtable");
				this.SetRelatedEntity<CrmEarlyBound.Team>("team_lux_bomtable", null, value);
				this.OnPropertyChanged("team_lux_bomtable");
			}
		}
		
		/// <summary>
		/// N:1 user_lux_bomtable
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_lux_bomtable")]
		public CrmEarlyBound.SystemUser user_lux_bomtable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("user_lux_bomtable", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_lux_bomtable");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("user_lux_bomtable", null, value);
				this.OnPropertyChanged("user_lux_bomtable");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public lux_bomtable(object anonymousType) : 
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
                        Attributes["lux_bomtableid"] = base.Id;
                        break;
                    case "lux_bomtableid":
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