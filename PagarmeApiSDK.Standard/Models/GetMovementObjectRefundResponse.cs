// <copyright file="GetMovementObjectRefundResponse.cs" company="APIMatic">
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
    /// GetMovementObjectRefundResponse.
    /// </summary>
    public class GetMovementObjectRefundResponse : GetMovementObjectBaseResponse
    {
        private string fraudCoverageFee;
        private string chargeFeeRecipientId;
        private string bankAccountId;
        private string localTransactionId;
        private string updatedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "fraud_coverage_fee", false },
            { "charge_fee_recipient_id", false },
            { "bank_account_id", false },
            { "local_transaction_id", false },
            { "updated_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectRefundResponse"/> class.
        /// </summary>
        public GetMovementObjectRefundResponse()
        {
            this.MObject = "refund";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectRefundResponse"/> class.
        /// </summary>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="type">type.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="fraudCoverageFee">fraud_coverage_fee.</param>
        /// <param name="chargeFeeRecipientId">charge_fee_recipient_id.</param>
        /// <param name="bankAccountId">bank_account_id.</param>
        /// <param name="localTransactionId">local_transaction_id.</param>
        /// <param name="updatedAt">updated_at.</param>
        public GetMovementObjectRefundResponse(
            string mObject = "refund",
            string id = null,
            string status = null,
            string amount = null,
            string createdAt = null,
            string type = null,
            string chargeId = null,
            string gatewayId = null,
            string fraudCoverageFee = null,
            string chargeFeeRecipientId = null,
            string bankAccountId = null,
            string localTransactionId = null,
            string updatedAt = null)
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

            if (fraudCoverageFee != null)
            {
                this.FraudCoverageFee = fraudCoverageFee;
            }

            if (chargeFeeRecipientId != null)
            {
                this.ChargeFeeRecipientId = chargeFeeRecipientId;
            }

            if (bankAccountId != null)
            {
                this.BankAccountId = bankAccountId;
            }

            if (localTransactionId != null)
            {
                this.LocalTransactionId = localTransactionId;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }
        }

        /// <summary>
        /// Gets or sets FraudCoverageFee.
        /// </summary>
        [JsonProperty("fraud_coverage_fee")]
        public string FraudCoverageFee
        {
            get
            {
                return this.fraudCoverageFee;
            }

            set
            {
                this.shouldSerialize["fraud_coverage_fee"] = true;
                this.fraudCoverageFee = value;
            }
        }

        /// <summary>
        /// Gets or sets ChargeFeeRecipientId.
        /// </summary>
        [JsonProperty("charge_fee_recipient_id")]
        public string ChargeFeeRecipientId
        {
            get
            {
                return this.chargeFeeRecipientId;
            }

            set
            {
                this.shouldSerialize["charge_fee_recipient_id"] = true;
                this.chargeFeeRecipientId = value;
            }
        }

        /// <summary>
        /// Gets or sets BankAccountId.
        /// </summary>
        [JsonProperty("bank_account_id")]
        public string BankAccountId
        {
            get
            {
                return this.bankAccountId;
            }

            set
            {
                this.shouldSerialize["bank_account_id"] = true;
                this.bankAccountId = value;
            }
        }

        /// <summary>
        /// Gets or sets LocalTransactionId.
        /// </summary>
        [JsonProperty("local_transaction_id")]
        public string LocalTransactionId
        {
            get
            {
                return this.localTransactionId;
            }

            set
            {
                this.shouldSerialize["local_transaction_id"] = true;
                this.localTransactionId = value;
            }
        }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetMovementObjectRefundResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFraudCoverageFee()
        {
            this.shouldSerialize["fraud_coverage_fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeFeeRecipientId()
        {
            this.shouldSerialize["charge_fee_recipient_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankAccountId()
        {
            this.shouldSerialize["bank_account_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLocalTransactionId()
        {
            this.shouldSerialize["local_transaction_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdatedAt()
        {
            this.shouldSerialize["updated_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFraudCoverageFee()
        {
            return this.shouldSerialize["fraud_coverage_fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeFeeRecipientId()
        {
            return this.shouldSerialize["charge_fee_recipient_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankAccountId()
        {
            return this.shouldSerialize["bank_account_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocalTransactionId()
        {
            return this.shouldSerialize["local_transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return this.shouldSerialize["updated_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetMovementObjectRefundResponse other &&
                (this.FraudCoverageFee == null && other.FraudCoverageFee == null ||
                 this.FraudCoverageFee?.Equals(other.FraudCoverageFee) == true) &&
                (this.ChargeFeeRecipientId == null && other.ChargeFeeRecipientId == null ||
                 this.ChargeFeeRecipientId?.Equals(other.ChargeFeeRecipientId) == true) &&
                (this.BankAccountId == null && other.BankAccountId == null ||
                 this.BankAccountId?.Equals(other.BankAccountId) == true) &&
                (this.LocalTransactionId == null && other.LocalTransactionId == null ||
                 this.LocalTransactionId?.Equals(other.LocalTransactionId) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FraudCoverageFee = {this.FraudCoverageFee ?? "null"}");
            toStringOutput.Add($"ChargeFeeRecipientId = {this.ChargeFeeRecipientId ?? "null"}");
            toStringOutput.Add($"BankAccountId = {this.BankAccountId ?? "null"}");
            toStringOutput.Add($"LocalTransactionId = {this.LocalTransactionId ?? "null"}");
            toStringOutput.Add($"UpdatedAt = {this.UpdatedAt ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}