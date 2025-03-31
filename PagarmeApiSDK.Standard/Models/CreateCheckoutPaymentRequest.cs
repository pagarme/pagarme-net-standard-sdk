// <copyright file="CreateCheckoutPaymentRequest.cs" company="APIMatic">
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
    /// CreateCheckoutPaymentRequest.
    /// </summary>
    public class CreateCheckoutPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutPaymentRequest"/> class.
        /// </summary>
        public CreateCheckoutPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutPaymentRequest"/> class.
        /// </summary>
        /// <param name="acceptedPaymentMethods">accepted_payment_methods.</param>
        /// <param name="acceptedMultiPaymentMethods">accepted_multi_payment_methods.</param>
        /// <param name="successUrl">success_url.</param>
        /// <param name="skipCheckoutSuccessPage">skip_checkout_success_page.</param>
        /// <param name="billingAddressEditable">billing_address_editable.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="acceptedBrands">accepted_brands.</param>
        /// <param name="defaultPaymentMethod">default_payment_method.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="creditCard">credit_card.</param>
        /// <param name="debitCard">debit_card.</param>
        /// <param name="boleto">boleto.</param>
        /// <param name="customerEditable">customer_editable.</param>
        /// <param name="expiresIn">expires_in.</param>
        /// <param name="bankTransfer">bank_transfer.</param>
        /// <param name="pix">pix.</param>
        public CreateCheckoutPaymentRequest(
            List<string> acceptedPaymentMethods,
            object acceptedMultiPaymentMethods,
            string successUrl,
            bool skipCheckoutSuccessPage,
            bool billingAddressEditable,
            Models.CreateAddressRequest billingAddress,
            List<string> acceptedBrands,
            string defaultPaymentMethod = null,
            string gatewayAffiliationId = null,
            Models.CreateCheckoutCreditCardPaymentRequest creditCard = null,
            Models.CreateCheckoutDebitCardPaymentRequest debitCard = null,
            Models.CreateCheckoutBoletoPaymentRequest boleto = null,
            bool? customerEditable = null,
            int? expiresIn = null,
            Models.CreateCheckoutBankTransferRequest bankTransfer = null,
            Models.CreateCheckoutPixPaymentRequest pix = null)
        {
            this.AcceptedPaymentMethods = acceptedPaymentMethods;
            this.AcceptedMultiPaymentMethods = acceptedMultiPaymentMethods;
            this.SuccessUrl = successUrl;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.GatewayAffiliationId = gatewayAffiliationId;
            this.CreditCard = creditCard;
            this.DebitCard = debitCard;
            this.Boleto = boleto;
            this.CustomerEditable = customerEditable;
            this.ExpiresIn = expiresIn;
            this.SkipCheckoutSuccessPage = skipCheckoutSuccessPage;
            this.BillingAddressEditable = billingAddressEditable;
            this.BillingAddress = billingAddress;
            this.BankTransfer = bankTransfer;
            this.AcceptedBrands = acceptedBrands;
            this.Pix = pix;
        }

        /// <summary>
        /// Accepted Payment Methods
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods { get; set; }

        /// <summary>
        /// Accepted Multi Payment Methods
        /// </summary>
        [JsonProperty("accepted_multi_payment_methods")]
        public object AcceptedMultiPaymentMethods { get; set; }

        /// <summary>
        /// Success url
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Default payment method
        /// </summary>
        [JsonProperty("default_payment_method", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Gateway Affiliation Id
        /// </summary>
        [JsonProperty("gateway_affiliation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// Credit Card payment request
        /// </summary>
        [JsonProperty("credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCheckoutCreditCardPaymentRequest CreditCard { get; set; }

        /// <summary>
        /// Debit Card payment request
        /// </summary>
        [JsonProperty("debit_card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCheckoutDebitCardPaymentRequest DebitCard { get; set; }

        /// <summary>
        /// Boleto payment request
        /// </summary>
        [JsonProperty("boleto", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCheckoutBoletoPaymentRequest Boleto { get; set; }

        /// <summary>
        /// Customer is editable?
        /// </summary>
        [JsonProperty("customer_editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomerEditable { get; set; }

        /// <summary>
        /// Time in minutes for expiration
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Skip postpay success screen?
        /// </summary>
        [JsonProperty("skip_checkout_success_page")]
        public bool SkipCheckoutSuccessPage { get; set; }

        /// <summary>
        /// Billing Address is editable?
        /// </summary>
        [JsonProperty("billing_address_editable")]
        public bool BillingAddressEditable { get; set; }

        /// <summary>
        /// Billing Address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress { get; set; }

        /// <summary>
        /// Bank Transfer payment request
        /// </summary>
        [JsonProperty("bank_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCheckoutBankTransferRequest BankTransfer { get; set; }

        /// <summary>
        /// Accepted Brands
        /// </summary>
        [JsonProperty("accepted_brands")]
        public List<string> AcceptedBrands { get; set; }

        /// <summary>
        /// Pix payment request
        /// </summary>
        [JsonProperty("pix", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCheckoutPixPaymentRequest Pix { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCheckoutPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCheckoutPaymentRequest other &&
                (this.AcceptedPaymentMethods == null && other.AcceptedPaymentMethods == null ||
                 this.AcceptedPaymentMethods?.Equals(other.AcceptedPaymentMethods) == true) &&
                (this.AcceptedMultiPaymentMethods == null && other.AcceptedMultiPaymentMethods == null ||
                 this.AcceptedMultiPaymentMethods?.Equals(other.AcceptedMultiPaymentMethods) == true) &&
                (this.SuccessUrl == null && other.SuccessUrl == null ||
                 this.SuccessUrl?.Equals(other.SuccessUrl) == true) &&
                (this.DefaultPaymentMethod == null && other.DefaultPaymentMethod == null ||
                 this.DefaultPaymentMethod?.Equals(other.DefaultPaymentMethod) == true) &&
                (this.GatewayAffiliationId == null && other.GatewayAffiliationId == null ||
                 this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true) &&
                (this.CreditCard == null && other.CreditCard == null ||
                 this.CreditCard?.Equals(other.CreditCard) == true) &&
                (this.DebitCard == null && other.DebitCard == null ||
                 this.DebitCard?.Equals(other.DebitCard) == true) &&
                (this.Boleto == null && other.Boleto == null ||
                 this.Boleto?.Equals(other.Boleto) == true) &&
                (this.CustomerEditable == null && other.CustomerEditable == null ||
                 this.CustomerEditable?.Equals(other.CustomerEditable) == true) &&
                (this.ExpiresIn == null && other.ExpiresIn == null ||
                 this.ExpiresIn?.Equals(other.ExpiresIn) == true) &&
                (this.SkipCheckoutSuccessPage.Equals(other.SkipCheckoutSuccessPage)) &&
                (this.BillingAddressEditable.Equals(other.BillingAddressEditable)) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.BankTransfer == null && other.BankTransfer == null ||
                 this.BankTransfer?.Equals(other.BankTransfer) == true) &&
                (this.AcceptedBrands == null && other.AcceptedBrands == null ||
                 this.AcceptedBrands?.Equals(other.AcceptedBrands) == true) &&
                (this.Pix == null && other.Pix == null ||
                 this.Pix?.Equals(other.Pix) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AcceptedPaymentMethods = {(this.AcceptedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AcceptedPaymentMethods)} ]")}");
            toStringOutput.Add($"AcceptedMultiPaymentMethods = {(this.AcceptedMultiPaymentMethods == null ? "null" : this.AcceptedMultiPaymentMethods.ToString())}");
            toStringOutput.Add($"SuccessUrl = {this.SuccessUrl ?? "null"}");
            toStringOutput.Add($"DefaultPaymentMethod = {this.DefaultPaymentMethod ?? "null"}");
            toStringOutput.Add($"GatewayAffiliationId = {this.GatewayAffiliationId ?? "null"}");
            toStringOutput.Add($"CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"DebitCard = {(this.DebitCard == null ? "null" : this.DebitCard.ToString())}");
            toStringOutput.Add($"Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"CustomerEditable = {(this.CustomerEditable == null ? "null" : this.CustomerEditable.ToString())}");
            toStringOutput.Add($"ExpiresIn = {(this.ExpiresIn == null ? "null" : this.ExpiresIn.ToString())}");
            toStringOutput.Add($"SkipCheckoutSuccessPage = {this.SkipCheckoutSuccessPage}");
            toStringOutput.Add($"BillingAddressEditable = {this.BillingAddressEditable}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"BankTransfer = {(this.BankTransfer == null ? "null" : this.BankTransfer.ToString())}");
            toStringOutput.Add($"AcceptedBrands = {(this.AcceptedBrands == null ? "null" : $"[{string.Join(", ", this.AcceptedBrands)} ]")}");
            toStringOutput.Add($"Pix = {(this.Pix == null ? "null" : this.Pix.ToString())}");
        }
    }
}