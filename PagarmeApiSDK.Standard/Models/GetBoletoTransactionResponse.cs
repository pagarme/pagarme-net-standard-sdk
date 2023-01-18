// <copyright file="GetBoletoTransactionResponse.cs" company="APIMatic">
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
    /// GetBoletoTransactionResponse.
    /// </summary>
    public class GetBoletoTransactionResponse : GetTransactionResponse
    {
        private DateTime? dueAt;
        private DateTime? paidAt;
        private DateTime? creditAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "due_at", false },
            { "paid_at", false },
            { "credit_at", false },
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
            this.Url = url;
            this.Barcode = barcode;
            this.NossoNumero = nossoNumero;
            this.Bank = bank;
            this.DocumentNumber = documentNumber;
            this.Instructions = instructions;
            this.BillingAddress = billingAddress;
            if (dueAt != null)
            {
                this.DueAt = dueAt;
            }

            this.QrCode = qrCode;
            this.Line = line;
            this.PdfPassword = pdfPassword;
            this.Pdf = pdf;
            if (paidAt != null)
            {
                this.PaidAt = paidAt;
            }

            this.PaidAmount = paidAmount;
            this.Type = type;
            if (creditAt != null)
            {
                this.CreditAt = creditAt;
            }

            this.StatementDescriptor = statementDescriptor;
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Include)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Barcode.
        /// </summary>
        [JsonProperty("barcode", NullValueHandling = NullValueHandling.Include)]
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or sets NossoNumero.
        /// </summary>
        [JsonProperty("nosso_numero", NullValueHandling = NullValueHandling.Include)]
        public string NossoNumero { get; set; }

        /// <summary>
        /// Gets or sets Bank.
        /// </summary>
        [JsonProperty("bank", NullValueHandling = NullValueHandling.Include)]
        public string Bank { get; set; }

        /// <summary>
        /// Gets or sets DocumentNumber.
        /// </summary>
        [JsonProperty("document_number", NullValueHandling = NullValueHandling.Include)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets Instructions.
        /// </summary>
        [JsonProperty("instructions", NullValueHandling = NullValueHandling.Include)]
        public string Instructions { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Include)]
        public Models.GetBillingAddressResponse BillingAddress { get; set; }

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
        [JsonProperty("qr_code", NullValueHandling = NullValueHandling.Include)]
        public string QrCode { get; set; }

        /// <summary>
        /// Gets or sets Line.
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Include)]
        public string Line { get; set; }

        /// <summary>
        /// Gets or sets PdfPassword.
        /// </summary>
        [JsonProperty("pdf_password", NullValueHandling = NullValueHandling.Include)]
        public string PdfPassword { get; set; }

        /// <summary>
        /// Gets or sets Pdf.
        /// </summary>
        [JsonProperty("pdf", NullValueHandling = NullValueHandling.Include)]
        public string Pdf { get; set; }

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
        [JsonProperty("paid_amount", NullValueHandling = NullValueHandling.Include)]
        public string PaidAmount { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

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
        [JsonProperty("statement_descriptor", NullValueHandling = NullValueHandling.Include)]
        public string StatementDescriptor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetBoletoTransactionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaidAt()
        {
            this.shouldSerialize["paid_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditAt()
        {
            this.shouldSerialize["credit_at"] = false;
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
        public bool ShouldSerializePaidAt()
        {
            return this.shouldSerialize["paid_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditAt()
        {
            return this.shouldSerialize["credit_at"];
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

            return obj is GetBoletoTransactionResponse other &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Barcode == null && other.Barcode == null) || (this.Barcode?.Equals(other.Barcode) == true)) &&
                ((this.NossoNumero == null && other.NossoNumero == null) || (this.NossoNumero?.Equals(other.NossoNumero) == true)) &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.DocumentNumber == null && other.DocumentNumber == null) || (this.DocumentNumber?.Equals(other.DocumentNumber) == true)) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.DueAt == null && other.DueAt == null) || (this.DueAt?.Equals(other.DueAt) == true)) &&
                ((this.QrCode == null && other.QrCode == null) || (this.QrCode?.Equals(other.QrCode) == true)) &&
                ((this.Line == null && other.Line == null) || (this.Line?.Equals(other.Line) == true)) &&
                ((this.PdfPassword == null && other.PdfPassword == null) || (this.PdfPassword?.Equals(other.PdfPassword) == true)) &&
                ((this.Pdf == null && other.Pdf == null) || (this.Pdf?.Equals(other.Pdf) == true)) &&
                ((this.PaidAt == null && other.PaidAt == null) || (this.PaidAt?.Equals(other.PaidAt) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.CreditAt == null && other.CreditAt == null) || (this.CreditAt?.Equals(other.CreditAt) == true)) &&
                ((this.StatementDescriptor == null && other.StatementDescriptor == null) || (this.StatementDescriptor?.Equals(other.StatementDescriptor) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.Barcode = {(this.Barcode == null ? "null" : this.Barcode == string.Empty ? "" : this.Barcode)}");
            toStringOutput.Add($"this.NossoNumero = {(this.NossoNumero == null ? "null" : this.NossoNumero == string.Empty ? "" : this.NossoNumero)}");
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank == string.Empty ? "" : this.Bank)}");
            toStringOutput.Add($"this.DocumentNumber = {(this.DocumentNumber == null ? "null" : this.DocumentNumber == string.Empty ? "" : this.DocumentNumber)}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions == string.Empty ? "" : this.Instructions)}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"this.QrCode = {(this.QrCode == null ? "null" : this.QrCode == string.Empty ? "" : this.QrCode)}");
            toStringOutput.Add($"this.Line = {(this.Line == null ? "null" : this.Line == string.Empty ? "" : this.Line)}");
            toStringOutput.Add($"this.PdfPassword = {(this.PdfPassword == null ? "null" : this.PdfPassword == string.Empty ? "" : this.PdfPassword)}");
            toStringOutput.Add($"this.Pdf = {(this.Pdf == null ? "null" : this.Pdf == string.Empty ? "" : this.Pdf)}");
            toStringOutput.Add($"this.PaidAt = {(this.PaidAt == null ? "null" : this.PaidAt.ToString())}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount == string.Empty ? "" : this.PaidAmount)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.CreditAt = {(this.CreditAt == null ? "null" : this.CreditAt.ToString())}");
            toStringOutput.Add($"this.StatementDescriptor = {(this.StatementDescriptor == null ? "null" : this.StatementDescriptor == string.Empty ? "" : this.StatementDescriptor)}");

            base.ToString(toStringOutput);
        }
    }
}