/* 
 * Invoice Ninja
 *
 * Invoice Ninja. Open Source Invoicing lives here. 
 *
 * OpenAPI spec version: 5.1.20
 * Contact: contact@invoiceninja.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = InvoiceNinjaSDK.SwaggerDateConverter;

namespace InvoiceNinjaSDK.Model
{
    /// <summary>
    /// Vendor
    /// </summary>
    [DataContract]
        public partial class Vendor :  IEquatable<Vendor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vendor" /> class.
        /// </summary>
        /// <param name="id">_________.</param>
        /// <param name="userId">__________.</param>
        /// <param name="assignedUserId">__________.</param>
        /// <param name="companyId">________.</param>
        /// <param name="clientId">________.</param>
        /// <param name="contacts">contacts.</param>
        /// <param name="name">________.</param>
        /// <param name="website">________.</param>
        /// <param name="privateNotes">________.</param>
        /// <param name="industryId">________.</param>
        /// <param name="sizeId">________.</param>
        /// <param name="address1">________.</param>
        /// <param name="address2">________.</param>
        /// <param name="city">________.</param>
        /// <param name="state">________.</param>
        /// <param name="postalCode">________.</param>
        /// <param name="workPhone">The client phone number.</param>
        /// <param name="countryId">________.</param>
        /// <param name="currencyId">________.</param>
        /// <param name="customValue1">________.</param>
        /// <param name="customValue2">________.</param>
        /// <param name="customValue3">________.</param>
        /// <param name="customValue4">________.</param>
        /// <param name="vatNumber">________.</param>
        /// <param name="idNumber">________.</param>
        /// <param name="number">________.</param>
        /// <param name="isDeleted">________.</param>
        /// <param name="lastLogin">Timestamp.</param>
        /// <param name="createdAt">Timestamp.</param>
        /// <param name="updatedAt">Timestamp.</param>
        /// <param name="settings">settings.</param>
        public Vendor(string id = default(string), string userId = default(string), string assignedUserId = default(string), string companyId = default(string), string clientId = default(string), List<VendorContact> contacts = default(List<VendorContact>), string name = default(string), string website = default(string), string privateNotes = default(string), string industryId = default(string), string sizeId = default(string), string address1 = default(string), string address2 = default(string), string city = default(string), string state = default(string), string postalCode = default(string), string workPhone = default(string), string countryId = default(string), string currencyId = default(string), string customValue1 = default(string), string customValue2 = default(string), string customValue3 = default(string), string customValue4 = default(string), string vatNumber = default(string), string idNumber = default(string), string number = default(string), bool? isDeleted = default(bool?), decimal? lastLogin = default(decimal?), decimal? createdAt = default(decimal?), decimal? updatedAt = default(decimal?), CompanySettings settings = default(CompanySettings))
        {
            this.Id = id;
            this.UserId = userId;
            this.AssignedUserId = assignedUserId;
            this.CompanyId = companyId;
            this.ClientId = clientId;
            this.Contacts = contacts;
            this.Name = name;
            this.Website = website;
            this.PrivateNotes = privateNotes;
            this.IndustryId = industryId;
            this.SizeId = sizeId;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.WorkPhone = workPhone;
            this.CountryId = countryId;
            this.CurrencyId = currencyId;
            this.CustomValue1 = customValue1;
            this.CustomValue2 = customValue2;
            this.CustomValue3 = customValue3;
            this.CustomValue4 = customValue4;
            this.VatNumber = vatNumber;
            this.IdNumber = idNumber;
            this.Number = number;
            this.IsDeleted = isDeleted;
            this.LastLogin = lastLogin;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Settings = settings;
        }
        
        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// __________
        /// </summary>
        /// <value>__________</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// __________
        /// </summary>
        /// <value>__________</value>
        [DataMember(Name="assigned_user_id", EmitDefaultValue=false)]
        public string AssignedUserId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<VendorContact> Contacts { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="private_notes", EmitDefaultValue=false)]
        public string PrivateNotes { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="industry_id", EmitDefaultValue=false)]
        public string IndustryId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="size_id", EmitDefaultValue=false)]
        public string SizeId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The client phone number
        /// </summary>
        /// <value>The client phone number</value>
        [DataMember(Name="work_phone", EmitDefaultValue=false)]
        public string WorkPhone { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="custom_value1", EmitDefaultValue=false)]
        public string CustomValue1 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="custom_value2", EmitDefaultValue=false)]
        public string CustomValue2 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="custom_value3", EmitDefaultValue=false)]
        public string CustomValue3 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="custom_value4", EmitDefaultValue=false)]
        public string CustomValue4 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="vat_number", EmitDefaultValue=false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="id_number", EmitDefaultValue=false)]
        public string IdNumber { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="is_deleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        /// <value>Timestamp</value>
        [DataMember(Name="last_login", EmitDefaultValue=false)]
        public decimal? LastLogin { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        /// <value>Timestamp</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        /// <value>Timestamp</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public decimal? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public CompanySettings Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vendor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AssignedUserId: ").Append(AssignedUserId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  PrivateNotes: ").Append(PrivateNotes).Append("\n");
            sb.Append("  IndustryId: ").Append(IndustryId).Append("\n");
            sb.Append("  SizeId: ").Append(SizeId).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CustomValue1: ").Append(CustomValue1).Append("\n");
            sb.Append("  CustomValue2: ").Append(CustomValue2).Append("\n");
            sb.Append("  CustomValue3: ").Append(CustomValue3).Append("\n");
            sb.Append("  CustomValue4: ").Append(CustomValue4).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Vendor);
        }

        /// <summary>
        /// Returns true if Vendor instances are equal
        /// </summary>
        /// <param name="input">Instance of Vendor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vendor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AssignedUserId == input.AssignedUserId ||
                    (this.AssignedUserId != null &&
                    this.AssignedUserId.Equals(input.AssignedUserId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.PrivateNotes == input.PrivateNotes ||
                    (this.PrivateNotes != null &&
                    this.PrivateNotes.Equals(input.PrivateNotes))
                ) && 
                (
                    this.IndustryId == input.IndustryId ||
                    (this.IndustryId != null &&
                    this.IndustryId.Equals(input.IndustryId))
                ) && 
                (
                    this.SizeId == input.SizeId ||
                    (this.SizeId != null &&
                    this.SizeId.Equals(input.SizeId))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.WorkPhone == input.WorkPhone ||
                    (this.WorkPhone != null &&
                    this.WorkPhone.Equals(input.WorkPhone))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.CustomValue1 == input.CustomValue1 ||
                    (this.CustomValue1 != null &&
                    this.CustomValue1.Equals(input.CustomValue1))
                ) && 
                (
                    this.CustomValue2 == input.CustomValue2 ||
                    (this.CustomValue2 != null &&
                    this.CustomValue2.Equals(input.CustomValue2))
                ) && 
                (
                    this.CustomValue3 == input.CustomValue3 ||
                    (this.CustomValue3 != null &&
                    this.CustomValue3.Equals(input.CustomValue3))
                ) && 
                (
                    this.CustomValue4 == input.CustomValue4 ||
                    (this.CustomValue4 != null &&
                    this.CustomValue4.Equals(input.CustomValue4))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AssignedUserId != null)
                    hashCode = hashCode * 59 + this.AssignedUserId.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.PrivateNotes != null)
                    hashCode = hashCode * 59 + this.PrivateNotes.GetHashCode();
                if (this.IndustryId != null)
                    hashCode = hashCode * 59 + this.IndustryId.GetHashCode();
                if (this.SizeId != null)
                    hashCode = hashCode * 59 + this.SizeId.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.WorkPhone != null)
                    hashCode = hashCode * 59 + this.WorkPhone.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.CustomValue1 != null)
                    hashCode = hashCode * 59 + this.CustomValue1.GetHashCode();
                if (this.CustomValue2 != null)
                    hashCode = hashCode * 59 + this.CustomValue2.GetHashCode();
                if (this.CustomValue3 != null)
                    hashCode = hashCode * 59 + this.CustomValue3.GetHashCode();
                if (this.CustomValue4 != null)
                    hashCode = hashCode * 59 + this.CustomValue4.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
