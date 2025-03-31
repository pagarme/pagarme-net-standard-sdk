// <copyright file="GetCheckoutDebitCardPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutDebitCardPaymentResponse.
    /// </summary>
    public class GetCheckoutDebitCardPaymentResponse
    {
        private string statementDescriptor;
        private Models.GetPaymentAuthenticationResponse authentication;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "statement_descriptor", false },
            { "authentication", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutDebitCardPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutDebitCardPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutDebitCardPaymentResponse"/> class.
        /// </summary>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="authentication">authentication.</param>
        public GetCheckoutDebitCardPaymentResponse(
            string statementDescriptor = null,
            Models.GetPaymentAuthenticationResponse authentication = null)
        {

            if (statementDescriptor != null)
            {
                this.StatementDescriptor = statementDescriptor;
            }

            if (authentication != null)
            {
                this.Authentication = authentication;
            }
        }

        /// <summary>
        /// Descrição na fatura
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor
        {
            get
            {
                return this.statementDescriptor;
            }

            set
            {
                this.shouldSerialize["statement_descriptor"] = true;
                this.statementDescriptor = value;
            }
        }

        /// <summary>
        /// Payment Authentication response object data
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
            return $"GetCheckoutDebitCardPaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatementDescriptor()
        {
            this.shouldSerialize["statement_descriptor"] = false;
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
            return this.shouldSerialize["statement_descriptor"];
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

            return obj is GetCheckoutDebitCardPaymentResponse other &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
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
            toStringOutput.Add($"Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
        }
    }
}