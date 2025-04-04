// <copyright file="CreatePaymentRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Utilities;

namespace PagarmeApiSDK.Standard.Models
{
    /// <summary>
    /// CreatePaymentRequest.
    /// </summary>
    public class CreatePaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentRequest"/> class.
        /// </summary>
        public CreatePaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentRequest"/> class.
        /// </summary>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="creditCard">credit_card.</param>
        /// <param name="debitCard">debit_card.</param>
        /// <param name="boleto">boleto.</param>
        /// <param name="currency">currency.</param>
        /// <param name="voucher">voucher.</param>
        /// <param name="split">split.</param>
        /// <param name="bankTransfer">bank_transfer.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="checkout">checkout.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="customer">customer.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="cash">cash.</param>
        /// <param name="privateLabel">private_label.</param>
        /// <param name="pix">pix.</param>
        public CreatePaymentRequest(
            string paymentMethod,
            Models.CreateCreditCardPaymentRequest creditCard = null,
            Models.CreateDebitCardPaymentRequest debitCard = null,
            Models.CreateBoletoPaymentRequest boleto = null,
            string currency = null,
            Models.CreateVoucherPaymentRequest voucher = null,
            List<Models.CreateSplitRequest> split = null,
            Models.CreateBankTransferPaymentRequest bankTransfer = null,
            string gatewayAffiliationId = null,
            int? amount = null,
            Models.CreateCheckoutPaymentRequest checkout = null,
            string customerId = null,
            Models.CreateCustomerRequest customer = null,
            Dictionary<string, string> metadata = null,
            Models.CreateCashPaymentRequest cash = null,
            Models.CreatePrivateLabelPaymentRequest privateLabel = null,
            Models.CreatePixPaymentRequest pix = null)
        {
            this.PaymentMethod = paymentMethod;
            this.CreditCard = creditCard;
            this.DebitCard = debitCard;
            this.Boleto = boleto;
            this.Currency = currency;
            this.Voucher = voucher;
            this.Split = split;
            this.BankTransfer = bankTransfer;
            this.GatewayAffiliationId = gatewayAffiliationId;
            this.Amount = amount;
            this.Checkout = checkout;
            this.CustomerId = customerId;
            this.Customer = customer;
            this.Metadata = metadata;
            this.Cash = cash;
            this.PrivateLabel = privateLabel;
            this.Pix = pix;
        }

        /// <summary>
        /// Payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Settings for credit card payment
        /// </summary>
        [JsonProperty("credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCreditCardPaymentRequest CreditCard { get; set; }

        /// <summary>
        /// Settings for debit card payment
        /// </summary>
        [JsonProperty("debit_card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateDebitCardPaymentRequest DebitCard { get; set; }

        /// <summary>
        /// Settings for boleto payment
        /// </summary>
        [JsonProperty("boleto", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateBoletoPaymentRequest Boleto { get; set; }

        /// <summary>
        /// Currency. Must be informed using 3 characters
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Settings for voucher payment
        /// </summary>
        [JsonProperty("voucher", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateVoucherPaymentRequest Voucher { get; set; }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("split", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateSplitRequest> Split { get; set; }

        /// <summary>
        /// Settings for bank transfer payment
        /// </summary>
        [JsonProperty("bank_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateBankTransferPaymentRequest BankTransfer { get; set; }

        /// <summary>
        /// Gateway affiliation code
        /// </summary>
        [JsonProperty("gateway_affiliation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// The amount of the payment, in cents
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Settings for checkout payment
        /// </summary>
        [JsonProperty("checkout", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCheckoutPaymentRequest Checkout { get; set; }

        /// <summary>
        /// Customer Id
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCustomerRequest Customer { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Settings for cash payment
        /// </summary>
        [JsonProperty("cash", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCashPaymentRequest Cash { get; set; }

        /// <summary>
        /// Settings for private label payment
        /// </summary>
        [JsonProperty("private_label", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePrivateLabelPaymentRequest PrivateLabel { get; set; }

        /// <summary>
        /// Settings for pix payment
        /// </summary>
        [JsonProperty("pix", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePixPaymentRequest Pix { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePaymentRequest other &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.CreditCard == null && other.CreditCard == null ||
                 this.CreditCard?.Equals(other.CreditCard) == true) &&
                (this.DebitCard == null && other.DebitCard == null ||
                 this.DebitCard?.Equals(other.DebitCard) == true) &&
                (this.Boleto == null && other.Boleto == null ||
                 this.Boleto?.Equals(other.Boleto) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Voucher == null && other.Voucher == null ||
                 this.Voucher?.Equals(other.Voucher) == true) &&
                (this.Split == null && other.Split == null ||
                 this.Split?.Equals(other.Split) == true) &&
                (this.BankTransfer == null && other.BankTransfer == null ||
                 this.BankTransfer?.Equals(other.BankTransfer) == true) &&
                (this.GatewayAffiliationId == null && other.GatewayAffiliationId == null ||
                 this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Checkout == null && other.Checkout == null ||
                 this.Checkout?.Equals(other.Checkout) == true) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Cash == null && other.Cash == null ||
                 this.Cash?.Equals(other.Cash) == true) &&
                (this.PrivateLabel == null && other.PrivateLabel == null ||
                 this.PrivateLabel?.Equals(other.PrivateLabel) == true) &&
                (this.Pix == null && other.Pix == null ||
                 this.Pix?.Equals(other.Pix) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod ?? "null"}");
            toStringOutput.Add($"CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"DebitCard = {(this.DebitCard == null ? "null" : this.DebitCard.ToString())}");
            toStringOutput.Add($"Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Voucher = {(this.Voucher == null ? "null" : this.Voucher.ToString())}");
            toStringOutput.Add($"Split = {(this.Split == null ? "null" : $"[{string.Join(", ", this.Split)} ]")}");
            toStringOutput.Add($"BankTransfer = {(this.BankTransfer == null ? "null" : this.BankTransfer.ToString())}");
            toStringOutput.Add($"GatewayAffiliationId = {this.GatewayAffiliationId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Checkout = {(this.Checkout == null ? "null" : this.Checkout.ToString())}");
            toStringOutput.Add($"CustomerId = {this.CustomerId ?? "null"}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Cash = {(this.Cash == null ? "null" : this.Cash.ToString())}");
            toStringOutput.Add($"PrivateLabel = {(this.PrivateLabel == null ? "null" : this.PrivateLabel.ToString())}");
            toStringOutput.Add($"Pix = {(this.Pix == null ? "null" : this.Pix.ToString())}");
        }
    }
}