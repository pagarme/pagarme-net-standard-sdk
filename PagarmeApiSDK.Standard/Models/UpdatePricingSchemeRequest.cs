// <copyright file="UpdatePricingSchemeRequest.cs" company="APIMatic">
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
    /// UpdatePricingSchemeRequest.
    /// </summary>
    public class UpdatePricingSchemeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePricingSchemeRequest"/> class.
        /// </summary>
        public UpdatePricingSchemeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePricingSchemeRequest"/> class.
        /// </summary>
        /// <param name="schemeType">scheme_type.</param>
        /// <param name="priceBrackets">price_brackets.</param>
        /// <param name="price">price.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="percentage">percentage.</param>
        public UpdatePricingSchemeRequest(
            string schemeType,
            List<Models.UpdatePriceBracketRequest> priceBrackets,
            int? price = null,
            int? minimumPrice = null,
            double? percentage = null)
        {
            this.SchemeType = schemeType;
            this.PriceBrackets = priceBrackets;
            this.Price = price;
            this.MinimumPrice = minimumPrice;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Scheme type
        /// </summary>
        [JsonProperty("scheme_type")]
        public string SchemeType { get; set; }

        /// <summary>
        /// Price brackets
        /// </summary>
        [JsonProperty("price_brackets")]
        public List<Models.UpdatePriceBracketRequest> PriceBrackets { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public int? Price { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <summary>
        /// percentual value used in pricing_scheme Percent
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdatePricingSchemeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdatePricingSchemeRequest other &&
                (this.SchemeType == null && other.SchemeType == null ||
                 this.SchemeType?.Equals(other.SchemeType) == true) &&
                (this.PriceBrackets == null && other.PriceBrackets == null ||
                 this.PriceBrackets?.Equals(other.PriceBrackets) == true) &&
                (this.Price == null && other.Price == null ||
                 this.Price?.Equals(other.Price) == true) &&
                (this.MinimumPrice == null && other.MinimumPrice == null ||
                 this.MinimumPrice?.Equals(other.MinimumPrice) == true) &&
                (this.Percentage == null && other.Percentage == null ||
                 this.Percentage?.Equals(other.Percentage) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SchemeType = {this.SchemeType ?? "null"}");
            toStringOutput.Add($"PriceBrackets = {(this.PriceBrackets == null ? "null" : $"[{string.Join(", ", this.PriceBrackets)} ]")}");
            toStringOutput.Add($"Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"Percentage = {(this.Percentage == null ? "null" : this.Percentage.ToString())}");
        }
    }
}