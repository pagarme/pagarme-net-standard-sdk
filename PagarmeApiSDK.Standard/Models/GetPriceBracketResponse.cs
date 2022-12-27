// <copyright file="GetPriceBracketResponse.cs" company="APIMatic">
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
    /// GetPriceBracketResponse.
    /// </summary>
    public class GetPriceBracketResponse
    {
        private int? endQuantity;
        private int? overagePrice;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "end_quantity", false },
            { "overage_price", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPriceBracketResponse"/> class.
        /// </summary>
        public GetPriceBracketResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPriceBracketResponse"/> class.
        /// </summary>
        /// <param name="startQuantity">start_quantity.</param>
        /// <param name="price">price.</param>
        /// <param name="endQuantity">end_quantity.</param>
        /// <param name="overagePrice">overage_price.</param>
        public GetPriceBracketResponse(
            int? startQuantity = null,
            int? price = null,
            int? endQuantity = null,
            int? overagePrice = null)
        {
            this.StartQuantity = startQuantity;
            this.Price = price;
            if (endQuantity != null)
            {
                this.EndQuantity = endQuantity;
            }

            if (overagePrice != null)
            {
                this.OveragePrice = overagePrice;
            }

        }

        /// <summary>
        /// Gets or sets StartQuantity.
        /// </summary>
        [JsonProperty("start_quantity", NullValueHandling = NullValueHandling.Include)]
        public int? StartQuantity { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Include)]
        public int? Price { get; set; }

        /// <summary>
        /// Gets or sets EndQuantity.
        /// </summary>
        [JsonProperty("end_quantity")]
        public int? EndQuantity
        {
            get
            {
                return this.endQuantity;
            }

            set
            {
                this.shouldSerialize["end_quantity"] = true;
                this.endQuantity = value;
            }
        }

        /// <summary>
        /// Gets or sets OveragePrice.
        /// </summary>
        [JsonProperty("overage_price")]
        public int? OveragePrice
        {
            get
            {
                return this.overagePrice;
            }

            set
            {
                this.shouldSerialize["overage_price"] = true;
                this.overagePrice = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPriceBracketResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEndQuantity()
        {
            this.shouldSerialize["end_quantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOveragePrice()
        {
            this.shouldSerialize["overage_price"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndQuantity()
        {
            return this.shouldSerialize["end_quantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOveragePrice()
        {
            return this.shouldSerialize["overage_price"];
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

            return obj is GetPriceBracketResponse other &&
                ((this.StartQuantity == null && other.StartQuantity == null) || (this.StartQuantity?.Equals(other.StartQuantity) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.EndQuantity == null && other.EndQuantity == null) || (this.EndQuantity?.Equals(other.EndQuantity) == true)) &&
                ((this.OveragePrice == null && other.OveragePrice == null) || (this.OveragePrice?.Equals(other.OveragePrice) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartQuantity = {(this.StartQuantity == null ? "null" : this.StartQuantity.ToString())}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.EndQuantity = {(this.EndQuantity == null ? "null" : this.EndQuantity.ToString())}");
            toStringOutput.Add($"this.OveragePrice = {(this.OveragePrice == null ? "null" : this.OveragePrice.ToString())}");
        }
    }
}