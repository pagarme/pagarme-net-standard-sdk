// <copyright file="GetMovementObjectTransferResponse.cs" company="APIMatic">
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
    /// GetMovementObjectTransferResponse.
    /// </summary>
    public class GetMovementObjectTransferResponse : GetMovementObjectBaseResponse
    {
        private string sourceType;
        private string sourceId;
        private string targetType;
        private string targetId;
        private string fee;
        private string fundingDate;
        private string fundingEstimatedDate;
        private string bankAccount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "source_type", false },
            { "source_id", false },
            { "target_type", false },
            { "target_id", false },
            { "fee", false },
            { "funding_date", false },
            { "funding_estimated_date", false },
            { "bank_account", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectTransferResponse"/> class.
        /// </summary>
        public GetMovementObjectTransferResponse()
        {
            this.MObject = "transfer";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectTransferResponse"/> class.
        /// </summary>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="type">type.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="sourceType">source_type.</param>
        /// <param name="sourceId">source_id.</param>
        /// <param name="targetType">target_type.</param>
        /// <param name="targetId">target_id.</param>
        /// <param name="fee">fee.</param>
        /// <param name="fundingDate">funding_date.</param>
        /// <param name="fundingEstimatedDate">funding_estimated_date.</param>
        /// <param name="bankAccount">bank_account.</param>
        public GetMovementObjectTransferResponse(
            string mObject = "transfer",
            string id = null,
            string status = null,
            string amount = null,
            string createdAt = null,
            string type = null,
            string chargeId = null,
            string gatewayId = null,
            string sourceType = null,
            string sourceId = null,
            string targetType = null,
            string targetId = null,
            string fee = null,
            string fundingDate = null,
            string fundingEstimatedDate = null,
            string bankAccount = null)
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

            if (sourceType != null)
            {
                this.SourceType = sourceType;
            }

            if (sourceId != null)
            {
                this.SourceId = sourceId;
            }

            if (targetType != null)
            {
                this.TargetType = targetType;
            }

            if (targetId != null)
            {
                this.TargetId = targetId;
            }

            if (fee != null)
            {
                this.Fee = fee;
            }

            if (fundingDate != null)
            {
                this.FundingDate = fundingDate;
            }

            if (fundingEstimatedDate != null)
            {
                this.FundingEstimatedDate = fundingEstimatedDate;
            }

            if (bankAccount != null)
            {
                this.BankAccount = bankAccount;
            }
        }

        /// <summary>
        /// Gets or sets SourceType.
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType
        {
            get
            {
                return this.sourceType;
            }

            set
            {
                this.shouldSerialize["source_type"] = true;
                this.sourceType = value;
            }
        }

        /// <summary>
        /// Gets or sets SourceId.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId
        {
            get
            {
                return this.sourceId;
            }

            set
            {
                this.shouldSerialize["source_id"] = true;
                this.sourceId = value;
            }
        }

        /// <summary>
        /// Gets or sets TargetType.
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType
        {
            get
            {
                return this.targetType;
            }

            set
            {
                this.shouldSerialize["target_type"] = true;
                this.targetType = value;
            }
        }

        /// <summary>
        /// Gets or sets TargetId.
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId
        {
            get
            {
                return this.targetId;
            }

            set
            {
                this.shouldSerialize["target_id"] = true;
                this.targetId = value;
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
        /// Gets or sets FundingDate.
        /// </summary>
        [JsonProperty("funding_date")]
        public string FundingDate
        {
            get
            {
                return this.fundingDate;
            }

            set
            {
                this.shouldSerialize["funding_date"] = true;
                this.fundingDate = value;
            }
        }

        /// <summary>
        /// Gets or sets FundingEstimatedDate.
        /// </summary>
        [JsonProperty("funding_estimated_date")]
        public string FundingEstimatedDate
        {
            get
            {
                return this.fundingEstimatedDate;
            }

            set
            {
                this.shouldSerialize["funding_estimated_date"] = true;
                this.fundingEstimatedDate = value;
            }
        }

        /// <summary>
        /// Gets or sets BankAccount.
        /// </summary>
        [JsonProperty("bank_account")]
        public string BankAccount
        {
            get
            {
                return this.bankAccount;
            }

            set
            {
                this.shouldSerialize["bank_account"] = true;
                this.bankAccount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetMovementObjectTransferResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSourceType()
        {
            this.shouldSerialize["source_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSourceId()
        {
            this.shouldSerialize["source_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTargetType()
        {
            this.shouldSerialize["target_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTargetId()
        {
            this.shouldSerialize["target_id"] = false;
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
        public void UnsetFundingDate()
        {
            this.shouldSerialize["funding_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFundingEstimatedDate()
        {
            this.shouldSerialize["funding_estimated_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankAccount()
        {
            this.shouldSerialize["bank_account"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSourceType()
        {
            return this.shouldSerialize["source_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSourceId()
        {
            return this.shouldSerialize["source_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTargetType()
        {
            return this.shouldSerialize["target_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTargetId()
        {
            return this.shouldSerialize["target_id"];
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
        public bool ShouldSerializeFundingDate()
        {
            return this.shouldSerialize["funding_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFundingEstimatedDate()
        {
            return this.shouldSerialize["funding_estimated_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankAccount()
        {
            return this.shouldSerialize["bank_account"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetMovementObjectTransferResponse other &&
                (this.SourceType == null && other.SourceType == null ||
                 this.SourceType?.Equals(other.SourceType) == true) &&
                (this.SourceId == null && other.SourceId == null ||
                 this.SourceId?.Equals(other.SourceId) == true) &&
                (this.TargetType == null && other.TargetType == null ||
                 this.TargetType?.Equals(other.TargetType) == true) &&
                (this.TargetId == null && other.TargetId == null ||
                 this.TargetId?.Equals(other.TargetId) == true) &&
                (this.Fee == null && other.Fee == null ||
                 this.Fee?.Equals(other.Fee) == true) &&
                (this.FundingDate == null && other.FundingDate == null ||
                 this.FundingDate?.Equals(other.FundingDate) == true) &&
                (this.FundingEstimatedDate == null && other.FundingEstimatedDate == null ||
                 this.FundingEstimatedDate?.Equals(other.FundingEstimatedDate) == true) &&
                (this.BankAccount == null && other.BankAccount == null ||
                 this.BankAccount?.Equals(other.BankAccount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SourceType = {this.SourceType ?? "null"}");
            toStringOutput.Add($"SourceId = {this.SourceId ?? "null"}");
            toStringOutput.Add($"TargetType = {this.TargetType ?? "null"}");
            toStringOutput.Add($"TargetId = {this.TargetId ?? "null"}");
            toStringOutput.Add($"Fee = {this.Fee ?? "null"}");
            toStringOutput.Add($"FundingDate = {this.FundingDate ?? "null"}");
            toStringOutput.Add($"FundingEstimatedDate = {this.FundingEstimatedDate ?? "null"}");
            toStringOutput.Add($"BankAccount = {this.BankAccount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}