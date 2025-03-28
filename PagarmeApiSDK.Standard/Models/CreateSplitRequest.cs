// <copyright file="CreateSplitRequest.cs" company="APIMatic">
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
    /// CreateSplitRequest.
    /// </summary>
    public class CreateSplitRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSplitRequest"/> class.
        /// </summary>
        public CreateSplitRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSplitRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        /// <param name="recipientId">recipient_id.</param>
        /// <param name="options">options.</param>
        /// <param name="splitRuleId">split_rule_id.</param>
        public CreateSplitRequest(
            string type,
            int amount,
            string recipientId,
            Models.CreateSplitOptionsRequest options = null,
            string splitRuleId = null)
        {
            this.Type = type;
            this.Amount = amount;
            this.RecipientId = recipientId;
            this.Options = options;
            this.SplitRuleId = splitRuleId;
        }

        /// <summary>
        /// Split type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Recipient id
        /// </summary>
        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        /// <summary>
        /// The split options request
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSplitOptionsRequest Options { get; set; }

        /// <summary>
        /// Rule code used in cancellation.
        /// </summary>
        [JsonProperty("split_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SplitRuleId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSplitRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSplitRequest other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Amount.Equals(other.Amount)) &&
                (this.RecipientId == null && other.RecipientId == null ||
                 this.RecipientId?.Equals(other.RecipientId) == true) &&
                (this.Options == null && other.Options == null ||
                 this.Options?.Equals(other.Options) == true) &&
                (this.SplitRuleId == null && other.SplitRuleId == null ||
                 this.SplitRuleId?.Equals(other.SplitRuleId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"RecipientId = {this.RecipientId ?? "null"}");
            toStringOutput.Add($"Options = {(this.Options == null ? "null" : this.Options.ToString())}");
            toStringOutput.Add($"SplitRuleId = {this.SplitRuleId ?? "null"}");
        }
    }
}