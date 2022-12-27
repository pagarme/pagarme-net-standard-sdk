// <copyright file="GetSubscriptionSplitResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetSubscriptionSplitResponse.
    /// </summary>
    public class GetSubscriptionSplitResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionSplitResponse"/> class.
        /// </summary>
        public GetSubscriptionSplitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionSplitResponse"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="rules">rules.</param>
        public GetSubscriptionSplitResponse(
            bool? enabled = null,
            List<Models.GetSplitResponse> rules = null)
        {
            this.Enabled = enabled;
            this.Rules = rules;
        }

        /// <summary>
        /// Defines if the split is enabled
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Include)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Split
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetSplitResponse> Rules { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSubscriptionSplitResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetSubscriptionSplitResponse other &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true)) &&
                ((this.Rules == null && other.Rules == null) || (this.Rules?.Equals(other.Rules) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"this.Rules = {(this.Rules == null ? "null" : $"[{string.Join(", ", this.Rules)} ]")}");
        }
    }
}