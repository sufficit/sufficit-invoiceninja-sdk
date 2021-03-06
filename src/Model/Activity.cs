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
    /// Activity
    /// </summary>
    [DataContract]
        public partial class Activity :  IEquatable<Activity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="id">______.</param>
        /// <param name="activityTypeId">______.</param>
        /// <param name="clientId">______.</param>
        /// <param name="companyId">______.</param>
        /// <param name="userId">______.</param>
        /// <param name="invoiceId">______.</param>
        /// <param name="paymentId">______.</param>
        /// <param name="creditId">______.</param>
        /// <param name="updatedAt">______.</param>
        /// <param name="expenseId">______.</param>
        /// <param name="isSystem">______.</param>
        /// <param name="contactId">______.</param>
        /// <param name="taskId">______.</param>
        /// <param name="notes">______.</param>
        /// <param name="ip">______.</param>
        public Activity(string id = default(string), string activityTypeId = default(string), string clientId = default(string), string companyId = default(string), string userId = default(string), string invoiceId = default(string), string paymentId = default(string), string creditId = default(string), string updatedAt = default(string), string expenseId = default(string), bool? isSystem = default(bool?), string contactId = default(string), string taskId = default(string), string notes = default(string), string ip = default(string))
        {
            this.Id = id;
            this.ActivityTypeId = activityTypeId;
            this.ClientId = clientId;
            this.CompanyId = companyId;
            this.UserId = userId;
            this.InvoiceId = invoiceId;
            this.PaymentId = paymentId;
            this.CreditId = creditId;
            this.UpdatedAt = updatedAt;
            this.ExpenseId = expenseId;
            this.IsSystem = isSystem;
            this.ContactId = contactId;
            this.TaskId = taskId;
            this.Notes = notes;
            this.Ip = ip;
        }
        
        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="activity_type_id", EmitDefaultValue=false)]
        public string ActivityTypeId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="payment_id", EmitDefaultValue=false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="credit_id", EmitDefaultValue=false)]
        public string CreditId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="expense_id", EmitDefaultValue=false)]
        public string ExpenseId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="is_system", EmitDefaultValue=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="contact_id", EmitDefaultValue=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="task_id", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActivityTypeId: ").Append(ActivityTypeId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  CreditId: ").Append(CreditId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ExpenseId: ").Append(ExpenseId).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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
            return this.Equals(input as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="input">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity input)
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
                    this.ActivityTypeId == input.ActivityTypeId ||
                    (this.ActivityTypeId != null &&
                    this.ActivityTypeId.Equals(input.ActivityTypeId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.CreditId == input.CreditId ||
                    (this.CreditId != null &&
                    this.CreditId.Equals(input.CreditId))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ExpenseId == input.ExpenseId ||
                    (this.ExpenseId != null &&
                    this.ExpenseId.Equals(input.ExpenseId))
                ) && 
                (
                    this.IsSystem == input.IsSystem ||
                    (this.IsSystem != null &&
                    this.IsSystem.Equals(input.IsSystem))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.ActivityTypeId != null)
                    hashCode = hashCode * 59 + this.ActivityTypeId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.PaymentId != null)
                    hashCode = hashCode * 59 + this.PaymentId.GetHashCode();
                if (this.CreditId != null)
                    hashCode = hashCode * 59 + this.CreditId.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ExpenseId != null)
                    hashCode = hashCode * 59 + this.ExpenseId.GetHashCode();
                if (this.IsSystem != null)
                    hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
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
