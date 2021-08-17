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
    /// Expense
    /// </summary>
    [DataContract]
        public partial class Expense :  IEquatable<Expense>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expense" /> class.
        /// </summary>
        /// <param name="id">_________.</param>
        /// <param name="userId">__________.</param>
        /// <param name="assignedUserId">__________.</param>
        /// <param name="companyId">________.</param>
        /// <param name="clientId">________.</param>
        /// <param name="invoiceId">________.</param>
        /// <param name="bankId">________.</param>
        /// <param name="invoiceCurrencyId">________.</param>
        /// <param name="expenseCurrencyId">________.</param>
        /// <param name="invoiceCategoryId">________.</param>
        /// <param name="paymentTypeId">________.</param>
        /// <param name="recurringExpenseId">________.</param>
        /// <param name="privateNotes">________.</param>
        /// <param name="publicNotes">________.</param>
        /// <param name="transactionReference">________.</param>
        /// <param name="transcationId">________.</param>
        /// <param name="customValue1">________.</param>
        /// <param name="customValue2">________.</param>
        /// <param name="customValue3">________.</param>
        /// <param name="customValue4">________.</param>
        /// <param name="taxName1">________.</param>
        /// <param name="taxName2">________.</param>
        /// <param name="taxRate1">_________.</param>
        /// <param name="taxRate2">_________.</param>
        /// <param name="taxName3">________.</param>
        /// <param name="taxRate3">_________.</param>
        /// <param name="amount">_________.</param>
        /// <param name="foreignAmount">_________.</param>
        /// <param name="exchangeRate">_________.</param>
        /// <param name="date">________.</param>
        /// <param name="paymentDate">________.</param>
        /// <param name="shouldBeInvoiced">_________.</param>
        /// <param name="isDeleted">_________.</param>
        /// <param name="invoiceDocuments">invoiceDocuments.</param>
        /// <param name="updatedAt">Timestamp.</param>
        /// <param name="archivedAt">Timestamp.</param>
        public Expense(string id = default(string), string userId = default(string), string assignedUserId = default(string), string companyId = default(string), string clientId = default(string), string invoiceId = default(string), string bankId = default(string), string invoiceCurrencyId = default(string), string expenseCurrencyId = default(string), string invoiceCategoryId = default(string), string paymentTypeId = default(string), string recurringExpenseId = default(string), string privateNotes = default(string), string publicNotes = default(string), string transactionReference = default(string), string transcationId = default(string), string customValue1 = default(string), string customValue2 = default(string), string customValue3 = default(string), string customValue4 = default(string), string taxName1 = default(string), string taxName2 = default(string), float? taxRate1 = default(float?), float? taxRate2 = default(float?), string taxName3 = default(string), float? taxRate3 = default(float?), float? amount = default(float?), float? foreignAmount = default(float?), float? exchangeRate = default(float?), string date = default(string), string paymentDate = default(string), bool? shouldBeInvoiced = default(bool?), bool? isDeleted = default(bool?), bool? invoiceDocuments = default(bool?), decimal? updatedAt = default(decimal?), decimal? archivedAt = default(decimal?))
        {
            this.Id = id;
            this.UserId = userId;
            this.AssignedUserId = assignedUserId;
            this.CompanyId = companyId;
            this.ClientId = clientId;
            this.InvoiceId = invoiceId;
            this.BankId = bankId;
            this.InvoiceCurrencyId = invoiceCurrencyId;
            this.ExpenseCurrencyId = expenseCurrencyId;
            this.InvoiceCategoryId = invoiceCategoryId;
            this.PaymentTypeId = paymentTypeId;
            this.RecurringExpenseId = recurringExpenseId;
            this.PrivateNotes = privateNotes;
            this.PublicNotes = publicNotes;
            this.TransactionReference = transactionReference;
            this.TranscationId = transcationId;
            this.CustomValue1 = customValue1;
            this.CustomValue2 = customValue2;
            this.CustomValue3 = customValue3;
            this.CustomValue4 = customValue4;
            this.TaxName1 = taxName1;
            this.TaxName2 = taxName2;
            this.TaxRate1 = taxRate1;
            this.TaxRate2 = taxRate2;
            this.TaxName3 = taxName3;
            this.TaxRate3 = taxRate3;
            this.Amount = amount;
            this.ForeignAmount = foreignAmount;
            this.ExchangeRate = exchangeRate;
            this.Date = date;
            this.PaymentDate = paymentDate;
            this.ShouldBeInvoiced = shouldBeInvoiced;
            this.IsDeleted = isDeleted;
            this.InvoiceDocuments = invoiceDocuments;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
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
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="invoice_id", EmitDefaultValue=false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="bank_id", EmitDefaultValue=false)]
        public string BankId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="invoice_currency_id", EmitDefaultValue=false)]
        public string InvoiceCurrencyId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="expense_currency_id", EmitDefaultValue=false)]
        public string ExpenseCurrencyId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="invoice_category_id", EmitDefaultValue=false)]
        public string InvoiceCategoryId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="payment_type_id", EmitDefaultValue=false)]
        public string PaymentTypeId { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="recurring_expense_id", EmitDefaultValue=false)]
        public string RecurringExpenseId { get; set; }

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
        [DataMember(Name="public_notes", EmitDefaultValue=false)]
        public string PublicNotes { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="transaction_reference", EmitDefaultValue=false)]
        public string TransactionReference { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="transcation_id", EmitDefaultValue=false)]
        public string TranscationId { get; set; }

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
        [DataMember(Name="tax_name1", EmitDefaultValue=false)]
        public string TaxName1 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="tax_name2", EmitDefaultValue=false)]
        public string TaxName2 { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="tax_rate1", EmitDefaultValue=false)]
        public float? TaxRate1 { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="tax_rate2", EmitDefaultValue=false)]
        public float? TaxRate2 { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="tax_name3", EmitDefaultValue=false)]
        public string TaxName3 { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="tax_rate3", EmitDefaultValue=false)]
        public float? TaxRate3 { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public float? Amount { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="foreign_amount", EmitDefaultValue=false)]
        public float? ForeignAmount { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="exchange_rate", EmitDefaultValue=false)]
        public float? ExchangeRate { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// ________
        /// </summary>
        /// <value>________</value>
        [DataMember(Name="payment_date", EmitDefaultValue=false)]
        public string PaymentDate { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="should_be_invoiced", EmitDefaultValue=false)]
        public bool? ShouldBeInvoiced { get; set; }

        /// <summary>
        /// _________
        /// </summary>
        /// <value>_________</value>
        [DataMember(Name="is_deleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDocuments
        /// </summary>
        [DataMember(Name="invoice_documents", EmitDefaultValue=false)]
        public bool? InvoiceDocuments { get; set; }

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
            sb.Append("class Expense {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AssignedUserId: ").Append(AssignedUserId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  BankId: ").Append(BankId).Append("\n");
            sb.Append("  InvoiceCurrencyId: ").Append(InvoiceCurrencyId).Append("\n");
            sb.Append("  ExpenseCurrencyId: ").Append(ExpenseCurrencyId).Append("\n");
            sb.Append("  InvoiceCategoryId: ").Append(InvoiceCategoryId).Append("\n");
            sb.Append("  PaymentTypeId: ").Append(PaymentTypeId).Append("\n");
            sb.Append("  RecurringExpenseId: ").Append(RecurringExpenseId).Append("\n");
            sb.Append("  PrivateNotes: ").Append(PrivateNotes).Append("\n");
            sb.Append("  PublicNotes: ").Append(PublicNotes).Append("\n");
            sb.Append("  TransactionReference: ").Append(TransactionReference).Append("\n");
            sb.Append("  TranscationId: ").Append(TranscationId).Append("\n");
            sb.Append("  CustomValue1: ").Append(CustomValue1).Append("\n");
            sb.Append("  CustomValue2: ").Append(CustomValue2).Append("\n");
            sb.Append("  CustomValue3: ").Append(CustomValue3).Append("\n");
            sb.Append("  CustomValue4: ").Append(CustomValue4).Append("\n");
            sb.Append("  TaxName1: ").Append(TaxName1).Append("\n");
            sb.Append("  TaxName2: ").Append(TaxName2).Append("\n");
            sb.Append("  TaxRate1: ").Append(TaxRate1).Append("\n");
            sb.Append("  TaxRate2: ").Append(TaxRate2).Append("\n");
            sb.Append("  TaxName3: ").Append(TaxName3).Append("\n");
            sb.Append("  TaxRate3: ").Append(TaxRate3).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  ShouldBeInvoiced: ").Append(ShouldBeInvoiced).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  InvoiceDocuments: ").Append(InvoiceDocuments).Append("\n");
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
            return this.Equals(input as Expense);
        }

        /// <summary>
        /// Returns true if Expense instances are equal
        /// </summary>
        /// <param name="input">Instance of Expense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Expense input)
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
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.BankId == input.BankId ||
                    (this.BankId != null &&
                    this.BankId.Equals(input.BankId))
                ) && 
                (
                    this.InvoiceCurrencyId == input.InvoiceCurrencyId ||
                    (this.InvoiceCurrencyId != null &&
                    this.InvoiceCurrencyId.Equals(input.InvoiceCurrencyId))
                ) && 
                (
                    this.ExpenseCurrencyId == input.ExpenseCurrencyId ||
                    (this.ExpenseCurrencyId != null &&
                    this.ExpenseCurrencyId.Equals(input.ExpenseCurrencyId))
                ) && 
                (
                    this.InvoiceCategoryId == input.InvoiceCategoryId ||
                    (this.InvoiceCategoryId != null &&
                    this.InvoiceCategoryId.Equals(input.InvoiceCategoryId))
                ) && 
                (
                    this.PaymentTypeId == input.PaymentTypeId ||
                    (this.PaymentTypeId != null &&
                    this.PaymentTypeId.Equals(input.PaymentTypeId))
                ) && 
                (
                    this.RecurringExpenseId == input.RecurringExpenseId ||
                    (this.RecurringExpenseId != null &&
                    this.RecurringExpenseId.Equals(input.RecurringExpenseId))
                ) && 
                (
                    this.PrivateNotes == input.PrivateNotes ||
                    (this.PrivateNotes != null &&
                    this.PrivateNotes.Equals(input.PrivateNotes))
                ) && 
                (
                    this.PublicNotes == input.PublicNotes ||
                    (this.PublicNotes != null &&
                    this.PublicNotes.Equals(input.PublicNotes))
                ) && 
                (
                    this.TransactionReference == input.TransactionReference ||
                    (this.TransactionReference != null &&
                    this.TransactionReference.Equals(input.TransactionReference))
                ) && 
                (
                    this.TranscationId == input.TranscationId ||
                    (this.TranscationId != null &&
                    this.TranscationId.Equals(input.TranscationId))
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
                    this.TaxName1 == input.TaxName1 ||
                    (this.TaxName1 != null &&
                    this.TaxName1.Equals(input.TaxName1))
                ) && 
                (
                    this.TaxName2 == input.TaxName2 ||
                    (this.TaxName2 != null &&
                    this.TaxName2.Equals(input.TaxName2))
                ) && 
                (
                    this.TaxRate1 == input.TaxRate1 ||
                    (this.TaxRate1 != null &&
                    this.TaxRate1.Equals(input.TaxRate1))
                ) && 
                (
                    this.TaxRate2 == input.TaxRate2 ||
                    (this.TaxRate2 != null &&
                    this.TaxRate2.Equals(input.TaxRate2))
                ) && 
                (
                    this.TaxName3 == input.TaxName3 ||
                    (this.TaxName3 != null &&
                    this.TaxName3.Equals(input.TaxName3))
                ) && 
                (
                    this.TaxRate3 == input.TaxRate3 ||
                    (this.TaxRate3 != null &&
                    this.TaxRate3.Equals(input.TaxRate3))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ForeignAmount == input.ForeignAmount ||
                    (this.ForeignAmount != null &&
                    this.ForeignAmount.Equals(input.ForeignAmount))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.ShouldBeInvoiced == input.ShouldBeInvoiced ||
                    (this.ShouldBeInvoiced != null &&
                    this.ShouldBeInvoiced.Equals(input.ShouldBeInvoiced))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.InvoiceDocuments == input.InvoiceDocuments ||
                    (this.InvoiceDocuments != null &&
                    this.InvoiceDocuments.Equals(input.InvoiceDocuments))
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
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.BankId != null)
                    hashCode = hashCode * 59 + this.BankId.GetHashCode();
                if (this.InvoiceCurrencyId != null)
                    hashCode = hashCode * 59 + this.InvoiceCurrencyId.GetHashCode();
                if (this.ExpenseCurrencyId != null)
                    hashCode = hashCode * 59 + this.ExpenseCurrencyId.GetHashCode();
                if (this.InvoiceCategoryId != null)
                    hashCode = hashCode * 59 + this.InvoiceCategoryId.GetHashCode();
                if (this.PaymentTypeId != null)
                    hashCode = hashCode * 59 + this.PaymentTypeId.GetHashCode();
                if (this.RecurringExpenseId != null)
                    hashCode = hashCode * 59 + this.RecurringExpenseId.GetHashCode();
                if (this.PrivateNotes != null)
                    hashCode = hashCode * 59 + this.PrivateNotes.GetHashCode();
                if (this.PublicNotes != null)
                    hashCode = hashCode * 59 + this.PublicNotes.GetHashCode();
                if (this.TransactionReference != null)
                    hashCode = hashCode * 59 + this.TransactionReference.GetHashCode();
                if (this.TranscationId != null)
                    hashCode = hashCode * 59 + this.TranscationId.GetHashCode();
                if (this.CustomValue1 != null)
                    hashCode = hashCode * 59 + this.CustomValue1.GetHashCode();
                if (this.CustomValue2 != null)
                    hashCode = hashCode * 59 + this.CustomValue2.GetHashCode();
                if (this.CustomValue3 != null)
                    hashCode = hashCode * 59 + this.CustomValue3.GetHashCode();
                if (this.CustomValue4 != null)
                    hashCode = hashCode * 59 + this.CustomValue4.GetHashCode();
                if (this.TaxName1 != null)
                    hashCode = hashCode * 59 + this.TaxName1.GetHashCode();
                if (this.TaxName2 != null)
                    hashCode = hashCode * 59 + this.TaxName2.GetHashCode();
                if (this.TaxRate1 != null)
                    hashCode = hashCode * 59 + this.TaxRate1.GetHashCode();
                if (this.TaxRate2 != null)
                    hashCode = hashCode * 59 + this.TaxRate2.GetHashCode();
                if (this.TaxName3 != null)
                    hashCode = hashCode * 59 + this.TaxName3.GetHashCode();
                if (this.TaxRate3 != null)
                    hashCode = hashCode * 59 + this.TaxRate3.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ForeignAmount != null)
                    hashCode = hashCode * 59 + this.ForeignAmount.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.ShouldBeInvoiced != null)
                    hashCode = hashCode * 59 + this.ShouldBeInvoiced.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.InvoiceDocuments != null)
                    hashCode = hashCode * 59 + this.InvoiceDocuments.GetHashCode();
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