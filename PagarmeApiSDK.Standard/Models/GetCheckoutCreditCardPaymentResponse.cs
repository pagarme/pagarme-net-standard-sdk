// <copyright file="GetCheckoutCreditCardPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutCreditCardPaymentResponse.
    /// </summary>
    public class GetCheckoutCreditCardPaymentResponse
    {
        private string statementDescriptor;
        private List<Models.GetCheckoutCardInstallmentOptionsResponse> installments;
        private Models.GetPaymentAuthenticationResponse authentication;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "statementDescriptor", false },
            { "installments", false },
            { "authentication", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCreditCardPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutCreditCardPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCreditCardPaymentResponse"/> class.
        /// </summary>
        /// <param name="statementDescriptor">statementDescriptor.</param>
        /// <param name="installments">installments.</param>
        /// <param name="authentication">authentication.</param>
        public GetCheckoutCreditCardPaymentResponse(
            string statementDescriptor = null,
            List<Models.GetCheckoutCardInstallmentOptionsResponse> installments = null,
            Models.GetPaymentAuthenticationResponse authentication = null)
        {

            if (statementDescriptor != null)
            {
                this.StatementDescriptor = statementDescriptor;
            }

            if (installments != null)
            {
                this.Installments = installments;
            }

            if (authentication != null)
            {
                this.Authentication = authentication;
            }
        }

        /// <summary>
        /// Descrição na fatura
        /// </summary>
        [JsonProperty("statementDescriptor")]
        public string StatementDescriptor
        {
            get
            {
                return this.statementDescriptor;
            }

            set
            {
                this.shouldSerialize["statementDescriptor"] = true;
                this.statementDescriptor = value;
            }
        }

        /// <summary>
        /// Parcelas
        /// </summary>
        [JsonProperty("installments")]
        public List<Models.GetCheckoutCardInstallmentOptionsResponse> Installments
        {
            get
            {
                return this.installments;
            }

            set
            {
                this.shouldSerialize["installments"] = true;
                this.installments = value;
            }
        }

        /// <summary>
        /// Payment Authentication response
        /// </summary>
        [JsonProperty("authentication")]
        public Models.GetPaymentAuthenticationResponse Authentication
        {
            get
            {
                return this.authentication;
            }

            set
            {
                this.shouldSerialize["authentication"] = true;
                this.authentication = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCheckoutCreditCardPaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatementDescriptor()
        {
            this.shouldSerialize["statementDescriptor"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInstallments()
        {
            this.shouldSerialize["installments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAuthentication()
        {
            this.shouldSerialize["authentication"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatementDescriptor()
        {
            return this.shouldSerialize["statementDescriptor"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstallments()
        {
            return this.shouldSerialize["installments"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAuthentication()
        {
            return this.shouldSerialize["authentication"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCheckoutCreditCardPaymentResponse other &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.Authentication == null && other.Authentication == null ||
                 this.Authentication?.Equals(other.Authentication) == true);
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
        }
    }
}