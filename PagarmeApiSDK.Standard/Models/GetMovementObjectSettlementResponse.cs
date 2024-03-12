// <copyright file="GetMovementObjectSettlementResponse.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetMovementObjectSettlementResponse.
    /// </summary>
    public class GetMovementObjectSettlementResponse : GetMovementObjectBaseResponse
    {
        private string product;
        private string brand;
        private string paymentDate;
        private string recipientId;
        private string documentType;
        private string document;
        private string contractObligationId;
        private string liquidationArrangementId;
        private string externalEnginePaymentId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "product", false },
            { "brand", false },
            { "payment_date", false },
            { "recipient_id", false },
            { "document_type", false },
            { "document", false },
            { "contract_obligation_id", false },
            { "liquidation_arrangement_id", false },
            { "external_engine_payment_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectSettlementResponse"/> class.
        /// </summary>
        public GetMovementObjectSettlementResponse()
        {
            this.MObject = "settlement";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovementObjectSettlementResponse"/> class.
        /// </summary>
        /// <param name="mObject">object.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="type">type.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="product">product.</param>
        /// <param name="brand">brand.</param>
        /// <param name="paymentDate">payment_date.</param>
        /// <param name="recipientId">recipient_id.</param>
        /// <param name="documentType">document_type.</param>
        /// <param name="document">document.</param>
        /// <param name="contractObligationId">contract_obligation_id.</param>
        /// <param name="liquidationArrangementId">liquidation_arrangement_id.</param>
        /// <param name="externalEnginePaymentId">external_engine_payment_id.</param>
        public GetMovementObjectSettlementResponse(
            string mObject = "settlement",
            string id = null,
            string status = null,
            string amount = null,
            string createdAt = null,
            string type = null,
            string chargeId = null,
            string gatewayId = null,
            string product = null,
            string brand = null,
            string paymentDate = null,
            string recipientId = null,
            string documentType = null,
            string document = null,
            string contractObligationId = null,
            string liquidationArrangementId = null,
            string externalEnginePaymentId = null)
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
            if (product != null)
            {
                this.Product = product;
            }

            if (brand != null)
            {
                this.Brand = brand;
            }

            if (paymentDate != null)
            {
                this.PaymentDate = paymentDate;
            }

            if (recipientId != null)
            {
                this.RecipientId = recipientId;
            }

            if (documentType != null)
            {
                this.DocumentType = documentType;
            }

            if (document != null)
            {
                this.Document = document;
            }

            if (contractObligationId != null)
            {
                this.ContractObligationId = contractObligationId;
            }

            if (liquidationArrangementId != null)
            {
                this.LiquidationArrangementId = liquidationArrangementId;
            }

            if (externalEnginePaymentId != null)
            {
                this.ExternalEnginePaymentId = externalEnginePaymentId;
            }

        }

        /// <summary>
        /// Gets or sets Product.
        /// </summary>
        [JsonProperty("product")]
        public string Product
        {
            get
            {
                return this.product;
            }

            set
            {
                this.shouldSerialize["product"] = true;
                this.product = value;
            }
        }

        /// <summary>
        /// Gets or sets Brand.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.shouldSerialize["brand"] = true;
                this.brand = value;
            }
        }

        /// <summary>
        /// Gets or sets PaymentDate.
        /// </summary>
        [JsonProperty("payment_date")]
        public string PaymentDate
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
        /// Gets or sets DocumentType.
        /// </summary>
        [JsonProperty("document_type")]
        public string DocumentType
        {
            get
            {
                return this.documentType;
            }

            set
            {
                this.shouldSerialize["document_type"] = true;
                this.documentType = value;
            }
        }

        /// <summary>
        /// Gets or sets Document.
        /// </summary>
        [JsonProperty("document")]
        public string Document
        {
            get
            {
                return this.document;
            }

            set
            {
                this.shouldSerialize["document"] = true;
                this.document = value;
            }
        }

        /// <summary>
        /// Gets or sets ContractObligationId.
        /// </summary>
        [JsonProperty("contract_obligation_id")]
        public string ContractObligationId
        {
            get
            {
                return this.contractObligationId;
            }

            set
            {
                this.shouldSerialize["contract_obligation_id"] = true;
                this.contractObligationId = value;
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

        /// <summary>
        /// Gets or sets ExternalEnginePaymentId.
        /// </summary>
        [JsonProperty("external_engine_payment_id")]
        public string ExternalEnginePaymentId
        {
            get
            {
                return this.externalEnginePaymentId;
            }

            set
            {
                this.shouldSerialize["external_engine_payment_id"] = true;
                this.externalEnginePaymentId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetMovementObjectSettlementResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProduct()
        {
            this.shouldSerialize["product"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBrand()
        {
            this.shouldSerialize["brand"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentDate()
        {
            this.shouldSerialize["payment_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRecipientId()
        {
            this.shouldSerialize["recipient_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentType()
        {
            this.shouldSerialize["document_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocument()
        {
            this.shouldSerialize["document"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContractObligationId()
        {
            this.shouldSerialize["contract_obligation_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLiquidationArrangementId()
        {
            this.shouldSerialize["liquidation_arrangement_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExternalEnginePaymentId()
        {
            this.shouldSerialize["external_engine_payment_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProduct()
        {
            return this.shouldSerialize["product"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBrand()
        {
            return this.shouldSerialize["brand"];
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
        public bool ShouldSerializeRecipientId()
        {
            return this.shouldSerialize["recipient_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentType()
        {
            return this.shouldSerialize["document_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocument()
        {
            return this.shouldSerialize["document"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContractObligationId()
        {
            return this.shouldSerialize["contract_obligation_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLiquidationArrangementId()
        {
            return this.shouldSerialize["liquidation_arrangement_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExternalEnginePaymentId()
        {
            return this.shouldSerialize["external_engine_payment_id"];
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
            return obj is GetMovementObjectSettlementResponse other &&                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.PaymentDate == null && other.PaymentDate == null) || (this.PaymentDate?.Equals(other.PaymentDate) == true)) &&
                ((this.RecipientId == null && other.RecipientId == null) || (this.RecipientId?.Equals(other.RecipientId) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.ContractObligationId == null && other.ContractObligationId == null) || (this.ContractObligationId?.Equals(other.ContractObligationId) == true)) &&
                ((this.LiquidationArrangementId == null && other.LiquidationArrangementId == null) || (this.LiquidationArrangementId?.Equals(other.LiquidationArrangementId) == true)) &&
                ((this.ExternalEnginePaymentId == null && other.ExternalEnginePaymentId == null) || (this.ExternalEnginePaymentId?.Equals(other.ExternalEnginePaymentId) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand)}");
            toStringOutput.Add($"this.PaymentDate = {(this.PaymentDate == null ? "null" : this.PaymentDate)}");
            toStringOutput.Add($"this.RecipientId = {(this.RecipientId == null ? "null" : this.RecipientId)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document)}");
            toStringOutput.Add($"this.ContractObligationId = {(this.ContractObligationId == null ? "null" : this.ContractObligationId)}");
            toStringOutput.Add($"this.LiquidationArrangementId = {(this.LiquidationArrangementId == null ? "null" : this.LiquidationArrangementId)}");
            toStringOutput.Add($"this.ExternalEnginePaymentId = {(this.ExternalEnginePaymentId == null ? "null" : this.ExternalEnginePaymentId)}");

            base.ToString(toStringOutput);
        }
    }
}