// <copyright file="GetPayableResponse.cs" company="APIMatic">
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
    /// GetPayableResponse.
    /// </summary>
    public class GetPayableResponse
    {
        private long? id;
        private string status;
        private int? amount;
        private int? fee;
        private int? anticipationFee;
        private int? fraudCoverageFee;
        private int? installment;
        private long? gatewayId;
        private string chargeId;
        private string splitId;
        private string bulkAnticipationId;
        private string anticipationId;
        private string recipientId;
        private string originatorModel;
        private string originatorModelId;
        private DateTime? paymentDate;
        private DateTime? originalPaymentDate;
        private string type;
        private string paymentMethod;
        private DateTime? accrualAt;
        private DateTime? createdAt;
        private string liquidationArrangementId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "status", false },
            { "amount", false },
            { "fee", false },
            { "anticipation_fee", false },
            { "fraud_coverage_fee", false },
            { "installment", false },
            { "gateway_id", false },
            { "charge_id", false },
            { "split_id", false },
            { "bulk_anticipation_id", false },
            { "anticipation_id", false },
            { "recipient_id", false },
            { "originator_model", false },
            { "originator_model_id", false },
            { "payment_date", false },
            { "original_payment_date", false },
            { "type", false },
            { "payment_method", false },
            { "accrual_at", false },
            { "created_at", false },
            { "liquidation_arrangement_id", false },
        };

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
            long? id = null,
            string status = null,
            int? amount = null,
            int? fee = null,
            int? anticipationFee = null,
            int? fraudCoverageFee = null,
            int? installment = null,
            long? gatewayId = null,
            string chargeId = null,
            string splitId = null,
            string bulkAnticipationId = null,
            string anticipationId = null,
            string recipientId = null,
            string originatorModel = null,
            string originatorModelId = null,
            DateTime? paymentDate = null,
            DateTime? originalPaymentDate = null,
            string type = null,
            string paymentMethod = null,
            DateTime? accrualAt = null,
            DateTime? createdAt = null,
            string liquidationArrangementId = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (fee != null)
            {
                this.Fee = fee;
            }

            if (anticipationFee != null)
            {
                this.AnticipationFee = anticipationFee;
            }

            if (fraudCoverageFee != null)
            {
                this.FraudCoverageFee = fraudCoverageFee;
            }

            if (installment != null)
            {
                this.Installment = installment;
            }

            if (gatewayId != null)
            {
                this.GatewayId = gatewayId;
            }

            if (chargeId != null)
            {
                this.ChargeId = chargeId;
            }

            if (splitId != null)
            {
                this.SplitId = splitId;
            }

            if (bulkAnticipationId != null)
            {
                this.BulkAnticipationId = bulkAnticipationId;
            }

            if (anticipationId != null)
            {
                this.AnticipationId = anticipationId;
            }

            if (recipientId != null)
            {
                this.RecipientId = recipientId;
            }

            if (originatorModel != null)
            {
                this.OriginatorModel = originatorModel;
            }

            if (originatorModelId != null)
            {
                this.OriginatorModelId = originatorModelId;
            }

            if (paymentDate != null)
            {
                this.PaymentDate = paymentDate;
            }

            if (originalPaymentDate != null)
            {
                this.OriginalPaymentDate = originalPaymentDate;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (paymentMethod != null)
            {
                this.PaymentMethod = paymentMethod;
            }

            if (accrualAt != null)
            {
                this.AccrualAt = accrualAt;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (liquidationArrangementId != null)
            {
                this.LiquidationArrangementId = liquidationArrangementId;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public long? Id
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
        /// Gets or sets Status.
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
        /// Gets or sets Amount.
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
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee")]
        public int? Fee
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
        public int? AnticipationFee
        {
            get
            {
                return this.anticipationFee;
            }

            set
            {
                this.shouldSerialize["anticipation_fee"] = true;
                this.anticipationFee = value;
            }
        }

        /// <summary>
        /// Gets or sets FraudCoverageFee.
        /// </summary>
        [JsonProperty("fraud_coverage_fee")]
        public int? FraudCoverageFee
        {
            get
            {
                return this.fraudCoverageFee;
            }

            set
            {
                this.shouldSerialize["fraud_coverage_fee"] = true;
                this.fraudCoverageFee = value;
            }
        }

        /// <summary>
        /// Gets or sets Installment.
        /// </summary>
        [JsonProperty("installment")]
        public int? Installment
        {
            get
            {
                return this.installment;
            }

            set
            {
                this.shouldSerialize["installment"] = true;
                this.installment = value;
            }
        }

        /// <summary>
        /// Gets or sets GatewayId.
        /// </summary>
        [JsonProperty("gateway_id")]
        public long? GatewayId
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
        /// Gets or sets ChargeId.
        /// </summary>
        [JsonProperty("charge_id")]
        public string ChargeId
        {
            get
            {
                return this.chargeId;
            }

            set
            {
                this.shouldSerialize["charge_id"] = true;
                this.chargeId = value;
            }
        }

        /// <summary>
        /// Gets or sets SplitId.
        /// </summary>
        [JsonProperty("split_id")]
        public string SplitId
        {
            get
            {
                return this.splitId;
            }

            set
            {
                this.shouldSerialize["split_id"] = true;
                this.splitId = value;
            }
        }

        /// <summary>
        /// Gets or sets BulkAnticipationId.
        /// </summary>
        [JsonProperty("bulk_anticipation_id")]
        public string BulkAnticipationId
        {
            get
            {
                return this.bulkAnticipationId;
            }

            set
            {
                this.shouldSerialize["bulk_anticipation_id"] = true;
                this.bulkAnticipationId = value;
            }
        }

        /// <summary>
        /// Gets or sets AnticipationId.
        /// </summary>
        [JsonProperty("anticipation_id")]
        public string AnticipationId
        {
            get
            {
                return this.anticipationId;
            }

            set
            {
                this.shouldSerialize["anticipation_id"] = true;
                this.anticipationId = value;
            }
        }

        /// <summary>
        /// Gets or sets RecipientId.
        /// </summary>
        [JsonProperty("recipient_id")]
        public string RecipientId
        {
            get
            {
                return this.recipientId;
            }

            set
            {
                this.shouldSerialize["recipient_id"] = true;
                this.recipientId = value;
            }
        }

        /// <summary>
        /// Gets or sets OriginatorModel.
        /// </summary>
        [JsonProperty("originator_model")]
        public string OriginatorModel
        {
            get
            {
                return this.originatorModel;
            }

            set
            {
                this.shouldSerialize["originator_model"] = true;
                this.originatorModel = value;
            }
        }

        /// <summary>
        /// Gets or sets OriginatorModelId.
        /// </summary>
        [JsonProperty("originator_model_id")]
        public string OriginatorModelId
        {
            get
            {
                return this.originatorModelId;
            }

            set
            {
                this.shouldSerialize["originator_model_id"] = true;
                this.originatorModelId = value;
            }
        }

        /// <summary>
        /// Gets or sets PaymentDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date")]
        public DateTime? PaymentDate
        {
            get
            {
                return this.paymentDate;
            }

            set
            {
                this.shouldSerialize["payment_date"] = true;
                this.paymentDate = value;
            }
        }

        /// <summary>
        /// Gets or sets OriginalPaymentDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("original_payment_date")]
        public DateTime? OriginalPaymentDate
        {
            get
            {
                return this.originalPaymentDate;
            }

            set
            {
                this.shouldSerialize["original_payment_date"] = true;
                this.originalPaymentDate = value;
            }
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod
        {
            get
            {
                return this.paymentMethod;
            }

            set
            {
                this.shouldSerialize["payment_method"] = true;
                this.paymentMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets AccrualAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("accrual_at")]
        public DateTime? AccrualAt
        {
            get
            {
                return this.accrualAt;
            }

            set
            {
                this.shouldSerialize["accrual_at"] = true;
                this.accrualAt = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
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
        /// Gets or sets LiquidationArrangementId.
        /// </summary>
        [JsonProperty("liquidation_arrangement_id")]
        public string LiquidationArrangementId
        {
            get
            {
                return this.liquidationArrangementId;
            }

            set
            {
                this.shouldSerialize["liquidation_arrangement_id"] = true;
                this.liquidationArrangementId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPayableResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
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
        public void UnsetFee()
        {
            this.shouldSerialize["fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnticipationFee()
        {
            this.shouldSerialize["anticipation_fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFraudCoverageFee()
        {
            this.shouldSerialize["fraud_coverage_fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInstallment()
        {
            this.shouldSerialize["installment"] = false;
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
        public void UnsetChargeId()
        {
            this.shouldSerialize["charge_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSplitId()
        {
            this.shouldSerialize["split_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBulkAnticipationId()
        {
            this.shouldSerialize["bulk_anticipation_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnticipationId()
        {
            this.shouldSerialize["anticipation_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRecipientId()
        {
            this.shouldSerialize["recipient_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOriginatorModel()
        {
            this.shouldSerialize["originator_model"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOriginatorModelId()
        {
            this.shouldSerialize["originator_model_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentDate()
        {
            this.shouldSerialize["payment_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOriginalPaymentDate()
        {
            this.shouldSerialize["original_payment_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentMethod()
        {
            this.shouldSerialize["payment_method"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccrualAt()
        {
            this.shouldSerialize["accrual_at"] = false;
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
        public void UnsetLiquidationArrangementId()
        {
            this.shouldSerialize["liquidation_arrangement_id"] = false;
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
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
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
        public bool ShouldSerializeFee()
        {
            return this.shouldSerialize["fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnticipationFee()
        {
            return this.shouldSerialize["anticipation_fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFraudCoverageFee()
        {
            return this.shouldSerialize["fraud_coverage_fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstallment()
        {
            return this.shouldSerialize["installment"];
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
        public bool ShouldSerializeChargeId()
        {
            return this.shouldSerialize["charge_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSplitId()
        {
            return this.shouldSerialize["split_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBulkAnticipationId()
        {
            return this.shouldSerialize["bulk_anticipation_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnticipationId()
        {
            return this.shouldSerialize["anticipation_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipientId()
        {
            return this.shouldSerialize["recipient_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginatorModel()
        {
            return this.shouldSerialize["originator_model"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginatorModelId()
        {
            return this.shouldSerialize["originator_model_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentDate()
        {
            return this.shouldSerialize["payment_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalPaymentDate()
        {
            return this.shouldSerialize["original_payment_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMethod()
        {
            return this.shouldSerialize["payment_method"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccrualAt()
        {
            return this.shouldSerialize["accrual_at"];
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
        public bool ShouldSerializeLiquidationArrangementId()
        {
            return this.shouldSerialize["liquidation_arrangement_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPayableResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Fee == null && other.Fee == null ||
                 this.Fee?.Equals(other.Fee) == true) &&
                (this.AnticipationFee == null && other.AnticipationFee == null ||
                 this.AnticipationFee?.Equals(other.AnticipationFee) == true) &&
                (this.FraudCoverageFee == null && other.FraudCoverageFee == null ||
                 this.FraudCoverageFee?.Equals(other.FraudCoverageFee) == true) &&
                (this.Installment == null && other.Installment == null ||
                 this.Installment?.Equals(other.Installment) == true) &&
                (this.GatewayId == null && other.GatewayId == null ||
                 this.GatewayId?.Equals(other.GatewayId) == true) &&
                (this.ChargeId == null && other.ChargeId == null ||
                 this.ChargeId?.Equals(other.ChargeId) == true) &&
                (this.SplitId == null && other.SplitId == null ||
                 this.SplitId?.Equals(other.SplitId) == true) &&
                (this.BulkAnticipationId == null && other.BulkAnticipationId == null ||
                 this.BulkAnticipationId?.Equals(other.BulkAnticipationId) == true) &&
                (this.AnticipationId == null && other.AnticipationId == null ||
                 this.AnticipationId?.Equals(other.AnticipationId) == true) &&
                (this.RecipientId == null && other.RecipientId == null ||
                 this.RecipientId?.Equals(other.RecipientId) == true) &&
                (this.OriginatorModel == null && other.OriginatorModel == null ||
                 this.OriginatorModel?.Equals(other.OriginatorModel) == true) &&
                (this.OriginatorModelId == null && other.OriginatorModelId == null ||
                 this.OriginatorModelId?.Equals(other.OriginatorModelId) == true) &&
                (this.PaymentDate == null && other.PaymentDate == null ||
                 this.PaymentDate?.Equals(other.PaymentDate) == true) &&
                (this.OriginalPaymentDate == null && other.OriginalPaymentDate == null ||
                 this.OriginalPaymentDate?.Equals(other.OriginalPaymentDate) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.AccrualAt == null && other.AccrualAt == null ||
                 this.AccrualAt?.Equals(other.AccrualAt) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.LiquidationArrangementId == null && other.LiquidationArrangementId == null ||
                 this.LiquidationArrangementId?.Equals(other.LiquidationArrangementId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"AnticipationFee = {(this.AnticipationFee == null ? "null" : this.AnticipationFee.ToString())}");
            toStringOutput.Add($"FraudCoverageFee = {(this.FraudCoverageFee == null ? "null" : this.FraudCoverageFee.ToString())}");
            toStringOutput.Add($"Installment = {(this.Installment == null ? "null" : this.Installment.ToString())}");
            toStringOutput.Add($"GatewayId = {(this.GatewayId == null ? "null" : this.GatewayId.ToString())}");
            toStringOutput.Add($"ChargeId = {this.ChargeId ?? "null"}");
            toStringOutput.Add($"SplitId = {this.SplitId ?? "null"}");
            toStringOutput.Add($"BulkAnticipationId = {this.BulkAnticipationId ?? "null"}");
            toStringOutput.Add($"AnticipationId = {this.AnticipationId ?? "null"}");
            toStringOutput.Add($"RecipientId = {this.RecipientId ?? "null"}");
            toStringOutput.Add($"OriginatorModel = {this.OriginatorModel ?? "null"}");
            toStringOutput.Add($"OriginatorModelId = {this.OriginatorModelId ?? "null"}");
            toStringOutput.Add($"PaymentDate = {(this.PaymentDate == null ? "null" : this.PaymentDate.ToString())}");
            toStringOutput.Add($"OriginalPaymentDate = {(this.OriginalPaymentDate == null ? "null" : this.OriginalPaymentDate.ToString())}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod ?? "null"}");
            toStringOutput.Add($"AccrualAt = {(this.AccrualAt == null ? "null" : this.AccrualAt.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"LiquidationArrangementId = {this.LiquidationArrangementId ?? "null"}");
        }
    }
}