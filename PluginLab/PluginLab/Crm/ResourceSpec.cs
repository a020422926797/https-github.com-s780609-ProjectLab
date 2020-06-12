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
	/// Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("resourcespec")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class ResourceSpec : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ResourceSpec() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "resourcespec";
		
		public const string EntitySchemaName = "ResourceSpec";
		
		public const string PrimaryIdAttribute = "resourcespecid";
		
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
		/// Unique identifier of the business unit with which the resource specification is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
		
		/// <summary>
		/// Additional constraints, specified as expressions, which are used to filter a set of valid resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraints")]
		public string Constraints
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("constraints");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Constraints");
				this.SetAttributeValue("constraints", value);
				this.OnPropertyChanged("Constraints");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the resource specification.
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
		/// Date and time when the resource specification was created.
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
		/// Unique identifier of the delegate user who created the resourcespec.
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
		/// Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Number that specifies the minimal effort required from resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effortrequired")]
		public System.Nullable<double> EffortRequired
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effortrequired");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffortRequired");
				this.SetAttributeValue("effortrequired", value);
				this.OnPropertyChanged("EffortRequired");
			}
		}
		
		/// <summary>
		/// Unique identifier of the scheduling group with which the resource specification is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupobjectid")]
		public System.Nullable<System.Guid> GroupObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("groupobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GroupObjectId");
				this.SetAttributeValue("groupobjectid", value);
				this.OnPropertyChanged("GroupObjectId");
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
		/// Unique identifier of the user who last modified the resource specification.
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
		/// Date and time when the resource specification was last modified.
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
		/// Unique identifier of the delegate user who last modified the resourcespec.
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
		/// Name of the resource specification.
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
		/// Search strategy to use for the resource specification.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectiveexpression")]
		public string ObjectiveExpression
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("objectiveexpression");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectiveExpression");
				this.SetAttributeValue("objectiveexpression", value);
				this.OnPropertyChanged("ObjectiveExpression");
			}
		}
		
		/// <summary>
		/// Type of entity with which the resource specification is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the resource specification is associated.
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
		/// Required number of resources that must be available. Use -1 to indicate all resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcount")]
		public System.Nullable<int> RequiredCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("requiredcount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RequiredCount");
				this.SetAttributeValue("requiredcount", value);
				this.OnPropertyChanged("RequiredCount");
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource specification.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		public System.Nullable<System.Guid> ResourceSpecId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("resourcespecid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpecId");
				this.SetAttributeValue("resourcespecid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ResourceSpecId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
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
				this.ResourceSpecId = value;
			}
		}
		
		/// <summary>
		/// Value that specifies that all valid and available resources must be in the same site.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("samesite")]
		public System.Nullable<bool> SameSite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("samesite");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SameSite");
				this.SetAttributeValue("samesite", value);
				this.OnPropertyChanged("SameSite");
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
		/// 1:N ActivityPartyResourceSpec
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPartyResourceSpec")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ActivityParty> ActivityPartyResourceSpec
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ActivityParty>("ActivityPartyResourceSpec", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityPartyResourceSpec");
				this.SetRelatedEntities<CrmEarlyBound.ActivityParty>("ActivityPartyResourceSpec", null, value);
				this.OnPropertyChanged("ActivityPartyResourceSpec");
			}
		}
		
		/// <summary>
		/// 1:N ResourceSpec_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_Annotation")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Annotation> ResourceSpec_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Annotation>("ResourceSpec_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpec_Annotation");
				this.SetRelatedEntities<CrmEarlyBound.Annotation>("ResourceSpec_Annotation", null, value);
				this.OnPropertyChanged("ResourceSpec_Annotation");
			}
		}
		
		/// <summary>
		/// 1:N ResourceSpec_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> ResourceSpec_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("ResourceSpec_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpec_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("ResourceSpec_AsyncOperations", null, value);
				this.OnPropertyChanged("ResourceSpec_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N resourcespec_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcespec_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> resourcespec_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("resourcespec_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("resourcespec_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("resourcespec_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("resourcespec_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N resourcespec_resources
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcespec_resources")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Resource> resourcespec_resources
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Resource>("resourcespec_resources", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("resourcespec_resources");
				this.SetRelatedEntities<CrmEarlyBound.Resource>("resourcespec_resources", null, value);
				this.OnPropertyChanged("resourcespec_resources");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_resourcespec
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resourcespec")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_resourcespec
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_resourcespec", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_resourcespec");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_resourcespec", null, value);
				this.OnPropertyChanged("userentityinstancedata_resourcespec");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resource_specs")]
		public CrmEarlyBound.BusinessUnit business_unit_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_resource_specs");
				this.SetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_resource_specs", null, value);
				this.OnPropertyChanged("business_unit_resource_specs");
			}
		}
		
		/// <summary>
		/// N:1 constraint_based_group_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraint_based_group_resource_specs")]
		public CrmEarlyBound.ConstraintBasedGroup constraint_based_group_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ConstraintBasedGroup>("constraint_based_group_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("constraint_based_group_resource_specs");
				this.SetRelatedEntity<CrmEarlyBound.ConstraintBasedGroup>("constraint_based_group_resource_specs", null, value);
				this.OnPropertyChanged("constraint_based_group_resource_specs");
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdby")]
		public CrmEarlyBound.SystemUser lk_resourcespec_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_resourcespec_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_createdby", null, value);
				this.OnPropertyChanged("lk_resourcespec_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_resourcespec_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_resourcespec_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_resourcespec_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedby")]
		public CrmEarlyBound.SystemUser lk_resourcespec_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_resourcespec_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_modifiedby", null, value);
				this.OnPropertyChanged("lk_resourcespec_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_resourcespec_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_resourcespec_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_resourcespec_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_resourcespec_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_resourcespec_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resource_specs")]
		public CrmEarlyBound.Organization organization_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("organization_resource_specs");
				this.SetRelatedEntity<CrmEarlyBound.Organization>("organization_resource_specs", null, value);
				this.OnPropertyChanged("organization_resource_specs");
			}
		}
		
		/// <summary>
		/// N:1 team_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_resource_specs")]
		public CrmEarlyBound.Team team_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_resource_specs");
				this.SetRelatedEntity<CrmEarlyBound.Team>("team_resource_specs", null, value);
				this.OnPropertyChanged("team_resource_specs");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ResourceSpec(object anonymousType) : 
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
                        Attributes["resourcespecid"] = base.Id;
                        break;
                    case "resourcespecid":
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