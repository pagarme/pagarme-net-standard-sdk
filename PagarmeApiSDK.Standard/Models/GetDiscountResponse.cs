// <copyright file="GetDiscountResponse.cs" company="APIMatic">
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
    /// GetDiscountResponse.
    /// </summary>
    public class GetDiscountResponse
    {
        private int? cycles;
        private DateTime? deletedAt;
        private string description;
        private Models.GetSubscriptionResponse subscription;
        private Models.GetSubscriptionItemResponse subscriptionItem;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cycles", false },
            { "deleted_at", false },
            { "description", false },
            { "subscription", false },
            { "subscription_item", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscountResponse"/> class.
        /// </summary>
        public GetDiscountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscountResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mValue">value.</param>
        /// <param name="discountType">discount_type.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="description">description.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="subscriptionItem">subscription_item.</param>
        public GetDiscountResponse(
            string id = null,
            double? mValue = null,
            string discountType = null,
            string status = null,
            DateTime? createdAt = null,
            int? cycles = null,
            DateTime? deletedAt = null,
            string description = null,
            Models.GetSubscriptionResponse subscription = null,
            Models.GetSubscriptionItemResponse subscriptionItem = null)
        {
            this.Id = id;
            this.MValue = mValue;
            this.DiscountType = discountType;
            this.Status = status;
            this.CreatedAt = createdAt;
            if (cycles != null)
            {
                this.Cycles = cycles;
            }

            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (subscription != null)
            {
                this.Subscription = subscription;
            }

            if (subscriptionItem != null)
            {
                this.SubscriptionItem = subscriptionItem;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Include)]
        public double? MValue { get; set; }

        /// <summary>
        /// Gets or sets DiscountType.
        /// </summary>
        [JsonProperty("discount_type", NullValueHandling = NullValueHandling.Include)]
        public string DiscountType { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Cycles.
        /// </summary>
        [JsonProperty("cycles")]
        public int? Cycles
        {
            get
            {
                return this.cycles;
            }

            set
            {
                this.shouldSerialize["cycles"] = true;
                this.cycles = value;
            }
        }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt
        {
            get
            {
                return this.deletedAt;
            }

            set
            {
                this.shouldSerialize["deleted_at"] = true;
                this.deletedAt = value;
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
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription
        {
            get
            {
                return this.subscription;
            }

            set
            {
                this.shouldSerialize["subscription"] = true;
                this.subscription = value;
            }
        }

        /// <summary>
        /// The subscription item
        /// </summary>
        [JsonProperty("subscription_item")]
        public Models.GetSubscriptionItemResponse SubscriptionItem
        {
            get
            {
                return this.subscriptionItem;
            }

            set
            {
                this.shouldSerialize["subscription_item"] = true;
                this.subscriptionItem = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetDiscountResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCycles()
        {
            this.shouldSerialize["cycles"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeletedAt()
        {
            this.shouldSerialize["deleted_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubscription()
        {
            this.shouldSerialize["subscription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubscriptionItem()
        {
            this.shouldSerialize["subscription_item"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCycles()
        {
            return this.shouldSerialize["cycles"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeletedAt()
        {
            return this.shouldSerialize["deleted_at"];
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
        public bool ShouldSerializeSubscription()
        {
            return this.shouldSerialize["subscription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionItem()
        {
            return this.shouldSerialize["subscription_item"];
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

            return obj is GetDiscountResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.DiscountType == null && other.DiscountType == null) || (this.DiscountType?.Equals(other.DiscountType) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.Cycles == null && other.Cycles == null) || (this.Cycles?.Equals(other.Cycles) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true)) &&
                ((this.SubscriptionItem == null && other.SubscriptionItem == null) || (this.SubscriptionItem?.Equals(other.SubscriptionItem) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"this.DiscountType = {(this.DiscountType == null ? "null" : this.DiscountType == string.Empty ? "" : this.DiscountType)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"this.SubscriptionItem = {(this.SubscriptionItem == null ? "null" : this.SubscriptionItem.ToString())}");
        }
    }
}