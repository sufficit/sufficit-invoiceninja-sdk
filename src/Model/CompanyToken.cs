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
    /// CompanyToken
    /// </summary>
    [DataContract]
        public partial class CompanyToken :  IEquatable<CompanyToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyToken" /> class.
        /// </summary>
        /// <param name="name">The token name.</param>
        /// <param name="token">The token value.</param>
        /// <param name="isSystem">Determines whether the token is created by the system rather than a user.</param>
        public CompanyToken(string name = default(string), string token = default(string), bool? isSystem = default(bool?))
        {
            this.Name = name;
            this.Token = token;
            this.IsSystem = isSystem;
        }
        
        /// <summary>
        /// The token name
        /// </summary>
        /// <value>The token name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The token value
        /// </summary>
        /// <value>The token value</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Determines whether the token is created by the system rather than a user
        /// </summary>
        /// <value>Determines whether the token is created by the system rather than a user</value>
        [DataMember(Name="is_system", EmitDefaultValue=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyToken {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
            return this.Equals(input as CompanyToken);
        }

        /// <summary>
        /// Returns true if CompanyToken instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.IsSystem == input.IsSystem ||
                    (this.IsSystem != null &&
                    this.IsSystem.Equals(input.IsSystem))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.IsSystem != null)
                    hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
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