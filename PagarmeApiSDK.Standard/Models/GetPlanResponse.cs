// <copyright file="GetPlanResponse.cs" company="APIMatic">
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
    /// GetPlanResponse.
    /// </summary>
    public class GetPlanResponse
    {
        private string id;
        private string name;
        private string description;
        private string url;
        private string statementDescriptor;
        private string interval;
        private int? intervalCount;
        private string billingType;
        private List<string> paymentMethods;
        private List<int> installments;
        private string status;
        private string currency;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private List<Models.GetPlanItemResponse> items;
        private List<int> billingDays;
        private bool? shippable;
        private Dictionary<string, string> metadata;
        private int? trialPeriodDays;
        private int? minimumPrice;
        private DateTime? deletedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "name", false },
            { "description", false },
            { "url", false },
            { "statement_descriptor", false },
            { "interval", false },
            { "interval_count", false },
            { "billing_type", false },
            { "payment_methods", false },
            { "installments", false },
            { "status", false },
            { "currency", false },
            { "created_at", false },
            { "updated_at", false },
            { "items", false },
            { "billing_days", false },
            { "shippable", false },
            { "metadata", false },
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

            if (id != null)
            {
                this.Id = id;
            }

            if (name != null)
            {
                this.Name = name;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (url != null)
            {
                this.Url = url;
            }

            if (statementDescriptor != null)
            {
                this.StatementDescriptor = statementDescriptor;
            }

            if (interval != null)
            {
                this.Interval = interval;
            }

            if (intervalCount != null)
            {
                this.IntervalCount = intervalCount;
            }

            if (billingType != null)
            {
                this.BillingType = billingType;
            }

            if (paymentMethods != null)
            {
                this.PaymentMethods = paymentMethods;
            }

            if (installments != null)
            {
                this.Installments = installments;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (currency != null)
            {
                this.Currency = currency;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (items != null)
            {
                this.Items = items;
            }

            if (billingDays != null)
            {
                this.BillingDays = billingDays;
            }

            if (shippable != null)
            {
                this.Shippable = shippable;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

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
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
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
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                this.shouldSerialize["url"] = true;
                this.url = value;
            }
        }

        /// <summary>
        /// Gets or sets StatementDescriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor
        {
            get
            {
                return this.statementDescriptor;
            }

            set
            {
                this.shouldSerialize["statement_descriptor"] = true;
                this.statementDescriptor = value;
            }
        }

        /// <summary>
        /// Gets or sets Interval.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                this.shouldSerialize["interval"] = true;
                this.interval = value;
            }
        }

        /// <summary>
        /// Gets or sets IntervalCount.
        /// </summary>
        [JsonProperty("interval_count")]
        public int? IntervalCount
        {
            get
            {
                return this.intervalCount;
            }

            set
            {
                this.shouldSerialize["interval_count"] = true;
                this.intervalCount = value;
            }
        }

        /// <summary>
        /// Gets or sets BillingType.
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType
        {
            get
            {
                return this.billingType;
            }

            set
            {
                this.shouldSerialize["billing_type"] = true;
                this.billingType = value;
            }
        }

        /// <summary>
        /// Gets or sets PaymentMethods.
        /// </summary>
        [JsonProperty("payment_methods")]
        public List<string> PaymentMethods
        {
            get
            {
                return this.paymentMethods;
            }

            set
            {
                this.shouldSerialize["payment_methods"] = true;
                this.paymentMethods = value;
            }
        }

        /// <summary>
        /// Gets or sets Installments.
        /// </summary>
        [JsonProperty("installments")]
        public List<int> Installments
        {
            get
            {
                return this.installments;
            }

            set
            {
                this.shouldSerialize["installments"] = true;
                this.installments = value;
            }
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency
        {
            get
            {
                return this.currency;
            }

            set
            {
                this.shouldSerialize["currency"] = true;
                this.currency = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime? CreatedAt
        {
            get
            {
                return this.createdAt;
            }

            set
            {
                this.shouldSerialize["created_at"] = true;
                this.createdAt = value;
            }
        }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt
        {
            get
            {
                return this.updatedAt;
            }

            set
            {
                this.shouldSerialize["updated_at"] = true;
                this.updatedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetPlanItemResponse> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                this.shouldSerialize["items"] = true;
                this.items = value;
            }
        }

        /// <summary>
        /// Gets or sets BillingDays.
        /// </summary>
        [JsonProperty("billing_days")]
        public List<int> BillingDays
        {
            get
            {
                return this.billingDays;
            }

            set
            {
                this.shouldSerialize["billing_days"] = true;
                this.billingDays = value;
            }
        }

        /// <summary>
        /// Gets or sets Shippable.
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable
        {
            get
            {
                return this.shippable;
            }

            set
            {
                this.shouldSerialize["shippable"] = true;
                this.shippable = value;
            }
        }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata
        {
            get
            {
                return this.metadata;
            }

            set
            {
                this.shouldSerialize["metadata"] = true;
                this.metadata = value;
            }
        }

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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
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
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUrl()
        {
            this.shouldSerialize["url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatementDescriptor()
        {
            this.shouldSerialize["statement_descriptor"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInterval()
        {
            this.shouldSerialize["interval"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIntervalCount()
        {
            this.shouldSerialize["interval_count"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingType()
        {
            this.shouldSerialize["billing_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentMethods()
        {
            this.shouldSerialize["payment_methods"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInstallments()
        {
            this.shouldSerialize["installments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCurrency()
        {
            this.shouldSerialize["currency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdatedAt()
        {
            this.shouldSerialize["updated_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetItems()
        {
            this.shouldSerialize["items"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingDays()
        {
            this.shouldSerialize["billing_days"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetShippable()
        {
            this.shouldSerialize["shippable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMetadata()
        {
            this.shouldSerialize["metadata"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTrialPeriodDays()
        {
            this.shouldSerialize["trial_period_days"] = false;
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
        public void UnsetDeletedAt()
        {
            this.shouldSerialize["deleted_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
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
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUrl()
        {
            return this.shouldSerialize["url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatementDescriptor()
        {
            return this.shouldSerialize["statement_descriptor"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInterval()
        {
            return this.shouldSerialize["interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIntervalCount()
        {
            return this.shouldSerialize["interval_count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingType()
        {
            return this.shouldSerialize["billing_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMethods()
        {
            return this.shouldSerialize["payment_methods"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstallments()
        {
            return this.shouldSerialize["installments"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrency()
        {
            return this.shouldSerialize["currency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return this.shouldSerialize["updated_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeItems()
        {
            return this.shouldSerialize["items"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingDays()
        {
            return this.shouldSerialize["billing_days"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShippable()
        {
            return this.shouldSerialize["shippable"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMetadata()
        {
            return this.shouldSerialize["metadata"];
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPlanResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalCount == null && other.IntervalCount == null ||
                 this.IntervalCount?.Equals(other.IntervalCount) == true) &&
                (this.BillingType == null && other.BillingType == null ||
                 this.BillingType?.Equals(other.BillingType) == true) &&
                (this.PaymentMethods == null && other.PaymentMethods == null ||
                 this.PaymentMethods?.Equals(other.PaymentMethods) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.BillingDays == null && other.BillingDays == null ||
                 this.BillingDays?.Equals(other.BillingDays) == true) &&
                (this.Shippable == null && other.Shippable == null ||
                 this.Shippable?.Equals(other.Shippable) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.TrialPeriodDays == null && other.TrialPeriodDays == null ||
                 this.TrialPeriodDays?.Equals(other.TrialPeriodDays) == true) &&
                (this.MinimumPrice == null && other.MinimumPrice == null ||
                 this.MinimumPrice?.Equals(other.MinimumPrice) == true) &&
                (this.DeletedAt == null && other.DeletedAt == null ||
                 this.DeletedAt?.Equals(other.DeletedAt) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Interval = {this.Interval ?? "null"}");
            toStringOutput.Add($"IntervalCount = {(this.IntervalCount == null ? "null" : this.IntervalCount.ToString())}");
            toStringOutput.Add($"BillingType = {this.BillingType ?? "null"}");
            toStringOutput.Add($"PaymentMethods = {(this.PaymentMethods == null ? "null" : $"[{string.Join(", ", this.PaymentMethods)} ]")}");
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : $"[{string.Join(", ", this.Installments)} ]")}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"BillingDays = {(this.BillingDays == null ? "null" : $"[{string.Join(", ", this.BillingDays)} ]")}");
            toStringOutput.Add($"Shippable = {(this.Shippable == null ? "null" : this.Shippable.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"TrialPeriodDays = {(this.TrialPeriodDays == null ? "null" : this.TrialPeriodDays.ToString())}");
            toStringOutput.Add($"MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
        }
    }
}