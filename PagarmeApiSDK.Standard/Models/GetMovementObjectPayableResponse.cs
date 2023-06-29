// <copyright file="GetMovementObjectPayableResponse.cs" company="APIMatic">
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
    /// GetMovementObjectPayableResponse.
    /// </summary>
    public class GetMovementObjectPayableResponse : GetMovementObjectBaseResponse
    {
        private string fee;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "fee", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectPayableResponse"/> class.
        /// </summary>
        public GetMovementObjectPayableResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectPayableResponse"/> class.
        /// </summary>
        /// <param name="anticipationFee">anticipation_fee.</param>
        /// <param name="fraudCoverageFee">fraud_coverage_fee.</param>
        /// <param name="installment">installment.</param>
        /// <param name="splitId">split_id.</param>
        /// <param name="bulkAnticipationId">bulk_anticipation_id.</param>
        /// <param name="anticipationId">anticipation_id.</param>
        /// <param name="recipientId">recipient_id.</param>
        /// <param name="originatorModel">originator_model.</param>
        /// <param name="originatorModelId">originator_model_id.</param>
        /// <param name="paymentDate">payment_date.</param>
        /// <param name="originalPaymentDate">original_payment_date.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="accrualAt">accrual_at.</param>
        /// <param name="liquidationArrangementId">liquidation_arrangement_id.</param>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="type">type.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="fee">fee.</param>
        public GetMovementObjectPayableResponse(
            string anticipationFee,
            string fraudCoverageFee,
            string installment,
            string splitId,
            string bulkAnticipationId,
            string anticipationId,
            string recipientId,
            string originatorModel,
            string originatorModelId,
            string paymentDate,
            string originalPaymentDate,
            string paymentMethod,
            string accrualAt,
            string liquidationArrangementId,
            string mObject = null,
            string id = null,
            string status = null,
            string amount = null,
            string createdAt = null,
            string type = null,
            string chargeId = null,
            string gatewayId = null,
            string fee = null)
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
            if (fee != null)
            {
                this.Fee = fee;
            }

            this.AnticipationFee = anticipationFee;
            this.FraudCoverageFee = fraudCoverageFee;
            this.Installment = installment;
            this.SplitId = splitId;
            this.BulkAnticipationId = bulkAnticipationId;
            this.AnticipationId = anticipationId;
            this.RecipientId = recipientId;
            this.OriginatorModel = originatorModel;
            this.OriginatorModelId = originatorModelId;
            this.PaymentDate = paymentDate;
            this.OriginalPaymentDate = originalPaymentDate;
            this.PaymentMethod = paymentMethod;
            this.AccrualAt = accrualAt;
            this.LiquidationArrangementId = liquidationArrangementId;
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
        /// Gets or sets AnticipationFee.
        /// </summary>
        [JsonProperty("anticipation_fee")]
        public string AnticipationFee { get; set; }

        /// <summary>
        /// Gets or sets FraudCoverageFee.
        /// </summary>
        [JsonProperty("fraud_coverage_fee")]
        public string FraudCoverageFee { get; set; }

        /// <summary>
        /// Gets or sets Installment.
        /// </summary>
        [JsonProperty("installment")]
        public string Installment { get; set; }

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
        [JsonProperty("payment_date")]
        public string PaymentDate { get; set; }

        /// <summary>
        /// Gets or sets OriginalPaymentDate.
        /// </summary>
        [JsonProperty("original_payment_date")]
        public string OriginalPaymentDate { get; set; }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets AccrualAt.
        /// </summary>
        [JsonProperty("accrual_at")]
        public string AccrualAt { get; set; }

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

            return $"GetMovementObjectPayableResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFee()
        {
            this.shouldSerialize["fee"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFee()
        {
            return this.shouldSerialize["fee"];
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
            return obj is GetMovementObjectPayableResponse other &&                ((this.Fee == null && other.Fee == null) || (this.Fee?.Equals(other.Fee) == true)) &&
                ((this.AnticipationFee == null && other.AnticipationFee == null) || (this.AnticipationFee?.Equals(other.AnticipationFee) == true)) &&
                ((this.FraudCoverageFee == null && other.FraudCoverageFee == null) || (this.FraudCoverageFee?.Equals(other.FraudCoverageFee) == true)) &&
                ((this.Installment == null && other.Installment == null) || (this.Installment?.Equals(other.Installment) == true)) &&
                ((this.SplitId == null && other.SplitId == null) || (this.SplitId?.Equals(other.SplitId) == true)) &&
                ((this.BulkAnticipationId == null && other.BulkAnticipationId == null) || (this.BulkAnticipationId?.Equals(other.BulkAnticipationId) == true)) &&
                ((this.AnticipationId == null && other.AnticipationId == null) || (this.AnticipationId?.Equals(other.AnticipationId) == true)) &&
                ((this.RecipientId == null && other.RecipientId == null) || (this.RecipientId?.Equals(other.RecipientId) == true)) &&
                ((this.OriginatorModel == null && other.OriginatorModel == null) || (this.OriginatorModel?.Equals(other.OriginatorModel) == true)) &&
                ((this.OriginatorModelId == null && other.OriginatorModelId == null) || (this.OriginatorModelId?.Equals(other.OriginatorModelId) == true)) &&
                ((this.PaymentDate == null && other.PaymentDate == null) || (this.PaymentDate?.Equals(other.PaymentDate) == true)) &&
                ((this.OriginalPaymentDate == null && other.OriginalPaymentDate == null) || (this.OriginalPaymentDate?.Equals(other.OriginalPaymentDate) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.AccrualAt == null && other.AccrualAt == null) || (this.AccrualAt?.Equals(other.AccrualAt) == true)) &&
                ((this.LiquidationArrangementId == null && other.LiquidationArrangementId == null) || (this.LiquidationArrangementId?.Equals(other.LiquidationArrangementId) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Fee = {(this.Fee == null ? "null" : this.Fee == string.Empty ? "" : this.Fee)}");
            toStringOutput.Add($"this.AnticipationFee = {(this.AnticipationFee == null ? "null" : this.AnticipationFee == string.Empty ? "" : this.AnticipationFee)}");
            toStringOutput.Add($"this.FraudCoverageFee = {(this.FraudCoverageFee == null ? "null" : this.FraudCoverageFee == string.Empty ? "" : this.FraudCoverageFee)}");
            toStringOutput.Add($"this.Installment = {(this.Installment == null ? "null" : this.Installment == string.Empty ? "" : this.Installment)}");
            toStringOutput.Add($"this.SplitId = {(this.SplitId == null ? "null" : this.SplitId == string.Empty ? "" : this.SplitId)}");
            toStringOutput.Add($"this.BulkAnticipationId = {(this.BulkAnticipationId == null ? "null" : this.BulkAnticipationId == string.Empty ? "" : this.BulkAnticipationId)}");
            toStringOutput.Add($"this.AnticipationId = {(this.AnticipationId == null ? "null" : this.AnticipationId == string.Empty ? "" : this.AnticipationId)}");
            toStringOutput.Add($"this.RecipientId = {(this.RecipientId == null ? "null" : this.RecipientId == string.Empty ? "" : this.RecipientId)}");
            toStringOutput.Add($"this.OriginatorModel = {(this.OriginatorModel == null ? "null" : this.OriginatorModel == string.Empty ? "" : this.OriginatorModel)}");
            toStringOutput.Add($"this.OriginatorModelId = {(this.OriginatorModelId == null ? "null" : this.OriginatorModelId == string.Empty ? "" : this.OriginatorModelId)}");
            toStringOutput.Add($"this.PaymentDate = {(this.PaymentDate == null ? "null" : this.PaymentDate == string.Empty ? "" : this.PaymentDate)}");
            toStringOutput.Add($"this.OriginalPaymentDate = {(this.OriginalPaymentDate == null ? "null" : this.OriginalPaymentDate == string.Empty ? "" : this.OriginalPaymentDate)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod == string.Empty ? "" : this.PaymentMethod)}");
            toStringOutput.Add($"this.AccrualAt = {(this.AccrualAt == null ? "null" : this.AccrualAt == string.Empty ? "" : this.AccrualAt)}");
            toStringOutput.Add($"this.LiquidationArrangementId = {(this.LiquidationArrangementId == null ? "null" : this.LiquidationArrangementId == string.Empty ? "" : this.LiquidationArrangementId)}");

            base.ToString(toStringOutput);
        }
    }
}