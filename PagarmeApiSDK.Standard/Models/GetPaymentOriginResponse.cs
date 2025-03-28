// <copyright file="GetPaymentOriginResponse.cs" company="APIMatic">
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
    /// GetPaymentOriginResponse.
    /// </summary>
    public class GetPaymentOriginResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPaymentOriginResponse"/> class.
        /// </summary>
        public GetPaymentOriginResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPaymentOriginResponse"/> class.
        /// </summary>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="brandId">brand_id.</param>
        public GetPaymentOriginResponse(
            string chargeId = null,
            string brandId = null)
        {
            this.ChargeId = chargeId;
            this.BrandId = brandId;
        }

        /// <summary>
        /// Gets or sets ChargeId.
        /// </summary>
        [JsonProperty("charge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeId { get; set; }

        /// <summary>
        /// Gets or sets BrandId.
        /// </summary>
        [JsonProperty("brand_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPaymentOriginResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPaymentOriginResponse other &&
                (this.ChargeId == null && other.ChargeId == null ||
                 this.ChargeId?.Equals(other.ChargeId) == true) &&
                (this.BrandId == null && other.BrandId == null ||
                 this.BrandId?.Equals(other.BrandId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ChargeId = {this.ChargeId ?? "null"}");
            toStringOutput.Add($"BrandId = {this.BrandId ?? "null"}");
        }
    }
}