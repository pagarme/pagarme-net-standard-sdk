// <copyright file="UpdatePlanRequest.cs" company="APIMatic">
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
    /// UpdatePlanRequest.
    /// </summary>
    public class UpdatePlanRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlanRequest"/> class.
        /// </summary>
        public UpdatePlanRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlanRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="installments">installments.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="currency">currency.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalCount">interval_count.</param>
        /// <param name="paymentMethods">payment_methods.</param>
        /// <param name="billingType">billing_type.</param>
        /// <param name="status">status.</param>
        /// <param name="shippable">shippable.</param>
        /// <param name="billingDays">billing_days.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="trialPeriodDays">trial_period_days.</param>
        public UpdatePlanRequest(
            string name,
            string description,
            List<int> installments,
            string statementDescriptor,
            string currency,
            string interval,
            int intervalCount,
            List<string> paymentMethods,
            string billingType,
            string status,
            bool shippable,
            List<int> billingDays,
            Dictionary<string, string> metadata,
            int? minimumPrice = null,
            int? trialPeriodDays = null)
        {
            this.Name = name;
            this.Description = description;
            this.Installments = installments;
            this.StatementDescriptor = statementDescriptor;
            this.Currency = currency;
            this.Interval = interval;
            this.IntervalCount = intervalCount;
            this.PaymentMethods = paymentMethods;
            this.BillingType = billingType;
            this.Status = status;
            this.Shippable = shippable;
            this.BillingDays = billingDays;
            this.Metadata = metadata;
            this.MinimumPrice = minimumPrice;
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
        /// Number os installments
        /// </summary>
        [JsonProperty("installments")]
        public List<int> Installments { get; set; }

        /// <summary>
        /// Text that will be shown on the credit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

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
        /// Interval count
        /// </summary>
        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; }

        /// <summary>
        /// Payment methods accepted by the plan
        /// </summary>
        [JsonProperty("payment_methods")]
        public List<string> PaymentMethods { get; set; }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType { get; set; }

        /// <summary>
        /// Plan status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Indicates if the plan is shippable
        /// </summary>
        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        /// <summary>
        /// Billing days accepted by the plan
        /// </summary>
        [JsonProperty("billing_days")]
        public List<int> BillingDays { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <summary>
        /// Number of trial period in days, where the customer will not be charged
        /// </summary>
        [JsonProperty("trial_period_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrialPeriodDays { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdatePlanRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdatePlanRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalCount.Equals(other.IntervalCount)) &&
                (this.PaymentMethods == null && other.PaymentMethods == null ||
                 this.PaymentMethods?.Equals(other.PaymentMethods) == true) &&
                (this.BillingType == null && other.BillingType == null ||
                 this.BillingType?.Equals(other.BillingType) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Shippable.Equals(other.Shippable)) &&
                (this.BillingDays == null && other.BillingDays == null ||
                 this.BillingDays?.Equals(other.BillingDays) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.MinimumPrice == null && other.MinimumPrice == null ||
                 this.MinimumPrice?.Equals(other.MinimumPrice) == true) &&
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
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : $"[{string.Join(", ", this.Installments)} ]")}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Interval = {this.Interval ?? "null"}");
            toStringOutput.Add($"IntervalCount = {this.IntervalCount}");
            toStringOutput.Add($"PaymentMethods = {(this.PaymentMethods == null ? "null" : $"[{string.Join(", ", this.PaymentMethods)} ]")}");
            toStringOutput.Add($"BillingType = {this.BillingType ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Shippable = {this.Shippable}");
            toStringOutput.Add($"BillingDays = {(this.BillingDays == null ? "null" : $"[{string.Join(", ", this.BillingDays)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"TrialPeriodDays = {(this.TrialPeriodDays == null ? "null" : this.TrialPeriodDays.ToString())}");
        }
    }
}