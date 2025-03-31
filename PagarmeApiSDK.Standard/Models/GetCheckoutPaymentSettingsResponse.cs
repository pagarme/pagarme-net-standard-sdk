// <copyright file="GetCheckoutPaymentSettingsResponse.cs" company="APIMatic">
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
    /// GetCheckoutPaymentSettingsResponse.
    /// </summary>
    public class GetCheckoutPaymentSettingsResponse
    {
        private string successUrl;
        private string paymentUrl;
        private List<string> acceptedPaymentMethods;
        private string status;
        private Models.GetCustomerResponse customer;
        private int? amount;
        private string defaultPaymentMethod;
        private string gatewayAffiliationId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "success_url", false },
            { "payment_url", false },
            { "accepted_payment_methods", false },
            { "status", false },
            { "customer", false },
            { "amount", false },
            { "default_payment_method", false },
            { "gateway_affiliation_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentSettingsResponse"/> class.
        /// </summary>
        public GetCheckoutPaymentSettingsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPaymentSettingsResponse"/> class.
        /// </summary>
        /// <param name="successUrl">success_url.</param>
        /// <param name="paymentUrl">payment_url.</param>
        /// <param name="acceptedPaymentMethods">accepted_payment_methods.</param>
        /// <param name="status">status.</param>
        /// <param name="customer">customer.</param>
        /// <param name="amount">amount.</param>
        /// <param name="defaultPaymentMethod">default_payment_method.</param>
        /// <param name="gatewayAffiliationId">gateway_affiliation_id.</param>
        public GetCheckoutPaymentSettingsResponse(
            string successUrl = null,
            string paymentUrl = null,
            List<string> acceptedPaymentMethods = null,
            string status = null,
            Models.GetCustomerResponse customer = null,
            int? amount = null,
            string defaultPaymentMethod = null,
            string gatewayAffiliationId = null)
        {

            if (successUrl != null)
            {
                this.SuccessUrl = successUrl;
            }

            if (paymentUrl != null)
            {
                this.PaymentUrl = paymentUrl;
            }

            if (acceptedPaymentMethods != null)
            {
                this.AcceptedPaymentMethods = acceptedPaymentMethods;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (customer != null)
            {
                this.Customer = customer;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (defaultPaymentMethod != null)
            {
                this.DefaultPaymentMethod = defaultPaymentMethod;
            }

            if (gatewayAffiliationId != null)
            {
                this.GatewayAffiliationId = gatewayAffiliationId;
            }
        }

        /// <summary>
        /// Success Url
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl
        {
            get
            {
                return this.successUrl;
            }

            set
            {
                this.shouldSerialize["success_url"] = true;
                this.successUrl = value;
            }
        }

        /// <summary>
        /// Payment Url
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentUrl
        {
            get
            {
                return this.paymentUrl;
            }

            set
            {
                this.shouldSerialize["payment_url"] = true;
                this.paymentUrl = value;
            }
        }

        /// <summary>
        /// Accepted Payment Methods
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods
        {
            get
            {
                return this.acceptedPaymentMethods;
            }

            set
            {
                this.shouldSerialize["accepted_payment_methods"] = true;
                this.acceptedPaymentMethods = value;
            }
        }

        /// <summary>
        /// Status
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
        /// Customer
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
        /// Payment amount
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
        /// Default Payment Method
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod
        {
            get
            {
                return this.defaultPaymentMethod;
            }

            set
            {
                this.shouldSerialize["default_payment_method"] = true;
                this.defaultPaymentMethod = value;
            }
        }

        /// <summary>
        /// Gateway Affiliation Id
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCheckoutPaymentSettingsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSuccessUrl()
        {
            this.shouldSerialize["success_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentUrl()
        {
            this.shouldSerialize["payment_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcceptedPaymentMethods()
        {
            this.shouldSerialize["accepted_payment_methods"] = false;
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
        public void UnsetCustomer()
        {
            this.shouldSerialize["customer"] = false;
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
        public void UnsetDefaultPaymentMethod()
        {
            this.shouldSerialize["default_payment_method"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayAffiliationId()
        {
            this.shouldSerialize["gateway_affiliation_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSuccessUrl()
        {
            return this.shouldSerialize["success_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentUrl()
        {
            return this.shouldSerialize["payment_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcceptedPaymentMethods()
        {
            return this.shouldSerialize["accepted_payment_methods"];
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
        public bool ShouldSerializeCustomer()
        {
            return this.shouldSerialize["customer"];
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
        public bool ShouldSerializeDefaultPaymentMethod()
        {
            return this.shouldSerialize["default_payment_method"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayAffiliationId()
        {
            return this.shouldSerialize["gateway_affiliation_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCheckoutPaymentSettingsResponse other &&
                (this.SuccessUrl == null && other.SuccessUrl == null ||
                 this.SuccessUrl?.Equals(other.SuccessUrl) == true) &&
                (this.PaymentUrl == null && other.PaymentUrl == null ||
                 this.PaymentUrl?.Equals(other.PaymentUrl) == true) &&
                (this.AcceptedPaymentMethods == null && other.AcceptedPaymentMethods == null ||
                 this.AcceptedPaymentMethods?.Equals(other.AcceptedPaymentMethods) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.DefaultPaymentMethod == null && other.DefaultPaymentMethod == null ||
                 this.DefaultPaymentMethod?.Equals(other.DefaultPaymentMethod) == true) &&
                (this.GatewayAffiliationId == null && other.GatewayAffiliationId == null ||
                 this.GatewayAffiliationId?.Equals(other.GatewayAffiliationId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SuccessUrl = {this.SuccessUrl ?? "null"}");
            toStringOutput.Add($"PaymentUrl = {this.PaymentUrl ?? "null"}");
            toStringOutput.Add($"AcceptedPaymentMethods = {(this.AcceptedPaymentMethods == null ? "null" : $"[{string.Join(", ", this.AcceptedPaymentMethods)} ]")}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"DefaultPaymentMethod = {this.DefaultPaymentMethod ?? "null"}");
            toStringOutput.Add($"GatewayAffiliationId = {this.GatewayAffiliationId ?? "null"}");
        }
    }
}