// <copyright file="GetInvoiceItemResponse.cs" company="APIMatic">
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
    /// GetInvoiceItemResponse.
    /// </summary>
    public class GetInvoiceItemResponse
    {
        private int? amount;
        private string description;
        private Models.GetPricingSchemeResponse pricingScheme;
        private Models.GetPriceBracketResponse priceBracket;
        private int? quantity;
        private string name;
        private string subscriptionItemId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "amount", false },
            { "description", false },
            { "pricing_scheme", false },
            { "price_bracket", false },
            { "quantity", false },
            { "name", false },
            { "subscription_item_id", false },
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

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (pricingScheme != null)
            {
                this.PricingScheme = pricingScheme;
            }

            if (priceBracket != null)
            {
                this.PriceBracket = priceBracket;
            }

            if (quantity != null)
            {
                this.Quantity = quantity;
            }

            if (name != null)
            {
                this.Name = name;
            }

            if (subscriptionItemId != null)
            {
                this.SubscriptionItemId = subscriptionItemId;
            }
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.shouldSerialize["amount"] = true;
                this.amount = value;
            }
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets PricingScheme.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.GetPricingSchemeResponse PricingScheme
        {
            get
            {
                return this.pricingScheme;
            }

            set
            {
                this.shouldSerialize["pricing_scheme"] = true;
                this.pricingScheme = value;
            }
        }

        /// <summary>
        /// Gets or sets PriceBracket.
        /// </summary>
        [JsonProperty("price_bracket")]
        public Models.GetPriceBracketResponse PriceBracket
        {
            get
            {
                return this.priceBracket;
            }

            set
            {
                this.shouldSerialize["price_bracket"] = true;
                this.priceBracket = value;
            }
        }

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
        [JsonProperty("subscription_item_id")]
        public string SubscriptionItemId
        {
            get
            {
                return this.subscriptionItemId;
            }

            set
            {
                this.shouldSerialize["subscription_item_id"] = true;
                this.subscriptionItemId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetInvoiceItemResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPricingScheme()
        {
            this.shouldSerialize["pricing_scheme"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPriceBracket()
        {
            this.shouldSerialize["price_bracket"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetQuantity()
        {
            this.shouldSerialize["quantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubscriptionItemId()
        {
            this.shouldSerialize["subscription_item_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingScheme()
        {
            return this.shouldSerialize["pricing_scheme"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceBracket()
        {
            return this.shouldSerialize["price_bracket"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionItemId()
        {
            return this.shouldSerialize["subscription_item_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetInvoiceItemResponse other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.PriceBracket == null && other.PriceBracket == null ||
                 this.PriceBracket?.Equals(other.PriceBracket) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.SubscriptionItemId == null && other.SubscriptionItemId == null ||
                 this.SubscriptionItemId?.Equals(other.SubscriptionItemId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"PriceBracket = {(this.PriceBracket == null ? "null" : this.PriceBracket.ToString())}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"SubscriptionItemId = {this.SubscriptionItemId ?? "null"}");
        }
    }
}