// <copyright file="GetPlanResponse.cs" company="APIMatic">
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
    /// GetPlanResponse.
    /// </summary>
    public class GetPlanResponse
    {
        private int? trialPeriodDays;
        private int? minimumPrice;
        private DateTime? deletedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "trial_period_days", false },
            { "minimum_price", false },
            { "deleted_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPlanResponse"/> class.
        /// </summary>
        public GetPlanResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPlanResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="url">url.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalCount">interval_count.</param>
        /// <param name="billingType">billing_type.</param>
        /// <param name="paymentMethods">payment_methods.</param>
        /// <param name="installments">installments.</param>
        /// <param name="status">status.</param>
        /// <param name="currency">currency.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="items">items.</param>
        /// <param name="billingDays">billing_days.</param>
        /// <param name="shippable">shippable.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="trialPeriodDays">trial_period_days.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public GetPlanResponse(
            string id = null,
            string name = null,
            string description = null,
            string url = null,
            string statementDescriptor = null,
            string interval = null,
            int? intervalCount = null,
            string billingType = null,
            List<string> paymentMethods = null,
            List<int> installments = null,
            string status = null,
            string currency = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            List<Models.GetPlanItemResponse> items = null,
            List<int> billingDays = null,
            bool? shippable = null,
            Dictionary<string, string> metadata = null,
            int? trialPeriodDays = null,
            int? minimumPrice = null,
            DateTime? deletedAt = null)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Url = url;
            this.StatementDescriptor = statementDescriptor;
            this.Interval = interval;
            this.IntervalCount = intervalCount;
            this.BillingType = billingType;
            this.PaymentMethods = paymentMethods;
            this.Installments = installments;
            this.Status = status;
            this.Currency = currency;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Items = items;
            this.BillingDays = billingDays;
            this.Shippable = shippable;
            this.Metadata = metadata;
            if (trialPeriodDays != null)
            {
                this.TrialPeriodDays = trialPeriodDays;
            }

            if (minimumPrice != null)
            {
                this.MinimumPrice = minimumPrice;
            }

            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Include)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Include)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets StatementDescriptor.
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Include)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Gets or sets Interval.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Include)]
        public string Interval { get; set; }

        /// <summary>
        /// Gets or sets IntervalCount.
        /// </summary>
        [JsonProperty("interval_count", NullValueHandling = NullValueHandling.Include)]
        public int? IntervalCount { get; set; }

        /// <summary>
        /// Gets or sets BillingType.
        /// </summary>
        [JsonProperty("billing_type", NullValueHandling = NullValueHandling.Include)]
        public string BillingType { get; set; }

        /// <summary>
        /// Gets or sets PaymentMethods.
        /// </summary>
        [JsonProperty("payment_methods", NullValueHandling = NullValueHandling.Include)]
        public List<string> PaymentMethods { get; set; }

        /// <summary>
        /// Gets or sets Installments.
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Include)]
        public List<int> Installments { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Include)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetPlanItemResponse> Items { get; set; }

        /// <summary>
        /// Gets or sets BillingDays.
        /// </summary>
        [JsonProperty("billing_days", NullValueHandling = NullValueHandling.Include)]
        public List<int> BillingDays { get; set; }

        /// <summary>
        /// Gets or sets Shippable.
        /// </summary>
        [JsonProperty("shippable", NullValueHandling = NullValueHandling.Include)]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets TrialPeriodDays.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays
        {
            get
            {
                return this.trialPeriodDays;
            }

            set
            {
                this.shouldSerialize["trial_period_days"] = true;
                this.trialPeriodDays = value;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPlanResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrialPeriodDays()
        {
            this.shouldSerialize["trial_period_days"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMinimumPrice()
        {
            this.shouldSerialize["minimum_price"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeletedAt()
        {
            this.shouldSerialize["deleted_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrialPeriodDays()
        {
            return this.shouldSerialize["trial_period_days"];
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
        public bool ShouldSerializeDeletedAt()
        {
            return this.shouldSerialize["deleted_at"];
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

            return obj is GetPlanResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalCount == null && other.IntervalCount == null) || (this.IntervalCount?.Equals(other.IntervalCount) == true)) &&
                ((this.BillingType == null && other.BillingType == null) || (this.BillingType?.Equals(other.BillingType) == true)) &&
                ((this.PaymentMethods == null && other.PaymentMethods == null) || (this.PaymentMethods?.Equals(other.PaymentMethods) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.BillingDays == null && other.BillingDays == null) || (this.BillingDays?.Equals(other.BillingDays) == true)) &&
                ((this.Shippable == null && other.Shippable == null) || (this.Shippable?.Equals(other.Shippable) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.TrialPeriodDays == null && other.TrialPeriodDays == null) || (this.TrialPeriodDays?.Equals(other.TrialPeriodDays) == true)) &&
                ((this.MinimumPrice == null && other.MinimumPrice == null) || (this.MinimumPrice?.Equals(other.MinimumPrice) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval == string.Empty ? "" : this.Interval)}");
            toStringOutput.Add($"this.IntervalCount = {(this.IntervalCount == null ? "null" : this.IntervalCount.ToString())}");
            toStringOutput.Add($"this.BillingType = {(this.BillingType == null ? "null" : this.BillingType == string.Empty ? "" : this.BillingType)}");
            toStringOutput.Add($"this.PaymentMethods = {(this.PaymentMethods == null ? "null" : $"[{string.Join(", ", this.PaymentMethods)} ]")}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : $"[{string.Join(", ", this.Installments)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.BillingDays = {(this.BillingDays == null ? "null" : $"[{string.Join(", ", this.BillingDays)} ]")}");
            toStringOutput.Add($"this.Shippable = {(this.Shippable == null ? "null" : this.Shippable.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.TrialPeriodDays = {(this.TrialPeriodDays == null ? "null" : this.TrialPeriodDays.ToString())}");
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
        }
    }
}