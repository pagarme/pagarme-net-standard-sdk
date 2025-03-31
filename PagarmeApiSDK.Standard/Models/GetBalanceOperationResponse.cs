// <copyright file="GetBalanceOperationResponse.cs" company="APIMatic">
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
    /// GetBalanceOperationResponse.
    /// </summary>
    public class GetBalanceOperationResponse
    {
        private string id;
        private string status;
        private string balanceAmount;
        private string balanceOldAmount;
        private string type;
        private int? amount;
        private string fee;
        private string createdAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "status", false },
            { "balance_amount", false },
            { "balance_old_amount", false },
            { "type", false },
            { "amount", false },
            { "fee", false },
            { "created_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceOperationResponse"/> class.
        /// </summary>
        public GetBalanceOperationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceOperationResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="balanceAmount">balance_amount.</param>
        /// <param name="balanceOldAmount">balance_old_amount.</param>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        /// <param name="fee">fee.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="movementObject">movement_object.</param>
        public GetBalanceOperationResponse(
            string id = null,
            string status = null,
            string balanceAmount = null,
            string balanceOldAmount = null,
            string type = null,
            int? amount = null,
            string fee = null,
            string createdAt = null,
            Models.GetMovementObjectBaseResponse movementObject = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (balanceAmount != null)
            {
                this.BalanceAmount = balanceAmount;
            }

            if (balanceOldAmount != null)
            {
                this.BalanceOldAmount = balanceOldAmount;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (fee != null)
            {
                this.Fee = fee;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }
            this.MovementObject = movementObject;
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
        /// Gets or sets BalanceAmount.
        /// </summary>
        [JsonProperty("balance_amount")]
        public string BalanceAmount
        {
            get
            {
                return this.balanceAmount;
            }

            set
            {
                this.shouldSerialize["balance_amount"] = true;
                this.balanceAmount = value;
            }
        }

        /// <summary>
        /// Gets or sets BalanceOldAmount.
        /// </summary>
        [JsonProperty("balance_old_amount")]
        public string BalanceOldAmount
        {
            get
            {
                return this.balanceOldAmount;
            }

            set
            {
                this.shouldSerialize["balance_old_amount"] = true;
                this.balanceOldAmount = value;
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
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee")]
        public string Fee
        {
            get
            {
                return this.fee;
            }

            set
            {
                this.shouldSerialize["fee"] = true;
                this.fee = value;
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
        /// Gets or sets MovementObject.
        /// </summary>
        [JsonProperty("movement_object", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetMovementObjectBaseResponse MovementObject { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetBalanceOperationResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetBalanceAmount()
        {
            this.shouldSerialize["balance_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBalanceOldAmount()
        {
            this.shouldSerialize["balance_old_amount"] = false;
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
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFee()
        {
            this.shouldSerialize["fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
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
        public bool ShouldSerializeBalanceAmount()
        {
            return this.shouldSerialize["balance_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBalanceOldAmount()
        {
            return this.shouldSerialize["balance_old_amount"];
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
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFee()
        {
            return this.shouldSerialize["fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetBalanceOperationResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.BalanceAmount == null && other.BalanceAmount == null ||
                 this.BalanceAmount?.Equals(other.BalanceAmount) == true) &&
                (this.BalanceOldAmount == null && other.BalanceOldAmount == null ||
                 this.BalanceOldAmount?.Equals(other.BalanceOldAmount) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Fee == null && other.Fee == null ||
                 this.Fee?.Equals(other.Fee) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.MovementObject == null && other.MovementObject == null ||
                 this.MovementObject?.Equals(other.MovementObject) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"BalanceAmount = {this.BalanceAmount ?? "null"}");
            toStringOutput.Add($"BalanceOldAmount = {this.BalanceOldAmount ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Fee = {this.Fee ?? "null"}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"MovementObject = {(this.MovementObject == null ? "null" : this.MovementObject.ToString())}");
        }
    }
}