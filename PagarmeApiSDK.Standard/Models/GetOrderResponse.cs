// <copyright file="GetOrderResponse.cs" company="APIMatic">
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
    /// GetOrderResponse.
    /// </summary>
    public class GetOrderResponse
    {
        private Models.GetCustomerResponse customer;
        private List<Models.GetCheckoutPaymentResponse> checkouts;
        private string ip;
        private string sessionId;
        private Models.GetLocationResponse location;
        private Models.GetDeviceResponse device;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "customer", false },
            { "checkouts", false },
            { "ip", false },
            { "session_id", false },
            { "location", false },
            { "device", false },
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
        /// <param name="currency">currency.</param>
        /// <param name="items">items.</param>
        /// <param name="customer">customer.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="charges">charges.</param>
        /// <param name="invoiceUrl">invoice_url.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="checkouts">checkouts.</param>
        /// <param name="ip">ip.</param>
        /// <param name="sessionId">session_id.</param>
        /// <param name="location">location.</param>
        /// <param name="device">device.</param>
        /// <param name="closed">closed.</param>
        public GetOrderResponse(
            string id = null,
            string code = null,
            string currency = null,
            List<Models.GetOrderItemResponse> items = null,
            Models.GetCustomerResponse customer = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            List<Models.GetChargeResponse> charges = null,
            string invoiceUrl = null,
            Models.GetShippingResponse shipping = null,
            Dictionary<string, string> metadata = null,
            List<Models.GetCheckoutPaymentResponse> checkouts = null,
            string ip = null,
            string sessionId = null,
            Models.GetLocationResponse location = null,
            Models.GetDeviceResponse device = null,
            bool? closed = null)
        {
            this.Id = id;
            this.Code = code;
            this.Currency = currency;
            this.Items = items;
            if (customer != null)
            {
                this.Customer = customer;
            }

            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Charges = charges;
            this.InvoiceUrl = invoiceUrl;
            this.Shipping = shipping;
            this.Metadata = metadata;
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

            this.Closed = closed;
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
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Include)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetOrderItemResponse> Items { get; set; }

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
        /// Gets or sets Charges.
        /// </summary>
        [JsonProperty("charges", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetChargeResponse> Charges { get; set; }

        /// <summary>
        /// Gets or sets InvoiceUrl.
        /// </summary>
        [JsonProperty("invoice_url", NullValueHandling = NullValueHandling.Include)]
        public string InvoiceUrl { get; set; }

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
        /// Indicates whether the order is closed
        /// </summary>
        [JsonProperty("closed", NullValueHandling = NullValueHandling.Include)]
        public bool? Closed { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetOrderResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCheckouts()
        {
            this.shouldSerialize["checkouts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIp()
        {
            this.shouldSerialize["ip"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSessionId()
        {
            this.shouldSerialize["session_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocation()
        {
            this.shouldSerialize["location"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDevice()
        {
            this.shouldSerialize["device"] = false;
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

            return obj is GetOrderResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Charges == null && other.Charges == null) || (this.Charges?.Equals(other.Charges) == true)) &&
                ((this.InvoiceUrl == null && other.InvoiceUrl == null) || (this.InvoiceUrl?.Equals(other.InvoiceUrl) == true)) &&
                ((this.Shipping == null && other.Shipping == null) || (this.Shipping?.Equals(other.Shipping) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Checkouts == null && other.Checkouts == null) || (this.Checkouts?.Equals(other.Checkouts) == true)) &&
                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true)) &&
                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Device == null && other.Device == null) || (this.Device?.Equals(other.Device) == true)) &&
                ((this.Closed == null && other.Closed == null) || (this.Closed?.Equals(other.Closed) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Charges = {(this.Charges == null ? "null" : $"[{string.Join(", ", this.Charges)} ]")}");
            toStringOutput.Add($"this.InvoiceUrl = {(this.InvoiceUrl == null ? "null" : this.InvoiceUrl == string.Empty ? "" : this.InvoiceUrl)}");
            toStringOutput.Add($"this.Shipping = {(this.Shipping == null ? "null" : this.Shipping.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Checkouts = {(this.Checkouts == null ? "null" : $"[{string.Join(", ", this.Checkouts)} ]")}");
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip == string.Empty ? "" : this.Ip)}");
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId == string.Empty ? "" : this.SessionId)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location.ToString())}");
            toStringOutput.Add($"this.Device = {(this.Device == null ? "null" : this.Device.ToString())}");
            toStringOutput.Add($"this.Closed = {(this.Closed == null ? "null" : this.Closed.ToString())}");
        }
    }
}