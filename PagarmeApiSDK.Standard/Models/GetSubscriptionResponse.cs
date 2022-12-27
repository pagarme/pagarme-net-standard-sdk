// <copyright file="GetSubscriptionResponse.cs" company="APIMatic">
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
    /// GetSubscriptionResponse.
    /// </summary>
    public class GetSubscriptionResponse
    {
        private Models.GetPeriodResponse currentCycle;
        private Models.GetCustomerResponse customer;
        private DateTime? nextBillingAt;
        private int? billingDay;
        private int? minimumPrice;
        private DateTime? canceledAt;
        private List<Models.GetDiscountResponse> discounts;
        private int? boletoDueDays;
        private Models.GetSubscriptionBoletoResponse boleto;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "current_cycle", false },
            { "customer", false },
            { "next_billing_at", false },
            { "billing_day", false },
            { "minimum_price", false },
            { "canceled_at", false },
            { "discounts", false },
            { "boleto_due_days", false },
            { "boleto", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse"/> class.
        /// </summary>
        public GetSubscriptionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="startAt">start_at.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalCount">interval_count.</param>
        /// <param name="billingType">billing_type.</param>
        /// <param name="currentCycle">current_cycle.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="currency">currency.</param>
        /// <param name="installments">installments.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="customer">customer.</param>
        /// <param name="card">card.</param>
        /// <param name="items">items.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="setup">setup.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="nextBillingAt">next_billing_at.</param>
        /// <param name="billingDay">billing_day.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="increments">increments.</param>
        /// <param name="boletoDueDays">boleto_due_days.</param>
        /// <param name="split">split.</param>
        /// <param name="boleto">boleto.</param>
        public GetSubscriptionResponse(
            string id = null,
            string code = null,
            DateTime? startAt = null,
            string interval = null,
            int? intervalCount = null,
            string billingType = null,
            Models.GetPeriodResponse currentCycle = null,
            string paymentMethod = null,
            string currency = null,
            int? installments = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            Models.GetCustomerResponse customer = null,
            Models.GetCardResponse card = null,
            List<Models.GetSubscriptionItemResponse> items = null,
            string statementDescriptor = null,
            Dictionary<string, string> metadata = null,
            Models.GetSetupResponse setup = null,
            string gatewayAffiliationId = null,
            DateTime? nextBillingAt = null,
            int? billingDay = null,
            int? minimumPrice = null,
            DateTime? canceledAt = null,
            List<Models.GetDiscountResponse> discounts = null,
            List<Models.GetIncrementResponse> increments = null,
            int? boletoDueDays = null,
            Models.GetSubscriptionSplitResponse split = null,
            Models.GetSubscriptionBoletoResponse boleto = null)
        {
            this.Id = id;
            this.Code = code;
            this.StartAt = startAt;
            this.Interval = interval;
            this.IntervalCount = intervalCount;
            this.BillingType = billingType;
            if (currentCycle != null)
            {
                this.CurrentCycle = currentCycle;
            }

            this.PaymentMethod = paymentMethod;
            this.Currency = currency;
            this.Installments = installments;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (customer != null)
            {
                this.Customer = customer;
            }

            this.Card = card;
            this.Items = items;
            this.StatementDescriptor = statementDescriptor;
            this.Metadata = metadata;
            this.Setup = setup;
            this.GatewayAffiliationId = gatewayAffiliationId;
            if (nextBillingAt != null)
            {
                this.NextBillingAt = nextBillingAt;
            }

            if (billingDay != null)
            {
                this.BillingDay = billingDay;
            }

            if (minimumPrice != null)
            {
                this.MinimumPrice = minimumPrice;
            }

            if (canceledAt != null)
            {
                this.CanceledAt = canceledAt;
            }

            if (discounts != null)
            {
                this.Discounts = discounts;
            }

            this.Increments = increments;
            if (boletoDueDays != null)
            {
                this.BoletoDueDays = boletoDueDays;
            }

            this.Split = split;
            if (boleto != null)
            {
                this.Boleto = boleto;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Include)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets StartAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? StartAt { get; set; }

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
        /// Gets or sets CurrentCycle.
        /// </summary>
        [JsonProperty("current_cycle")]
        public Models.GetPeriodResponse CurrentCycle
        {
            get
            {
                return this.currentCycle;
            }

            set
            {
                this.shouldSerialize["current_cycle"] = true;
                this.currentCycle = value;
            }
        }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Include)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Include)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Installments.
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Include)]
        public int? Installments { get; set; }

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
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.shouldSerialize["customer"] = true;
                this.customer = value;
            }
        }

        /// <summary>
        /// Gets or sets Card.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Include)]
        public Models.GetCardResponse Card { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetSubscriptionItemResponse> Items { get; set; }

        /// <summary>
        /// Gets or sets StatementDescriptor.
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Include)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Setup.
        /// </summary>
        [JsonProperty("setup", NullValueHandling = NullValueHandling.Include)]
        public Models.GetSetupResponse Setup { get; set; }

        /// <summary>
        /// Affiliation Code
        /// </summary>
        [JsonProperty("gateway_affiliation_id", NullValueHandling = NullValueHandling.Include)]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// Gets or sets NextBillingAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_billing_at")]
        public DateTime? NextBillingAt
        {
            get
            {
                return this.nextBillingAt;
            }

            set
            {
                this.shouldSerialize["next_billing_at"] = true;
                this.nextBillingAt = value;
            }
        }

        /// <summary>
        /// Gets or sets BillingDay.
        /// </summary>
        [JsonProperty("billing_day")]
        public int? BillingDay
        {
            get
            {
                return this.billingDay;
            }

            set
            {
                this.shouldSerialize["billing_day"] = true;
                this.billingDay = value;
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
        /// Gets or sets CanceledAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at")]
        public DateTime? CanceledAt
        {
            get
            {
                return this.canceledAt;
            }

            set
            {
                this.shouldSerialize["canceled_at"] = true;
                this.canceledAt = value;
            }
        }

        /// <summary>
        /// Subscription discounts
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.GetDiscountResponse> Discounts
        {
            get
            {
                return this.discounts;
            }

            set
            {
                this.shouldSerialize["discounts"] = true;
                this.discounts = value;
            }
        }

        /// <summary>
        /// Subscription increments
        /// </summary>
        [JsonProperty("increments", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetIncrementResponse> Increments { get; set; }

        /// <summary>
        /// Days until boleto expires
        /// </summary>
        [JsonProperty("boleto_due_days")]
        public int? BoletoDueDays
        {
            get
            {
                return this.boletoDueDays;
            }

            set
            {
                this.shouldSerialize["boleto_due_days"] = true;
                this.boletoDueDays = value;
            }
        }

        /// <summary>
        /// Subscription's split response
        /// </summary>
        [JsonProperty("split", NullValueHandling = NullValueHandling.Include)]
        public Models.GetSubscriptionSplitResponse Split { get; set; }

        /// <summary>
        /// Gets or sets Boleto.
        /// </summary>
        [JsonProperty("boleto")]
        public Models.GetSubscriptionBoletoResponse Boleto
        {
            get
            {
                return this.boleto;
            }

            set
            {
                this.shouldSerialize["boleto"] = true;
                this.boleto = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSubscriptionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrentCycle()
        {
            this.shouldSerialize["current_cycle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomer()
        {
            this.shouldSerialize["customer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNextBillingAt()
        {
            this.shouldSerialize["next_billing_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingDay()
        {
            this.shouldSerialize["billing_day"] = false;
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
        public void UnsetCanceledAt()
        {
            this.shouldSerialize["canceled_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDiscounts()
        {
            this.shouldSerialize["discounts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBoletoDueDays()
        {
            this.shouldSerialize["boleto_due_days"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBoleto()
        {
            this.shouldSerialize["boleto"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrentCycle()
        {
            return this.shouldSerialize["current_cycle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomer()
        {
            return this.shouldSerialize["customer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextBillingAt()
        {
            return this.shouldSerialize["next_billing_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingDay()
        {
            return this.shouldSerialize["billing_day"];
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
        public bool ShouldSerializeCanceledAt()
        {
            return this.shouldSerialize["canceled_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDiscounts()
        {
            return this.shouldSerialize["discounts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBoletoDueDays()
        {
            return this.shouldSerialize["boleto_due_days"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBoleto()
        {
            return this.shouldSerialize["boleto"];
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

            return obj is GetSubscriptionResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.StartAt == null && other.StartAt == null) || (this.StartAt?.Equals(other.StartAt) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalCount == null && other.IntervalCount == null) || (this.IntervalCount?.Equals(other.IntervalCount) == true)) &&
                ((this.BillingType == null && other.BillingType == null) || (this.BillingType?.Equals(other.BillingType) == true)) &&
                ((this.CurrentCycle == null && other.CurrentCycle == null) || (this.CurrentCycle?.Equals(other.CurrentCycle) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Setup == null && other.Setup == null) || (this.Setup?.Equals(other.Setup) == true)) &&
                ((this.GatewayAffiliationId == null && other.GatewayAffiliationId == null) || (this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true)) &&
                ((this.NextBillingAt == null && other.NextBillingAt == null) || (this.NextBillingAt?.Equals(other.NextBillingAt) == true)) &&
                ((this.BillingDay == null && other.BillingDay == null) || (this.BillingDay?.Equals(other.BillingDay) == true)) &&
                ((this.MinimumPrice == null && other.MinimumPrice == null) || (this.MinimumPrice?.Equals(other.MinimumPrice) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Increments == null && other.Increments == null) || (this.Increments?.Equals(other.Increments) == true)) &&
                ((this.BoletoDueDays == null && other.BoletoDueDays == null) || (this.BoletoDueDays?.Equals(other.BoletoDueDays) == true)) &&
                ((this.Split == null && other.Split == null) || (this.Split?.Equals(other.Split) == true)) &&
                ((this.Boleto == null && other.Boleto == null) || (this.Boleto?.Equals(other.Boleto) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.StartAt = {(this.StartAt == null ? "null" : this.StartAt.ToString())}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval == string.Empty ? "" : this.Interval)}");
            toStringOutput.Add($"this.IntervalCount = {(this.IntervalCount == null ? "null" : this.IntervalCount.ToString())}");
            toStringOutput.Add($"this.BillingType = {(this.BillingType == null ? "null" : this.BillingType == string.Empty ? "" : this.BillingType)}");
            toStringOutput.Add($"this.CurrentCycle = {(this.CurrentCycle == null ? "null" : this.CurrentCycle.ToString())}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Setup = {(this.Setup == null ? "null" : this.Setup.ToString())}");
            toStringOutput.Add($"this.GatewayAffiliationId = {(this.GatewayAffiliationId == null ? "null" : this.GatewayAffiliationId == string.Empty ? "" : this.GatewayAffiliationId)}");
            toStringOutput.Add($"this.NextBillingAt = {(this.NextBillingAt == null ? "null" : this.NextBillingAt.ToString())}");
            toStringOutput.Add($"this.BillingDay = {(this.BillingDay == null ? "null" : this.BillingDay.ToString())}");
            toStringOutput.Add($"this.MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"this.Increments = {(this.Increments == null ? "null" : $"[{string.Join(", ", this.Increments)} ]")}");
            toStringOutput.Add($"this.BoletoDueDays = {(this.BoletoDueDays == null ? "null" : this.BoletoDueDays.ToString())}");
            toStringOutput.Add($"this.Split = {(this.Split == null ? "null" : this.Split.ToString())}");
            toStringOutput.Add($"this.Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
        }
    }
}