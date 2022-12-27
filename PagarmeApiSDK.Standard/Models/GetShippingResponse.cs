// <copyright file="GetShippingResponse.cs" company="APIMatic">
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
    /// GetShippingResponse.
    /// </summary>
    public class GetShippingResponse
    {
        private DateTime? maxDeliveryDate;
        private DateTime? estimatedDeliveryDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "max_delivery_date", false },
            { "estimated_delivery_date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShippingResponse"/> class.
        /// </summary>
        public GetShippingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShippingResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description.</param>
        /// <param name="recipientName">recipient_name.</param>
        /// <param name="recipientPhone">recipient_phone.</param>
        /// <param name="address">address.</param>
        /// <param name="maxDeliveryDate">max_delivery_date.</param>
        /// <param name="estimatedDeliveryDate">estimated_delivery_date.</param>
        /// <param name="type">type.</param>
        public GetShippingResponse(
            int? amount = null,
            string description = null,
            string recipientName = null,
            string recipientPhone = null,
            Models.GetAddressResponse address = null,
            DateTime? maxDeliveryDate = null,
            DateTime? estimatedDeliveryDate = null,
            string type = null)
        {
            this.Amount = amount;
            this.Description = description;
            this.RecipientName = recipientName;
            this.RecipientPhone = recipientPhone;
            this.Address = address;
            if (maxDeliveryDate != null)
            {
                this.MaxDeliveryDate = maxDeliveryDate;
            }

            if (estimatedDeliveryDate != null)
            {
                this.EstimatedDeliveryDate = estimatedDeliveryDate;
            }

            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets RecipientName.
        /// </summary>
        [JsonProperty("recipient_name", NullValueHandling = NullValueHandling.Include)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or sets RecipientPhone.
        /// </summary>
        [JsonProperty("recipient_phone", NullValueHandling = NullValueHandling.Include)]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Include)]
        public Models.GetAddressResponse Address { get; set; }

        /// <summary>
        /// Data máxima de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("max_delivery_date")]
        public DateTime? MaxDeliveryDate
        {
            get
            {
                return this.maxDeliveryDate;
            }

            set
            {
                this.shouldSerialize["max_delivery_date"] = true;
                this.maxDeliveryDate = value;
            }
        }

        /// <summary>
        /// Prazo estimado de entrega
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("estimated_delivery_date")]
        public DateTime? EstimatedDeliveryDate
        {
            get
            {
                return this.estimatedDeliveryDate;
            }

            set
            {
                this.shouldSerialize["estimated_delivery_date"] = true;
                this.estimatedDeliveryDate = value;
            }
        }

        /// <summary>
        /// Shipping Type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetShippingResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMaxDeliveryDate()
        {
            this.shouldSerialize["max_delivery_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEstimatedDeliveryDate()
        {
            this.shouldSerialize["estimated_delivery_date"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxDeliveryDate()
        {
            return this.shouldSerialize["max_delivery_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEstimatedDeliveryDate()
        {
            return this.shouldSerialize["estimated_delivery_date"];
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

            return obj is GetShippingResponse other &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.RecipientName == null && other.RecipientName == null) || (this.RecipientName?.Equals(other.RecipientName) == true)) &&
                ((this.RecipientPhone == null && other.RecipientPhone == null) || (this.RecipientPhone?.Equals(other.RecipientPhone) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.MaxDeliveryDate == null && other.MaxDeliveryDate == null) || (this.MaxDeliveryDate?.Equals(other.MaxDeliveryDate) == true)) &&
                ((this.EstimatedDeliveryDate == null && other.EstimatedDeliveryDate == null) || (this.EstimatedDeliveryDate?.Equals(other.EstimatedDeliveryDate) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.RecipientName = {(this.RecipientName == null ? "null" : this.RecipientName == string.Empty ? "" : this.RecipientName)}");
            toStringOutput.Add($"this.RecipientPhone = {(this.RecipientPhone == null ? "null" : this.RecipientPhone == string.Empty ? "" : this.RecipientPhone)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.MaxDeliveryDate = {(this.MaxDeliveryDate == null ? "null" : this.MaxDeliveryDate.ToString())}");
            toStringOutput.Add($"this.EstimatedDeliveryDate = {(this.EstimatedDeliveryDate == null ? "null" : this.EstimatedDeliveryDate.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}