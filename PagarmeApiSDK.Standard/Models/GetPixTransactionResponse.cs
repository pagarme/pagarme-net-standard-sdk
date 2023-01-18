// <copyright file="GetPixTransactionResponse.cs" company="APIMatic">
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
    /// GetPixTransactionResponse.
    /// </summary>
    public class GetPixTransactionResponse : GetTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixTransactionResponse"/> class.
        /// </summary>
        public GetPixTransactionResponse()
        {
            this.TransactionType = "pix";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixTransactionResponse"/> class.
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
        /// <param name="qrCode">qr_code.</param>
        /// <param name="qrCodeUrl">qr_code_url.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="additionalInformation">additional_information.</param>
        /// <param name="endToEndId">end_to_end_id.</param>
        /// <param name="payer">payer.</param>
        public GetPixTransactionResponse(
            string transactionType = "pix",
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
            string qrCode = null,
            string qrCodeUrl = null,
            DateTime? expiresAt = null,
            List<Models.PixAdditionalInformation> additionalInformation = null,
            string endToEndId = null,
            Models.GetPixPayerResponse payer = null)
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
            this.QrCode = qrCode;
            this.QrCodeUrl = qrCodeUrl;
            this.ExpiresAt = expiresAt;
            this.AdditionalInformation = additionalInformation;
            this.EndToEndId = endToEndId;
            this.Payer = payer;
        }

        /// <summary>
        /// Gets or sets QrCode.
        /// </summary>
        [JsonProperty("qr_code", NullValueHandling = NullValueHandling.Include)]
        public string QrCode { get; set; }

        /// <summary>
        /// Gets or sets QrCodeUrl.
        /// </summary>
        [JsonProperty("qr_code_url", NullValueHandling = NullValueHandling.Include)]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets AdditionalInformation.
        /// </summary>
        [JsonProperty("additional_information", NullValueHandling = NullValueHandling.Include)]
        public List<Models.PixAdditionalInformation> AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets EndToEndId.
        /// </summary>
        [JsonProperty("end_to_end_id", NullValueHandling = NullValueHandling.Include)]
        public string EndToEndId { get; set; }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer", NullValueHandling = NullValueHandling.Include)]
        public Models.GetPixPayerResponse Payer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPixTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPixTransactionResponse other &&
                ((this.QrCode == null && other.QrCode == null) || (this.QrCode?.Equals(other.QrCode) == true)) &&
                ((this.QrCodeUrl == null && other.QrCodeUrl == null) || (this.QrCodeUrl?.Equals(other.QrCodeUrl) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.AdditionalInformation == null && other.AdditionalInformation == null) || (this.AdditionalInformation?.Equals(other.AdditionalInformation) == true)) &&
                ((this.EndToEndId == null && other.EndToEndId == null) || (this.EndToEndId?.Equals(other.EndToEndId) == true)) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QrCode = {(this.QrCode == null ? "null" : this.QrCode == string.Empty ? "" : this.QrCode)}");
            toStringOutput.Add($"this.QrCodeUrl = {(this.QrCodeUrl == null ? "null" : this.QrCodeUrl == string.Empty ? "" : this.QrCodeUrl)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.AdditionalInformation = {(this.AdditionalInformation == null ? "null" : $"[{string.Join(", ", this.AdditionalInformation)} ]")}");
            toStringOutput.Add($"this.EndToEndId = {(this.EndToEndId == null ? "null" : this.EndToEndId == string.Empty ? "" : this.EndToEndId)}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}