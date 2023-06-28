// <copyright file="GetMovementObjectTransferResponse.cs" company="APIMatic">
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
    /// GetMovementObjectTransferResponse.
    /// </summary>
    public class GetMovementObjectTransferResponse : GetMovementObjectBaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectTransferResponse"/> class.
        /// </summary>
        public GetMovementObjectTransferResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectTransferResponse"/> class.
        /// </summary>
        /// <param name="sourceType">source_type.</param>
        /// <param name="sourceId">source_id.</param>
        /// <param name="targetType">target_type.</param>
        /// <param name="targetId">target_id.</param>
        /// <param name="fee">fee.</param>
        /// <param name="fundingDate">funding_date.</param>
        /// <param name="fundingEstimatedDate">funding_estimated_date.</param>
        /// <param name="bankAccount">bank_account.</param>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="type">type.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        public GetMovementObjectTransferResponse(
            string sourceType,
            string sourceId,
            string targetType,
            string targetId,
            string fee,
            string fundingDate,
            string fundingEstimatedDate,
            string bankAccount,
            string mObject = null,
            string id = null,
            string status = null,
            string amount = null,
            string createdAt = null,
            string type = null,
            string chargeId = null,
            string gatewayId = null)
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
            this.SourceType = sourceType;
            this.SourceId = sourceId;
            this.TargetType = targetType;
            this.TargetId = targetId;
            this.Fee = fee;
            this.FundingDate = fundingDate;
            this.FundingEstimatedDate = fundingEstimatedDate;
            this.BankAccount = bankAccount;
        }

        /// <summary>
        /// Gets or sets SourceType.
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or sets SourceId.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or sets TargetType.
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// Gets or sets TargetId.
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Gets or sets FundingDate.
        /// </summary>
        [JsonProperty("funding_date")]
        public string FundingDate { get; set; }

        /// <summary>
        /// Gets or sets FundingEstimatedDate.
        /// </summary>
        [JsonProperty("funding_estimated_date")]
        public string FundingEstimatedDate { get; set; }

        /// <summary>
        /// Gets or sets BankAccount.
        /// </summary>
        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetMovementObjectTransferResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetMovementObjectTransferResponse other &&                ((this.SourceType == null && other.SourceType == null) || (this.SourceType?.Equals(other.SourceType) == true)) &&
                ((this.SourceId == null && other.SourceId == null) || (this.SourceId?.Equals(other.SourceId) == true)) &&
                ((this.TargetType == null && other.TargetType == null) || (this.TargetType?.Equals(other.TargetType) == true)) &&
                ((this.TargetId == null && other.TargetId == null) || (this.TargetId?.Equals(other.TargetId) == true)) &&
                ((this.Fee == null && other.Fee == null) || (this.Fee?.Equals(other.Fee) == true)) &&
                ((this.FundingDate == null && other.FundingDate == null) || (this.FundingDate?.Equals(other.FundingDate) == true)) &&
                ((this.FundingEstimatedDate == null && other.FundingEstimatedDate == null) || (this.FundingEstimatedDate?.Equals(other.FundingEstimatedDate) == true)) &&
                ((this.BankAccount == null && other.BankAccount == null) || (this.BankAccount?.Equals(other.BankAccount) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SourceType = {(this.SourceType == null ? "null" : this.SourceType == string.Empty ? "" : this.SourceType)}");
            toStringOutput.Add($"this.SourceId = {(this.SourceId == null ? "null" : this.SourceId == string.Empty ? "" : this.SourceId)}");
            toStringOutput.Add($"this.TargetType = {(this.TargetType == null ? "null" : this.TargetType == string.Empty ? "" : this.TargetType)}");
            toStringOutput.Add($"this.TargetId = {(this.TargetId == null ? "null" : this.TargetId == string.Empty ? "" : this.TargetId)}");
            toStringOutput.Add($"this.Fee = {(this.Fee == null ? "null" : this.Fee == string.Empty ? "" : this.Fee)}");
            toStringOutput.Add($"this.FundingDate = {(this.FundingDate == null ? "null" : this.FundingDate == string.Empty ? "" : this.FundingDate)}");
            toStringOutput.Add($"this.FundingEstimatedDate = {(this.FundingEstimatedDate == null ? "null" : this.FundingEstimatedDate == string.Empty ? "" : this.FundingEstimatedDate)}");
            toStringOutput.Add($"this.BankAccount = {(this.BankAccount == null ? "null" : this.BankAccount == string.Empty ? "" : this.BankAccount)}");

            base.ToString(toStringOutput);
        }
    }
}