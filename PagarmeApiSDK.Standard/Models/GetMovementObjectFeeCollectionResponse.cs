// <copyright file="GetMovementObjectFeeCollectionResponse.cs" company="APIMatic">
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
    /// GetMovementObjectFeeCollectionResponse.
    /// </summary>
    public class GetMovementObjectFeeCollectionResponse : GetMovementObjectBaseResponse
    {
        private string description;
        private string paymentDate;
        private string recipientId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "payment_date", false },
            { "recipient_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectFeeCollectionResponse"/> class.
        /// </summary>
        public GetMovementObjectFeeCollectionResponse()
        {
            this.MObject = "feeCollection";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectFeeCollectionResponse"/> class.
        /// </summary>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="type">type.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="description">description.</param>
        /// <param name="paymentDate">payment_date.</param>
        /// <param name="recipientId">recipient_id.</param>
        public GetMovementObjectFeeCollectionResponse(
            string mObject = "feeCollection",
            string id = null,
            string status = null,
            string amount = null,
            string createdAt = null,
            string type = null,
            string chargeId = null,
            string gatewayId = null,
            string description = null,
            string paymentDate = null,
            string recipientId = null)
            : base(
                mObject,
                id,
                status,
                amount,
                createdAt,
                type,
                chargeId,
                gatewayId)
        {

            if (description != null)
            {
                this.Description = description;
            }

            if (paymentDate != null)
            {
                this.PaymentDate = paymentDate;
            }

            if (recipientId != null)
            {
                this.RecipientId = recipientId;
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
        /// Gets or sets PaymentDate.
        /// </summary>
        [JsonProperty("payment_date")]
        public string PaymentDate
        {
            get
            {
                return this.paymentDate;
            }

            set
            {
                this.shouldSerialize["payment_date"] = true;
                this.paymentDate = value;
            }
        }

        /// <summary>
        /// Gets or sets RecipientId.
        /// </summary>
        [JsonProperty("recipient_id")]
        public string RecipientId
        {
            get
            {
                return this.recipientId;
            }

            set
            {
                this.shouldSerialize["recipient_id"] = true;
                this.recipientId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetMovementObjectFeeCollectionResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPaymentDate()
        {
            this.shouldSerialize["payment_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRecipientId()
        {
            this.shouldSerialize["recipient_id"] = false;
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
        public bool ShouldSerializePaymentDate()
        {
            return this.shouldSerialize["payment_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipientId()
        {
            return this.shouldSerialize["recipient_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetMovementObjectFeeCollectionResponse other &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.PaymentDate == null && other.PaymentDate == null ||
                 this.PaymentDate?.Equals(other.PaymentDate) == true) &&
                (this.RecipientId == null && other.RecipientId == null ||
                 this.RecipientId?.Equals(other.RecipientId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"PaymentDate = {this.PaymentDate ?? "null"}");
            toStringOutput.Add($"RecipientId = {this.RecipientId ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}