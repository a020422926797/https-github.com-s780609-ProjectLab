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
	/// Team template for an entity enabled for automatically created access teams.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teamtemplate")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class TeamTemplate : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TeamTemplate() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "teamtemplate";
		
		public const string EntitySchemaName = "TeamTemplate";
		
		public const string PrimaryIdAttribute = "teamtemplateid";
		
		public const string PrimaryNameAttribute = "teamtemplatename";
		
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
		/// Unique identifier of the user who created the team template.
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
		/// Date and time when the team template was created.
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
		/// Unique identifier of the delegate user who created the team template.
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
		/// Default access rights mask for the access teams associated with entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultaccessrightsmask")]
		public System.Nullable<int> DefaultAccessRightsMask
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("defaultaccessrightsmask");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DefaultAccessRightsMask");
				this.SetAttributeValue("defaultaccessrightsmask", value);
				this.OnPropertyChanged("DefaultAccessRightsMask");
			}
		}
		
		/// <summary>
		/// Type additional information that describes the team.
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
		/// Information about whether this team template is user-defined or system-defined.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issystem")]
		public System.Nullable<bool> IsSystem
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("issystem");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsSystem");
				this.SetAttributeValue("issystem", value);
				this.OnPropertyChanged("IsSystem");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the team template.
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
		/// Date and time when the team template was last modified.
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
		/// Unique identifier of the delegate user who modified the team template.
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
		/// Object type code of entity which is enabled for access teams
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public System.Nullable<int> ObjectTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("objecttypecode");
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
		/// Unique identifier of the team template.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
		public System.Nullable<System.Guid> TeamTemplateId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("teamtemplateid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TeamTemplateId");
				this.SetAttributeValue("teamtemplateid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TeamTemplateId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
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
				this.TeamTemplateId = value;
			}
		}
		
		/// <summary>
		/// Type the name of the team template.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplatename")]
		public string TeamTemplateName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("teamtemplatename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TeamTemplateName");
				this.SetAttributeValue("teamtemplatename", value);
				this.OnPropertyChanged("TeamTemplateName");
			}
		}
		
		/// <summary>
		/// 1:N teamtemplate_Teams
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamtemplate_Teams")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Team> teamtemplate_Teams
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Team>("teamtemplate_Teams", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("teamtemplate_Teams");
				this.SetRelatedEntities<CrmEarlyBound.Team>("teamtemplate_Teams", null, value);
				this.OnPropertyChanged("teamtemplate_Teams");
			}
		}
		
		/// <summary>
		/// N:1 lk_teamtemplate_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_createdby")]
		public CrmEarlyBound.SystemUser lk_teamtemplate_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_teamtemplate_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_createdby", null, value);
				this.OnPropertyChanged("lk_teamtemplate_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_teamtemplate_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_teamtemplate_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_teamtemplate_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_teamtemplate_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_teamtemplate_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_modifiedby")]
		public CrmEarlyBound.SystemUser lk_teamtemplate_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_teamtemplate_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_modifiedby", null, value);
				this.OnPropertyChanged("lk_teamtemplate_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_teamtemplate_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_teamtemplate_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_teamtemplate_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_teamtemplate_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_teamtemplate_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TeamTemplate(object anonymousType) : 
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
                        Attributes["teamtemplateid"] = base.Id;
                        break;
                    case "teamtemplateid":
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