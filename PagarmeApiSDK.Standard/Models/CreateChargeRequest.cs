// <copyright file="CreateChargeRequest.cs" company="APIMatic">
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
    /// CreateChargeRequest.
    /// </summary>
    public class CreateChargeRequest
    {
        private string code;
        private string customerId;
        private Models.CreateCustomerRequest customer;
        private Dictionary<string, string> metadata;
        private DateTime? dueAt;
        private Models.CreateAntifraudRequest antifraud;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "code", false },
            { "customer_id", false },
            { "customer", false },
            { "metadata", false },
            { "due_at", false },
            { "antifraud", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest"/> class.
        /// </summary>
        public CreateChargeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="payment">payment.</param>
        /// <param name="orderId">order_id.</param>
        /// <param name="code">code.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="customer">customer.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="antifraud">antifraud.</param>
        public CreateChargeRequest(
            int amount,
            Models.CreatePaymentRequest payment,
            string orderId,
            string code = null,
            string customerId = null,
            Models.CreateCustomerRequest customer = null,
            Dictionary<string, string> metadata = null,
            DateTime? dueAt = null,
            Models.CreateAntifraudRequest antifraud = null)
        {

            if (code != null)
            {
                this.Code = code;
            }
            this.Amount = amount;

            if (customerId != null)
            {
                this.CustomerId = customerId;
            }

            if (customer != null)
            {
                this.Customer = customer;
            }
            this.Payment = payment;

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (dueAt != null)
            {
                this.DueAt = dueAt;
            }

            if (antifraud != null)
            {
                this.Antifraud = antifraud;
            }
            this.OrderId = orderId;
        }

        /// <summary>
        /// Code
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
        /// The amount of the charge, in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The customer's id
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId
        {
            get
            {
                return this.customerId;
            }

            set
            {
                this.shouldSerialize["customer_id"] = true;
                this.customerId = value;
            }
        }

        /// <summary>
        /// Customer data
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer
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
        /// Payment data
        /// </summary>
        [JsonProperty("payment")]
        public Models.CreatePaymentRequest Payment { get; set; }

        /// <summary>
        /// Metadata
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
        /// The charge due date
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
        /// Gets or sets Antifraud.
        /// </summary>
        [JsonProperty("antifraud")]
        public Models.CreateAntifraudRequest Antifraud
        {
            get
            {
                return this.antifraud;
            }

            set
            {
                this.shouldSerialize["antifraud"] = true;
                this.antifraud = value;
            }
        }

        /// <summary>
        /// Order Id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateChargeRequest : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCustomerId()
        {
            this.shouldSerialize["customer_id"] = false;
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
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAntifraud()
        {
            this.shouldSerialize["antifraud"] = false;
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
        public bool ShouldSerializeCustomerId()
        {
            return this.shouldSerialize["customer_id"];
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
        public bool ShouldSerializeDueAt()
        {
            return this.shouldSerialize["due_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAntifraud()
        {
            return this.shouldSerialize["antifraud"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateChargeRequest other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Amount.Equals(other.Amount)) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Payment == null && other.Payment == null ||
                 this.Payment?.Equals(other.Payment) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.DueAt == null && other.DueAt == null ||
                 this.DueAt?.Equals(other.DueAt) == true) &&
                (this.Antifraud == null && other.Antifraud == null ||
                 this.Antifraud?.Equals(other.Antifraud) == true) &&
                (this.OrderId == null && other.OrderId == null ||
                 this.OrderId?.Equals(other.OrderId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"CustomerId = {this.CustomerId ?? "null"}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"Antifraud = {(this.Antifraud == null ? "null" : this.Antifraud.ToString())}");
            toStringOutput.Add($"OrderId = {this.OrderId ?? "null"}");
        }
    }
}