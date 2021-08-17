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
    /// ClientContact
    /// </summary>
    [DataContract]
        public partial class ClientContact :  IEquatable<ClientContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContact" /> class.
        /// </summary>
        /// <param name="id">_________.</param>
        /// <param name="userId">__________.</param>
        /// <param name="companyId">________.</param>
        /// <param name="clientId">________.</param>
        /// <param name="firstName">________.</param>
        /// <param name="lastName">________.</param>
        /// <param name="phone">________.</param>
        /// <param name="customValue1">________.</param>
        /// <param name="customValue2">________.</param>
        /// <param name="customValue3">________.</param>
        /// <param name="customValue4">________.</param>
        /// <param name="email">________.</param>
        /// <param name="acceptedTermsVersion">________.</param>
        /// <param name="password">________.</param>
        /// <param name="confirmationCode">________.</param>
        /// <param name="token">________.</param>
        /// <param name="isPrimary">________.</param>
        /// <param name="confirmed">________.</param>
        /// <param name="isLocked">________.</param>
        /// <param name="sendEmail">________.</param>
        /// <param name="failedLogins">________.</param>
        /// <param name="emailVerifiedAt">________.</param>
        /// <param name="paidToDate">________.</param>
        /// <param name="lastLogin">Timestamp.</param>
        /// <param name="createdAt">Timestamp.</param>
        /// <param name="updatedAt">Timestamp.</param>
        /// <param name="deletedAt">Timestamp.</param>
        public ClientContact(string id = default(string), string userId = default(string), string companyId = default(string), string clientId = default(string), string firstName = default(string), string lastName = default(string), string phone = default(string), string customValue1 = default(string), string customValue2 = default(string), string customValue3 = default(string), string customValue4 = default(string), string email = default(string), string acceptedTermsVersion = default(string), string password = default(string), string confirmationCode = default(string), string token = default(string), bool? isPrimary = default(bool?), bool? confirmed = default(bool?), bool? isLocked = default(bool?), bool? sendEmail = default(bool?), decimal? failedLogins = default(decimal?), decimal? emailVerifiedAt = default(decimal?), float? paidToDate = default(float?), decimal? lastLogin = default(decimal?), decimal? createdAt = default(decimal?), decimal? updatedAt = default(decimal?), decimal? deletedAt = default(decimal?))
        {
            this.Id = id;
            this.UserId = userId;
            this.CompanyId = companyId;
            this.ClientId = clientId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.CustomValue1 = customValue1;
            this.CustomValue2 = customValue2;
            this.CustomValue3 = customValue3;
            this.CustomValue4 = customValue4;
            this.Email = email;
            this.AcceptedTermsVersion = acceptedTermsVersion;
            this.Password = password;
            this.ConfirmationCode = confirmationCode;
            this.Token = token;
            this.IsPrimary = isPrimary;
            this.Confirmed = confirmed;
            this.IsLocked = isLocked;
            this.SendEmail = sendEmail;
            this.FailedLogins = failedLogins;
            this.EmailVerifiedAt = emailVerifiedAt;
            this.PaidToDate = paidToDate;
            this.LastLogin = lastLogin;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
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
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

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
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="accepted_terms_version", EmitDefaultValue=false)]
        public string AcceptedTermsVersion { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="confirmation-code", EmitDefaultValue=false)]
        public string ConfirmationCode { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="is_primary", EmitDefaultValue=false)]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="confirmed", EmitDefaultValue=false)]
        public bool? Confirmed { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="is_locked", EmitDefaultValue=false)]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="send_email", EmitDefaultValue=false)]
        public bool? SendEmail { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="failed_logins", EmitDefaultValue=false)]
        public decimal? FailedLogins { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="email_verified_at", EmitDefaultValue=false)]
        public decimal? EmailVerifiedAt { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="paid_to_date", EmitDefaultValue=false)]
        public float? PaidToDate { get; set; }

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
        /// Timestamp
        /// </summary>
        /// <value>Timestamp</value>
        [DataMember(Name="deleted_at", EmitDefaultValue=false)]
        public decimal? DeletedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientContact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  CustomValue1: ").Append(CustomValue1).Append("\n");
            sb.Append("  CustomValue2: ").Append(CustomValue2).Append("\n");
            sb.Append("  CustomValue3: ").Append(CustomValue3).Append("\n");
            sb.Append("  CustomValue4: ").Append(CustomValue4).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  AcceptedTermsVersion: ").Append(AcceptedTermsVersion).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ConfirmationCode: ").Append(ConfirmationCode).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
            sb.Append("  Confirmed: ").Append(Confirmed).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  SendEmail: ").Append(SendEmail).Append("\n");
            sb.Append("  FailedLogins: ").Append(FailedLogins).Append("\n");
            sb.Append("  EmailVerifiedAt: ").Append(EmailVerifiedAt).Append("\n");
            sb.Append("  PaidToDate: ").Append(PaidToDate).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
            return this.Equals(input as ClientContact);
        }

        /// <summary>
        /// Returns true if ClientContact instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientContact input)
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
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.AcceptedTermsVersion == input.AcceptedTermsVersion ||
                    (this.AcceptedTermsVersion != null &&
                    this.AcceptedTermsVersion.Equals(input.AcceptedTermsVersion))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ConfirmationCode == input.ConfirmationCode ||
                    (this.ConfirmationCode != null &&
                    this.ConfirmationCode.Equals(input.ConfirmationCode))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.IsPrimary == input.IsPrimary ||
                    (this.IsPrimary != null &&
                    this.IsPrimary.Equals(input.IsPrimary))
                ) && 
                (
                    this.Confirmed == input.Confirmed ||
                    (this.Confirmed != null &&
                    this.Confirmed.Equals(input.Confirmed))
                ) && 
                (
                    this.IsLocked == input.IsLocked ||
                    (this.IsLocked != null &&
                    this.IsLocked.Equals(input.IsLocked))
                ) && 
                (
                    this.SendEmail == input.SendEmail ||
                    (this.SendEmail != null &&
                    this.SendEmail.Equals(input.SendEmail))
                ) && 
                (
                    this.FailedLogins == input.FailedLogins ||
                    (this.FailedLogins != null &&
                    this.FailedLogins.Equals(input.FailedLogins))
                ) && 
                (
                    this.EmailVerifiedAt == input.EmailVerifiedAt ||
                    (this.EmailVerifiedAt != null &&
                    this.EmailVerifiedAt.Equals(input.EmailVerifiedAt))
                ) && 
                (
                    this.PaidToDate == input.PaidToDate ||
                    (this.PaidToDate != null &&
                    this.PaidToDate.Equals(input.PaidToDate))
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
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.CustomValue1 != null)
                    hashCode = hashCode * 59 + this.CustomValue1.GetHashCode();
                if (this.CustomValue2 != null)
                    hashCode = hashCode * 59 + this.CustomValue2.GetHashCode();
                if (this.CustomValue3 != null)
                    hashCode = hashCode * 59 + this.CustomValue3.GetHashCode();
                if (this.CustomValue4 != null)
                    hashCode = hashCode * 59 + this.CustomValue4.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.AcceptedTermsVersion != null)
                    hashCode = hashCode * 59 + this.AcceptedTermsVersion.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ConfirmationCode != null)
                    hashCode = hashCode * 59 + this.ConfirmationCode.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.IsPrimary != null)
                    hashCode = hashCode * 59 + this.IsPrimary.GetHashCode();
                if (this.Confirmed != null)
                    hashCode = hashCode * 59 + this.Confirmed.GetHashCode();
                if (this.IsLocked != null)
                    hashCode = hashCode * 59 + this.IsLocked.GetHashCode();
                if (this.SendEmail != null)
                    hashCode = hashCode * 59 + this.SendEmail.GetHashCode();
                if (this.FailedLogins != null)
                    hashCode = hashCode * 59 + this.FailedLogins.GetHashCode();
                if (this.EmailVerifiedAt != null)
                    hashCode = hashCode * 59 + this.EmailVerifiedAt.GetHashCode();
                if (this.PaidToDate != null)
                    hashCode = hashCode * 59 + this.PaidToDate.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
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