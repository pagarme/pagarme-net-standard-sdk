// <copyright file="GetUsageResponse.cs" company="APIMatic">
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
    /// GetUsageResponse.
    /// </summary>
    public class GetUsageResponse
    {
        private DateTime? deletedAt;
        private string code;
        private string mGroup;
        private int? amount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "deleted_at", false },
            { "code", false },
            { "group", false },
            { "amount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse"/> class.
        /// </summary>
        public GetUsageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="description">description.</param>
        /// <param name="usedAt">used_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="status">status.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="subscriptionItem">subscription_item.</param>
        /// <param name="code">code.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="amount">amount.</param>
        public GetUsageResponse(
            string id = null,
            int? quantity = null,
            string description = null,
            DateTime? usedAt = null,
            DateTime? createdAt = null,
            string status = null,
            DateTime? deletedAt = null,
            Models.GetSubscriptionItemResponse subscriptionItem = null,
            string code = null,
            string mGroup = null,
            int? amount = null)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Description = description;
            this.UsedAt = usedAt;
            this.CreatedAt = createdAt;
            this.Status = status;
            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

            this.SubscriptionItem = subscriptionItem;
            if (code != null)
            {
                this.Code = code;
            }

            if (mGroup != null)
            {
                this.MGroup = mGroup;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Include)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Used at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("used_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UsedAt { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

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
        /// Subscription item
        /// </summary>
        [JsonProperty("subscription_item", NullValueHandling = NullValueHandling.Include)]
        public Models.GetSubscriptionItemResponse SubscriptionItem { get; set; }

        /// <summary>
        /// Identification code in the client system
        /// </summary>
        [JsonProperty("code")]
        public string Code
        {
            get
            {
                return this.code;
            }

            set
            {
                this.shouldSerialize["code"] = true;
                this.code = value;
            }
        }

        /// <summary>
        /// Identification group in the client system
        /// </summary>
        [JsonProperty("group")]
        public string MGroup
        {
            get
            {
                return this.mGroup;
            }

            set
            {
                this.shouldSerialize["group"] = true;
                this.mGroup = value;
            }
        }

        /// <summary>
        /// Field used in item scheme type 'Percent'
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetUsageResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCode()
        {
            this.shouldSerialize["code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGroup()
        {
            this.shouldSerialize["group"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
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
        public bool ShouldSerializeCode()
        {
            return this.shouldSerialize["code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGroup()
        {
            return this.shouldSerialize["group"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
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

            return obj is GetUsageResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.UsedAt == null && other.UsedAt == null) || (this.UsedAt?.Equals(other.UsedAt) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.SubscriptionItem == null && other.SubscriptionItem == null) || (this.SubscriptionItem?.Equals(other.SubscriptionItem) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.UsedAt = {(this.UsedAt == null ? "null" : this.UsedAt.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.SubscriptionItem = {(this.SubscriptionItem == null ? "null" : this.SubscriptionItem.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup == string.Empty ? "" : this.MGroup)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}