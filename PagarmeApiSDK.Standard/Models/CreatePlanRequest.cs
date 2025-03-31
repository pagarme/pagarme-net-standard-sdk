// <copyright file="CreatePlanRequest.cs" company="APIMatic">
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
    /// CreatePlanRequest.
    /// </summary>
    public class CreatePlanRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlanRequest"/> class.
        /// </summary>
        public CreatePlanRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlanRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="items">items.</param>
        /// <param name="shippable">shippable.</param>
        /// <param name="paymentMethods">payment_methods.</param>
        /// <param name="installments">installments.</param>
        /// <param name="currency">currency.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalCount">interval_count.</param>
        /// <param name="billingDays">billing_days.</param>
        /// <param name="billingType">billing_type.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="trialPeriodDays">trial_period_days.</param>
        public CreatePlanRequest(
            string name,
            string description,
            string statementDescriptor,
            List<Models.CreatePlanItemRequest> items,
            bool shippable,
            List<string> paymentMethods,
            List<int> installments,
            string currency,
            string interval,
            int intervalCount,
            List<int> billingDays,
            string billingType,
            Models.CreatePricingSchemeRequest pricingScheme,
            Dictionary<string, string> metadata,
            int? minimumPrice = null,
            int? cycles = null,
            int? quantity = null,
            int? trialPeriodDays = null)
        {
            this.Name = name;
            this.Description = description;
            this.StatementDescriptor = statementDescriptor;
            this.Items = items;
            this.Shippable = shippable;
            this.PaymentMethods = paymentMethods;
            this.Installments = installments;
            this.Currency = currency;
            this.Interval = interval;
            this.IntervalCount = intervalCount;
            this.BillingDays = billingDays;
            this.BillingType = billingType;
            this.PricingScheme = pricingScheme;
            this.Metadata = metadata;
            this.MinimumPrice = minimumPrice;
            this.Cycles = cycles;
            this.Quantity = quantity;
            this.TrialPeriodDays = trialPeriodDays;
        }

        /// <summary>
        /// Plan's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Text that will be printed on the credit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Plan items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreatePlanItemRequest> Items { get; set; }

        /// <summary>
        /// Indicates if the plan is shippable
        /// </summary>
        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        /// <summary>
        /// Allowed payment methods for the plan
        /// </summary>
        [JsonProperty("payment_methods")]
        public List<string> PaymentMethods { get; set; }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments")]
        public List<int> Installments { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Interval counts between two charges. For instance, if the interval is 'month' and count is 2, the customer will be charged once every two months.
        /// </summary>
        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; }

        /// <summary>
        /// Allowed billings days for the subscription, in case the plan type is 'exact_day'
        /// </summary>
        [JsonProperty("billing_days")]
        public List<int> BillingDays { get; set; }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType { get; set; }

        /// <summary>
        /// Plan's pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.CreatePricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Minimum price that will be charged
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <summary>
        /// Number of cycles
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Trial period, where the customer will not be charged.
        /// </summary>
        [JsonProperty("trial_period_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrialPeriodDays { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePlanRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePlanRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.Shippable.Equals(other.Shippable)) &&
                (this.PaymentMethods == null && other.PaymentMethods == null ||
                 this.PaymentMethods?.Equals(other.PaymentMethods) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalCount.Equals(other.IntervalCount)) &&
                (this.BillingDays == null && other.BillingDays == null ||
                 this.BillingDays?.Equals(other.BillingDays) == true) &&
                (this.BillingType == null && other.BillingType == null ||
                 this.BillingType?.Equals(other.BillingType) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.MinimumPrice == null && other.MinimumPrice == null ||
                 this.MinimumPrice?.Equals(other.MinimumPrice) == true) &&
                (this.Cycles == null && other.Cycles == null ||
                 this.Cycles?.Equals(other.Cycles) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.TrialPeriodDays == null && other.TrialPeriodDays == null ||
                 this.TrialPeriodDays?.Equals(other.TrialPeriodDays) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"Shippable = {this.Shippable}");
            toStringOutput.Add($"PaymentMethods = {(this.PaymentMethods == null ? "null" : $"[{string.Join(", ", this.PaymentMethods)} ]")}");
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : $"[{string.Join(", ", this.Installments)} ]")}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Interval = {this.Interval ?? "null"}");
            toStringOutput.Add($"IntervalCount = {this.IntervalCount}");
            toStringOutput.Add($"BillingDays = {(this.BillingDays == null ? "null" : $"[{string.Join(", ", this.BillingDays)} ]")}");
            toStringOutput.Add($"BillingType = {this.BillingType ?? "null"}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"TrialPeriodDays = {(this.TrialPeriodDays == null ? "null" : this.TrialPeriodDays.ToString())}");
        }
    }
}