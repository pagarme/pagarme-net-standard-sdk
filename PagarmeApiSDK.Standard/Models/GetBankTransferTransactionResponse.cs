// <copyright file="GetBankTransferTransactionResponse.cs" company="APIMatic">
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
    /// GetBankTransferTransactionResponse.
    /// </summary>
    public class GetBankTransferTransactionResponse : GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBankTransferTransactionResponse"/> class.
        /// </summary>
        public GetBankTransferTransactionResponse()
        {
            this.TransactionType = "bank_transfer";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBankTransferTransactionResponse"/> class.
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
        /// <param name="url">url.</param>
        /// <param name="bankTid">bank_tid.</param>
        /// <param name="bank">bank.</param>
        /// <param name="paidAt">paid_at.</param>
        /// <param name="paidAmount">paid_amount.</param>
        public GetBankTransferTransactionResponse(
            string transactionType = "bank_transfer",
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
            int? maxDaysToPayPastDue = null,
            string url = null,
            string bankTid = null,
            string bank = null,
            DateTime? paidAt = null,
            int? paidAmount = null)
            : base(
                transactionType,
                gatewayId,
                amount,
                status,
                success,
                createdAt,
                updatedAt,
                attemptCount,
                maxAttempts,
                splits,
                nextAttempt,
                id,
                gatewayResponse,
                antifraudResponse,
                metadata,
                split,
                interest,
                fine,
                maxDaysToPayPastDue)
        {
            this.Url = url;
            this.BankTid = bankTid;
            this.Bank = bank;
            this.PaidAt = paidAt;
            this.PaidAmount = paidAmount;
        }

        /// <summary>
        /// Payment url
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Transaction identifier for the bank
        /// </summary>
        [JsonProperty("bank_tid", NullValueHandling = NullValueHandling.Ignore)]
        public string BankTid { get; set; }

        /// <summary>
        /// Bank
        /// </summary>
        [JsonProperty("bank", NullValueHandling = NullValueHandling.Ignore)]
        public string Bank { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// Paid amount
        /// </summary>
        [JsonProperty("paid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaidAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetBankTransferTransactionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetBankTransferTransactionResponse other &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.BankTid == null && other.BankTid == null ||
                 this.BankTid?.Equals(other.BankTid) == true) &&
                (this.Bank == null && other.Bank == null ||
                 this.Bank?.Equals(other.Bank) == true) &&
                (this.PaidAt == null && other.PaidAt == null ||
                 this.PaidAt?.Equals(other.PaidAt) == true) &&
                (this.PaidAmount == null && other.PaidAmount == null ||
                 this.PaidAmount?.Equals(other.PaidAmount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"BankTid = {this.BankTid ?? "null"}");
            toStringOutput.Add($"Bank = {this.Bank ?? "null"}");
            toStringOutput.Add($"PaidAt = {(this.PaidAt == null ? "null" : this.PaidAt.ToString())}");
            toStringOutput.Add($"PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}