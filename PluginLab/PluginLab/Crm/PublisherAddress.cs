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
	/// Address and shipping information. Used to store additional addresses for a publisher.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("publisheraddress")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class PublisherAddress : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PublisherAddress() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "publisheraddress";
		
		public const string EntitySchemaName = "PublisherAddress";
		
		public const string PrimaryIdAttribute = "publisheraddressid";
		
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
		/// Specifies which publisher address is applicable.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressnumber")]
		public System.Nullable<int> AddressNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AddressNumber");
				this.SetAttributeValue("addressnumber", value);
				this.OnPropertyChanged("AddressNumber");
			}
		}
		
		/// <summary>
		/// Type of address for the publisher, such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresstypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("addresstypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AddressTypeCode");
				this.SetAttributeValue("addresstypecode", value);
				this.OnPropertyChanged("AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type of address for the publisher, such as billing, shipping, or primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresstypecode")]
		public virtual PublisherAddress_AddressTypeCode? AddressTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PublisherAddress_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AddressTypeCode");
				this.SetAttributeValue("addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("AddressTypeCode");
			}
		}
		
		/// <summary>
		/// City name in the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("city")]
		public string City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("City");
				this.SetAttributeValue("city", value);
				this.OnPropertyChanged("City");
			}
		}
		
		/// <summary>
		/// Country/region name in the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("country")]
		public string Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Country");
				this.SetAttributeValue("country", value);
				this.OnPropertyChanged("Country");
			}
		}
		
		/// <summary>
		/// County name in the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("county")]
		public string County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("County");
				this.SetAttributeValue("county", value);
				this.OnPropertyChanged("County");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the publisher address.
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
		/// Date and time when the publisher address was created.
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
		/// Unique identifier of the delegate user who created the publisher address.
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
		/// Fax number for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Freight terms for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FreightTermsCode");
				this.SetAttributeValue("freighttermscode", value);
				this.OnPropertyChanged("FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Freight terms for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public virtual PublisherAddress_FreightTermsCode? FreightTermsCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PublisherAddress_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FreightTermsCode");
				this.SetAttributeValue("freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Latitude for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("latitude")]
		public System.Nullable<double> Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Latitude");
				this.SetAttributeValue("latitude", value);
				this.OnPropertyChanged("Latitude");
			}
		}
		
		/// <summary>
		/// First line for entering address information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line1")]
		public string Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Line1");
				this.SetAttributeValue("line1", value);
				this.OnPropertyChanged("Line1");
			}
		}
		
		/// <summary>
		/// Second line for entering address information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line2")]
		public string Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Line2");
				this.SetAttributeValue("line2", value);
				this.OnPropertyChanged("Line2");
			}
		}
		
		/// <summary>
		/// Third line for entering address information.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line3")]
		public string Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Line3");
				this.SetAttributeValue("line3", value);
				this.OnPropertyChanged("Line3");
			}
		}
		
		/// <summary>
		/// Longitude for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("longitude")]
		public System.Nullable<double> Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Longitude");
				this.SetAttributeValue("longitude", value);
				this.OnPropertyChanged("Longitude");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the publisher address.
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
		/// Date and time when the publisher address was last modified.
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
		/// Unique identifier of the delegate user who modified the publisher address.
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
		/// Name used to identify the publisher address.
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
		/// Unique identifier of the parent object with which the publisher address is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentId");
				this.SetAttributeValue("parentid", value);
				this.OnPropertyChanged("ParentId");
			}
		}
		
		/// <summary>
		/// ZIP Code or postal code in the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postalcode")]
		public string PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostalCode");
				this.SetAttributeValue("postalcode", value);
				this.OnPropertyChanged("PostalCode");
			}
		}
		
		/// <summary>
		/// Post office box number in the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postofficebox")]
		public string PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostOfficeBox");
				this.SetAttributeValue("postofficebox", value);
				this.OnPropertyChanged("PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Name of the primary contact at the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactname")]
		public string PrimaryContactName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primarycontactname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimaryContactName");
				this.SetAttributeValue("primarycontactname", value);
				this.OnPropertyChanged("PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisheraddressid")]
		public System.Nullable<System.Guid> PublisherAddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("publisheraddressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PublisherAddressId");
				this.SetAttributeValue("publisheraddressid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PublisherAddressId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisheraddressid")]
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
				this.PublisherAddressId = value;
			}
		}
		
		/// <summary>
		/// Method of shipment for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Method of shipment for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public virtual PublisherAddress_ShippingMethodCode? ShippingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((PublisherAddress_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// State or province in the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stateorprovince")]
		public string StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateOrProvince");
				this.SetAttributeValue("stateorprovince", value);
				this.OnPropertyChanged("StateOrProvince");
			}
		}
		
		/// <summary>
		/// First telephone number for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Second telephone number for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Third telephone number for the publisher address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
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
		/// United Parcel Service (UPS) zone for the address of the publisher.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("upszone")]
		public string UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UPSZone");
				this.SetAttributeValue("upszone", value);
				this.OnPropertyChanged("UPSZone");
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
		/// UTC offset for the address. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcoffset")]
		public System.Nullable<int> UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCOffset");
				this.SetAttributeValue("utcoffset", value);
				this.OnPropertyChanged("UTCOffset");
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
		/// 1:N userentityinstancedata_publisheraddress
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_publisheraddress")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_publisheraddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_publisheraddress", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_publisheraddress");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_publisheraddress", null, value);
				this.OnPropertyChanged("userentityinstancedata_publisheraddress");
			}
		}
		
		/// <summary>
		/// N:1 lk_publisheraddressbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdby")]
		public CrmEarlyBound.SystemUser lk_publisheraddressbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_publisheraddressbase_createdby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_createdby", null, value);
				this.OnPropertyChanged("lk_publisheraddressbase_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_publisheraddressbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_publisheraddressbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_publisheraddressbase_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_publisheraddressbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_publisheraddressbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedby")]
		public CrmEarlyBound.SystemUser lk_publisheraddressbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_publisheraddressbase_modifiedby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_publisheraddressbase_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_publisheraddressbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_publisheraddressbase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_publisheraddressbase_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_publisheraddressbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_publisheraddressbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 Publisher_PublisherAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Publisher_PublisherAddress")]
		public CrmEarlyBound.Publisher Publisher_PublisherAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Publisher>("Publisher_PublisherAddress", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Publisher_PublisherAddress");
				this.SetRelatedEntity<CrmEarlyBound.Publisher>("Publisher_PublisherAddress", null, value);
				this.OnPropertyChanged("Publisher_PublisherAddress");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PublisherAddress(object anonymousType) : 
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
                        Attributes["publisheraddressid"] = base.Id;
                        break;
                    case "publisheraddressid":
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