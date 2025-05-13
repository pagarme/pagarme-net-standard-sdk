// <copyright file="GetTransactionResponse.cs" company="APIMatic">
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
    /// GetTransactionResponse.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "transaction_type")]
    [JsonSubtypes.KnownSubType(typeof(GetSafetyPayTransactionResponse), "safetypay")]
    [JsonSubtypes.KnownSubType(typeof(GetVoucherTransactionResponse), "voucher")]
    [JsonSubtypes.KnownSubType(typeof(GetBankTransferTransactionResponse), "bank_transfer")]
    [JsonSubtypes.KnownSubType(typeof(GetBoletoTransactionResponse), "boleto")]
    [JsonSubtypes.KnownSubType(typeof(GetDebitCardTransactionResponse), "debit_card")]
    [JsonSubtypes.KnownSubType(typeof(GetCashTransactionResponse), "cash")]
    [JsonSubtypes.KnownSubType(typeof(GetPrivateLabelTransactionResponse), "private_label")]
    [JsonSubtypes.KnownSubType(typeof(GetCreditCardTransactionResponse), "credit_card")]
    [JsonSubtypes.KnownSubType(typeof(GetPixTransactionResponse), "pix")]
    public class GetTransactionResponse
    {
        private string gatewayId;
        private int? amount;
        private string status;
        private bool? success;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private int? attemptCount;
        private int? maxAttempts;
        private List<Models.GetSplitResponse> splits;
        private DateTime? nextAttempt;
        private string id;
        private Models.GetGatewayResponseResponse gatewayResponse;
        private Models.GetAntifraudResponse antifraudResponse;
        private Dictionary<string, string> metadata;
        private List<Models.GetSplitResponse> split;
        private Models.GetInterestResponse interest;
        private Models.GetFineResponse fine;
        private int? maxDaysToPayPastDue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "gateway_id", false },
            { "amount", false },
            { "status", false },
            { "success", false },
            { "created_at", false },
            { "updated_at", false },
            { "attempt_count", false },
            { "max_attempts", false },
            { "splits", false },
            { "next_attempt", false },
            { "id", false },
            { "gateway_response", false },
            { "antifraud_response", false },
            { "metadata", false },
            { "split", false },
            { "interest", false },
            { "fine", false },
            { "max_days_to_pay_past_due", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponse"/> class.
        /// </summary>
        public GetTransactionResponse()
        {
            this.TransactionType = "transaction";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponse"/> class.
        /// </summary>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="success">success.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="attemptCount">attempt_count.</param>
        /// <param name="maxAttempts">max_attempts.</param>
        /// <param name="splits">splits.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="id">id.</param>
        /// <param name="gatewayResponse">gateway_response.</param>
        /// <param name="antifraudResponse">antifraud_response.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="split">split.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public GetTransactionResponse(
            string transactionType = "transaction",
            string gatewayId = null,
            int? amount = null,
            string status = null,
            bool? success = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            int? attemptCount = null,
            int? maxAttempts = null,
            List<Models.GetSplitResponse> splits = null,
            DateTime? nextAttempt = null,
            string id = null,
            Models.GetGatewayResponseResponse gatewayResponse = null,
            Models.GetAntifraudResponse antifraudResponse = null,
            Dictionary<string, string> metadata = null,
            List<Models.GetSplitResponse> split = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null)
        {

            if (gatewayId != null)
            {
                this.GatewayId = gatewayId;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (success != null)
            {
                this.Success = success;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (attemptCount != null)
            {
                this.AttemptCount = attemptCount;
            }

            if (maxAttempts != null)
            {
                this.MaxAttempts = maxAttempts;
            }

            if (splits != null)
            {
                this.Splits = splits;
            }

            if (nextAttempt != null)
            {
                this.NextAttempt = nextAttempt;
            }
            this.TransactionType = transactionType;

            if (id != null)
            {
                this.Id = id;
            }

            if (gatewayResponse != null)
            {
                this.GatewayResponse = gatewayResponse;
            }

            if (antifraudResponse != null)
            {
                this.AntifraudResponse = antifraudResponse;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (split != null)
            {
                this.Split = split;
            }

            if (interest != null)
            {
                this.Interest = interest;
            }

            if (fine != null)
            {
                this.Fine = fine;
            }

            if (maxDaysToPayPastDue != null)
            {
                this.MaxDaysToPayPastDue = maxDaysToPayPastDue;
            }
        }

        /// <summary>
        /// Gateway transaction id
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

        /// <summary>
        /// Amount in cents
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
        /// Transaction status
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
        /// Indicates if the transaction ocurred successfuly
        /// </summary>
        [JsonProperty("success")]
        public bool? Success
        {
            get
            {
                return this.success;
            }

            set
            {
                this.shouldSerialize["success"] = true;
                this.success = value;
            }
        }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime? CreatedAt
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
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt
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

        /// <summary>
        /// Number of attempts tried
        /// </summary>
        [JsonProperty("attempt_count")]
        public int? AttemptCount
        {
            get
            {
                return this.attemptCount;
            }

            set
            {
                this.shouldSerialize["attempt_count"] = true;
                this.attemptCount = value;
            }
        }

        /// <summary>
        /// Max attempts
        /// </summary>
        [JsonProperty("max_attempts")]
        public int? MaxAttempts
        {
            get
            {
                return this.maxAttempts;
            }

            set
            {
                this.shouldSerialize["max_attempts"] = true;
                this.maxAttempts = value;
            }
        }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("splits")]
        public List<Models.GetSplitResponse> Splits
        {
            get
            {
                return this.splits;
            }

            set
            {
                this.shouldSerialize["splits"] = true;
                this.splits = value;
            }
        }

        /// <summary>
        /// Date and time of the next attempt
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_attempt")]
        public DateTime? NextAttempt
        {
            get
            {
                return this.nextAttempt;
            }

            set
            {
                this.shouldSerialize["next_attempt"] = true;
                this.nextAttempt = value;
            }
        }

        /// <summary>
        /// Gets or sets TransactionType.
        /// </summary>
        [JsonProperty("transaction_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Código da transação
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
        /// The Gateway Response
        /// </summary>
        [JsonProperty("gateway_response")]
        public Models.GetGatewayResponseResponse GatewayResponse
        {
            get
            {
                return this.gatewayResponse;
            }

            set
            {
                this.shouldSerialize["gateway_response"] = true;
                this.gatewayResponse = value;
            }
        }

        /// <summary>
        /// Gets or sets AntifraudResponse.
        /// </summary>
        [JsonProperty("antifraud_response")]
        public Models.GetAntifraudResponse AntifraudResponse
        {
            get
            {
                return this.antifraudResponse;
            }

            set
            {
                this.shouldSerialize["antifraud_response"] = true;
                this.antifraudResponse = value;
            }
        }

        /// <summary>
        /// Gets or sets Metadata.
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
        /// Gets or sets Split.
        /// </summary>
        [JsonProperty("split")]
        public List<Models.GetSplitResponse> Split
        {
            get
            {
                return this.split;
            }

            set
            {
                this.shouldSerialize["split"] = true;
                this.split = value;
            }
        }

        /// <summary>
        /// Gets or sets Interest.
        /// </summary>
        [JsonProperty("interest")]
        public Models.GetInterestResponse Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                this.shouldSerialize["interest"] = true;
                this.interest = value;
            }
        }

        /// <summary>
        /// Gets or sets Fine.
        /// </summary>
        [JsonProperty("fine")]
        public Models.GetFineResponse Fine
        {
            get
            {
                return this.fine;
            }

            set
            {
                this.shouldSerialize["fine"] = true;
                this.fine = value;
            }
        }

        /// <summary>
        /// Gets or sets MaxDaysToPayPastDue.
        /// </summary>
        [JsonProperty("max_days_to_pay_past_due")]
        public int? MaxDaysToPayPastDue
        {
            get
            {
                return this.maxDaysToPayPastDue;
            }

            set
            {
                this.shouldSerialize["max_days_to_pay_past_due"] = true;
                this.maxDaysToPayPastDue = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetTransactionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayId()
        {
            this.shouldSerialize["gateway_id"] = false;
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
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSuccess()
        {
            this.shouldSerialize["success"] = false;
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
        public void UnsetUpdatedAt()
        {
            this.shouldSerialize["updated_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAttemptCount()
        {
            this.shouldSerialize["attempt_count"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaxAttempts()
        {
            this.shouldSerialize["max_attempts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSplits()
        {
            this.shouldSerialize["splits"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNextAttempt()
        {
            this.shouldSerialize["next_attempt"] = false;
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
        public void UnsetGatewayResponse()
        {
            this.shouldSerialize["gateway_response"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAntifraudResponse()
        {
            this.shouldSerialize["antifraud_response"] = false;
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
        public void UnsetSplit()
        {
            this.shouldSerialize["split"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInterest()
        {
            this.shouldSerialize["interest"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFine()
        {
            this.shouldSerialize["fine"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaxDaysToPayPastDue()
        {
            this.shouldSerialize["max_days_to_pay_past_due"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayId()
        {
            return this.shouldSerialize["gateway_id"];
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
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSuccess()
        {
            return this.shouldSerialize["success"];
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
        public bool ShouldSerializeUpdatedAt()
        {
            return this.shouldSerialize["updated_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAttemptCount()
        {
            return this.shouldSerialize["attempt_count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxAttempts()
        {
            return this.shouldSerialize["max_attempts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSplits()
        {
            return this.shouldSerialize["splits"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextAttempt()
        {
            return this.shouldSerialize["next_attempt"];
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
        public bool ShouldSerializeGatewayResponse()
        {
            return this.shouldSerialize["gateway_response"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAntifraudResponse()
        {
            return this.shouldSerialize["antifraud_response"];
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
        public bool ShouldSerializeSplit()
        {
            return this.shouldSerialize["split"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInterest()
        {
            return this.shouldSerialize["interest"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFine()
        {
            return this.shouldSerialize["fine"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxDaysToPayPastDue()
        {
            return this.shouldSerialize["max_days_to_pay_past_due"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetTransactionResponse other &&
                (this.GatewayId == null && other.GatewayId == null ||
                 this.GatewayId?.Equals(other.GatewayId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Success == null && other.Success == null ||
                 this.Success?.Equals(other.Success) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.AttemptCount == null && other.AttemptCount == null ||
                 this.AttemptCount?.Equals(other.AttemptCount) == true) &&
                (this.MaxAttempts == null && other.MaxAttempts == null ||
                 this.MaxAttempts?.Equals(other.MaxAttempts) == true) &&
                (this.Splits == null && other.Splits == null ||
                 this.Splits?.Equals(other.Splits) == true) &&
                (this.NextAttempt == null && other.NextAttempt == null ||
                 this.NextAttempt?.Equals(other.NextAttempt) == true) &&
                (this.TransactionType == null && other.TransactionType == null ||
                 this.TransactionType?.Equals(other.TransactionType) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.GatewayResponse == null && other.GatewayResponse == null ||
                 this.GatewayResponse?.Equals(other.GatewayResponse) == true) &&
                (this.AntifraudResponse == null && other.AntifraudResponse == null ||
                 this.AntifraudResponse?.Equals(other.AntifraudResponse) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Split == null && other.Split == null ||
                 this.Split?.Equals(other.Split) == true) &&
                (this.Interest == null && other.Interest == null ||
                 this.Interest?.Equals(other.Interest) == true) &&
                (this.Fine == null && other.Fine == null ||
                 this.Fine?.Equals(other.Fine) == true) &&
                (this.MaxDaysToPayPastDue == null && other.MaxDaysToPayPastDue == null ||
                 this.MaxDaysToPayPastDue?.Equals(other.MaxDaysToPayPastDue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"GatewayId = {this.GatewayId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Success = {(this.Success == null ? "null" : this.Success.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"AttemptCount = {(this.AttemptCount == null ? "null" : this.AttemptCount.ToString())}");
            toStringOutput.Add($"MaxAttempts = {(this.MaxAttempts == null ? "null" : this.MaxAttempts.ToString())}");
            toStringOutput.Add($"Splits = {(this.Splits == null ? "null" : $"[{string.Join(", ", this.Splits)} ]")}");
            toStringOutput.Add($"NextAttempt = {(this.NextAttempt == null ? "null" : this.NextAttempt.ToString())}");
            toStringOutput.Add($"TransactionType = {this.TransactionType ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"GatewayResponse = {(this.GatewayResponse == null ? "null" : this.GatewayResponse.ToString())}");
            toStringOutput.Add($"AntifraudResponse = {(this.AntifraudResponse == null ? "null" : this.AntifraudResponse.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Split = {(this.Split == null ? "null" : $"[{string.Join(", ", this.Split)} ]")}");
            toStringOutput.Add($"Interest = {(this.Interest == null ? "null" : this.Interest.ToString())}");
            toStringOutput.Add($"Fine = {(this.Fine == null ? "null" : this.Fine.ToString())}");
            toStringOutput.Add($"MaxDaysToPayPastDue = {(this.MaxDaysToPayPastDue == null ? "null" : this.MaxDaysToPayPastDue.ToString())}");
        }
    }
}