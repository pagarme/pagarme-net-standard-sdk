// <copyright file="GetTransactionResponse.cs" company="APIMatic">
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
    /// GetTransactionResponse.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "transaction_type")]
    [JsonSubtypes.KnownSubType(typeof(GetBankTransferTransactionResponse), "bank_transfer")]
    [JsonSubtypes.KnownSubType(typeof(GetSafetyPayTransactionResponse), "safetypay")]
    [JsonSubtypes.KnownSubType(typeof(GetVoucherTransactionResponse), "voucher")]
    [JsonSubtypes.KnownSubType(typeof(GetBoletoTransactionResponse), "boleto")]
    [JsonSubtypes.KnownSubType(typeof(GetDebitCardTransactionResponse), "debit_card")]
    [JsonSubtypes.KnownSubType(typeof(GetPrivateLabelTransactionResponse), "private_label")]
    [JsonSubtypes.KnownSubType(typeof(GetCashTransactionResponse), "cash")]
    [JsonSubtypes.KnownSubType(typeof(GetCreditCardTransactionResponse), "credit_card")]
    [JsonSubtypes.KnownSubType(typeof(GetPixTransactionResponse), "pix")]
    public class GetTransactionResponse
    {
        private DateTime? nextAttempt;
        private Dictionary<string, string> metadata;
        private Models.GetInterestResponse interest;
        private Models.GetFineResponse fine;
        private int? maxDaysToPayPastDue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "next_attempt", false },
            { "metadata", false },
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
            this.GatewayId = gatewayId;
            this.Amount = amount;
            this.Status = status;
            this.Success = success;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AttemptCount = attemptCount;
            this.MaxAttempts = maxAttempts;
            this.Splits = splits;
            if (nextAttempt != null)
            {
                this.NextAttempt = nextAttempt;
            }

            this.TransactionType = transactionType;
            this.Id = id;
            this.GatewayResponse = gatewayResponse;
            this.AntifraudResponse = antifraudResponse;
            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            this.Split = split;
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
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Include)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Amount in cents
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

        /// <summary>
        /// Transaction status
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates if the transaction ocurred successfuly
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Include)]
        public bool? Success { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Number of attempts tried
        /// </summary>
        [JsonProperty("attempt_count", NullValueHandling = NullValueHandling.Include)]
        public int? AttemptCount { get; set; }

        /// <summary>
        /// Max attempts
        /// </summary>
        [JsonProperty("max_attempts", NullValueHandling = NullValueHandling.Include)]
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("splits", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetSplitResponse> Splits { get; set; }

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
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// The Gateway Response
        /// </summary>
        [JsonProperty("gateway_response", NullValueHandling = NullValueHandling.Include)]
        public Models.GetGatewayResponseResponse GatewayResponse { get; set; }

        /// <summary>
        /// Gets or sets AntifraudResponse.
        /// </summary>
        [JsonProperty("antifraud_response", NullValueHandling = NullValueHandling.Include)]
        public Models.GetAntifraudResponse AntifraudResponse { get; set; }

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
        [JsonProperty("split", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetSplitResponse> Split { get; set; }

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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNextAttempt()
        {
            this.shouldSerialize["next_attempt"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMetadata()
        {
            this.shouldSerialize["metadata"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInterest()
        {
            this.shouldSerialize["interest"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFine()
        {
            this.shouldSerialize["fine"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMaxDaysToPayPastDue()
        {
            this.shouldSerialize["max_days_to_pay_past_due"] = false;
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
        public bool ShouldSerializeMetadata()
        {
            return this.shouldSerialize["metadata"];
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetTransactionResponse other &&
                ((this.GatewayId == null && other.GatewayId == null) || (this.GatewayId?.Equals(other.GatewayId) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Success == null && other.Success == null) || (this.Success?.Equals(other.Success) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.AttemptCount == null && other.AttemptCount == null) || (this.AttemptCount?.Equals(other.AttemptCount) == true)) &&
                ((this.MaxAttempts == null && other.MaxAttempts == null) || (this.MaxAttempts?.Equals(other.MaxAttempts) == true)) &&
                ((this.Splits == null && other.Splits == null) || (this.Splits?.Equals(other.Splits) == true)) &&
                ((this.NextAttempt == null && other.NextAttempt == null) || (this.NextAttempt?.Equals(other.NextAttempt) == true)) &&
                ((this.TransactionType == null && other.TransactionType == null) || (this.TransactionType?.Equals(other.TransactionType) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.GatewayResponse == null && other.GatewayResponse == null) || (this.GatewayResponse?.Equals(other.GatewayResponse) == true)) &&
                ((this.AntifraudResponse == null && other.AntifraudResponse == null) || (this.AntifraudResponse?.Equals(other.AntifraudResponse) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Split == null && other.Split == null) || (this.Split?.Equals(other.Split) == true)) &&
                ((this.Interest == null && other.Interest == null) || (this.Interest?.Equals(other.Interest) == true)) &&
                ((this.Fine == null && other.Fine == null) || (this.Fine?.Equals(other.Fine) == true)) &&
                ((this.MaxDaysToPayPastDue == null && other.MaxDaysToPayPastDue == null) || (this.MaxDaysToPayPastDue?.Equals(other.MaxDaysToPayPastDue) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GatewayId = {(this.GatewayId == null ? "null" : this.GatewayId == string.Empty ? "" : this.GatewayId)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Success = {(this.Success == null ? "null" : this.Success.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.AttemptCount = {(this.AttemptCount == null ? "null" : this.AttemptCount.ToString())}");
            toStringOutput.Add($"this.MaxAttempts = {(this.MaxAttempts == null ? "null" : this.MaxAttempts.ToString())}");
            toStringOutput.Add($"this.Splits = {(this.Splits == null ? "null" : $"[{string.Join(", ", this.Splits)} ]")}");
            toStringOutput.Add($"this.NextAttempt = {(this.NextAttempt == null ? "null" : this.NextAttempt.ToString())}");
            toStringOutput.Add($"this.TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType == string.Empty ? "" : this.TransactionType)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.GatewayResponse = {(this.GatewayResponse == null ? "null" : this.GatewayResponse.ToString())}");
            toStringOutput.Add($"this.AntifraudResponse = {(this.AntifraudResponse == null ? "null" : this.AntifraudResponse.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Split = {(this.Split == null ? "null" : $"[{string.Join(", ", this.Split)} ]")}");
            toStringOutput.Add($"this.Interest = {(this.Interest == null ? "null" : this.Interest.ToString())}");
            toStringOutput.Add($"this.Fine = {(this.Fine == null ? "null" : this.Fine.ToString())}");
            toStringOutput.Add($"this.MaxDaysToPayPastDue = {(this.MaxDaysToPayPastDue == null ? "null" : this.MaxDaysToPayPastDue.ToString())}");
        }
    }
}