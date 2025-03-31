// <copyright file="GetPixTransactionResponse.cs" company="APIMatic">
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
    /// GetPixTransactionResponse.
    /// </summary>
    public class GetPixTransactionResponse : GetTransactionResponse
    {
        private string qrCode;
        private string qrCodeUrl;
        private DateTime? expiresAt;
        private List<Models.PixAdditionalInformation> additionalInformation;
        private string endToEndId;
        private Models.GetPixPayerResponse payer;
        private string pixProviderTid;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "qr_code", false },
            { "qr_code_url", false },
            { "expires_at", false },
            { "additional_information", false },
            { "end_to_end_id", false },
            { "payer", false },
            { "pix_provider_tid", false },
        };

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
        /// <param name="pixProviderTid">pix_provider_tid.</param>
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
            Models.GetPixPayerResponse payer = null,
            string pixProviderTid = null)
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

            if (qrCode != null)
            {
                this.QrCode = qrCode;
            }

            if (qrCodeUrl != null)
            {
                this.QrCodeUrl = qrCodeUrl;
            }

            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }

            if (additionalInformation != null)
            {
                this.AdditionalInformation = additionalInformation;
            }

            if (endToEndId != null)
            {
                this.EndToEndId = endToEndId;
            }

            if (payer != null)
            {
                this.Payer = payer;
            }

            if (pixProviderTid != null)
            {
                this.PixProviderTid = pixProviderTid;
            }
        }

        /// <summary>
        /// Gets or sets QrCode.
        /// </summary>
        [JsonProperty("qr_code")]
        public string QrCode
        {
            get
            {
                return this.qrCode;
            }

            set
            {
                this.shouldSerialize["qr_code"] = true;
                this.qrCode = value;
            }
        }

        /// <summary>
        /// Gets or sets QrCodeUrl.
        /// </summary>
        [JsonProperty("qr_code_url")]
        public string QrCodeUrl
        {
            get
            {
                return this.qrCodeUrl;
            }

            set
            {
                this.shouldSerialize["qr_code_url"] = true;
                this.qrCodeUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt
        {
            get
            {
                return this.expiresAt;
            }

            set
            {
                this.shouldSerialize["expires_at"] = true;
                this.expiresAt = value;
            }
        }

        /// <summary>
        /// Gets or sets AdditionalInformation.
        /// </summary>
        [JsonProperty("additional_information")]
        public List<Models.PixAdditionalInformation> AdditionalInformation
        {
            get
            {
                return this.additionalInformation;
            }

            set
            {
                this.shouldSerialize["additional_information"] = true;
                this.additionalInformation = value;
            }
        }

        /// <summary>
        /// Gets or sets EndToEndId.
        /// </summary>
        [JsonProperty("end_to_end_id")]
        public string EndToEndId
        {
            get
            {
                return this.endToEndId;
            }

            set
            {
                this.shouldSerialize["end_to_end_id"] = true;
                this.endToEndId = value;
            }
        }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer")]
        public Models.GetPixPayerResponse Payer
        {
            get
            {
                return this.payer;
            }

            set
            {
                this.shouldSerialize["payer"] = true;
                this.payer = value;
            }
        }

        /// <summary>
        /// Pix provider TID
        /// </summary>
        [JsonProperty("pix_provider_tid")]
        public string PixProviderTid
        {
            get
            {
                return this.pixProviderTid;
            }

            set
            {
                this.shouldSerialize["pix_provider_tid"] = true;
                this.pixProviderTid = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPixTransactionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetQrCode()
        {
            this.shouldSerialize["qr_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetQrCodeUrl()
        {
            this.shouldSerialize["qr_code_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation()
        {
            this.shouldSerialize["additional_information"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEndToEndId()
        {
            this.shouldSerialize["end_to_end_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPayer()
        {
            this.shouldSerialize["payer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPixProviderTid()
        {
            this.shouldSerialize["pix_provider_tid"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeQrCode()
        {
            return this.shouldSerialize["qr_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeQrCodeUrl()
        {
            return this.shouldSerialize["qr_code_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return this.shouldSerialize["expires_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation()
        {
            return this.shouldSerialize["additional_information"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndToEndId()
        {
            return this.shouldSerialize["end_to_end_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayer()
        {
            return this.shouldSerialize["payer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePixProviderTid()
        {
            return this.shouldSerialize["pix_provider_tid"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPixTransactionResponse other &&
                (this.QrCode == null && other.QrCode == null ||
                 this.QrCode?.Equals(other.QrCode) == true) &&
                (this.QrCodeUrl == null && other.QrCodeUrl == null ||
                 this.QrCodeUrl?.Equals(other.QrCodeUrl) == true) &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                (this.AdditionalInformation == null && other.AdditionalInformation == null ||
                 this.AdditionalInformation?.Equals(other.AdditionalInformation) == true) &&
                (this.EndToEndId == null && other.EndToEndId == null ||
                 this.EndToEndId?.Equals(other.EndToEndId) == true) &&
                (this.Payer == null && other.Payer == null ||
                 this.Payer?.Equals(other.Payer) == true) &&
                (this.PixProviderTid == null && other.PixProviderTid == null ||
                 this.PixProviderTid?.Equals(other.PixProviderTid) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"QrCode = {this.QrCode ?? "null"}");
            toStringOutput.Add($"QrCodeUrl = {this.QrCodeUrl ?? "null"}");
            toStringOutput.Add($"ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"AdditionalInformation = {(this.AdditionalInformation == null ? "null" : $"[{string.Join(", ", this.AdditionalInformation)} ]")}");
            toStringOutput.Add($"EndToEndId = {this.EndToEndId ?? "null"}");
            toStringOutput.Add($"Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"PixProviderTid = {this.PixProviderTid ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}