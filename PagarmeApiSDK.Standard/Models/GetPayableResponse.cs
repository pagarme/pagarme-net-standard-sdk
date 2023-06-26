// <copyright file="GetPayableResponse.cs" company="APIMatic">
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
    /// GetPayableResponse.
    /// </summary>
    public class GetPayableResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPayableResponse"/> class.
        /// </summary>
        public GetPayableResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPayableResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="fee">fee.</param>
        /// <param name="anticipationFee">anticipation_fee.</param>
        /// <param name="fraudCoverageFee">fraud_coverage_fee.</param>
        /// <param name="installment">installment.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="splitId">split_id.</param>
        /// <param name="bulkAnticipationId">bulk_anticipation_id.</param>
        /// <param name="anticipationId">anticipation_id.</param>
        /// <param name="recipientId">recipient_id.</param>
        /// <param name="originatorModel">originator_model.</param>
        /// <param name="originatorModelId">originator_model_id.</param>
        /// <param name="paymentDate">payment_date.</param>
        /// <param name="originalPaymentDate">original_payment_date.</param>
        /// <param name="type">type.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="accrualAt">accrual_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="liquidationArrangementId">liquidation_arrangement_id.</param>
        public GetPayableResponse(
            long id,
            string status,
            int amount,
            int fee,
            int anticipationFee,
            int fraudCoverageFee,
            int installment,
            int gatewayId,
            string chargeId,
            string splitId,
            string bulkAnticipationId,
            string anticipationId,
            string recipientId,
            string originatorModel,
            string originatorModelId,
            DateTime paymentDate,
            DateTime originalPaymentDate,
            string type,
            string paymentMethod,
            DateTime accrualAt,
            DateTime createdAt,
            string liquidationArrangementId)
        {
            this.Id = id;
            this.Status = status;
            this.Amount = amount;
            this.Fee = fee;
            this.AnticipationFee = anticipationFee;
            this.FraudCoverageFee = fraudCoverageFee;
            this.Installment = installment;
            this.GatewayId = gatewayId;
            this.ChargeId = chargeId;
            this.SplitId = splitId;
            this.BulkAnticipationId = bulkAnticipationId;
            this.AnticipationId = anticipationId;
            this.RecipientId = recipientId;
            this.OriginatorModel = originatorModel;
            this.OriginatorModelId = originatorModelId;
            this.PaymentDate = paymentDate;
            this.OriginalPaymentDate = originalPaymentDate;
            this.Type = type;
            this.PaymentMethod = paymentMethod;
            this.AccrualAt = accrualAt;
            this.CreatedAt = createdAt;
            this.LiquidationArrangementId = liquidationArrangementId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee")]
        public int Fee { get; set; }

        /// <summary>
        /// Gets or sets AnticipationFee.
        /// </summary>
        [JsonProperty("anticipation_fee")]
        public int AnticipationFee { get; set; }

        /// <summary>
        /// Gets or sets FraudCoverageFee.
        /// </summary>
        [JsonProperty("fraud_coverage_fee")]
        public int FraudCoverageFee { get; set; }

        /// <summary>
        /// Gets or sets Installment.
        /// </summary>
        [JsonProperty("installment")]
        public int Installment { get; set; }

        /// <summary>
        /// Gets or sets GatewayId.
        /// </summary>
        [JsonProperty("gateway_id")]
        public int GatewayId { get; set; }

        /// <summary>
        /// Gets or sets ChargeId.
        /// </summary>
        [JsonProperty("charge_id")]
        public string ChargeId { get; set; }

        /// <summary>
        /// Gets or sets SplitId.
        /// </summary>
        [JsonProperty("split_id")]
        public string SplitId { get; set; }

        /// <summary>
        /// Gets or sets BulkAnticipationId.
        /// </summary>
        [JsonProperty("bulk_anticipation_id")]
        public string BulkAnticipationId { get; set; }

        /// <summary>
        /// Gets or sets AnticipationId.
        /// </summary>
        [JsonProperty("anticipation_id")]
        public string AnticipationId { get; set; }

        /// <summary>
        /// Gets or sets RecipientId.
        /// </summary>
        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        /// <summary>
        /// Gets or sets OriginatorModel.
        /// </summary>
        [JsonProperty("originator_model")]
        public string OriginatorModel { get; set; }

        /// <summary>
        /// Gets or sets OriginatorModelId.
        /// </summary>
        [JsonProperty("originator_model_id")]
        public string OriginatorModelId { get; set; }

        /// <summary>
        /// Gets or sets PaymentDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date")]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Gets or sets OriginalPaymentDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("original_payment_date")]
        public DateTime OriginalPaymentDate { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets AccrualAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("accrual_at")]
        public DateTime AccrualAt { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets LiquidationArrangementId.
        /// </summary>
        [JsonProperty("liquidation_arrangement_id")]
        public string LiquidationArrangementId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPayableResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetPayableResponse other &&                this.Id.Equals(other.Id) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                this.Amount.Equals(other.Amount) &&
                this.Fee.Equals(other.Fee) &&
                this.AnticipationFee.Equals(other.AnticipationFee) &&
                this.FraudCoverageFee.Equals(other.FraudCoverageFee) &&
                this.Installment.Equals(other.Installment) &&
                this.GatewayId.Equals(other.GatewayId) &&
                ((this.ChargeId == null && other.ChargeId == null) || (this.ChargeId?.Equals(other.ChargeId) == true)) &&
                ((this.SplitId == null && other.SplitId == null) || (this.SplitId?.Equals(other.SplitId) == true)) &&
                ((this.BulkAnticipationId == null && other.BulkAnticipationId == null) || (this.BulkAnticipationId?.Equals(other.BulkAnticipationId) == true)) &&
                ((this.AnticipationId == null && other.AnticipationId == null) || (this.AnticipationId?.Equals(other.AnticipationId) == true)) &&
                ((this.RecipientId == null && other.RecipientId == null) || (this.RecipientId?.Equals(other.RecipientId) == true)) &&
                ((this.OriginatorModel == null && other.OriginatorModel == null) || (this.OriginatorModel?.Equals(other.OriginatorModel) == true)) &&
                ((this.OriginatorModelId == null && other.OriginatorModelId == null) || (this.OriginatorModelId?.Equals(other.OriginatorModelId) == true)) &&
                this.PaymentDate.Equals(other.PaymentDate) &&
                this.OriginalPaymentDate.Equals(other.OriginalPaymentDate) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                this.AccrualAt.Equals(other.AccrualAt) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                ((this.LiquidationArrangementId == null && other.LiquidationArrangementId == null) || (this.LiquidationArrangementId?.Equals(other.LiquidationArrangementId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Fee = {this.Fee}");
            toStringOutput.Add($"this.AnticipationFee = {this.AnticipationFee}");
            toStringOutput.Add($"this.FraudCoverageFee = {this.FraudCoverageFee}");
            toStringOutput.Add($"this.Installment = {this.Installment}");
            toStringOutput.Add($"this.GatewayId = {this.GatewayId}");
            toStringOutput.Add($"this.ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId == string.Empty ? "" : this.ChargeId)}");
            toStringOutput.Add($"this.SplitId = {(this.SplitId == null ? "null" : this.SplitId == string.Empty ? "" : this.SplitId)}");
            toStringOutput.Add($"this.BulkAnticipationId = {(this.BulkAnticipationId == null ? "null" : this.BulkAnticipationId == string.Empty ? "" : this.BulkAnticipationId)}");
            toStringOutput.Add($"this.AnticipationId = {(this.AnticipationId == null ? "null" : this.AnticipationId == string.Empty ? "" : this.AnticipationId)}");
            toStringOutput.Add($"this.RecipientId = {(this.RecipientId == null ? "null" : this.RecipientId == string.Empty ? "" : this.RecipientId)}");
            toStringOutput.Add($"this.OriginatorModel = {(this.OriginatorModel == null ? "null" : this.OriginatorModel == string.Empty ? "" : this.OriginatorModel)}");
            toStringOutput.Add($"this.OriginatorModelId = {(this.OriginatorModelId == null ? "null" : this.OriginatorModelId == string.Empty ? "" : this.OriginatorModelId)}");
            toStringOutput.Add($"this.PaymentDate = {this.PaymentDate}");
            toStringOutput.Add($"this.OriginalPaymentDate = {this.OriginalPaymentDate}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.AccrualAt = {this.AccrualAt}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.LiquidationArrangementId = {(this.LiquidationArrangementId == null ? "null" : this.LiquidationArrangementId == string.Empty ? "" : this.LiquidationArrangementId)}");
        }
    }
}