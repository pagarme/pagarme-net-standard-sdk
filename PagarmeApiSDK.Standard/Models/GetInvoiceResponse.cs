// <copyright file="GetInvoiceResponse.cs" company="APIMatic">
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
    /// GetInvoiceResponse.
    /// </summary>
    public class GetInvoiceResponse
    {
        private Models.GetCustomerResponse customer;
        private Models.GetPeriodResponse cycle;
        private DateTime? dueAt;
        private DateTime? canceledAt;
        private DateTime? billingAt;
        private DateTime? seenAt;
        private int? totalDiscount;
        private int? totalIncrement;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "customer", false },
            { "cycle", false },
            { "due_at", false },
            { "canceled_at", false },
            { "billing_at", false },
            { "seen_at", false },
            { "total_discount", false },
            { "total_increment", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse"/> class.
        /// </summary>
        public GetInvoiceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="url">url.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="items">items.</param>
        /// <param name="customer">customer.</param>
        /// <param name="charge">charge.</param>
        /// <param name="installments">installments.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="cycle">cycle.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="billingAt">billing_at.</param>
        /// <param name="seenAt">seen_at.</param>
        /// <param name="totalDiscount">total_discount.</param>
        /// <param name="totalIncrement">total_increment.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        public GetInvoiceResponse(
            string id = null,
            string code = null,
            string url = null,
            int? amount = null,
            string status = null,
            string paymentMethod = null,
            DateTime? createdAt = null,
            List<Models.GetInvoiceItemResponse> items = null,
            Models.GetCustomerResponse customer = null,
            Models.GetChargeResponse charge = null,
            int? installments = null,
            Models.GetBillingAddressResponse billingAddress = null,
            Models.GetSubscriptionResponse subscription = null,
            Models.GetPeriodResponse cycle = null,
            Models.GetShippingResponse shipping = null,
            Dictionary<string, string> metadata = null,
            DateTime? dueAt = null,
            DateTime? canceledAt = null,
            DateTime? billingAt = null,
            DateTime? seenAt = null,
            int? totalDiscount = null,
            int? totalIncrement = null,
            string subscriptionId = null)
        {
            this.Id = id;
            this.Code = code;
            this.Url = url;
            this.Amount = amount;
            this.Status = status;
            this.PaymentMethod = paymentMethod;
            this.CreatedAt = createdAt;
            this.Items = items;
            if (customer != null)
            {
                this.Customer = customer;
            }

            this.Charge = charge;
            this.Installments = installments;
            this.BillingAddress = billingAddress;
            this.Subscription = subscription;
            if (cycle != null)
            {
                this.Cycle = cycle;
            }

            this.Shipping = shipping;
            this.Metadata = metadata;
            if (dueAt != null)
            {
                this.DueAt = dueAt;
            }

            if (canceledAt != null)
            {
                this.CanceledAt = canceledAt;
            }

            if (billingAt != null)
            {
                this.BillingAt = billingAt;
            }

            if (seenAt != null)
            {
                this.SeenAt = seenAt;
            }

            if (totalDiscount != null)
            {
                this.TotalDiscount = totalDiscount;
            }

            if (totalIncrement != null)
            {
                this.TotalIncrement = totalIncrement;
            }

            this.SubscriptionId = subscriptionId;
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
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Include)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Include)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetInvoiceItemResponse> Items { get; set; }

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
        /// Gets or sets Charge.
        /// </summary>
        [JsonProperty("charge", NullValueHandling = NullValueHandling.Include)]
        public Models.GetChargeResponse Charge { get; set; }

        /// <summary>
        /// Gets or sets Installments.
        /// </summary>
        [JsonProperty("installments", NullValueHandling = NullValueHandling.Include)]
        public int? Installments { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Include)]
        public Models.GetBillingAddressResponse BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Include)]
        public Models.GetSubscriptionResponse Subscription { get; set; }

        /// <summary>
        /// Gets or sets Cycle.
        /// </summary>
        [JsonProperty("cycle")]
        public Models.GetPeriodResponse Cycle
        {
            get
            {
                return this.cycle;
            }

            set
            {
                this.shouldSerialize["cycle"] = true;
                this.cycle = value;
            }
        }

        /// <summary>
        /// Gets or sets Shipping.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Include)]
        public Models.GetShippingResponse Shipping { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets DueAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime? DueAt
        {
            get
            {
                return this.dueAt;
            }

            set
            {
                this.shouldSerialize["due_at"] = true;
                this.dueAt = value;
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
        /// Gets or sets BillingAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_at")]
        public DateTime? BillingAt
        {
            get
            {
                return this.billingAt;
            }

            set
            {
                this.shouldSerialize["billing_at"] = true;
                this.billingAt = value;
            }
        }

        /// <summary>
        /// Gets or sets SeenAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("seen_at")]
        public DateTime? SeenAt
        {
            get
            {
                return this.seenAt;
            }

            set
            {
                this.shouldSerialize["seen_at"] = true;
                this.seenAt = value;
            }
        }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_discount")]
        public int? TotalDiscount
        {
            get
            {
                return this.totalDiscount;
            }

            set
            {
                this.shouldSerialize["total_discount"] = true;
                this.totalDiscount = value;
            }
        }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_increment")]
        public int? TotalIncrement
        {
            get
            {
                return this.totalIncrement;
            }

            set
            {
                this.shouldSerialize["total_increment"] = true;
                this.totalIncrement = value;
            }
        }

        /// <summary>
        /// Subscription Id
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Include)]
        public string SubscriptionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetInvoiceResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCycle()
        {
            this.shouldSerialize["cycle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
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
        public void UnsetBillingAt()
        {
            this.shouldSerialize["billing_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSeenAt()
        {
            this.shouldSerialize["seen_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalDiscount()
        {
            this.shouldSerialize["total_discount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalIncrement()
        {
            this.shouldSerialize["total_increment"] = false;
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
        public bool ShouldSerializeCycle()
        {
            return this.shouldSerialize["cycle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueAt()
        {
            return this.shouldSerialize["due_at"];
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
        public bool ShouldSerializeBillingAt()
        {
            return this.shouldSerialize["billing_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSeenAt()
        {
            return this.shouldSerialize["seen_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalDiscount()
        {
            return this.shouldSerialize["total_discount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalIncrement()
        {
            return this.shouldSerialize["total_increment"];
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

            return obj is GetInvoiceResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Charge == null && other.Charge == null) || (this.Charge?.Equals(other.Charge) == true)) &&
                ((this.Installments == null && other.Installments == null) || (this.Installments?.Equals(other.Installments) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true)) &&
                ((this.Cycle == null && other.Cycle == null) || (this.Cycle?.Equals(other.Cycle) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.DueAt == null && other.DueAt == null) || (this.DueAt?.Equals(other.DueAt) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.BillingAt == null && other.BillingAt == null) || (this.BillingAt?.Equals(other.BillingAt) == true)) &&
                ((this.SeenAt == null && other.SeenAt == null) || (this.SeenAt?.Equals(other.SeenAt) == true)) &&
                ((this.TotalDiscount == null && other.TotalDiscount == null) || (this.TotalDiscount?.Equals(other.TotalDiscount) == true)) &&
                ((this.TotalIncrement == null && other.TotalIncrement == null) || (this.TotalIncrement?.Equals(other.TotalIncrement) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Charge = {(this.Charge == null ? "null" : this.Charge.ToString())}");
            toStringOutput.Add($"this.Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"this.Cycle = {(this.Cycle == null ? "null" : this.Cycle.ToString())}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"this.BillingAt = {(this.BillingAt == null ? "null" : this.BillingAt.ToString())}");
            toStringOutput.Add($"this.SeenAt = {(this.SeenAt == null ? "null" : this.SeenAt.ToString())}");
            toStringOutput.Add($"this.TotalDiscount = {(this.TotalDiscount == null ? "null" : this.TotalDiscount.ToString())}");
            toStringOutput.Add($"this.TotalIncrement = {(this.TotalIncrement == null ? "null" : this.TotalIncrement.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId == string.Empty ? "" : this.SubscriptionId)}");
        }
    }
}