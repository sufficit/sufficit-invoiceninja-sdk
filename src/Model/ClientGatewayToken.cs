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
    /// ClientGatewayToken
    /// </summary>
    [DataContract]
        public partial class ClientGatewayToken :  IEquatable<ClientGatewayToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGatewayToken" /> class.
        /// </summary>
        /// <param name="id">______.</param>
        /// <param name="companyId">______.</param>
        /// <param name="clientId">______.</param>
        /// <param name="token">______.</param>
        /// <param name="routingNumber">______.</param>
        /// <param name="companyGatewayId">______.</param>
        /// <param name="isDefault">______.</param>
        public ClientGatewayToken(string id = default(string), string companyId = default(string), string clientId = default(string), string token = default(string), string routingNumber = default(string), string companyGatewayId = default(string), bool? isDefault = default(bool?))
        {
            this.Id = id;
            this.CompanyId = companyId;
            this.ClientId = clientId;
            this.Token = token;
            this.RoutingNumber = routingNumber;
            this.CompanyGatewayId = companyGatewayId;
            this.IsDefault = isDefault;
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
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

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
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="routing_number", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="company_gateway_id", EmitDefaultValue=false)]
        public string CompanyGatewayId { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="is_default", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientGatewayToken {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  CompanyGatewayId: ").Append(CompanyGatewayId).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
            return this.Equals(input as ClientGatewayToken);
        }

        /// <summary>
        /// Returns true if ClientGatewayToken instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientGatewayToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientGatewayToken input)
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
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.CompanyGatewayId == input.CompanyGatewayId ||
                    (this.CompanyGatewayId != null &&
                    this.CompanyGatewayId.Equals(input.CompanyGatewayId))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
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
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.RoutingNumber != null)
                    hashCode = hashCode * 59 + this.RoutingNumber.GetHashCode();
                if (this.CompanyGatewayId != null)
                    hashCode = hashCode * 59 + this.CompanyGatewayId.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
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
