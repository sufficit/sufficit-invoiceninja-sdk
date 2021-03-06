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
    /// Body3
    /// </summary>
    [DataContract]
        public partial class Body3 :  IEquatable<Body3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body3" /> class.
        /// </summary>
        /// <param name="subject">The email subject.</param>
        /// <param name="body">The email body.</param>
        /// <param name="entity">The entity name.</param>
        /// <param name="entityId">The entity_id.</param>
        /// <param name="template">The template required.</param>
        public Body3(string subject = default(string), string body = default(string), string entity = default(string), string entityId = default(string), string template = default(string))
        {
            this.Subject = subject;
            this.Body = body;
            this.Entity = entity;
            this.EntityId = entityId;
            this.Template = template;
        }
        
        /// <summary>
        /// The email subject
        /// </summary>
        /// <value>The email subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// The email body
        /// </summary>
        /// <value>The email body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// The entity name
        /// </summary>
        /// <value>The entity name</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public string Entity { get; set; }

        /// <summary>
        /// The entity_id
        /// </summary>
        /// <value>The entity_id</value>
        [DataMember(Name="entity_id", EmitDefaultValue=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// The template required
        /// </summary>
        /// <value>The template required</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body3 {\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as Body3);
        }

        /// <summary>
        /// Returns true if Body3 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
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
