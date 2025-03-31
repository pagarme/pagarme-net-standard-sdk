// <copyright file="CreateSubscriptionRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionRequest.
    /// </summary>
    public class CreateSubscriptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        public CreateSubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="card">card.</param>
        /// <param name="code">code.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="billingType">billing_type.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="description">description.</param>
        /// <param name="currency">currency.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalCount">interval_count.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="items">items.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="increments">increments.</param>
        /// <param name="setup">setup.</param>
        /// <param name="planId">plan_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="billingDay">billing_day.</param>
        /// <param name="installments">installments.</param>
        /// <param name="startAt">start_at.</param>
        /// <param name="minimumPrice">minimum_price.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="cardToken">card_token.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="boletoDueDays">boleto_due_days.</param>
        /// <param name="period">period.</param>
        /// <param name="submerchant">submerchant.</param>
        /// <param name="split">split.</param>
        /// <param name="boleto">boleto.</param>
        /// <param name="indirectAcceptor">indirect_acceptor.</param>
        public CreateSubscriptionRequest(
            Models.CreateCustomerRequest customer,
            Models.CreateCardRequest card,
            string code,
            string paymentMethod,
            string billingType,
            string statementDescriptor,
            string description,
            string currency,
            string interval,
            int intervalCount,
            Models.CreatePricingSchemeRequest pricingScheme,
            List<Models.CreateSubscriptionItemRequest> items,
            Models.CreateShippingRequest shipping,
            List<Models.CreateDiscountRequest> discounts,
            Dictionary<string, string> metadata,
            List<Models.CreateIncrementRequest> increments,
            Models.CreateSetupRequest setup = null,
            string planId = null,
            string customerId = null,
            string cardId = null,
            int? billingDay = null,
            int? installments = null,
            DateTime? startAt = null,
            int? minimumPrice = null,
            int? cycles = null,
            string cardToken = null,
            string gatewayAffiliationId = null,
            int? quantity = null,
            int? boletoDueDays = null,
            Models.CreatePeriodRequest period = null,
            Models.CreateSubMerchantRequest submerchant = null,
            Models.CreateSubscriptionSplitRequest split = null,
            Models.CreateSubscriptionBoletoRequest boleto = null,
            string indirectAcceptor = null)
        {
            this.Customer = customer;
            this.Card = card;
            this.Code = code;
            this.PaymentMethod = paymentMethod;
            this.BillingType = billingType;
            this.StatementDescriptor = statementDescriptor;
            this.Description = description;
            this.Currency = currency;
            this.Interval = interval;
            this.IntervalCount = intervalCount;
            this.PricingScheme = pricingScheme;
            this.Items = items;
            this.Shipping = shipping;
            this.Discounts = discounts;
            this.Metadata = metadata;
            this.Setup = setup;
            this.PlanId = planId;
            this.CustomerId = customerId;
            this.CardId = cardId;
            this.BillingDay = billingDay;
            this.Installments = installments;
            this.StartAt = startAt;
            this.MinimumPrice = minimumPrice;
            this.Cycles = cycles;
            this.CardToken = cardToken;
            this.GatewayAffiliationId = gatewayAffiliationId;
            this.Quantity = quantity;
            this.BoletoDueDays = boletoDueDays;
            this.Increments = increments;
            this.Period = period;
            this.Submerchant = submerchant;
            this.Split = split;
            this.Boleto = boleto;
            this.IndirectAcceptor = indirectAcceptor;
        }

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer { get; set; }

        /// <summary>
        /// Card
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// Subscription code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType { get; set; }

        /// <summary>
        /// Statement descriptor for credit card subscriptions
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Subscription description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

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
        /// Subscription pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.CreatePricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        /// Subscription items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreateSubscriptionItemRequest> Items { get; set; }

        /// <summary>
        /// Shipping
        /// </summary>
        [JsonProperty("shipping")]
        public Models.CreateShippingRequest Shipping { get; set; }

        /// <summary>
        /// Discounts
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.CreateDiscountRequest> Discounts { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Setup data
        /// </summary>
        [JsonProperty("setup", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSetupRequest Setup { get; set; }

        /// <summary>
        /// Plan id
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// Customer id
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Card id
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; set; }

        /// <summary>
        /// Billing day
        /// </summary>
        [JsonProperty("billing_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingDay { get; set; }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
        public int? Installments { get; set; }

        /// <summary>
        /// Subscription start date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Subscription minimum price
        /// </summary>
        [JsonProperty("minimum_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumPrice { get; set; }

        /// <summary>
        /// Number of cycles
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Card token
        /// </summary>
        [JsonProperty("card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CardToken { get; set; }

        /// <summary>
        /// Gateway Affiliation code
        /// </summary>
        [JsonProperty("gateway_affiliation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayAffiliationId { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Days until boleto expires
        /// </summary>
        [JsonProperty("boleto_due_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? BoletoDueDays { get; set; }

        /// <summary>
        /// Increments
        /// </summary>
        [JsonProperty("increments")]
        public List<Models.CreateIncrementRequest> Increments { get; set; }

        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePeriodRequest Period { get; set; }

        /// <summary>
        /// SubMerchant
        /// </summary>
        [JsonProperty("submerchant", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubMerchantRequest Submerchant { get; set; }

        /// <summary>
        /// Subscription's split
        /// </summary>
        [JsonProperty("split", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubscriptionSplitRequest Split { get; set; }

        /// <summary>
        /// Information about fines and interest on the "boleto" used from payment
        /// </summary>
        [JsonProperty("boleto", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubscriptionBoletoRequest Boleto { get; set; }

        /// <summary>
        /// Business model identifier
        /// </summary>
        [JsonProperty("indirect_acceptor", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectAcceptor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSubscriptionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSubscriptionRequest other &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.BillingType == null && other.BillingType == null ||
                 this.BillingType?.Equals(other.BillingType) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalCount.Equals(other.IntervalCount)) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.Shipping == null && other.Shipping == null ||
                 this.Shipping?.Equals(other.Shipping) == true) &&
                (this.Discounts == null && other.Discounts == null ||
                 this.Discounts?.Equals(other.Discounts) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Setup == null && other.Setup == null ||
                 this.Setup?.Equals(other.Setup) == true) &&
                (this.PlanId == null && other.PlanId == null ||
                 this.PlanId?.Equals(other.PlanId) == true) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.BillingDay == null && other.BillingDay == null ||
                 this.BillingDay?.Equals(other.BillingDay) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.StartAt == null && other.StartAt == null ||
                 this.StartAt?.Equals(other.StartAt) == true) &&
                (this.MinimumPrice == null && other.MinimumPrice == null ||
                 this.MinimumPrice?.Equals(other.MinimumPrice) == true) &&
                (this.Cycles == null && other.Cycles == null ||
                 this.Cycles?.Equals(other.Cycles) == true) &&
                (this.CardToken == null && other.CardToken == null ||
                 this.CardToken?.Equals(other.CardToken) == true) &&
                (this.GatewayAffiliationId == null && other.GatewayAffiliationId == null ||
                 this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.BoletoDueDays == null && other.BoletoDueDays == null ||
                 this.BoletoDueDays?.Equals(other.BoletoDueDays) == true) &&
                (this.Increments == null && other.Increments == null ||
                 this.Increments?.Equals(other.Increments) == true) &&
                (this.Period == null && other.Period == null ||
                 this.Period?.Equals(other.Period) == true) &&
                (this.Submerchant == null && other.Submerchant == null ||
                 this.Submerchant?.Equals(other.Submerchant) == true) &&
                (this.Split == null && other.Split == null ||
                 this.Split?.Equals(other.Split) == true) &&
                (this.Boleto == null && other.Boleto == null ||
                 this.Boleto?.Equals(other.Boleto) == true) &&
                (this.IndirectAcceptor == null && other.IndirectAcceptor == null ||
                 this.IndirectAcceptor?.Equals(other.IndirectAcceptor) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod ?? "null"}");
            toStringOutput.Add($"BillingType = {this.BillingType ?? "null"}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Interval = {this.Interval ?? "null"}");
            toStringOutput.Add($"IntervalCount = {this.IntervalCount}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Setup = {(this.Setup == null ? "null" : this.Setup.ToString())}");
            toStringOutput.Add($"PlanId = {this.PlanId ?? "null"}");
            toStringOutput.Add($"CustomerId = {this.CustomerId ?? "null"}");
            toStringOutput.Add($"CardId = {this.CardId ?? "null"}");
            toStringOutput.Add($"BillingDay = {(this.BillingDay == null ? "null" : this.BillingDay.ToString())}");
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"StartAt = {(this.StartAt == null ? "null" : this.StartAt.ToString())}");
            toStringOutput.Add($"MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"CardToken = {this.CardToken ?? "null"}");
            toStringOutput.Add($"GatewayAffiliationId = {this.GatewayAffiliationId ?? "null"}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"BoletoDueDays = {(this.BoletoDueDays == null ? "null" : this.BoletoDueDays.ToString())}");
            toStringOutput.Add($"Increments = {(this.Increments == null ? "null" : $"[{string.Join(", ", this.Increments)} ]")}");
            toStringOutput.Add($"Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"Submerchant = {(this.Submerchant == null ? "null" : this.Submerchant.ToString())}");
            toStringOutput.Add($"Split = {(this.Split == null ? "null" : this.Split.ToString())}");
            toStringOutput.Add($"Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"IndirectAcceptor = {this.IndirectAcceptor ?? "null"}");
        }
    }
}