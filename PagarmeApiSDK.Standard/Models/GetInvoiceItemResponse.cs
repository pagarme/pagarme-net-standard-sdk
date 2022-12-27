// <copyright file="GetInvoiceItemResponse.cs" company="APIMatic">
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
    /// GetInvoiceItemResponse.
    /// </summary>
    public class GetInvoiceItemResponse
    {
        private int? quantity;
        private string name;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "quantity", false },
            { "name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceItemResponse"/> class.
        /// </summary>
        public GetInvoiceItemResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceItemResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="priceBracket">price_bracket.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="name">name.</param>
        /// <param name="subscriptionItemId">subscription_item_id.</param>
        public GetInvoiceItemResponse(
            int? amount = null,
            string description = null,
            Models.GetPricingSchemeResponse pricingScheme = null,
            Models.GetPriceBracketResponse priceBracket = null,
            int? quantity = null,
            string name = null,
            string subscriptionItemId = null)
        {
            this.Amount = amount;
            this.Description = description;
            this.PricingScheme = pricingScheme;
            this.PriceBracket = priceBracket;
            if (quantity != null)
            {
                this.Quantity = quantity;
            }

            if (name != null)
            {
                this.Name = name;
            }

            this.SubscriptionItemId = subscriptionItemId;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets PricingScheme.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Include)]
        public Models.GetPricingSchemeResponse PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets PriceBracket.
        /// </summary>
        [JsonProperty("price_bracket", NullValueHandling = NullValueHandling.Include)]
        public Models.GetPriceBracketResponse PriceBracket { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                this.shouldSerialize["quantity"] = true;
                this.quantity = value;
            }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Subscription Item Id
        /// </summary>
        [JsonProperty("subscription_item_id", NullValueHandling = NullValueHandling.Include)]
        public string SubscriptionItemId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetInvoiceItemResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetQuantity()
        {
            this.shouldSerialize["quantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeQuantity()
        {
            return this.shouldSerialize["quantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
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

            return obj is GetInvoiceItemResponse other &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.PriceBracket == null && other.PriceBracket == null) || (this.PriceBracket?.Equals(other.PriceBracket) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.SubscriptionItemId == null && other.SubscriptionItemId == null) || (this.SubscriptionItemId?.Equals(other.SubscriptionItemId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.PriceBracket = {(this.PriceBracket == null ? "null" : this.PriceBracket.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.SubscriptionItemId = {(this.SubscriptionItemId == null ? "null" : this.SubscriptionItemId == string.Empty ? "" : this.SubscriptionItemId)}");
        }
    }
}