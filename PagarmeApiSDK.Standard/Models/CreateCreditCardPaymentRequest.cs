// <copyright file="CreateCreditCardPaymentRequest.cs" company="APIMatic">
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
    /// CreateCreditCardPaymentRequest.
    /// </summary>
    public class CreateCreditCardPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardPaymentRequest"/> class.
        /// </summary>
        public CreateCreditCardPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditCardPaymentRequest"/> class.
        /// </summary>
        /// <param name="installments">installments.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="card">card.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="cardToken">card_token.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="capture">capture.</param>
        /// <param name="extendedLimitEnabled">extended_limit_enabled.</param>
        /// <param name="extendedLimitCode">extended_limit_code.</param>
        /// <param name="merchantCategoryCode">merchant_category_code.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="contactless">contactless.</param>
        /// <param name="autoRecovery">auto_recovery.</param>
        /// <param name="operationType">operation_type.</param>
        /// <param name="recurrencyCycle">recurrency_cycle.</param>
        /// <param name="payload">payload.</param>
        /// <param name="initiatedType">initiated_type.</param>
        /// <param name="recurrenceModel">recurrence_model.</param>
        /// <param name="paymentOrigin">payment_origin.</param>
        /// <param name="indirectAcceptor">indirect_acceptor.</param>
        public CreateCreditCardPaymentRequest(
            int? installments = 1,
            string statementDescriptor = null,
            Models.CreateCardRequest card = null,
            string cardId = null,
            string cardToken = null,
            bool? recurrence = null,
            bool? capture = true,
            bool? extendedLimitEnabled = null,
            string extendedLimitCode = null,
            long? merchantCategoryCode = null,
            Models.CreatePaymentAuthenticationRequest authentication = null,
            Models.CreateCardPaymentContactlessRequest contactless = null,
            bool? autoRecovery = null,
            string operationType = null,
            string recurrencyCycle = null,
            Models.CreateCardPayloadRequest payload = null,
            string initiatedType = null,
            string recurrenceModel = null,
            Models.CreatePaymentOriginRequest paymentOrigin = null,
            string indirectAcceptor = null)
        {
            this.Installments = installments;
            this.StatementDescriptor = statementDescriptor;
            this.Card = card;
            this.CardId = cardId;
            this.CardToken = cardToken;
            this.Recurrence = recurrence;
            this.Capture = capture;
            this.ExtendedLimitEnabled = extendedLimitEnabled;
            this.ExtendedLimitCode = extendedLimitCode;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.Authentication = authentication;
            this.Contactless = contactless;
            this.AutoRecovery = autoRecovery;
            this.OperationType = operationType;
            this.RecurrencyCycle = recurrencyCycle;
            this.Payload = payload;
            this.InitiatedType = initiatedType;
            this.RecurrenceModel = recurrenceModel;
            this.PaymentOrigin = paymentOrigin;
            this.IndirectAcceptor = indirectAcceptor;
        }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public int? Installments { get; set; }

        /// <summary>
        /// The text that will be shown on the credit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Credit card data
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// The credit card id
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// Gets or sets CardToken.
        /// </summary>
        [JsonProperty("card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CardToken { get; set; }

        /// <summary>
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurrence { get; set; }

        /// <summary>
        /// Indicates if the operation should be only authorization or auth and capture.
        /// </summary>
        [JsonProperty("capture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Capture { get; set; }

        /// <summary>
        /// Indicates whether the extended label (private label) is enabled
        /// </summary>
        [JsonProperty("extended_limit_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExtendedLimitEnabled { get; set; }

        /// <summary>
        /// Extended Limit Code
        /// </summary>
        [JsonProperty("extended_limit_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendedLimitCode { get; set; }

        /// <summary>
        /// Customer business segment code
        /// </summary>
        [JsonProperty("merchant_category_code", NullValueHandling = NullValueHandling.Ignore)]
        public long? MerchantCategoryCode { get; set; }

        /// <summary>
        /// The payment authentication request
        /// </summary>
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePaymentAuthenticationRequest Authentication { get; set; }

        /// <summary>
        /// The Credit card payment contactless request
        /// </summary>
        [JsonProperty("contactless", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardPaymentContactlessRequest Contactless { get; set; }

        /// <summary>
        /// Indicates whether a particular payment will enter the offline retry flow
        /// </summary>
        [JsonProperty("auto_recovery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRecovery { get; set; }

        /// <summary>
        /// AuthOnly, AuthAndCapture, PreAuth
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// Defines whether the card has been used one or more times.
        /// </summary>
        [JsonProperty("recurrency_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurrencyCycle { get; set; }

        /// <summary>
        /// Gets or sets Payload.
        /// </summary>
        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateCardPayloadRequest Payload { get; set; }

        /// <summary>
        /// Gets or sets InitiatedType.
        /// </summary>
        [JsonProperty("initiated_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InitiatedType { get; set; }

        /// <summary>
        /// Gets or sets RecurrenceModel.
        /// </summary>
        [JsonProperty("recurrence_model", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurrenceModel { get; set; }

        /// <summary>
        /// Gets or sets PaymentOrigin.
        /// </summary>
        [JsonProperty("payment_origin", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePaymentOriginRequest PaymentOrigin { get; set; }

        /// <summary>
        /// Business model identifier
        /// </summary>
        [JsonProperty("indirect_acceptor", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectAcceptor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCreditCardPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCreditCardPaymentRequest other &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.CardToken == null && other.CardToken == null ||
                 this.CardToken?.Equals(other.CardToken) == true) &&
                (this.Recurrence == null && other.Recurrence == null ||
                 this.Recurrence?.Equals(other.Recurrence) == true) &&
                (this.Capture == null && other.Capture == null ||
                 this.Capture?.Equals(other.Capture) == true) &&
                (this.ExtendedLimitEnabled == null && other.ExtendedLimitEnabled == null ||
                 this.ExtendedLimitEnabled?.Equals(other.ExtendedLimitEnabled) == true) &&
                (this.ExtendedLimitCode == null && other.ExtendedLimitCode == null ||
                 this.ExtendedLimitCode?.Equals(other.ExtendedLimitCode) == true) &&
                (this.MerchantCategoryCode == null && other.MerchantCategoryCode == null ||
                 this.MerchantCategoryCode?.Equals(other.MerchantCategoryCode) == true) &&
                (this.Authentication == null && other.Authentication == null ||
                 this.Authentication?.Equals(other.Authentication) == true) &&
                (this.Contactless == null && other.Contactless == null ||
                 this.Contactless?.Equals(other.Contactless) == true) &&
                (this.AutoRecovery == null && other.AutoRecovery == null ||
                 this.AutoRecovery?.Equals(other.AutoRecovery) == true) &&
                (this.OperationType == null && other.OperationType == null ||
                 this.OperationType?.Equals(other.OperationType) == true) &&
                (this.RecurrencyCycle == null && other.RecurrencyCycle == null ||
                 this.RecurrencyCycle?.Equals(other.RecurrencyCycle) == true) &&
                (this.Payload == null && other.Payload == null ||
                 this.Payload?.Equals(other.Payload) == true) &&
                (this.InitiatedType == null && other.InitiatedType == null ||
                 this.InitiatedType?.Equals(other.InitiatedType) == true) &&
                (this.RecurrenceModel == null && other.RecurrenceModel == null ||
                 this.RecurrenceModel?.Equals(other.RecurrenceModel) == true) &&
                (this.PaymentOrigin == null && other.PaymentOrigin == null ||
                 this.PaymentOrigin?.Equals(other.PaymentOrigin) == true) &&
                (this.IndirectAcceptor == null && other.IndirectAcceptor == null ||
                 this.IndirectAcceptor?.Equals(other.IndirectAcceptor) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"CardId = {this.CardId ?? "null"}");
            toStringOutput.Add($"CardToken = {this.CardToken ?? "null"}");
            toStringOutput.Add($"Recurrence = {(this.Recurrence == null ? "null" : this.Recurrence.ToString())}");
            toStringOutput.Add($"Capture = {(this.Capture == null ? "null" : this.Capture.ToString())}");
            toStringOutput.Add($"ExtendedLimitEnabled = {(this.ExtendedLimitEnabled == null ? "null" : this.ExtendedLimitEnabled.ToString())}");
            toStringOutput.Add($"ExtendedLimitCode = {this.ExtendedLimitCode ?? "null"}");
            toStringOutput.Add($"MerchantCategoryCode = {(this.MerchantCategoryCode == null ? "null" : this.MerchantCategoryCode.ToString())}");
            toStringOutput.Add($"Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
            toStringOutput.Add($"Contactless = {(this.Contactless == null ? "null" : this.Contactless.ToString())}");
            toStringOutput.Add($"AutoRecovery = {(this.AutoRecovery == null ? "null" : this.AutoRecovery.ToString())}");
            toStringOutput.Add($"OperationType = {this.OperationType ?? "null"}");
            toStringOutput.Add($"RecurrencyCycle = {this.RecurrencyCycle ?? "null"}");
            toStringOutput.Add($"Payload = {(this.Payload == null ? "null" : this.Payload.ToString())}");
            toStringOutput.Add($"InitiatedType = {this.InitiatedType ?? "null"}");
            toStringOutput.Add($"RecurrenceModel = {this.RecurrenceModel ?? "null"}");
            toStringOutput.Add($"PaymentOrigin = {(this.PaymentOrigin == null ? "null" : this.PaymentOrigin.ToString())}");
            toStringOutput.Add($"IndirectAcceptor = {this.IndirectAcceptor ?? "null"}");
        }
    }
}