// <copyright file="UpdateSubscriptionAffiliationIdRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionAffiliationIdRequest.
    /// </summary>
    public class UpdateSubscriptionAffiliationIdRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionAffiliationIdRequest"/> class.
        /// </summary>
        public UpdateSubscriptionAffiliationIdRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionAffiliationIdRequest"/> class.
        /// </summary>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        public UpdateSubscriptionAffiliationIdRequest(
            string gatewayAffiliationId)
        {
            this.GatewayAffiliationId = gatewayAffiliationId;
        }

        /// <summary>
        /// Gets or sets GatewayAffiliationId.
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionAffiliationIdRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionAffiliationIdRequest other &&
                (this.GatewayAffiliationId == null && other.GatewayAffiliationId == null ||
                 this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"GatewayAffiliationId = {this.GatewayAffiliationId ?? "null"}");
        }
    }
}