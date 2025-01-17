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
	/// A solution which contains CRM customizations.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("solution")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class Solution : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Solution() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "solution";
		
		public const string EntitySchemaName = "Solution";
		
		public const string PrimaryIdAttribute = "solutionid";
		
		public const string PrimaryNameAttribute = "friendlyname";
		
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
		/// A link to an optional configuration page for this solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationpageid")]
		public Microsoft.Xrm.Sdk.EntityReference ConfigurationPageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("configurationpageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConfigurationPageId");
				this.SetAttributeValue("configurationpageid", value);
				this.OnPropertyChanged("ConfigurationPageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the solution.
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
		/// Date and time when the solution was created.
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
		/// Unique identifier of the delegate user who created the solution.
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
		/// Description of the solution.
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
		/// User display name for the solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlyname")]
		public string FriendlyName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("friendlyname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FriendlyName");
				this.SetAttributeValue("friendlyname", value);
				this.OnPropertyChanged("FriendlyName");
			}
		}
		
		/// <summary>
		/// Date and time when the solution was installed/upgraded.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("installedon")]
		public System.Nullable<System.DateTime> InstalledOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("installedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InstalledOn");
				this.SetAttributeValue("installedon", value);
				this.OnPropertyChanged("InstalledOn");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution is internal or not.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isinternal")]
		public System.Nullable<bool> IsInternal
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isinternal");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsInternal");
				this.SetAttributeValue("isinternal", value);
				this.OnPropertyChanged("IsInternal");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution is managed or unmanaged.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsManaged");
				this.SetAttributeValue("ismanaged", value);
				this.OnPropertyChanged("IsManaged");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution is visible outside of the platform.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisible")]
		public System.Nullable<bool> IsVisible
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvisible");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsVisible");
				this.SetAttributeValue("isvisible", value);
				this.OnPropertyChanged("IsVisible");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the solution.
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
		/// Date and time when the solution was last modified.
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
		/// Unique identifier of the delegate user who modified the solution.
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
		/// Unique identifier of the organization associated with the solution.
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
		/// Unique identifier of the parent solution. Should only be non-null if this solution is a patch.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsolutionid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentSolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsolutionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentSolutionId");
				this.SetAttributeValue("parentsolutionid", value);
				this.OnPropertyChanged("ParentSolutionId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointassetid")]
		public string PinpointAssetId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pinpointassetid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PinpointAssetId");
				this.SetAttributeValue("pinpointassetid", value);
				this.OnPropertyChanged("PinpointAssetId");
			}
		}
		
		/// <summary>
		/// Identifier of the publisher of this solution in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointpublisherid")]
		public System.Nullable<long> PinpointPublisherId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("pinpointpublisherid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PinpointPublisherId");
				this.SetAttributeValue("pinpointpublisherid", value);
				this.OnPropertyChanged("PinpointPublisherId");
			}
		}
		
		/// <summary>
		/// Default locale of the solution in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointsolutiondefaultlocale")]
		public string PinpointSolutionDefaultLocale
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("pinpointsolutiondefaultlocale");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PinpointSolutionDefaultLocale");
				this.SetAttributeValue("pinpointsolutiondefaultlocale", value);
				this.OnPropertyChanged("PinpointSolutionDefaultLocale");
			}
		}
		
		/// <summary>
		/// Identifier of the solution in Microsoft Pinpoint.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointsolutionid")]
		public System.Nullable<long> PinpointSolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("pinpointsolutionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PinpointSolutionId");
				this.SetAttributeValue("pinpointsolutionid", value);
				this.OnPropertyChanged("PinpointSolutionId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		public Microsoft.Xrm.Sdk.EntityReference PublisherId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("publisherid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PublisherId");
				this.SetAttributeValue("publisherid", value);
				this.OnPropertyChanged("PublisherId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SolutionId");
				this.SetAttributeValue("solutionid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SolutionId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
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
				this.SolutionId = value;
			}
		}
		
		/// <summary>
		/// Solution package source organization version
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionpackageversion")]
		public string SolutionPackageVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("solutionpackageversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SolutionPackageVersion");
				this.SetAttributeValue("solutionpackageversion", value);
				this.OnPropertyChanged("SolutionPackageVersion");
			}
		}
		
		/// <summary>
		/// Solution Type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutiontype")]
		public Microsoft.Xrm.Sdk.OptionSetValue SolutionType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("solutiontype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SolutionType");
				this.SetAttributeValue("solutiontype", value);
				this.OnPropertyChanged("SolutionType");
			}
		}
		
		/// <summary>
		/// Solution Type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutiontype")]
		public virtual Solution_SolutionType? SolutionTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Solution_SolutionType?)(EntityOptionSetEnum.GetEnum(this, "solutiontype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SolutionType");
				this.SetAttributeValue("solutiontype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("SolutionType");
			}
		}
		
		/// <summary>
		/// The unique name of this solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// Date and time when the solution was updated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("updatedon")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("updatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UpdatedOn");
				this.SetAttributeValue("updatedon", value);
				this.OnPropertyChanged("UpdatedOn");
			}
		}
		
		/// <summary>
		/// Solution version, used to identify a solution for upgrades and hotfixes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public string Version
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("version");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Version");
				this.SetAttributeValue("version", value);
				this.OnPropertyChanged("Version");
			}
		}
		
		/// <summary>
		/// 
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
		/// 1:N solution_parent_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Solution> Referencedsolution_parent_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Solution>("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedsolution_parent_solution");
				this.SetRelatedEntities<CrmEarlyBound.Solution>("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedsolution_parent_solution");
			}
		}
		
		/// <summary>
		/// 1:N solution_solutioncomponent
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_solutioncomponent")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SolutionComponent> solution_solutioncomponent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SolutionComponent>("solution_solutioncomponent", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solution_solutioncomponent");
				this.SetRelatedEntities<CrmEarlyBound.SolutionComponent>("solution_solutioncomponent", null, value);
				this.OnPropertyChanged("solution_solutioncomponent");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_solution")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_solution", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_solution");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_solution", null, value);
				this.OnPropertyChanged("userentityinstancedata_solution");
			}
		}
		
		/// <summary>
		/// N:1 lk_solution_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_createdby")]
		public CrmEarlyBound.SystemUser lk_solution_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solution_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solution_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solution_createdby", null, value);
				this.OnPropertyChanged("lk_solution_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_solution_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_modifiedby")]
		public CrmEarlyBound.SystemUser lk_solution_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solution_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solution_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solution_modifiedby", null, value);
				this.OnPropertyChanged("lk_solution_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_solutionbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_solutionbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solutionbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solutionbase_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solutionbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_solutionbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_solutionbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_solutionbase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solutionbase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_solutionbase_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_solutionbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_solutionbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_solution")]
		public CrmEarlyBound.Organization organization_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_solution", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("organization_solution");
				this.SetRelatedEntity<CrmEarlyBound.Organization>("organization_solution", null, value);
				this.OnPropertyChanged("organization_solution");
			}
		}
		
		/// <summary>
		/// N:1 publisher_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("publisher_solution")]
		public CrmEarlyBound.Publisher publisher_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Publisher>("publisher_solution", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("publisher_solution");
				this.SetRelatedEntity<CrmEarlyBound.Publisher>("publisher_solution", null, value);
				this.OnPropertyChanged("publisher_solution");
			}
		}
		
		/// <summary>
		/// N:1 solution_configuration_webresource
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationpageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_configuration_webresource")]
		public CrmEarlyBound.WebResource solution_configuration_webresource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.WebResource>("solution_configuration_webresource", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("solution_configuration_webresource");
				this.SetRelatedEntity<CrmEarlyBound.WebResource>("solution_configuration_webresource", null, value);
				this.OnPropertyChanged("solution_configuration_webresource");
			}
		}
		
		/// <summary>
		/// N:1 solution_parent_solution
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsolutionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public CrmEarlyBound.Solution Referencingsolution_parent_solution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Solution>("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingsolution_parent_solution");
				this.SetRelatedEntity<CrmEarlyBound.Solution>("solution_parent_solution", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingsolution_parent_solution");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Solution(object anonymousType) : 
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
                        Attributes["solutionid"] = base.Id;
                        break;
                    case "solutionid":
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