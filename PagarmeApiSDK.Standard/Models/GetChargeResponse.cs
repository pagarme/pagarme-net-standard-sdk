// <copyright file="GetChargeResponse.cs" company="APIMatic">
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
    /// GetChargeResponse.
    /// </summary>
    public class GetChargeResponse
    {
        private string id;
        private string code;
        private string gatewayId;
        private int? amount;
        private string status;
        private string currency;
        private string paymentMethod;
        private DateTime? dueAt;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private Models.GetTransactionResponse lastTransaction;
        private Models.GetInvoiceResponse invoice;
        private Models.GetOrderResponse order;
        private Models.GetCustomerResponse customer;
        private Dictionary<string, string> metadata;
        private DateTime? paidAt;
        private DateTime? canceledAt;
        private int? canceledAmount;
        private int? paidAmount;
        private int? interestAndFinePaid;
        private string recurrencyCycle;
        private Models.GetPaymentOriginResponse paymentOrigin;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "code", false },
            { "gateway_id", false },
            { "amount", false },
            { "status", false },
            { "currency", false },
            { "payment_method", false },
            { "due_at", false },
            { "created_at", false },
            { "updated_at", false },
            { "last_transaction", false },
            { "invoice", false },
            { "order", false },
            { "customer", false },
            { "metadata", false },
            { "paid_at", false },
            { "canceled_at", false },
            { "canceled_amount", false },
            { "paid_amount", false },
            { "interest_and_fine_paid", false },
            { "recurrency_cycle", false },
            { "payment_origin", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargeResponse"/> class.
        /// </summary>
        public GetChargeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargeResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="currency">currency.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="lastTransaction">last_transaction.</param>
        /// <param name="invoice">invoice.</param>
        /// <param name="order">order.</param>
        /// <param name="customer">customer.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="paidAt">paid_at.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="canceledAmount">canceled_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="interestAndFinePaid">interest_and_fine_paid.</param>
        /// <param name="recurrencyCycle">recurrency_cycle.</param>
        /// <param name="paymentOrigin">payment_origin.</param>
        public GetChargeResponse(
            string id = null,
            string code = null,
            string gatewayId = null,
            int? amount = null,
            string status = null,
            string currency = null,
            string paymentMethod = null,
            DateTime? dueAt = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            Models.GetTransactionResponse lastTransaction = null,
            Models.GetInvoiceResponse invoice = null,
            Models.GetOrderResponse order = null,
            Models.GetCustomerResponse customer = null,
            Dictionary<string, string> metadata = null,
            DateTime? paidAt = null,
            DateTime? canceledAt = null,
            int? canceledAmount = null,
            int? paidAmount = null,
            int? interestAndFinePaid = null,
            string recurrencyCycle = null,
            Models.GetPaymentOriginResponse paymentOrigin = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (code != null)
            {
                this.Code = code;
            }

            if (gatewayId != null)
            {
                this.GatewayId = gatewayId;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (currency != null)
            {
                this.Currency = currency;
            }

            if (paymentMethod != null)
            {
                this.PaymentMethod = paymentMethod;
            }

            if (dueAt != null)
            {
                this.DueAt = dueAt;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (lastTransaction != null)
            {
                this.LastTransaction = lastTransaction;
            }

            if (invoice != null)
            {
                this.Invoice = invoice;
            }

            if (order != null)
            {
                this.Order = order;
            }

            if (customer != null)
            {
                this.Customer = customer;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (paidAt != null)
            {
                this.PaidAt = paidAt;
            }

            if (canceledAt != null)
            {
                this.CanceledAt = canceledAt;
            }

            if (canceledAmount != null)
            {
                this.CanceledAmount = canceledAmount;
            }

            if (paidAmount != null)
            {
                this.PaidAmount = paidAmount;
            }

            if (interestAndFinePaid != null)
            {
                this.InterestAndFinePaid = interestAndFinePaid;
            }

            if (recurrencyCycle != null)
            {
                this.RecurrencyCycle = recurrencyCycle;
            }

            if (paymentOrigin != null)
            {
                this.PaymentOrigin = paymentOrigin;
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
        /// Gets or sets GatewayId.
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId
        {
            get
            {
                return this.gatewayId;
            }

            set
            {
                this.shouldSerialize["gateway_id"] = true;
                this.gatewayId = value;
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
        /// Gets or sets LastTransaction.
        /// </summary>
        [JsonProperty("last_transaction")]
        public Models.GetTransactionResponse LastTransaction
        {
            get
            {
                return this.lastTransaction;
            }

            set
            {
                this.shouldSerialize["last_transaction"] = true;
                this.lastTransaction = value;
            }
        }

        /// <summary>
        /// Gets or sets Invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public Models.GetInvoiceResponse Invoice
        {
            get
            {
                return this.invoice;
            }

            set
            {
                this.shouldSerialize["invoice"] = true;
                this.invoice = value;
            }
        }

        /// <summary>
        /// Gets or sets Order.
        /// </summary>
        [JsonProperty("order")]
        public Models.GetOrderResponse Order
        {
            get
            {
                return this.order;
            }

            set
            {
                this.shouldSerialize["order"] = true;
                this.order = value;
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
        /// Gets or sets PaidAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at")]
        public DateTime? PaidAt
        {
            get
            {
                return this.paidAt;
            }

            set
            {
                this.shouldSerialize["paid_at"] = true;
                this.paidAt = value;
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
        /// Canceled Amount
        /// </summary>
        [JsonProperty("canceled_amount")]
        public int? CanceledAmount
        {
            get
            {
                return this.canceledAmount;
            }

            set
            {
                this.shouldSerialize["canceled_amount"] = true;
                this.canceledAmount = value;
            }
        }

        /// <summary>
        /// Paid amount
        /// </summary>
        [JsonProperty("paid_amount")]
        public int? PaidAmount
        {
            get
            {
                return this.paidAmount;
            }

            set
            {
                this.shouldSerialize["paid_amount"] = true;
                this.paidAmount = value;
            }
        }

        /// <summary>
        /// interest and fine paid
        /// </summary>
        [JsonProperty("interest_and_fine_paid")]
        public int? InterestAndFinePaid
        {
            get
            {
                return this.interestAndFinePaid;
            }

            set
            {
                this.shouldSerialize["interest_and_fine_paid"] = true;
                this.interestAndFinePaid = value;
            }
        }

        /// <summary>
        /// Defines whether the card has been used one or more times.
        /// </summary>
        [JsonProperty("recurrency_cycle")]
        public string RecurrencyCycle
        {
            get
            {
                return this.recurrencyCycle;
            }

            set
            {
                this.shouldSerialize["recurrency_cycle"] = true;
                this.recurrencyCycle = value;
            }
        }

        /// <summary>
        /// Gets or sets PaymentOrigin.
        /// </summary>
        [JsonProperty("payment_origin")]
        public Models.GetPaymentOriginResponse PaymentOrigin
        {
            get
            {
                return this.paymentOrigin;
            }

            set
            {
                this.shouldSerialize["payment_origin"] = true;
                this.paymentOrigin = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetChargeResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetGatewayId()
        {
            this.shouldSerialize["gateway_id"] = false;
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
        public void UnsetCurrency()
        {
            this.shouldSerialize["currency"] = false;
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
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
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
        public void UnsetLastTransaction()
        {
            this.shouldSerialize["last_transaction"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInvoice()
        {
            this.shouldSerialize["invoice"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOrder()
        {
            this.shouldSerialize["order"] = false;
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
        public void UnsetMetadata()
        {
            this.shouldSerialize["metadata"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaidAt()
        {
            this.shouldSerialize["paid_at"] = false;
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
        public void UnsetCanceledAmount()
        {
            this.shouldSerialize["canceled_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaidAmount()
        {
            this.shouldSerialize["paid_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInterestAndFinePaid()
        {
            this.shouldSerialize["interest_and_fine_paid"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRecurrencyCycle()
        {
            this.shouldSerialize["recurrency_cycle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentOrigin()
        {
            this.shouldSerialize["payment_origin"] = false;
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
        public bool ShouldSerializeGatewayId()
        {
            return this.shouldSerialize["gateway_id"];
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
        public bool ShouldSerializeCurrency()
        {
            return this.shouldSerialize["currency"];
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
        public bool ShouldSerializeDueAt()
        {
            return this.shouldSerialize["due_at"];
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
        public bool ShouldSerializeLastTransaction()
        {
            return this.shouldSerialize["last_transaction"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoice()
        {
            return this.shouldSerialize["invoice"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOrder()
        {
            return this.shouldSerialize["order"];
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
        public bool ShouldSerializeMetadata()
        {
            return this.shouldSerialize["metadata"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidAt()
        {
            return this.shouldSerialize["paid_at"];
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
        public bool ShouldSerializeCanceledAmount()
        {
            return this.shouldSerialize["canceled_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidAmount()
        {
            return this.shouldSerialize["paid_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInterestAndFinePaid()
        {
            return this.shouldSerialize["interest_and_fine_paid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecurrencyCycle()
        {
            return this.shouldSerialize["recurrency_cycle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentOrigin()
        {
            return this.shouldSerialize["payment_origin"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetChargeResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.GatewayId == null && other.GatewayId == null ||
                 this.GatewayId?.Equals(other.GatewayId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.DueAt == null && other.DueAt == null ||
                 this.DueAt?.Equals(other.DueAt) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.LastTransaction == null && other.LastTransaction == null ||
                 this.LastTransaction?.Equals(other.LastTransaction) == true) &&
                (this.Invoice == null && other.Invoice == null ||
                 this.Invoice?.Equals(other.Invoice) == true) &&
                (this.Order == null && other.Order == null ||
                 this.Order?.Equals(other.Order) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.PaidAt == null && other.PaidAt == null ||
                 this.PaidAt?.Equals(other.PaidAt) == true) &&
                (this.CanceledAt == null && other.CanceledAt == null ||
                 this.CanceledAt?.Equals(other.CanceledAt) == true) &&
                (this.CanceledAmount == null && other.CanceledAmount == null ||
                 this.CanceledAmount?.Equals(other.CanceledAmount) == true) &&
                (this.PaidAmount == null && other.PaidAmount == null ||
                 this.PaidAmount?.Equals(other.PaidAmount) == true) &&
                (this.InterestAndFinePaid == null && other.InterestAndFinePaid == null ||
                 this.InterestAndFinePaid?.Equals(other.InterestAndFinePaid) == true) &&
                (this.RecurrencyCycle == null && other.RecurrencyCycle == null ||
                 this.RecurrencyCycle?.Equals(other.RecurrencyCycle) == true) &&
                (this.PaymentOrigin == null && other.PaymentOrigin == null ||
                 this.PaymentOrigin?.Equals(other.PaymentOrigin) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"GatewayId = {this.GatewayId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod ?? "null"}");
            toStringOutput.Add($"DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"LastTransaction = {(this.LastTransaction == null ? "null" : this.LastTransaction.ToString())}");
            toStringOutput.Add($"Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");
            toStringOutput.Add($"Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"PaidAt = {(this.PaidAt == null ? "null" : this.PaidAt.ToString())}");
            toStringOutput.Add($"CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt.ToString())}");
            toStringOutput.Add($"CanceledAmount = {(this.CanceledAmount == null ? "null" : this.CanceledAmount.ToString())}");
            toStringOutput.Add($"PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount.ToString())}");
            toStringOutput.Add($"InterestAndFinePaid = {(this.InterestAndFinePaid == null ? "null" : this.InterestAndFinePaid.ToString())}");
            toStringOutput.Add($"RecurrencyCycle = {this.RecurrencyCycle ?? "null"}");
            toStringOutput.Add($"PaymentOrigin = {(this.PaymentOrigin == null ? "null" : this.PaymentOrigin.ToString())}");
        }
    }
}