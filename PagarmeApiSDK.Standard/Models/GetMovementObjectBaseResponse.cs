// <copyright file="GetMovementObjectBaseResponse.cs" company="APIMatic">
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
    /// GetMovementObjectBaseResponse.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "object")]
    [JsonSubtypes.KnownSubType(typeof(GetMovementObjectFeeCollectionResponse), "feeCollection")]
    [JsonSubtypes.KnownSubType(typeof(GetMovementObjectPayableResponse), "payable")]
    [JsonSubtypes.KnownSubType(typeof(GetMovementObjectRefundResponse), "refund")]
    [JsonSubtypes.KnownSubType(typeof(GetMovementObjectTransferResponse), "transfer")]
    [JsonSubtypes.KnownSubType(typeof(GetMovementObjectSettlementResponse), "settlement")]
    public class GetMovementObjectBaseResponse
    {
        private string id;
        private string status;
        private string amount;
        private string createdAt;
        private string type;
        private string chargeId;
        private string gatewayId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "status", false },
            { "amount", false },
            { "created_at", false },
            { "type", false },
            { "charge_id", false },
            { "gateway_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectBaseResponse"/> class.
        /// </summary>
        public GetMovementObjectBaseResponse()
        {
            this.MObject = "MovementObject";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectBaseResponse"/> class.
        /// </summary>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="type">type.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        public GetMovementObjectBaseResponse(
            string mObject = "MovementObject",
            string id = null,
            string status = null,
            string amount = null,
            string createdAt = null,
            string type = null,
            string chargeId = null,
            string gatewayId = null)
        {
            this.MObject = mObject;

            if (id != null)
            {
                this.Id = id;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (chargeId != null)
            {
                this.ChargeId = chargeId;
            }

            if (gatewayId != null)
            {
                this.GatewayId = gatewayId;
            }
        }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string MObject { get; set; }

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
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount
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
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt
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
        /// Gets or sets Type.
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

        /// <summary>
        /// Gets or sets ChargeId.
        /// </summary>
        [JsonProperty("charge_id")]
        public string ChargeId
        {
            get
            {
                return this.chargeId;
            }

            set
            {
                this.shouldSerialize["charge_id"] = true;
                this.chargeId = value;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetMovementObjectBaseResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
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
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeId()
        {
            this.shouldSerialize["charge_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayId()
        {
            this.shouldSerialize["gateway_id"] = false;
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
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
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
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeId()
        {
            return this.shouldSerialize["charge_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayId()
        {
            return this.shouldSerialize["gateway_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetMovementObjectBaseResponse other &&
                (this.MObject == null && other.MObject == null ||
                 this.MObject?.Equals(other.MObject) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.ChargeId == null && other.ChargeId == null ||
                 this.ChargeId?.Equals(other.ChargeId) == true) &&
                (this.GatewayId == null && other.GatewayId == null ||
                 this.GatewayId?.Equals(other.GatewayId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MObject = {this.MObject ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"ChargeId = {this.ChargeId ?? "null"}");
            toStringOutput.Add($"GatewayId = {this.GatewayId ?? "null"}");
        }
    }
}