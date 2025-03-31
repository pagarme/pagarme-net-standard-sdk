// <copyright file="GetPricingSchemeResponse.cs" company="APIMatic">
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
    /// GetPricingSchemeResponse.
    /// </summary>
    public class GetPricingSchemeResponse
    {
        private int? price;
        private string schemeType;
        private List<Models.GetPriceBracketResponse> priceBrackets;
        private int? minimumPrice;
        private double? percentage;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "price", false },
            { "scheme_type", false },
            { "price_brackets", false },
            { "minimum_price", false },
            { "percentage", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingSchemeResponse"/> class.
        /// </summary>
        public GetPricingSchemeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingSchemeResponse"/> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="schemeType">scheme_type.</param>
        /// <param name="priceBrackets">price_brackets.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="percentage">percentage.</param>
        public GetPricingSchemeResponse(
            int? price = null,
            string schemeType = null,
            List<Models.GetPriceBracketResponse> priceBrackets = null,
            int? minimumPrice = null,
            double? percentage = null)
        {

            if (price != null)
            {
                this.Price = price;
            }

            if (schemeType != null)
            {
                this.SchemeType = schemeType;
            }

            if (priceBrackets != null)
            {
                this.PriceBrackets = priceBrackets;
            }

            if (minimumPrice != null)
            {
                this.MinimumPrice = minimumPrice;
            }

            if (percentage != null)
            {
                this.Percentage = percentage;
            }
        }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price")]
        public int? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.shouldSerialize["price"] = true;
                this.price = value;
            }
        }

        /// <summary>
        /// Gets or sets SchemeType.
        /// </summary>
        [JsonProperty("scheme_type")]
        public string SchemeType
        {
            get
            {
                return this.schemeType;
            }

            set
            {
                this.shouldSerialize["scheme_type"] = true;
                this.schemeType = value;
            }
        }

        /// <summary>
        /// Gets or sets PriceBrackets.
        /// </summary>
        [JsonProperty("price_brackets")]
        public List<Models.GetPriceBracketResponse> PriceBrackets
        {
            get
            {
                return this.priceBrackets;
            }

            set
            {
                this.shouldSerialize["price_brackets"] = true;
                this.priceBrackets = value;
            }
        }

        /// <summary>
        /// Gets or sets MinimumPrice.
        /// </summary>
        [JsonProperty("minimum_price")]
        public int? MinimumPrice
        {
            get
            {
                return this.minimumPrice;
            }

            set
            {
                this.shouldSerialize["minimum_price"] = true;
                this.minimumPrice = value;
            }
        }

        /// <summary>
        /// percentual value used in pricing_scheme Percent
        /// </summary>
        [JsonProperty("percentage")]
        public double? Percentage
        {
            get
            {
                return this.percentage;
            }

            set
            {
                this.shouldSerialize["percentage"] = true;
                this.percentage = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPricingSchemeResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPrice()
        {
            this.shouldSerialize["price"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSchemeType()
        {
            this.shouldSerialize["scheme_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPriceBrackets()
        {
            this.shouldSerialize["price_brackets"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMinimumPrice()
        {
            this.shouldSerialize["minimum_price"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPercentage()
        {
            this.shouldSerialize["percentage"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrice()
        {
            return this.shouldSerialize["price"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSchemeType()
        {
            return this.shouldSerialize["scheme_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceBrackets()
        {
            return this.shouldSerialize["price_brackets"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMinimumPrice()
        {
            return this.shouldSerialize["minimum_price"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePercentage()
        {
            return this.shouldSerialize["percentage"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPricingSchemeResponse other &&
                (this.Price == null && other.Price == null ||
                 this.Price?.Equals(other.Price) == true) &&
                (this.SchemeType == null && other.SchemeType == null ||
                 this.SchemeType?.Equals(other.SchemeType) == true) &&
                (this.PriceBrackets == null && other.PriceBrackets == null ||
                 this.PriceBrackets?.Equals(other.PriceBrackets) == true) &&
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
            toStringOutput.Add($"Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"SchemeType = {this.SchemeType ?? "null"}");
            toStringOutput.Add($"PriceBrackets = {(this.PriceBrackets == null ? "null" : $"[{string.Join(", ", this.PriceBrackets)} ]")}");
            toStringOutput.Add($"MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"Percentage = {(this.Percentage == null ? "null" : this.Percentage.ToString())}");
        }
    }
}