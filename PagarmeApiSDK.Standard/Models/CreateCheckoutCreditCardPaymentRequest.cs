// <copyright file="CreateCheckoutCreditCardPaymentRequest.cs" company="APIMatic">
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
    /// CreateCheckoutCreditCardPaymentRequest.
    /// </summary>
    public class CreateCheckoutCreditCardPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutCreditCardPaymentRequest"/> class.
        /// </summary>
        public CreateCheckoutCreditCardPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutCreditCardPaymentRequest"/> class.
        /// </summary>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="installments">installments.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="capture">capture.</param>
        public CreateCheckoutCreditCardPaymentRequest(
            string statementDescriptor = null,
            List<Models.CreateCheckoutCardInstallmentOptionRequest> installments = null,
            Models.CreatePaymentAuthenticationRequest authentication = null,
            bool? capture = null)
        {
            this.StatementDescriptor = statementDescriptor;
            this.Installments = installments;
            this.Authentication = authentication;
            this.Capture = capture;
        }

        /// <summary>
        /// Card invoice text descriptor
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Payment installment options
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateCheckoutCardInstallmentOptionRequest> Installments { get; set; }

        /// <summary>
        /// Creates payment authentication
        /// </summary>
        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePaymentAuthenticationRequest Authentication { get; set; }

        /// <summary>
        /// Authorize and capture?
        /// </summary>
        [JsonProperty("capture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Capture { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCheckoutCreditCardPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCheckoutCreditCardPaymentRequest other &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.Authentication == null && other.Authentication == null ||
                 this.Authentication?.Equals(other.Authentication) == true) &&
                (this.Capture == null && other.Capture == null ||
                 this.Capture?.Equals(other.Capture) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : $"[{string.Join(", ", this.Installments)} ]")}");
            toStringOutput.Add($"Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
            toStringOutput.Add($"Capture = {(this.Capture == null ? "null" : this.Capture.ToString())}");
        }
    }
}