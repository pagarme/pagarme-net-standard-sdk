// <copyright file="GetShippingResponse.cs" company="APIMatic">
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
    /// GetShippingResponse.
    /// </summary>
    public class GetShippingResponse
    {
        private int? amount;
        private string description;
        private string recipientName;
        private string recipientPhone;
        private Models.GetAddressResponse address;
        private DateTime? maxDeliveryDate;
        private DateTime? estimatedDeliveryDate;
        private string type;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "amount", false },
            { "description", false },
            { "recipient_name", false },
            { "recipient_phone", false },
            { "address", false },
            { "max_delivery_date", false },
            { "estimated_delivery_date", false },
            { "type", false },
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

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (recipientName != null)
            {
                this.RecipientName = recipientName;
            }

            if (recipientPhone != null)
            {
                this.RecipientPhone = recipientPhone;
            }

            if (address != null)
            {
                this.Address = address;
            }

            if (maxDeliveryDate != null)
            {
                this.MaxDeliveryDate = maxDeliveryDate;
            }

            if (estimatedDeliveryDate != null)
            {
                this.EstimatedDeliveryDate = estimatedDeliveryDate;
            }

            if (type != null)
            {
                this.Type = type;
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
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets RecipientName.
        /// </summary>
        [JsonProperty("recipient_name")]
        public string RecipientName
        {
            get
            {
                return this.recipientName;
            }

            set
            {
                this.shouldSerialize["recipient_name"] = true;
                this.recipientName = value;
            }
        }

        /// <summary>
        /// Gets or sets RecipientPhone.
        /// </summary>
        [JsonProperty("recipient_phone")]
        public string RecipientPhone
        {
            get
            {
                return this.recipientPhone;
            }

            set
            {
                this.shouldSerialize["recipient_phone"] = true;
                this.recipientPhone = value;
            }
        }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public Models.GetAddressResponse Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.shouldSerialize["address"] = true;
                this.address = value;
            }
        }

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
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["type"] = true;
                this.type = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetShippingResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRecipientName()
        {
            this.shouldSerialize["recipient_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRecipientPhone()
        {
            this.shouldSerialize["recipient_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAddress()
        {
            this.shouldSerialize["address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaxDeliveryDate()
        {
            this.shouldSerialize["max_delivery_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEstimatedDeliveryDate()
        {
            this.shouldSerialize["estimated_delivery_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
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
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipientName()
        {
            return this.shouldSerialize["recipient_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipientPhone()
        {
            return this.shouldSerialize["recipient_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddress()
        {
            return this.shouldSerialize["address"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetShippingResponse other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.RecipientName == null && other.RecipientName == null ||
                 this.RecipientName?.Equals(other.RecipientName) == true) &&
                (this.RecipientPhone == null && other.RecipientPhone == null ||
                 this.RecipientPhone?.Equals(other.RecipientPhone) == true) &&
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
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"RecipientName = {this.RecipientName ?? "null"}");
            toStringOutput.Add($"RecipientPhone = {this.RecipientPhone ?? "null"}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"MaxDeliveryDate = {(this.MaxDeliveryDate == null ? "null" : this.MaxDeliveryDate.ToString())}");
            toStringOutput.Add($"EstimatedDeliveryDate = {(this.EstimatedDeliveryDate == null ? "null" : this.EstimatedDeliveryDate.ToString())}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
        }
    }
}