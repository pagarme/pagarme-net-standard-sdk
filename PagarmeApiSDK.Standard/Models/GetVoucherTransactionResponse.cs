// <copyright file="GetVoucherTransactionResponse.cs" company="APIMatic">
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
    /// GetVoucherTransactionResponse.
    /// </summary>
    public class GetVoucherTransactionResponse : GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoucherTransactionResponse"/> class.
        /// </summary>
        public GetVoucherTransactionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoucherTransactionResponse"/> class.
        /// </summary>
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
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="id">id.</param>
        /// <param name="gatewayResponse">gateway_response.</param>
        /// <param name="antifraudResponse">antifraud_response.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="split">split.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="acquirerName">acquirer_name.</param>
        /// <param name="acquirerAffiliationCode">acquirer_affiliation_code.</param>
        /// <param name="acquirerTid">acquirer_tid.</param>
        /// <param name="acquirerNsu">acquirer_nsu.</param>
        /// <param name="acquirerAuthCode">acquirer_auth_code.</param>
        /// <param name="acquirerMessage">acquirer_message.</param>
        /// <param name="acquirerReturnCode">acquirer_return_code.</param>
        /// <param name="operationType">operation_type.</param>
        /// <param name="card">card.</param>
        public GetVoucherTransactionResponse(
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
            string transactionType = null,
            string id = null,
            Models.GetGatewayResponseResponse gatewayResponse = null,
            Models.GetAntifraudResponse antifraudResponse = null,
            Dictionary<string, string> metadata = null,
            List<Models.GetSplitResponse> split = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null,
            string statementDescriptor = null,
            string acquirerName = null,
            string acquirerAffiliationCode = null,
            string acquirerTid = null,
            string acquirerNsu = null,
            string acquirerAuthCode = null,
            string acquirerMessage = null,
            string acquirerReturnCode = null,
            string operationType = null,
            Models.GetCardResponse card = null)
            : base(
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
                transactionType,
                id,
                gatewayResponse,
                antifraudResponse,
                metadata,
                split,
                interest,
                fine,
                maxDaysToPayPastDue)
        {
            this.StatementDescriptor = statementDescriptor;
            this.AcquirerName = acquirerName;
            this.AcquirerAffiliationCode = acquirerAffiliationCode;
            this.AcquirerTid = acquirerTid;
            this.AcquirerNsu = acquirerNsu;
            this.AcquirerAuthCode = acquirerAuthCode;
            this.AcquirerMessage = acquirerMessage;
            this.AcquirerReturnCode = acquirerReturnCode;
            this.OperationType = operationType;
            this.Card = card;
        }

        /// <summary>
        /// Text that will appear on the voucher's statement
        /// </summary>
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Include)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Acquirer name
        /// </summary>
        [JsonProperty("acquirer_name", NullValueHandling = NullValueHandling.Include)]
        public string AcquirerName { get; set; }

        /// <summary>
        /// Acquirer affiliation code
        /// </summary>
        [JsonProperty("acquirer_affiliation_code", NullValueHandling = NullValueHandling.Include)]
        public string AcquirerAffiliationCode { get; set; }

        /// <summary>
        /// Acquirer TID
        /// </summary>
        [JsonProperty("acquirer_tid", NullValueHandling = NullValueHandling.Include)]
        public string AcquirerTid { get; set; }

        /// <summary>
        /// Acquirer NSU
        /// </summary>
        [JsonProperty("acquirer_nsu", NullValueHandling = NullValueHandling.Include)]
        public string AcquirerNsu { get; set; }

        /// <summary>
        /// Acquirer authorization code
        /// </summary>
        [JsonProperty("acquirer_auth_code", NullValueHandling = NullValueHandling.Include)]
        public string AcquirerAuthCode { get; set; }

        /// <summary>
        /// acquirer_message
        /// </summary>
        [JsonProperty("acquirer_message", NullValueHandling = NullValueHandling.Include)]
        public string AcquirerMessage { get; set; }

        /// <summary>
        /// Acquirer return code
        /// </summary>
        [JsonProperty("acquirer_return_code", NullValueHandling = NullValueHandling.Include)]
        public string AcquirerReturnCode { get; set; }

        /// <summary>
        /// Operation type
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Include)]
        public string OperationType { get; set; }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Include)]
        public Models.GetCardResponse Card { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetVoucherTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetVoucherTransactionResponse other &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                ((this.AcquirerName == null && other.AcquirerName == null) || (this.AcquirerName?.Equals(other.AcquirerName) == true)) &&
                ((this.AcquirerAffiliationCode == null && other.AcquirerAffiliationCode == null) || (this.AcquirerAffiliationCode?.Equals(other.AcquirerAffiliationCode) == true)) &&
                ((this.AcquirerTid == null && other.AcquirerTid == null) || (this.AcquirerTid?.Equals(other.AcquirerTid) == true)) &&
                ((this.AcquirerNsu == null && other.AcquirerNsu == null) || (this.AcquirerNsu?.Equals(other.AcquirerNsu) == true)) &&
                ((this.AcquirerAuthCode == null && other.AcquirerAuthCode == null) || (this.AcquirerAuthCode?.Equals(other.AcquirerAuthCode) == true)) &&
                ((this.AcquirerMessage == null && other.AcquirerMessage == null) || (this.AcquirerMessage?.Equals(other.AcquirerMessage) == true)) &&
                ((this.AcquirerReturnCode == null && other.AcquirerReturnCode == null) || (this.AcquirerReturnCode?.Equals(other.AcquirerReturnCode) == true)) &&
                ((this.OperationType == null && other.OperationType == null) || (this.OperationType?.Equals(other.OperationType) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");
            toStringOutput.Add($"this.AcquirerName = {(this.AcquirerName == null ? "null" : this.AcquirerName == string.Empty ? "" : this.AcquirerName)}");
            toStringOutput.Add($"this.AcquirerAffiliationCode = {(this.AcquirerAffiliationCode == null ? "null" : this.AcquirerAffiliationCode == string.Empty ? "" : this.AcquirerAffiliationCode)}");
            toStringOutput.Add($"this.AcquirerTid = {(this.AcquirerTid == null ? "null" : this.AcquirerTid == string.Empty ? "" : this.AcquirerTid)}");
            toStringOutput.Add($"this.AcquirerNsu = {(this.AcquirerNsu == null ? "null" : this.AcquirerNsu == string.Empty ? "" : this.AcquirerNsu)}");
            toStringOutput.Add($"this.AcquirerAuthCode = {(this.AcquirerAuthCode == null ? "null" : this.AcquirerAuthCode == string.Empty ? "" : this.AcquirerAuthCode)}");
            toStringOutput.Add($"this.AcquirerMessage = {(this.AcquirerMessage == null ? "null" : this.AcquirerMessage == string.Empty ? "" : this.AcquirerMessage)}");
            toStringOutput.Add($"this.AcquirerReturnCode = {(this.AcquirerReturnCode == null ? "null" : this.AcquirerReturnCode == string.Empty ? "" : this.AcquirerReturnCode)}");
            toStringOutput.Add($"this.OperationType = {(this.OperationType == null ? "null" : this.OperationType == string.Empty ? "" : this.OperationType)}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}