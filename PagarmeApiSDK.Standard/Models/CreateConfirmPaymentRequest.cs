// <copyright file="CreateConfirmPaymentRequest.cs" company="APIMatic">
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
    /// CreateConfirmPaymentRequest.
    /// </summary>
    public class CreateConfirmPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfirmPaymentRequest"/> class.
        /// </summary>
        public CreateConfirmPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfirmPaymentRequest"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="code">Code.</param>
        /// <param name="amount">Amount.</param>
        public CreateConfirmPaymentRequest(
            string description,
            string code,
            int? amount = null)
        {
            this.Description = description;
            this.Amount = amount;
            this.Code = code;
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("Amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Code reference
        /// </summary>
        [JsonProperty("Code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateConfirmPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateConfirmPaymentRequest other &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
        }
    }
}