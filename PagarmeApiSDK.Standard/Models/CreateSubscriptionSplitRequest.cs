// <copyright file="CreateSubscriptionSplitRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionSplitRequest.
    /// </summary>
    public class CreateSubscriptionSplitRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionSplitRequest"/> class.
        /// </summary>
        public CreateSubscriptionSplitRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionSplitRequest"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="rules">rules.</param>
        public CreateSubscriptionSplitRequest(
            bool enabled,
            List<Models.CreateSplitRequest> rules)
        {
            this.Enabled = enabled;
            this.Rules = rules;
        }

        /// <summary>
        /// Defines if the split is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Split
        /// </summary>
        [JsonProperty("rules")]
        public List<Models.CreateSplitRequest> Rules { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSubscriptionSplitRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSubscriptionSplitRequest other &&
                (this.Enabled.Equals(other.Enabled)) &&
                (this.Rules == null && other.Rules == null ||
                 this.Rules?.Equals(other.Rules) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {this.Enabled}");
            toStringOutput.Add($"Rules = {(this.Rules == null ? "null" : $"[{string.Join(", ", this.Rules)} ]")}");
        }
    }
}