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
    /// PaymentTerm
    /// </summary>
    [DataContract]
        public partial class PaymentTerm :  IEquatable<PaymentTerm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerm" /> class.
        /// </summary>
        /// <param name="numDays">The payment term length in days.</param>
        /// <param name="name">The payment term length in string format.</param>
        /// <param name="createdAt">Timestamp.</param>
        /// <param name="updatedAt">Timestamp.</param>
        /// <param name="archivedAt">Timestamp.</param>
        public PaymentTerm(int? numDays = default(int?), string name = default(string), decimal? createdAt = default(decimal?), decimal? updatedAt = default(decimal?), decimal? archivedAt = default(decimal?))
        {
            this.NumDays = numDays;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
        }
        
        /// <summary>
        /// The payment term length in days
        /// </summary>
        /// <value>The payment term length in days</value>
        [DataMember(Name="num_days", EmitDefaultValue=false)]
        public int? NumDays { get; set; }

        /// <summary>
        /// The payment term length in string format
        /// </summary>
        /// <value>The payment term length in string format</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        [DataMember(Name="archived_at", EmitDefaultValue=false)]
        public decimal? ArchivedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerm {\n");
            sb.Append("  NumDays: ").Append(NumDays).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ArchivedAt: ").Append(ArchivedAt).Append("\n");
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
            return this.Equals(input as PaymentTerm);
        }

        /// <summary>
        /// Returns true if PaymentTerm instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumDays == input.NumDays ||
                    (this.NumDays != null &&
                    this.NumDays.Equals(input.NumDays))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.ArchivedAt == input.ArchivedAt ||
                    (this.ArchivedAt != null &&
                    this.ArchivedAt.Equals(input.ArchivedAt))
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
                if (this.NumDays != null)
                    hashCode = hashCode * 59 + this.NumDays.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ArchivedAt != null)
                    hashCode = hashCode * 59 + this.ArchivedAt.GetHashCode();
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
