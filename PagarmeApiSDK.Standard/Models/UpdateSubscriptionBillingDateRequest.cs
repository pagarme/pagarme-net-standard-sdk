// <copyright file="UpdateSubscriptionBillingDateRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionBillingDateRequest.
    /// </summary>
    public class UpdateSubscriptionBillingDateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionBillingDateRequest"/> class.
        /// </summary>
        public UpdateSubscriptionBillingDateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionBillingDateRequest"/> class.
        /// </summary>
        /// <param name="nextBillingAt">next_billing_at.</param>
        public UpdateSubscriptionBillingDateRequest(
            DateTime nextBillingAt)
        {
            this.NextBillingAt = nextBillingAt;
        }

        /// <summary>
        /// The date when the next subscription billing must occur
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_billing_at")]
        public DateTime NextBillingAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionBillingDateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionBillingDateRequest other &&
                (this.NextBillingAt.Equals(other.NextBillingAt));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NextBillingAt = {this.NextBillingAt}");
        }
    }
}