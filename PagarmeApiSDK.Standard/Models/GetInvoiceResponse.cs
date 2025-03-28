// <copyright file="GetInvoiceResponse.cs" company="APIMatic">
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
    /// GetInvoiceResponse.
    /// </summary>
    public class GetInvoiceResponse
    {
        private string id;
        private string code;
        private string url;
        private int? amount;
        private string status;
        private string paymentMethod;
        private DateTime? createdAt;
        private List<Models.GetInvoiceItemResponse> items;
        private Models.GetCustomerResponse customer;
        private Models.GetChargeResponse charge;
        private int? installments;
        private Models.GetBillingAddressResponse billingAddress;
        private Models.GetSubscriptionResponse subscription;
        private Models.GetPeriodResponse cycle;
        private Models.GetShippingResponse shipping;
        private Dictionary<string, string> metadata;
        private DateTime? dueAt;
        private DateTime? canceledAt;
        private DateTime? billingAt;
        private DateTime? seenAt;
        private int? totalDiscount;
        private int? totalIncrement;
        private string subscriptionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "code", false },
            { "url", false },
            { "amount", false },
            { "status", false },
            { "payment_method", false },
            { "created_at", false },
            { "items", false },
            { "customer", false },
            { "charge", false },
            { "installments", false },
            { "billing_address", false },
            { "subscription", false },
            { "cycle", false },
            { "shipping", false },
            { "metadata", false },
            { "due_at", false },
            { "canceled_at", false },
            { "billing_at", false },
            { "seen_at", false },
            { "total_discount", false },
            { "total_increment", false },
            { "subscription_id", false },
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

            if (id != null)
            {
                this.Id = id;
            }

            if (code != null)
            {
                this.Code = code;
            }

            if (url != null)
            {
                this.Url = url;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (paymentMethod != null)
            {
                this.PaymentMethod = paymentMethod;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (items != null)
            {
                this.Items = items;
            }

            if (customer != null)
            {
                this.Customer = customer;
            }

            if (charge != null)
            {
                this.Charge = charge;
            }

            if (installments != null)
            {
                this.Installments = installments;
            }

            if (billingAddress != null)
            {
                this.BillingAddress = billingAddress;
            }

            if (subscription != null)
            {
                this.Subscription = subscription;
            }

            if (cycle != null)
            {
                this.Cycle = cycle;
            }

            if (shipping != null)
            {
                this.Shipping = shipping;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

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

            if (subscriptionId != null)
            {
                this.SubscriptionId = subscriptionId;
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
        /// Gets or sets Amount.
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
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetInvoiceItemResponse> Items
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
        [JsonProperty("charge")]
        public Models.GetChargeResponse Charge
        {
            get
            {
                return this.charge;
            }

            set
            {
                this.shouldSerialize["charge"] = true;
                this.charge = value;
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
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.GetBillingAddressResponse BillingAddress
        {
            get
            {
                return this.billingAddress;
            }

            set
            {
                this.shouldSerialize["billing_address"] = true;
                this.billingAddress = value;
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
        [JsonProperty("shipping")]
        public Models.GetShippingResponse Shipping
        {
            get
            {
                return this.shipping;
            }

            set
            {
                this.shouldSerialize["shipping"] = true;
                this.shipping = value;
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
        [JsonProperty("subscription_id")]
        public string SubscriptionId
        {
            get
            {
                return this.subscriptionId;
            }

            set
            {
                this.shouldSerialize["subscription_id"] = true;
                this.subscriptionId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetInvoiceResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetUrl()
        {
            this.shouldSerialize["url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
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
        public void UnsetPaymentMethod()
        {
            this.shouldSerialize["payment_method"] = false;
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
        public void UnsetItems()
        {
            this.shouldSerialize["items"] = false;
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
        public void UnsetCharge()
        {
            this.shouldSerialize["charge"] = false;
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
        public void UnsetBillingAddress()
        {
            this.shouldSerialize["billing_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubscription()
        {
            this.shouldSerialize["subscription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCycle()
        {
            this.shouldSerialize["cycle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetShipping()
        {
            this.shouldSerialize["shipping"] = false;
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
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
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
        public void UnsetBillingAt()
        {
            this.shouldSerialize["billing_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSeenAt()
        {
            this.shouldSerialize["seen_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTotalDiscount()
        {
            this.shouldSerialize["total_discount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTotalIncrement()
        {
            this.shouldSerialize["total_increment"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubscriptionId()
        {
            this.shouldSerialize["subscription_id"] = false;
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
        public bool ShouldSerializeUrl()
        {
            return this.shouldSerialize["url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
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
        public bool ShouldSerializePaymentMethod()
        {
            return this.shouldSerialize["payment_method"];
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
        public bool ShouldSerializeItems()
        {
            return this.shouldSerialize["items"];
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
        public bool ShouldSerializeCharge()
        {
            return this.shouldSerialize["charge"];
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
        public bool ShouldSerializeBillingAddress()
        {
            return this.shouldSerialize["billing_address"];
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
        public bool ShouldSerializeCycle()
        {
            return this.shouldSerialize["cycle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShipping()
        {
            return this.shouldSerialize["shipping"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionId()
        {
            return this.shouldSerialize["subscription_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetInvoiceResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Charge == null && other.Charge == null ||
                 this.Charge?.Equals(other.Charge) == true) &&
                (this.Installments == null && other.Installments == null ||
                 this.Installments?.Equals(other.Installments) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.Subscription == null && other.Subscription == null ||
                 this.Subscription?.Equals(other.Subscription) == true) &&
                (this.Cycle == null && other.Cycle == null ||
                 this.Cycle?.Equals(other.Cycle) == true) &&
                (this.Shipping == null && other.Shipping == null ||
                 this.Shipping?.Equals(other.Shipping) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.DueAt == null && other.DueAt == null ||
                 this.DueAt?.Equals(other.DueAt) == true) &&
                (this.CanceledAt == null && other.CanceledAt == null ||
                 this.CanceledAt?.Equals(other.CanceledAt) == true) &&
                (this.BillingAt == null && other.BillingAt == null ||
                 this.BillingAt?.Equals(other.BillingAt) == true) &&
                (this.SeenAt == null && other.SeenAt == null ||
                 this.SeenAt?.Equals(other.SeenAt) == true) &&
                (this.TotalDiscount == null && other.TotalDiscount == null ||
                 this.TotalDiscount?.Equals(other.TotalDiscount) == true) &&
                (this.TotalIncrement == null && other.TotalIncrement == null ||
                 this.TotalIncrement?.Equals(other.TotalIncrement) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Charge = {(this.Charge == null ? "null" : this.Charge.ToString())}");
            toStringOutput.Add($"Installments = {(this.Installments == null ? "null" : this.Installments.ToString())}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"Cycle = {(this.Cycle == null ? "null" : this.Cycle.ToString())}");
            toStringOutput.Add($"Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"BillingAt = {(this.BillingAt == null ? "null" : this.BillingAt.ToString())}");
            toStringOutput.Add($"SeenAt = {(this.SeenAt == null ? "null" : this.SeenAt.ToString())}");
            toStringOutput.Add($"TotalDiscount = {(this.TotalDiscount == null ? "null" : this.TotalDiscount.ToString())}");
            toStringOutput.Add($"TotalIncrement = {(this.TotalIncrement == null ? "null" : this.TotalIncrement.ToString())}");
            toStringOutput.Add($"SubscriptionId = {this.SubscriptionId ?? "null"}");
        }
    }
}