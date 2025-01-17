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
	/// Person or group associated with an activity. An activity can have multiple activity parties.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class ActivityParty : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActivityParty() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "activityparty";
		
		public const string EntitySchemaName = "ActivityParty";
		
		public const string PrimaryIdAttribute = "activitypartyid";
		
		public const string PrimaryNameAttribute = "partyidname";
		
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
		/// Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated with an activity.)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public Microsoft.Xrm.Sdk.EntityReference ActivityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityId");
				this.SetAttributeValue("activityid", value);
				this.OnPropertyChanged("ActivityId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public System.Nullable<System.Guid> ActivityPartyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityPartyId");
				this.SetAttributeValue("activitypartyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ActivityPartyId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
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
				this.ActivityPartyId = value;
			}
		}
		
		/// <summary>
		/// Email address to which an email is delivered, and which is associated with the target entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
		public string AddressUsed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("addressused");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AddressUsed");
				this.SetAttributeValue("addressused", value);
				this.OnPropertyChanged("AddressUsed");
			}
		}
		
		/// <summary>
		/// Email address column number from associated party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressusedemailcolumnnumber")]
		public System.Nullable<int> AddressUsedEmailColumnNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressusedemailcolumnnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AddressUsedEmailColumnNumber");
				this.SetAttributeValue("addressusedemailcolumnnumber", value);
				this.OnPropertyChanged("AddressUsedEmailColumnNumber");
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending email to the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEmail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotEmail");
				this.SetAttributeValue("donotemail", value);
				this.OnPropertyChanged("DoNotEmail");
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending faxes to the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotFax");
				this.SetAttributeValue("donotfax", value);
				this.OnPropertyChanged("DoNotFax");
			}
		}
		
		/// <summary>
		/// Information about whether to allow phone calls to the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotPhone");
				this.SetAttributeValue("donotphone", value);
				this.OnPropertyChanged("DoNotPhone");
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending postal mail to the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DoNotPostalMail");
				this.SetAttributeValue("donotpostalmail", value);
				this.OnPropertyChanged("DoNotPostalMail");
			}
		}
		
		/// <summary>
		/// Amount of effort used by the resource in a service appointment activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
		public System.Nullable<double> Effort
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effort");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Effort");
				this.SetAttributeValue("effort", value);
				this.OnPropertyChanged("Effort");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
		public string ExchangeEntryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("exchangeentryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExchangeEntryId");
				this.SetAttributeValue("exchangeentryid", value);
				this.OnPropertyChanged("ExchangeEntryId");
			}
		}
		
		/// <summary>
		/// Type of instance of a recurring series.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue InstanceTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instancetypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InstanceTypeCode");
				this.SetAttributeValue("instancetypecode", value);
				this.OnPropertyChanged("InstanceTypeCode");
			}
		}
		
		/// <summary>
		/// Type of instance of a recurring series.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
		public virtual ActivityParty_InstanceTypeCode? InstanceTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ActivityParty_InstanceTypeCode?)(EntityOptionSetEnum.GetEnum(this, "instancetypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("InstanceTypeCode");
				this.SetAttributeValue("instancetypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("InstanceTypeCode");
			}
		}
		
		/// <summary>
		/// Information about whether the underlying entity record is deleted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
		public System.Nullable<bool> IsPartyDeleted
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsPartyDeleted");
				this.SetAttributeValue("ispartydeleted", value);
				this.OnPropertyChanged("IsPartyDeleted");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the activity_party.
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public System.Nullable<System.Guid> OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser");
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
		/// Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
		public Microsoft.Xrm.Sdk.OptionSetValue ParticipationTypeMask
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("participationtypemask");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParticipationTypeMask");
				this.SetAttributeValue("participationtypemask", value);
				this.OnPropertyChanged("ParticipationTypeMask");
			}
		}
		
		/// <summary>
		/// Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
		public virtual ActivityParty_ParticipationTypeMask? ParticipationTypeMaskEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ActivityParty_ParticipationTypeMask?)(EntityOptionSetEnum.GetEnum(this, "participationtypemask")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParticipationTypeMask");
				this.SetAttributeValue("participationtypemask", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("ParticipationTypeMask");
			}
		}
		
		/// <summary>
		/// Unique identifier of the party associated with the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		public Microsoft.Xrm.Sdk.EntityReference PartyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PartyId");
				this.SetAttributeValue("partyid", value);
				this.OnPropertyChanged("PartyId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource specification for the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		public Microsoft.Xrm.Sdk.EntityReference ResourceSpecId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResourceSpecId");
				this.SetAttributeValue("resourcespecid", value);
				this.OnPropertyChanged("ResourceSpecId");
			}
		}
		
		/// <summary>
		/// Scheduled end time of the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
		public System.Nullable<System.DateTime> ScheduledEnd
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ScheduledEnd");
				this.SetAttributeValue("scheduledend", value);
				this.OnPropertyChanged("ScheduledEnd");
			}
		}
		
		/// <summary>
		/// Scheduled start time of the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ScheduledStart");
				this.SetAttributeValue("scheduledstart", value);
				this.OnPropertyChanged("ScheduledStart");
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
		/// 1:N userentityinstancedata_activityparty
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_activityparty")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_activityparty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_activityparty", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_activityparty");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_activityparty", null, value);
				this.OnPropertyChanged("userentityinstancedata_activityparty");
			}
		}
		
		/// <summary>
		/// N:1 account_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
		public CrmEarlyBound.Account account_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Account>("account_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("account_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Account>("account_activity_parties", null, value);
				this.OnPropertyChanged("account_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 ActivityPartyResourceSpec
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPartyResourceSpec")]
		public CrmEarlyBound.ResourceSpec ActivityPartyResourceSpec
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ResourceSpec>("ActivityPartyResourceSpec", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityPartyResourceSpec");
				this.SetRelatedEntity<CrmEarlyBound.ResourceSpec>("ActivityPartyResourceSpec", null, value);
				this.OnPropertyChanged("ActivityPartyResourceSpec");
			}
		}
		
		/// <summary>
		/// N:1 activitypointer_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_activity_parties")]
		public CrmEarlyBound.ActivityPointer activitypointer_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ActivityPointer>("activitypointer_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("activitypointer_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.ActivityPointer>("activitypointer_activity_parties", null, value);
				this.OnPropertyChanged("activitypointer_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 appointment_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_parties")]
		public CrmEarlyBound.Appointment appointment_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Appointment>("appointment_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("appointment_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Appointment>("appointment_activity_parties", null, value);
				this.OnPropertyChanged("appointment_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 contact_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
		public CrmEarlyBound.Contact contact_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Contact>("contact_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contact_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Contact>("contact_activity_parties", null, value);
				this.OnPropertyChanged("contact_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 email_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
		public CrmEarlyBound.Email email_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Email>("email_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("email_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Email>("email_activity_parties", null, value);
				this.OnPropertyChanged("email_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 entitlement_ActivityParties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_ActivityParties")]
		public CrmEarlyBound.Entitlement entitlement_ActivityParties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Entitlement>("entitlement_ActivityParties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("entitlement_ActivityParties");
				this.SetRelatedEntity<CrmEarlyBound.Entitlement>("entitlement_ActivityParties", null, value);
				this.OnPropertyChanged("entitlement_ActivityParties");
			}
		}
		
		/// <summary>
		/// N:1 equipment_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_activity_parties")]
		public CrmEarlyBound.Equipment equipment_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Equipment>("equipment_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("equipment_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Equipment>("equipment_activity_parties", null, value);
				this.OnPropertyChanged("equipment_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 fax_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_activity_parties")]
		public CrmEarlyBound.Fax fax_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Fax>("fax_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("fax_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Fax>("fax_activity_parties", null, value);
				this.OnPropertyChanged("fax_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 incident_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_activity_parties")]
		public CrmEarlyBound.Incident incident_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Incident>("incident_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("incident_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Incident>("incident_activity_parties", null, value);
				this.OnPropertyChanged("incident_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 incidentresolution_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incidentresolution_activity_parties")]
		public CrmEarlyBound.IncidentResolution incidentresolution_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.IncidentResolution>("incidentresolution_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("incidentresolution_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.IncidentResolution>("incidentresolution_activity_parties", null, value);
				this.OnPropertyChanged("incidentresolution_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 invoice_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_activity_parties")]
		public CrmEarlyBound.Invoice invoice_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Invoice>("invoice_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("invoice_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Invoice>("invoice_activity_parties", null, value);
				this.OnPropertyChanged("invoice_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 lux_employee_ActivityParties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_employee_ActivityParties")]
		public CrmEarlyBound.lux_employee lux_employee_ActivityParties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.lux_employee>("lux_employee_ActivityParties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_employee_ActivityParties");
				this.SetRelatedEntity<CrmEarlyBound.lux_employee>("lux_employee_ActivityParties", null, value);
				this.OnPropertyChanged("lux_employee_ActivityParties");
			}
		}
		
		/// <summary>
		/// N:1 lux_incotermsmaster_ActivityParties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_incotermsmaster_ActivityParties")]
		public CrmEarlyBound.lux_incotermsmaster lux_incotermsmaster_ActivityParties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.lux_incotermsmaster>("lux_incotermsmaster_ActivityParties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_incotermsmaster_ActivityParties");
				this.SetRelatedEntity<CrmEarlyBound.lux_incotermsmaster>("lux_incotermsmaster_ActivityParties", null, value);
				this.OnPropertyChanged("lux_incotermsmaster_ActivityParties");
			}
		}
		
		/// <summary>
		/// N:1 lux_oppproductmgt_ActivityParties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lux_oppproductmgt_ActivityParties")]
		public CrmEarlyBound.lux_oppproductmgt lux_oppproductmgt_ActivityParties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.lux_oppproductmgt>("lux_oppproductmgt_ActivityParties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lux_oppproductmgt_ActivityParties");
				this.SetRelatedEntity<CrmEarlyBound.lux_oppproductmgt>("lux_oppproductmgt_ActivityParties", null, value);
				this.OnPropertyChanged("lux_oppproductmgt_ActivityParties");
			}
		}
		
		/// <summary>
		/// N:1 opportunity_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_activity_parties")]
		public CrmEarlyBound.Opportunity opportunity_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Opportunity>("opportunity_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunity_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Opportunity>("opportunity_activity_parties", null, value);
				this.OnPropertyChanged("opportunity_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 opportunityclose_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunityclose_activity_parties")]
		public CrmEarlyBound.OpportunityClose opportunityclose_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.OpportunityClose>("opportunityclose_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("opportunityclose_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.OpportunityClose>("opportunityclose_activity_parties", null, value);
				this.OnPropertyChanged("opportunityclose_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 orderclose_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orderclose_activity_parties")]
		public CrmEarlyBound.OrderClose orderclose_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.OrderClose>("orderclose_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("orderclose_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.OrderClose>("orderclose_activity_parties", null, value);
				this.OnPropertyChanged("orderclose_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 phonecall_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_activity_parties")]
		public CrmEarlyBound.PhoneCall phonecall_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.PhoneCall>("phonecall_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("phonecall_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.PhoneCall>("phonecall_activity_parties", null, value);
				this.OnPropertyChanged("phonecall_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 queue_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_activity_parties")]
		public CrmEarlyBound.Queue queue_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Queue>("queue_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("queue_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Queue>("queue_activity_parties", null, value);
				this.OnPropertyChanged("queue_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 quote_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_activity_parties")]
		public CrmEarlyBound.Quote quote_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Quote>("quote_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("quote_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Quote>("quote_activity_parties", null, value);
				this.OnPropertyChanged("quote_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 quoteclose_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quoteclose_activity_parties")]
		public CrmEarlyBound.QuoteClose quoteclose_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.QuoteClose>("quoteclose_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("quoteclose_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.QuoteClose>("quoteclose_activity_parties", null, value);
				this.OnPropertyChanged("quoteclose_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 recurringappointmentmaster_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_activity_parties")]
		public CrmEarlyBound.RecurringAppointmentMaster recurringappointmentmaster_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.RecurringAppointmentMaster>("recurringappointmentmaster_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("recurringappointmentmaster_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.RecurringAppointmentMaster>("recurringappointmentmaster_activity_parties", null, value);
				this.OnPropertyChanged("recurringappointmentmaster_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 salesorder_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_activity_parties")]
		public CrmEarlyBound.SalesOrder salesorder_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SalesOrder>("salesorder_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("salesorder_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.SalesOrder>("salesorder_activity_parties", null, value);
				this.OnPropertyChanged("salesorder_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 socialactivity_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_activity_parties")]
		public CrmEarlyBound.SocialActivity socialactivity_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SocialActivity>("socialactivity_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("socialactivity_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.SocialActivity>("socialactivity_activity_parties", null, value);
				this.OnPropertyChanged("socialactivity_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 system_user_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
		public CrmEarlyBound.SystemUser system_user_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("system_user_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("system_user_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("system_user_activity_parties", null, value);
				this.OnPropertyChanged("system_user_activity_parties");
			}
		}
		
		/// <summary>
		/// N:1 task_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_activity_parties")]
		public CrmEarlyBound.Task task_activity_parties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Task>("task_activity_parties", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("task_activity_parties");
				this.SetRelatedEntity<CrmEarlyBound.Task>("task_activity_parties", null, value);
				this.OnPropertyChanged("task_activity_parties");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ActivityParty(object anonymousType) : 
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
                        Attributes["activitypartyid"] = base.Id;
                        break;
                    case "activitypartyid":
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