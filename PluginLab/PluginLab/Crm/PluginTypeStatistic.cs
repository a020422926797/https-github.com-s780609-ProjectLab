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
	/// Plug-in type statistic.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("plugintypestatistic")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class PluginTypeStatistic : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginTypeStatistic() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "plugintypestatistic";
		
		public const string EntitySchemaName = "PluginTypeStatistic";
		
		public const string PrimaryIdAttribute = "plugintypestatisticid";
		
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
		/// The average execution time (in milliseconds) for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("averageexecutetimeinmilliseconds")]
		public System.Nullable<int> AverageExecuteTimeInMilliseconds
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("averageexecutetimeinmilliseconds");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AverageExecuteTimeInMilliseconds");
				this.SetAttributeValue("averageexecutetimeinmilliseconds", value);
				this.OnPropertyChanged("AverageExecuteTimeInMilliseconds");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to crashes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashcontributionpercent")]
		public System.Nullable<int> CrashContributionPercent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("crashcontributionpercent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CrashContributionPercent");
				this.SetAttributeValue("crashcontributionpercent", value);
				this.OnPropertyChanged("CrashContributionPercent");
			}
		}
		
		/// <summary>
		/// Number of times the plug-in type has crashed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashcount")]
		public System.Nullable<int> CrashCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("crashcount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CrashCount");
				this.SetAttributeValue("crashcount", value);
				this.OnPropertyChanged("CrashCount");
			}
		}
		
		/// <summary>
		/// Percentage of crashes for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashpercent")]
		public System.Nullable<int> CrashPercent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("crashpercent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CrashPercent");
				this.SetAttributeValue("crashpercent", value);
				this.OnPropertyChanged("CrashPercent");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the plug-in type statistic.
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
		/// Date and time when the plug-in type statistic was created.
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
		/// Unique identifier of the delegate user who created the plug-in type statistic.
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
		/// Number of times the plug-in type has been executed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executecount")]
		public System.Nullable<int> ExecuteCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("executecount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExecuteCount");
				this.SetAttributeValue("executecount", value);
				this.OnPropertyChanged("ExecuteCount");
			}
		}
		
		/// <summary>
		/// Number of times the plug-in type has failed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurecount")]
		public System.Nullable<int> FailureCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("failurecount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FailureCount");
				this.SetAttributeValue("failurecount", value);
				this.OnPropertyChanged("FailureCount");
			}
		}
		
		/// <summary>
		/// Percentage of failures for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurepercent")]
		public System.Nullable<int> FailurePercent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("failurepercent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FailurePercent");
				this.SetAttributeValue("failurepercent", value);
				this.OnPropertyChanged("FailurePercent");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the plug-in type statistic.
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
		/// Date and time when the plug-in type statistic was last modified.
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
		/// Unique identifier of the delegate user who modified the plug-in type statistic.
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
		/// Unique identifier of the organization with which the plug-in type statistic is associated.
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
		/// Unique identifier of the plug-in type associated with this plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PluginTypeId");
				this.SetAttributeValue("plugintypeid", value);
				this.OnPropertyChanged("PluginTypeId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypestatisticid")]
		public System.Nullable<System.Guid> PluginTypeStatisticId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintypestatisticid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PluginTypeStatisticId");
				this.SetAttributeValue("plugintypestatisticid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PluginTypeStatisticId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypestatisticid")]
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
				this.PluginTypeStatisticId = value;
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to excessive CPU usage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatecpucontributionpercent")]
		public System.Nullable<int> TerminateCpuContributionPercent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminatecpucontributionpercent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerminateCpuContributionPercent");
				this.SetAttributeValue("terminatecpucontributionpercent", value);
				this.OnPropertyChanged("TerminateCpuContributionPercent");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to excessive handle usage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatehandlescontributionpercent")]
		public System.Nullable<int> TerminateHandlesContributionPercent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminatehandlescontributionpercent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerminateHandlesContributionPercent");
				this.SetAttributeValue("terminatehandlescontributionpercent", value);
				this.OnPropertyChanged("TerminateHandlesContributionPercent");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to excessive memory usage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatememorycontributionpercent")]
		public System.Nullable<int> TerminateMemoryContributionPercent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminatememorycontributionpercent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerminateMemoryContributionPercent");
				this.SetAttributeValue("terminatememorycontributionpercent", value);
				this.OnPropertyChanged("TerminateMemoryContributionPercent");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to unknown reasons.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminateothercontributionpercent")]
		public System.Nullable<int> TerminateOtherContributionPercent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminateothercontributionpercent");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TerminateOtherContributionPercent");
				this.SetAttributeValue("terminateothercontributionpercent", value);
				this.OnPropertyChanged("TerminateOtherContributionPercent");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_plugintypestatistic
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_plugintypestatistic")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_plugintypestatistic
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_plugintypestatistic", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_plugintypestatistic");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_plugintypestatistic", null, value);
				this.OnPropertyChanged("userentityinstancedata_plugintypestatistic");
			}
		}
		
		/// <summary>
		/// N:1 createdby_plugintypestatistic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_plugintypestatistic")]
		public CrmEarlyBound.SystemUser createdby_plugintypestatistic
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("createdby_plugintypestatistic", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("createdby_plugintypestatistic");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("createdby_plugintypestatistic", null, value);
				this.OnPropertyChanged("createdby_plugintypestatistic");
			}
		}
		
		/// <summary>
		/// N:1 lk_plugintypestatisticbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_plugintypestatisticbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_plugintypestatisticbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_plugintypestatisticbase_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_plugintypestatisticbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_plugintypestatisticbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_plugintypestatisticbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_plugintypestatisticbase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_plugintypestatisticbase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_plugintypestatisticbase_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_plugintypestatisticbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_plugintypestatisticbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 modifiedby_plugintypestatistic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_plugintypestatistic")]
		public CrmEarlyBound.SystemUser modifiedby_plugintypestatistic
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("modifiedby_plugintypestatistic", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("modifiedby_plugintypestatistic");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("modifiedby_plugintypestatistic", null, value);
				this.OnPropertyChanged("modifiedby_plugintypestatistic");
			}
		}
		
		/// <summary>
		/// N:1 organization_plugintypestatistic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_plugintypestatistic")]
		public CrmEarlyBound.Organization organization_plugintypestatistic
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_plugintypestatistic", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("organization_plugintypestatistic");
				this.SetRelatedEntity<CrmEarlyBound.Organization>("organization_plugintypestatistic", null, value);
				this.OnPropertyChanged("organization_plugintypestatistic");
			}
		}
		
		/// <summary>
		/// N:1 plugintype_plugintypestatistic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_plugintypestatistic")]
		public CrmEarlyBound.PluginType plugintype_plugintypestatistic
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.PluginType>("plugintype_plugintypestatistic", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("plugintype_plugintypestatistic");
				this.SetRelatedEntity<CrmEarlyBound.PluginType>("plugintype_plugintypestatistic", null, value);
				this.OnPropertyChanged("plugintype_plugintypestatistic");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PluginTypeStatistic(object anonymousType) : 
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
                        Attributes["plugintypestatisticid"] = base.Id;
                        break;
                    case "plugintypestatisticid":
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