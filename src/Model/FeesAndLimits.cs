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
    /// FeesAndLimits
    /// </summary>
    [DataContract]
        public partial class FeesAndLimits :  IEquatable<FeesAndLimits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesAndLimits" /> class.
        /// </summary>
        /// <param name="minLimit">______.</param>
        /// <param name="maxLimit">______.</param>
        /// <param name="feeAmount">______.</param>
        /// <param name="feePercent">______.</param>
        /// <param name="feeTaxName1">______.</param>
        /// <param name="feeTaxName2">______.</param>
        /// <param name="feeTaxName3">______.</param>
        /// <param name="feeTaxRate1">______.</param>
        /// <param name="feeTaxRate2">______.</param>
        /// <param name="feeTaxRate3">______.</param>
        /// <param name="feeCap">______.</param>
        /// <param name="adjustFeePercent">______.</param>
        public FeesAndLimits(string minLimit = default(string), string maxLimit = default(string), float? feeAmount = default(float?), float? feePercent = default(float?), string feeTaxName1 = default(string), string feeTaxName2 = default(string), string feeTaxName3 = default(string), float? feeTaxRate1 = default(float?), float? feeTaxRate2 = default(float?), float? feeTaxRate3 = default(float?), float? feeCap = default(float?), bool? adjustFeePercent = default(bool?))
        {
            this.MinLimit = minLimit;
            this.MaxLimit = maxLimit;
            this.FeeAmount = feeAmount;
            this.FeePercent = feePercent;
            this.FeeTaxName1 = feeTaxName1;
            this.FeeTaxName2 = feeTaxName2;
            this.FeeTaxName3 = feeTaxName3;
            this.FeeTaxRate1 = feeTaxRate1;
            this.FeeTaxRate2 = feeTaxRate2;
            this.FeeTaxRate3 = feeTaxRate3;
            this.FeeCap = feeCap;
            this.AdjustFeePercent = adjustFeePercent;
        }
        
        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="min_limit", EmitDefaultValue=false)]
        public string MinLimit { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="max_limit", EmitDefaultValue=false)]
        public string MaxLimit { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_amount", EmitDefaultValue=false)]
        public float? FeeAmount { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_percent", EmitDefaultValue=false)]
        public float? FeePercent { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_tax_name1", EmitDefaultValue=false)]
        public string FeeTaxName1 { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_tax_name2", EmitDefaultValue=false)]
        public string FeeTaxName2 { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_tax_name3", EmitDefaultValue=false)]
        public string FeeTaxName3 { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_tax_rate1", EmitDefaultValue=false)]
        public float? FeeTaxRate1 { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_tax_rate2", EmitDefaultValue=false)]
        public float? FeeTaxRate2 { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_tax_rate3", EmitDefaultValue=false)]
        public float? FeeTaxRate3 { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="fee_cap", EmitDefaultValue=false)]
        public float? FeeCap { get; set; }

        /// <summary>
        /// ______
        /// </summary>
        /// <value>______</value>
        [DataMember(Name="adjust_fee_percent", EmitDefaultValue=false)]
        public bool? AdjustFeePercent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeesAndLimits {\n");
            sb.Append("  MinLimit: ").Append(MinLimit).Append("\n");
            sb.Append("  MaxLimit: ").Append(MaxLimit).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  FeePercent: ").Append(FeePercent).Append("\n");
            sb.Append("  FeeTaxName1: ").Append(FeeTaxName1).Append("\n");
            sb.Append("  FeeTaxName2: ").Append(FeeTaxName2).Append("\n");
            sb.Append("  FeeTaxName3: ").Append(FeeTaxName3).Append("\n");
            sb.Append("  FeeTaxRate1: ").Append(FeeTaxRate1).Append("\n");
            sb.Append("  FeeTaxRate2: ").Append(FeeTaxRate2).Append("\n");
            sb.Append("  FeeTaxRate3: ").Append(FeeTaxRate3).Append("\n");
            sb.Append("  FeeCap: ").Append(FeeCap).Append("\n");
            sb.Append("  AdjustFeePercent: ").Append(AdjustFeePercent).Append("\n");
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
            return this.Equals(input as FeesAndLimits);
        }

        /// <summary>
        /// Returns true if FeesAndLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of FeesAndLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeesAndLimits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinLimit == input.MinLimit ||
                    (this.MinLimit != null &&
                    this.MinLimit.Equals(input.MinLimit))
                ) && 
                (
                    this.MaxLimit == input.MaxLimit ||
                    (this.MaxLimit != null &&
                    this.MaxLimit.Equals(input.MaxLimit))
                ) && 
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
                ) && 
                (
                    this.FeePercent == input.FeePercent ||
                    (this.FeePercent != null &&
                    this.FeePercent.Equals(input.FeePercent))
                ) && 
                (
                    this.FeeTaxName1 == input.FeeTaxName1 ||
                    (this.FeeTaxName1 != null &&
                    this.FeeTaxName1.Equals(input.FeeTaxName1))
                ) && 
                (
                    this.FeeTaxName2 == input.FeeTaxName2 ||
                    (this.FeeTaxName2 != null &&
                    this.FeeTaxName2.Equals(input.FeeTaxName2))
                ) && 
                (
                    this.FeeTaxName3 == input.FeeTaxName3 ||
                    (this.FeeTaxName3 != null &&
                    this.FeeTaxName3.Equals(input.FeeTaxName3))
                ) && 
                (
                    this.FeeTaxRate1 == input.FeeTaxRate1 ||
                    (this.FeeTaxRate1 != null &&
                    this.FeeTaxRate1.Equals(input.FeeTaxRate1))
                ) && 
                (
                    this.FeeTaxRate2 == input.FeeTaxRate2 ||
                    (this.FeeTaxRate2 != null &&
                    this.FeeTaxRate2.Equals(input.FeeTaxRate2))
                ) && 
                (
                    this.FeeTaxRate3 == input.FeeTaxRate3 ||
                    (this.FeeTaxRate3 != null &&
                    this.FeeTaxRate3.Equals(input.FeeTaxRate3))
                ) && 
                (
                    this.FeeCap == input.FeeCap ||
                    (this.FeeCap != null &&
                    this.FeeCap.Equals(input.FeeCap))
                ) && 
                (
                    this.AdjustFeePercent == input.AdjustFeePercent ||
                    (this.AdjustFeePercent != null &&
                    this.AdjustFeePercent.Equals(input.AdjustFeePercent))
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
                if (this.MinLimit != null)
                    hashCode = hashCode * 59 + this.MinLimit.GetHashCode();
                if (this.MaxLimit != null)
                    hashCode = hashCode * 59 + this.MaxLimit.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
                if (this.FeePercent != null)
                    hashCode = hashCode * 59 + this.FeePercent.GetHashCode();
                if (this.FeeTaxName1 != null)
                    hashCode = hashCode * 59 + this.FeeTaxName1.GetHashCode();
                if (this.FeeTaxName2 != null)
                    hashCode = hashCode * 59 + this.FeeTaxName2.GetHashCode();
                if (this.FeeTaxName3 != null)
                    hashCode = hashCode * 59 + this.FeeTaxName3.GetHashCode();
                if (this.FeeTaxRate1 != null)
                    hashCode = hashCode * 59 + this.FeeTaxRate1.GetHashCode();
                if (this.FeeTaxRate2 != null)
                    hashCode = hashCode * 59 + this.FeeTaxRate2.GetHashCode();
                if (this.FeeTaxRate3 != null)
                    hashCode = hashCode * 59 + this.FeeTaxRate3.GetHashCode();
                if (this.FeeCap != null)
                    hashCode = hashCode * 59 + this.FeeCap.GetHashCode();
                if (this.AdjustFeePercent != null)
                    hashCode = hashCode * 59 + this.AdjustFeePercent.GetHashCode();
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
