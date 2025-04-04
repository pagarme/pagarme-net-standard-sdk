// <copyright file="CreateShippingRequest.cs" company="APIMatic">
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
    /// CreateShippingRequest.
    /// </summary>
    public class CreateShippingRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShippingRequest"/> class.
        /// </summary>
        public CreateShippingRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShippingRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="recipientName">recipient_name.</param>
        /// <param name="recipientPhone">recipient_phone.</param>
        /// <param name="addressId">address_id.</param>
        /// <param name="address">address.</param>
        /// <param name="type">type.</param>
        /// <param name="maxDeliveryDate">max_delivery_date.</param>
        /// <param name="estimatedDeliveryDate">estimated_delivery_date.</param>
        public CreateShippingRequest(
            int amount,
            string description,
            string recipientName,
            string recipientPhone,
            string addressId,
            Models.CreateAddressRequest address,
            string type,
            DateTime? maxDeliveryDate = null,
            DateTime? estimatedDeliveryDate = null)
        {
            this.Amount = amount;
            this.Description = description;
            this.RecipientName = recipientName;
            this.RecipientPhone = recipientPhone;
            this.AddressId = addressId;
            this.Address = address;
            this.MaxDeliveryDate = maxDeliveryDate;
            this.EstimatedDeliveryDate = estimatedDeliveryDate;
            this.Type = type;
        }

        /// <summary>
        /// Shipping amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// Recipient phone number
        /// </summary>
        [JsonProperty("recipient_phone")]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// The id of the address that will be used for shipping
        /// </summary>
        [JsonProperty("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// Address data
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateAddressRequest Address { get; set; }

        /// <summary>
        /// Data máxima de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("max_delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MaxDeliveryDate { get; set; }

        /// <summary>
        /// Prazo estimado de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("estimated_delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Shipping type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateShippingRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateShippingRequest other &&
                (this.Amount.Equals(other.Amount)) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.RecipientName == null && other.RecipientName == null ||
                 this.RecipientName?.Equals(other.RecipientName) == true) &&
                (this.RecipientPhone == null && other.RecipientPhone == null ||
                 this.RecipientPhone?.Equals(other.RecipientPhone) == true) &&
                (this.AddressId == null && other.AddressId == null ||
                 this.AddressId?.Equals(other.AddressId) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.MaxDeliveryDate == null && other.MaxDeliveryDate == null ||
                 this.MaxDeliveryDate?.Equals(other.MaxDeliveryDate) == true) &&
                (this.EstimatedDeliveryDate == null && other.EstimatedDeliveryDate == null ||
                 this.EstimatedDeliveryDate?.Equals(other.EstimatedDeliveryDate) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"RecipientName = {this.RecipientName ?? "null"}");
            toStringOutput.Add($"RecipientPhone = {this.RecipientPhone ?? "null"}");
            toStringOutput.Add($"AddressId = {this.AddressId ?? "null"}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"MaxDeliveryDate = {(this.MaxDeliveryDate == null ? "null" : this.MaxDeliveryDate.ToString())}");
            toStringOutput.Add($"EstimatedDeliveryDate = {(this.EstimatedDeliveryDate == null ? "null" : this.EstimatedDeliveryDate.ToString())}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
        }
    }
}