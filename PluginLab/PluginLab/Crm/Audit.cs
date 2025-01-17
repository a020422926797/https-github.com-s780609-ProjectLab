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
	/// Track changes to records for analysis, record keeping, and compliance.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("audit")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class Audit : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Audit() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "audit";
		
		public const string EntitySchemaName = "Audit";
		
		public const string PrimaryIdAttribute = "auditid";
		
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
		/// Actions the user can perform that cause a change
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("action")]
		public Microsoft.Xrm.Sdk.OptionSetValue Action
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("action");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Action");
				this.SetAttributeValue("action", value);
				this.OnPropertyChanged("Action");
			}
		}
		
		/// <summary>
		/// Actions the user can perform that cause a change
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("action")]
		public virtual Audit_Action? ActionEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Audit_Action?)(EntityOptionSetEnum.GetEnum(this, "action")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Action");
				this.SetAttributeValue("action", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("Action");
			}
		}
		
		/// <summary>
		/// Contains a CSV of the ColumnNumber metadata property of attributes
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributemask")]
		public string AttributeMask
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("attributemask");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AttributeMask");
				this.SetAttributeValue("attributemask", value);
				this.OnPropertyChanged("AttributeMask");
			}
		}
		
		/// <summary>
		/// Unique identifier of the auditing instance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("auditid")]
		public System.Nullable<System.Guid> AuditId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("auditid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AuditId");
				this.SetAttributeValue("auditid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AuditId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("auditid")]
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
				this.AuditId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the calling user in case of an impersonated call
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callinguserid")]
		public Microsoft.Xrm.Sdk.EntityReference CallingUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("callinguserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CallingUserId");
				this.SetAttributeValue("callinguserid", value);
				this.OnPropertyChanged("CallingUserId");
			}
		}
		
		/// <summary>
		/// Contains a CSV of old values of all the attributes whose IsAuditEnabled property is True and are being changed
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("changedata")]
		public string ChangeData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("changedata");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ChangeData");
				this.SetAttributeValue("changedata", value);
				this.OnPropertyChanged("ChangeData");
			}
		}
		
		/// <summary>
		/// Date and time when the audit record was created.
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
		/// Unique identifier of the record that is being audited
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public Microsoft.Xrm.Sdk.EntityReference ObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectId");
				this.SetAttributeValue("objectid", value);
				this.OnPropertyChanged("ObjectId");
			}
		}
		
		/// <summary>
		/// The action that causes the audit--it will be create, delete, or update
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operation")]
		public Microsoft.Xrm.Sdk.OptionSetValue Operation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operation");
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
		/// The action that causes the audit--it will be create, delete, or update
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operation")]
		public virtual Audit_Operation? OperationEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Audit_Operation?)(EntityOptionSetEnum.GetEnum(this, "operation")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Operation");
				this.SetAttributeValue("operation", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("Operation");
			}
		}
		
		/// <summary>
		/// Unique identifier of the object with which the record is associated.
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
		/// Unique identifier for multiple changes that are part of a single operation; this field contains the same GUID for all the audit rows generated in a single transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactionid")]
		public System.Nullable<System.Guid> TransactionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("transactionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionId");
				this.SetAttributeValue("transactionid", value);
				this.OnPropertyChanged("TransactionId");
			}
		}
		
		/// <summary>
		/// Additional information associated to the user who caused the change.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useradditionalinfo")]
		public string UserAdditionalInfo
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("useradditionalinfo");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserAdditionalInfo");
				this.SetAttributeValue("useradditionalinfo", value);
				this.OnPropertyChanged("UserAdditionalInfo");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who caused a change
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("userid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserId");
				this.SetAttributeValue("userid", value);
				this.OnPropertyChanged("UserId");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_audit
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_audit")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_audit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_audit", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_audit");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_audit", null, value);
				this.OnPropertyChanged("userentityinstancedata_audit");
			}
		}
		
		/// <summary>
		/// N:1 lk_audit_callinguserid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callinguserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_callinguserid")]
		public CrmEarlyBound.SystemUser lk_audit_callinguserid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_audit_callinguserid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_audit_callinguserid");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_audit_callinguserid", null, value);
				this.OnPropertyChanged("lk_audit_callinguserid");
			}
		}
		
		/// <summary>
		/// N:1 lk_audit_userid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_userid")]
		public CrmEarlyBound.SystemUser lk_audit_userid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_audit_userid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_audit_userid");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_audit_userid", null, value);
				this.OnPropertyChanged("lk_audit_userid");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Audit(object anonymousType) : 
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
                        Attributes["auditid"] = base.Id;
                        break;
                    case "auditid":
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