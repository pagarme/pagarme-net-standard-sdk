// <copyright file="GetSubscriptionResponse.cs" company="APIMatic">
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
    /// GetSubscriptionResponse.
    /// </summary>
    public class GetSubscriptionResponse
    {
        private string id;
        private string code;
        private DateTime? startAt;
        private string interval;
        private int? intervalCount;
        private string billingType;
        private Models.GetPeriodResponse currentCycle;
        private string paymentMethod;
        private string currency;
        private int? installments;
        private string status;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private Models.GetCustomerResponse customer;
        private Models.GetCardResponse card;
        private List<Models.GetSubscriptionItemResponse> items;
        private string statementDescriptor;
        private Dictionary<string, string> metadata;
        private Models.GetSetupResponse setup;
        private string gatewayAffiliationId;
        private DateTime? nextBillingAt;
        private int? billingDay;
        private int? minimumPrice;
        private DateTime? canceledAt;
        private List<Models.GetDiscountResponse> discounts;
        private List<Models.GetIncrementResponse> increments;
        private int? boletoDueDays;
        private Models.GetSubscriptionSplitResponse split;
        private Models.GetSubscriptionBoletoResponse boleto;
        private bool? manualBilling;
        private string indirectAcceptor;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "code", false },
            { "start_at", false },
            { "interval", false },
            { "interval_count", false },
            { "billing_type", false },
            { "current_cycle", false },
            { "payment_method", false },
            { "currency", false },
            { "installments", false },
            { "status", false },
            { "created_at", false },
            { "updated_at", false },
            { "customer", false },
            { "card", false },
            { "items", false },
            { "statement_descriptor", false },
            { "metadata", false },
            { "setup", false },
            { "gateway_affiliation_id", false },
            { "next_billing_at", false },
            { "billing_day", false },
            { "minimum_price", false },
            { "canceled_at", false },
            { "discounts", false },
            { "increments", false },
            { "boleto_due_days", false },
            { "split", false },
            { "boleto", false },
            { "manual_billing", false },
            { "indirect_acceptor", false },
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
        /// <param name="manualBilling">manual_billing.</param>
        /// <param name="indirectAcceptor">indirect_acceptor.</param>
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
            Models.GetSubscriptionBoletoResponse boleto = null,
            bool? manualBilling = null,
            string indirectAcceptor = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (code != null)
            {
                this.Code = code;
            }

            if (startAt != null)
            {
                this.StartAt = startAt;
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

            if (currentCycle != null)
            {
                this.CurrentCycle = currentCycle;
            }

            if (paymentMethod != null)
            {
                this.PaymentMethod = paymentMethod;
            }

            if (currency != null)
            {
                this.Currency = currency;
            }

            if (installments != null)
            {
                this.Installments = installments;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (customer != null)
            {
                this.Customer = customer;
            }

            if (card != null)
            {
                this.Card = card;
            }

            if (items != null)
            {
                this.Items = items;
            }

            if (statementDescriptor != null)
            {
                this.StatementDescriptor = statementDescriptor;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (setup != null)
            {
                this.Setup = setup;
            }

            if (gatewayAffiliationId != null)
            {
                this.GatewayAffiliationId = gatewayAffiliationId;
            }

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

            if (increments != null)
            {
                this.Increments = increments;
            }

            if (boletoDueDays != null)
            {
                this.BoletoDueDays = boletoDueDays;
            }

            if (split != null)
            {
                this.Split = split;
            }

            if (boleto != null)
            {
                this.Boleto = boleto;
            }

            if (manualBilling != null)
            {
                this.ManualBilling = manualBilling;
            }

            if (indirectAcceptor != null)
            {
                this.IndirectAcceptor = indirectAcceptor;
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
        /// Gets or sets Code.
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
        /// Gets or sets StartAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime? StartAt
        {
            get
            {
                return this.startAt;
            }

            set
            {
                this.shouldSerialize["start_at"] = true;
                this.startAt = value;
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
        [JsonProperty("payment_method")]
        public string PaymentMethod
        {
            get
            {
                return this.paymentMethod;
            }

            set
            {
                this.shouldSerialize["payment_method"] = true;
                this.paymentMethod = value;
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
        /// Gets or sets Installments.
        /// </summary>
        [JsonProperty("installments")]
        public int? Installments
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
        [JsonProperty("card")]
        public Models.GetCardResponse Card
        {
            get
            {
                return this.card;
            }

            set
            {
                this.shouldSerialize["card"] = true;
                this.card = value;
            }
        }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetSubscriptionItemResponse> Items
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
        /// Gets or sets Setup.
        /// </summary>
        [JsonProperty("setup")]
        public Models.GetSetupResponse Setup
        {
            get
            {
                return this.setup;
            }

            set
            {
                this.shouldSerialize["setup"] = true;
                this.setup = value;
            }
        }

        /// <summary>
        /// Affiliation Code
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId
        {
            get
            {
                return this.gatewayAffiliationId;
            }

            set
            {
                this.shouldSerialize["gateway_affiliation_id"] = true;
                this.gatewayAffiliationId = value;
            }
        }

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
        [JsonProperty("increments")]
        public List<Models.GetIncrementResponse> Increments
        {
            get
            {
                return this.increments;
            }

            set
            {
                this.shouldSerialize["increments"] = true;
                this.increments = value;
            }
        }

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
        [JsonProperty("split")]
        public Models.GetSubscriptionSplitResponse Split
        {
            get
            {
                return this.split;
            }

            set
            {
                this.shouldSerialize["split"] = true;
                this.split = value;
            }
        }

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

        /// <summary>
        /// Gets or sets ManualBilling.
        /// </summary>
        [JsonProperty("manual_billing")]
        public bool? ManualBilling
        {
            get
            {
                return this.manualBilling;
            }

            set
            {
                this.shouldSerialize["manual_billing"] = true;
                this.manualBilling = value;
            }
        }

        /// <summary>
        /// Business model identifier
        /// </summary>
        [JsonProperty("indirect_acceptor")]
        public string IndirectAcceptor
        {
            get
            {
                return this.indirectAcceptor;
            }

            set
            {
                this.shouldSerialize["indirect_acceptor"] = true;
                this.indirectAcceptor = value;
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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCode()
        {
            this.shouldSerialize["code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStartAt()
        {
            this.shouldSerialize["start_at"] = false;
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
        public void UnsetCurrentCycle()
        {
            this.shouldSerialize["current_cycle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentMethod()
        {
            this.shouldSerialize["payment_method"] = false;
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
        public void UnsetCustomer()
        {
            this.shouldSerialize["customer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCard()
        {
            this.shouldSerialize["card"] = false;
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
        public void UnsetStatementDescriptor()
        {
            this.shouldSerialize["statement_descriptor"] = false;
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
        public void UnsetSetup()
        {
            this.shouldSerialize["setup"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayAffiliationId()
        {
            this.shouldSerialize["gateway_affiliation_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNextBillingAt()
        {
            this.shouldSerialize["next_billing_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingDay()
        {
            this.shouldSerialize["billing_day"] = false;
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
        public void UnsetCanceledAt()
        {
            this.shouldSerialize["canceled_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDiscounts()
        {
            this.shouldSerialize["discounts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIncrements()
        {
            this.shouldSerialize["increments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBoletoDueDays()
        {
            this.shouldSerialize["boleto_due_days"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSplit()
        {
            this.shouldSerialize["split"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBoleto()
        {
            this.shouldSerialize["boleto"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetManualBilling()
        {
            this.shouldSerialize["manual_billing"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIndirectAcceptor()
        {
            this.shouldSerialize["indirect_acceptor"] = false;
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
        public bool ShouldSerializeCode()
        {
            return this.shouldSerialize["code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStartAt()
        {
            return this.shouldSerialize["start_at"];
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
        public bool ShouldSerializeCurrentCycle()
        {
            return this.shouldSerialize["current_cycle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMethod()
        {
            return this.shouldSerialize["payment_method"];
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
        public bool ShouldSerializeCustomer()
        {
            return this.shouldSerialize["customer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCard()
        {
            return this.shouldSerialize["card"];
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
        public bool ShouldSerializeStatementDescriptor()
        {
            return this.shouldSerialize["statement_descriptor"];
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
        public bool ShouldSerializeSetup()
        {
            return this.shouldSerialize["setup"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayAffiliationId()
        {
            return this.shouldSerialize["gateway_affiliation_id"];
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
        public bool ShouldSerializeIncrements()
        {
            return this.shouldSerialize["increments"];
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
        public bool ShouldSerializeSplit()
        {
            return this.shouldSerialize["split"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBoleto()
        {
            return this.shouldSerialize["boleto"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeManualBilling()
        {
            return this.shouldSerialize["manual_billing"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIndirectAcceptor()
        {
            return this.shouldSerialize["indirect_acceptor"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetSubscriptionResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.StartAt == null && other.StartAt == null ||
                 this.StartAt?.Equals(other.StartAt) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalCount == null && other.IntervalCount == null ||
                 this.IntervalCount?.Equals(other.IntervalCount) == true) &&
                (this.BillingType == null && other.BillingType == null ||
                 this.BillingType?.Equals(other.BillingType) == true) &&
                (this.CurrentCycle == null && other.CurrentCycle == null ||
                 this.CurrentCycle?.Equals(other.CurrentCycle) == true) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Setup == null && other.Setup == null ||
                 this.Setup?.Equals(other.Setup) == true) &&
                (this.GatewayAffiliationId == null && other.GatewayAffiliationId == null ||
                 this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true) &&
                (this.NextBillingAt == null && other.NextBillingAt == null ||
                 this.NextBillingAt?.Equals(other.NextBillingAt) == true) &&
                (this.BillingDay == null && other.BillingDay == null ||
                 this.BillingDay?.Equals(other.BillingDay) == true) &&
                (this.MinimumPrice == null && other.MinimumPrice == null ||
                 this.MinimumPrice?.Equals(other.MinimumPrice) == true) &&
                (this.CanceledAt == null && other.CanceledAt == null ||
                 this.CanceledAt?.Equals(other.CanceledAt) == true) &&
                (this.Discounts == null && other.Discounts == null ||
                 this.Discounts?.Equals(other.Discounts) == true) &&
                (this.Increments == null && other.Increments == null ||
                 this.Increments?.Equals(other.Increments) == true) &&
                (this.BoletoDueDays == null && other.BoletoDueDays == null ||
                 this.BoletoDueDays?.Equals(other.BoletoDueDays) == true) &&
                (this.Split == null && other.Split == null ||
                 this.Split?.Equals(other.Split) == true) &&
                (this.Boleto == null && other.Boleto == null ||
                 this.Boleto?.Equals(other.Boleto) == true) &&
                (this.ManualBilling == null && other.ManualBilling == null ||
                 this.ManualBilling?.Equals(other.ManualBilling) == true) &&
                (this.IndirectAcceptor == null && other.IndirectAcceptor == null ||
                 this.IndirectAcceptor?.Equals(other.IndirectAcceptor) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"StartAt = {(this.StartAt == null ? "null" : this.StartAt.ToString())}");
            toStringOutput.Add($"Interval = {this.Interval ?? "null"}");
            toStringOutput.Add($"IntervalCount = {(this.IntervalCount == null ? "null" : this.IntervalCount.ToString())}");
            toStringOutput.Add($"BillingType = {this.BillingType ?? "null"}");
            toStringOutput.Add($"CurrentCycle = {(this.CurrentCycle == null ? "null" : this.CurrentCycle.ToString())}");
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Setup = {(this.Setup == null ? "null" : this.Setup.ToString())}");
            toStringOutput.Add($"GatewayAffiliationId = {this.GatewayAffiliationId ?? "null"}");
            toStringOutput.Add($"NextBillingAt = {(this.NextBillingAt == null ? "null" : this.NextBillingAt.ToString())}");
            toStringOutput.Add($"BillingDay = {(this.BillingDay == null ? "null" : this.BillingDay.ToString())}");
            toStringOutput.Add($"MinimumPrice = {(this.MinimumPrice == null ? "null" : this.MinimumPrice.ToString())}");
            toStringOutput.Add($"CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"Increments = {(this.Increments == null ? "null" : $"[{string.Join(", ", this.Increments)} ]")}");
            toStringOutput.Add($"BoletoDueDays = {(this.BoletoDueDays == null ? "null" : this.BoletoDueDays.ToString())}");
            toStringOutput.Add($"Split = {(this.Split == null ? "null" : this.Split.ToString())}");
            toStringOutput.Add($"Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"ManualBilling = {(this.ManualBilling == null ? "null" : this.ManualBilling.ToString())}");
            toStringOutput.Add($"IndirectAcceptor = {this.IndirectAcceptor ?? "null"}");
        }
    }
}