// <copyright file="GetOrderResponse.cs" company="APIMatic">
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
    /// GetOrderResponse.
    /// </summary>
    public class GetOrderResponse
    {
        private string id;
        private string code;
        private int? amount;
        private string currency;
        private bool? closed;
        private List<Models.GetOrderItemResponse> items;
        private Models.GetCustomerResponse customer;
        private string status;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private DateTime? closedAt;
        private List<Models.GetChargeResponse> charges;
        private string invoiceUrl;
        private Models.GetShippingResponse shipping;
        private Dictionary<string, string> metadata;
        private List<Models.GetCheckoutPaymentResponse> checkouts;
        private string ip;
        private string sessionId;
        private Models.GetLocationResponse location;
        private Models.GetDeviceResponse device;
        private Models.GetIntegrationResponse integration;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "code", false },
            { "amount", false },
            { "currency", false },
            { "closed", false },
            { "items", false },
            { "customer", false },
            { "status", false },
            { "created_at", false },
            { "updated_at", false },
            { "closed_at", false },
            { "charges", false },
            { "invoice_url", false },
            { "shipping", false },
            { "metadata", false },
            { "checkouts", false },
            { "ip", false },
            { "session_id", false },
            { "location", false },
            { "device", false },
            { "integration", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponse"/> class.
        /// </summary>
        public GetOrderResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">code.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="closed">closed.</param>
        /// <param name="items">items.</param>
        /// <param name="customer">customer.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="closedAt">closed_at.</param>
        /// <param name="charges">charges.</param>
        /// <param name="invoiceUrl">invoice_url.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="checkouts">checkouts.</param>
        /// <param name="ip">ip.</param>
        /// <param name="sessionId">session_id.</param>
        /// <param name="location">location.</param>
        /// <param name="device">device.</param>
        /// <param name="integration">integration.</param>
        public GetOrderResponse(
            string id = null,
            string code = null,
            int? amount = null,
            string currency = null,
            bool? closed = null,
            List<Models.GetOrderItemResponse> items = null,
            Models.GetCustomerResponse customer = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? closedAt = null,
            List<Models.GetChargeResponse> charges = null,
            string invoiceUrl = null,
            Models.GetShippingResponse shipping = null,
            Dictionary<string, string> metadata = null,
            List<Models.GetCheckoutPaymentResponse> checkouts = null,
            string ip = null,
            string sessionId = null,
            Models.GetLocationResponse location = null,
            Models.GetDeviceResponse device = null,
            Models.GetIntegrationResponse integration = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (code != null)
            {
                this.Code = code;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (currency != null)
            {
                this.Currency = currency;
            }

            if (closed != null)
            {
                this.Closed = closed;
            }

            if (items != null)
            {
                this.Items = items;
            }

            if (customer != null)
            {
                this.Customer = customer;
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

            if (closedAt != null)
            {
                this.ClosedAt = closedAt;
            }

            if (charges != null)
            {
                this.Charges = charges;
            }

            if (invoiceUrl != null)
            {
                this.InvoiceUrl = invoiceUrl;
            }

            if (shipping != null)
            {
                this.Shipping = shipping;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (checkouts != null)
            {
                this.Checkouts = checkouts;
            }

            if (ip != null)
            {
                this.Ip = ip;
            }

            if (sessionId != null)
            {
                this.SessionId = sessionId;
            }

            if (location != null)
            {
                this.Location = location;
            }

            if (device != null)
            {
                this.Device = device;
            }

            if (integration != null)
            {
                this.Integration = integration;
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
        /// Indicates whether the order is closed
        /// </summary>
        [JsonProperty("closed")]
        public bool? Closed
        {
            get
            {
                return this.closed;
            }

            set
            {
                this.shouldSerialize["closed"] = true;
                this.closed = value;
            }
        }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetOrderItemResponse> Items
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
        /// Gets or sets ClosedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt
        {
            get
            {
                return this.closedAt;
            }

            set
            {
                this.shouldSerialize["closed_at"] = true;
                this.closedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets Charges.
        /// </summary>
        [JsonProperty("charges")]
        public List<Models.GetChargeResponse> Charges
        {
            get
            {
                return this.charges;
            }

            set
            {
                this.shouldSerialize["charges"] = true;
                this.charges = value;
            }
        }

        /// <summary>
        /// Gets or sets InvoiceUrl.
        /// </summary>
        [JsonProperty("invoice_url")]
        public string InvoiceUrl
        {
            get
            {
                return this.invoiceUrl;
            }

            set
            {
                this.shouldSerialize["invoice_url"] = true;
                this.invoiceUrl = value;
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
        /// Checkout Payment Settings Response
        /// </summary>
        [JsonProperty("checkouts")]
        public List<Models.GetCheckoutPaymentResponse> Checkouts
        {
            get
            {
                return this.checkouts;
            }

            set
            {
                this.shouldSerialize["checkouts"] = true;
                this.checkouts = value;
            }
        }

        /// <summary>
        /// Ip address
        /// </summary>
        [JsonProperty("ip")]
        public string Ip
        {
            get
            {
                return this.ip;
            }

            set
            {
                this.shouldSerialize["ip"] = true;
                this.ip = value;
            }
        }

        /// <summary>
        /// Session id
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId
        {
            get
            {
                return this.sessionId;
            }

            set
            {
                this.shouldSerialize["session_id"] = true;
                this.sessionId = value;
            }
        }

        /// <summary>
        /// Location
        /// </summary>
        [JsonProperty("location")]
        public Models.GetLocationResponse Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.shouldSerialize["location"] = true;
                this.location = value;
            }
        }

        /// <summary>
        /// Device's informations
        /// </summary>
        [JsonProperty("device")]
        public Models.GetDeviceResponse Device
        {
            get
            {
                return this.device;
            }

            set
            {
                this.shouldSerialize["device"] = true;
                this.device = value;
            }
        }

        /// <summary>
        /// Gets or sets Integration.
        /// </summary>
        [JsonProperty("integration")]
        public Models.GetIntegrationResponse Integration
        {
            get
            {
                return this.integration;
            }

            set
            {
                this.shouldSerialize["integration"] = true;
                this.integration = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetOrderResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
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
        public void UnsetClosed()
        {
            this.shouldSerialize["closed"] = false;
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
        public void UnsetClosedAt()
        {
            this.shouldSerialize["closed_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCharges()
        {
            this.shouldSerialize["charges"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInvoiceUrl()
        {
            this.shouldSerialize["invoice_url"] = false;
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
        public void UnsetCheckouts()
        {
            this.shouldSerialize["checkouts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIp()
        {
            this.shouldSerialize["ip"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSessionId()
        {
            this.shouldSerialize["session_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLocation()
        {
            this.shouldSerialize["location"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDevice()
        {
            this.shouldSerialize["device"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIntegration()
        {
            this.shouldSerialize["integration"] = false;
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
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
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
        public bool ShouldSerializeClosed()
        {
            return this.shouldSerialize["closed"];
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
        public bool ShouldSerializeClosedAt()
        {
            return this.shouldSerialize["closed_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCharges()
        {
            return this.shouldSerialize["charges"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceUrl()
        {
            return this.shouldSerialize["invoice_url"];
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
        public bool ShouldSerializeCheckouts()
        {
            return this.shouldSerialize["checkouts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIp()
        {
            return this.shouldSerialize["ip"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSessionId()
        {
            return this.shouldSerialize["session_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocation()
        {
            return this.shouldSerialize["location"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDevice()
        {
            return this.shouldSerialize["device"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIntegration()
        {
            return this.shouldSerialize["integration"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetOrderResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Closed == null && other.Closed == null ||
                 this.Closed?.Equals(other.Closed) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.ClosedAt == null && other.ClosedAt == null ||
                 this.ClosedAt?.Equals(other.ClosedAt) == true) &&
                (this.Charges == null && other.Charges == null ||
                 this.Charges?.Equals(other.Charges) == true) &&
                (this.InvoiceUrl == null && other.InvoiceUrl == null ||
                 this.InvoiceUrl?.Equals(other.InvoiceUrl) == true) &&
                (this.Shipping == null && other.Shipping == null ||
                 this.Shipping?.Equals(other.Shipping) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Checkouts == null && other.Checkouts == null ||
                 this.Checkouts?.Equals(other.Checkouts) == true) &&
                (this.Ip == null && other.Ip == null ||
                 this.Ip?.Equals(other.Ip) == true) &&
                (this.SessionId == null && other.SessionId == null ||
                 this.SessionId?.Equals(other.SessionId) == true) &&
                (this.Location == null && other.Location == null ||
                 this.Location?.Equals(other.Location) == true) &&
                (this.Device == null && other.Device == null ||
                 this.Device?.Equals(other.Device) == true) &&
                (this.Integration == null && other.Integration == null ||
                 this.Integration?.Equals(other.Integration) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Closed = {(this.Closed == null ? "null" : this.Closed.ToString())}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"ClosedAt = {(this.ClosedAt == null ? "null" : this.ClosedAt.ToString())}");
            toStringOutput.Add($"Charges = {(this.Charges == null ? "null" : $"[{string.Join(", ", this.Charges)} ]")}");
            toStringOutput.Add($"InvoiceUrl = {this.InvoiceUrl ?? "null"}");
            toStringOutput.Add($"Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Checkouts = {(this.Checkouts == null ? "null" : $"[{string.Join(", ", this.Checkouts)} ]")}");
            toStringOutput.Add($"Ip = {this.Ip ?? "null"}");
            toStringOutput.Add($"SessionId = {this.SessionId ?? "null"}");
            toStringOutput.Add($"Location = {(this.Location == null ? "null" : this.Location.ToString())}");
            toStringOutput.Add($"Device = {(this.Device == null ? "null" : this.Device.ToString())}");
            toStringOutput.Add($"Integration = {(this.Integration == null ? "null" : this.Integration.ToString())}");
        }
    }
}