// <copyright file="GetBoletoTransactionResponse.cs" company="APIMatic">
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
    /// GetBoletoTransactionResponse.
    /// </summary>
    public class GetBoletoTransactionResponse : GetTransactionResponse
    {
        private string url;
        private string barcode;
        private string nossoNumero;
        private string bank;
        private string documentNumber;
        private string instructions;
        private Models.GetBillingAddressResponse billingAddress;
        private DateTime? dueAt;
        private string qrCode;
        private string line;
        private string pdfPassword;
        private string pdf;
        private DateTime? paidAt;
        private string paidAmount;
        private string type;
        private DateTime? creditAt;
        private string statementDescriptor;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "url", false },
            { "barcode", false },
            { "nosso_numero", false },
            { "bank", false },
            { "document_number", false },
            { "instructions", false },
            { "billing_address", false },
            { "due_at", false },
            { "qr_code", false },
            { "line", false },
            { "pdf_password", false },
            { "pdf", false },
            { "paid_at", false },
            { "paid_amount", false },
            { "type", false },
            { "credit_at", false },
            { "statement_descriptor", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBoletoTransactionResponse"/> class.
        /// </summary>
        public GetBoletoTransactionResponse()
        {
            this.TransactionType = "boleto";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBoletoTransactionResponse"/> class.
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
        /// <param name="barcode">barcode.</param>
        /// <param name="nossoNumero">nosso_numero.</param>
        /// <param name="bank">bank.</param>
        /// <param name="documentNumber">document_number.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="qrCode">qr_code.</param>
        /// <param name="line">line.</param>
        /// <param name="pdfPassword">pdf_password.</param>
        /// <param name="pdf">pdf.</param>
        /// <param name="paidAt">paid_at.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="type">type.</param>
        /// <param name="creditAt">credit_at.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        public GetBoletoTransactionResponse(
            string transactionType = "boleto",
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
            string barcode = null,
            string nossoNumero = null,
            string bank = null,
            string documentNumber = null,
            string instructions = null,
            Models.GetBillingAddressResponse billingAddress = null,
            DateTime? dueAt = null,
            string qrCode = null,
            string line = null,
            string pdfPassword = null,
            string pdf = null,
            DateTime? paidAt = null,
            string paidAmount = null,
            string type = null,
            DateTime? creditAt = null,
            string statementDescriptor = null)
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

            if (url != null)
            {
                this.Url = url;
            }

            if (barcode != null)
            {
                this.Barcode = barcode;
            }

            if (nossoNumero != null)
            {
                this.NossoNumero = nossoNumero;
            }

            if (bank != null)
            {
                this.Bank = bank;
            }

            if (documentNumber != null)
            {
                this.DocumentNumber = documentNumber;
            }

            if (instructions != null)
            {
                this.Instructions = instructions;
            }

            if (billingAddress != null)
            {
                this.BillingAddress = billingAddress;
            }

            if (dueAt != null)
            {
                this.DueAt = dueAt;
            }

            if (qrCode != null)
            {
                this.QrCode = qrCode;
            }

            if (line != null)
            {
                this.Line = line;
            }

            if (pdfPassword != null)
            {
                this.PdfPassword = pdfPassword;
            }

            if (pdf != null)
            {
                this.Pdf = pdf;
            }

            if (paidAt != null)
            {
                this.PaidAt = paidAt;
            }

            if (paidAmount != null)
            {
                this.PaidAmount = paidAmount;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (creditAt != null)
            {
                this.CreditAt = creditAt;
            }

            if (statementDescriptor != null)
            {
                this.StatementDescriptor = statementDescriptor;
            }
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                this.shouldSerialize["url"] = true;
                this.url = value;
            }
        }

        /// <summary>
        /// Gets or sets Barcode.
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode
        {
            get
            {
                return this.barcode;
            }

            set
            {
                this.shouldSerialize["barcode"] = true;
                this.barcode = value;
            }
        }

        /// <summary>
        /// Gets or sets NossoNumero.
        /// </summary>
        [JsonProperty("nosso_numero")]
        public string NossoNumero
        {
            get
            {
                return this.nossoNumero;
            }

            set
            {
                this.shouldSerialize["nosso_numero"] = true;
                this.nossoNumero = value;
            }
        }

        /// <summary>
        /// Gets or sets Bank.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank
        {
            get
            {
                return this.bank;
            }

            set
            {
                this.shouldSerialize["bank"] = true;
                this.bank = value;
            }
        }

        /// <summary>
        /// Gets or sets DocumentNumber.
        /// </summary>
        [JsonProperty("document_number")]
        public string DocumentNumber
        {
            get
            {
                return this.documentNumber;
            }

            set
            {
                this.shouldSerialize["document_number"] = true;
                this.documentNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets Instructions.
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions
        {
            get
            {
                return this.instructions;
            }

            set
            {
                this.shouldSerialize["instructions"] = true;
                this.instructions = value;
            }
        }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.GetBillingAddressResponse BillingAddress
        {
            get
            {
                return this.billingAddress;
            }

            set
            {
                this.shouldSerialize["billing_address"] = true;
                this.billingAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets DueAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime? DueAt
        {
            get
            {
                return this.dueAt;
            }

            set
            {
                this.shouldSerialize["due_at"] = true;
                this.dueAt = value;
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
        /// Gets or sets Line.
        /// </summary>
        [JsonProperty("line")]
        public string Line
        {
            get
            {
                return this.line;
            }

            set
            {
                this.shouldSerialize["line"] = true;
                this.line = value;
            }
        }

        /// <summary>
        /// Gets or sets PdfPassword.
        /// </summary>
        [JsonProperty("pdf_password")]
        public string PdfPassword
        {
            get
            {
                return this.pdfPassword;
            }

            set
            {
                this.shouldSerialize["pdf_password"] = true;
                this.pdfPassword = value;
            }
        }

        /// <summary>
        /// Gets or sets Pdf.
        /// </summary>
        [JsonProperty("pdf")]
        public string Pdf
        {
            get
            {
                return this.pdf;
            }

            set
            {
                this.shouldSerialize["pdf"] = true;
                this.pdf = value;
            }
        }

        /// <summary>
        /// Gets or sets PaidAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at")]
        public DateTime? PaidAt
        {
            get
            {
                return this.paidAt;
            }

            set
            {
                this.shouldSerialize["paid_at"] = true;
                this.paidAt = value;
            }
        }

        /// <summary>
        /// Gets or sets PaidAmount.
        /// </summary>
        [JsonProperty("paid_amount")]
        public string PaidAmount
        {
            get
            {
                return this.paidAmount;
            }

            set
            {
                this.shouldSerialize["paid_amount"] = true;
                this.paidAmount = value;
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
        /// Gets or sets CreditAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("credit_at")]
        public DateTime? CreditAt
        {
            get
            {
                return this.creditAt;
            }

            set
            {
                this.shouldSerialize["credit_at"] = true;
                this.creditAt = value;
            }
        }

        /// <summary>
        /// Soft Descriptor
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor
        {
            get
            {
                return this.statementDescriptor;
            }

            set
            {
                this.shouldSerialize["statement_descriptor"] = true;
                this.statementDescriptor = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetBoletoTransactionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUrl()
        {
            this.shouldSerialize["url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBarcode()
        {
            this.shouldSerialize["barcode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNossoNumero()
        {
            this.shouldSerialize["nosso_numero"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBank()
        {
            this.shouldSerialize["bank"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDocumentNumber()
        {
            this.shouldSerialize["document_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInstructions()
        {
            this.shouldSerialize["instructions"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingAddress()
        {
            this.shouldSerialize["billing_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
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
        public void UnsetLine()
        {
            this.shouldSerialize["line"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPdfPassword()
        {
            this.shouldSerialize["pdf_password"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPdf()
        {
            this.shouldSerialize["pdf"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaidAt()
        {
            this.shouldSerialize["paid_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaidAmount()
        {
            this.shouldSerialize["paid_amount"] = false;
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
        public void UnsetCreditAt()
        {
            this.shouldSerialize["credit_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatementDescriptor()
        {
            this.shouldSerialize["statement_descriptor"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUrl()
        {
            return this.shouldSerialize["url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBarcode()
        {
            return this.shouldSerialize["barcode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNossoNumero()
        {
            return this.shouldSerialize["nosso_numero"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBank()
        {
            return this.shouldSerialize["bank"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentNumber()
        {
            return this.shouldSerialize["document_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstructions()
        {
            return this.shouldSerialize["instructions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingAddress()
        {
            return this.shouldSerialize["billing_address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueAt()
        {
            return this.shouldSerialize["due_at"];
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
        public bool ShouldSerializeLine()
        {
            return this.shouldSerialize["line"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePdfPassword()
        {
            return this.shouldSerialize["pdf_password"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePdf()
        {
            return this.shouldSerialize["pdf"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidAt()
        {
            return this.shouldSerialize["paid_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidAmount()
        {
            return this.shouldSerialize["paid_amount"];
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
        public bool ShouldSerializeCreditAt()
        {
            return this.shouldSerialize["credit_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatementDescriptor()
        {
            return this.shouldSerialize["statement_descriptor"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetBoletoTransactionResponse other &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.Barcode == null && other.Barcode == null ||
                 this.Barcode?.Equals(other.Barcode) == true) &&
                (this.NossoNumero == null && other.NossoNumero == null ||
                 this.NossoNumero?.Equals(other.NossoNumero) == true) &&
                (this.Bank == null && other.Bank == null ||
                 this.Bank?.Equals(other.Bank) == true) &&
                (this.DocumentNumber == null && other.DocumentNumber == null ||
                 this.DocumentNumber?.Equals(other.DocumentNumber) == true) &&
                (this.Instructions == null && other.Instructions == null ||
                 this.Instructions?.Equals(other.Instructions) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.DueAt == null && other.DueAt == null ||
                 this.DueAt?.Equals(other.DueAt) == true) &&
                (this.QrCode == null && other.QrCode == null ||
                 this.QrCode?.Equals(other.QrCode) == true) &&
                (this.Line == null && other.Line == null ||
                 this.Line?.Equals(other.Line) == true) &&
                (this.PdfPassword == null && other.PdfPassword == null ||
                 this.PdfPassword?.Equals(other.PdfPassword) == true) &&
                (this.Pdf == null && other.Pdf == null ||
                 this.Pdf?.Equals(other.Pdf) == true) &&
                (this.PaidAt == null && other.PaidAt == null ||
                 this.PaidAt?.Equals(other.PaidAt) == true) &&
                (this.PaidAmount == null && other.PaidAmount == null ||
                 this.PaidAmount?.Equals(other.PaidAmount) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.CreditAt == null && other.CreditAt == null ||
                 this.CreditAt?.Equals(other.CreditAt) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"Barcode = {this.Barcode ?? "null"}");
            toStringOutput.Add($"NossoNumero = {this.NossoNumero ?? "null"}");
            toStringOutput.Add($"Bank = {this.Bank ?? "null"}");
            toStringOutput.Add($"DocumentNumber = {this.DocumentNumber ?? "null"}");
            toStringOutput.Add($"Instructions = {this.Instructions ?? "null"}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"QrCode = {this.QrCode ?? "null"}");
            toStringOutput.Add($"Line = {this.Line ?? "null"}");
            toStringOutput.Add($"PdfPassword = {this.PdfPassword ?? "null"}");
            toStringOutput.Add($"Pdf = {this.Pdf ?? "null"}");
            toStringOutput.Add($"PaidAt = {(this.PaidAt == null ? "null" : this.PaidAt.ToString())}");
            toStringOutput.Add($"PaidAmount = {this.PaidAmount ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"CreditAt = {(this.CreditAt == null ? "null" : this.CreditAt.ToString())}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}