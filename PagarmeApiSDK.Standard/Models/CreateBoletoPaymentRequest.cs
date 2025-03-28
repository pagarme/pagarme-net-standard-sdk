// <copyright file="CreateBoletoPaymentRequest.cs" company="APIMatic">
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
    /// CreateBoletoPaymentRequest.
    /// </summary>
    public class CreateBoletoPaymentRequest
    {
        private string bank;
        private DateTime? dueAt;
        private string billingAddressId;
        private string nossoNumero;
        private Models.CreateInterestRequest interest;
        private Models.CreateFineRequest fine;
        private int? maxDaysToPayPastDue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "bank", false },
            { "due_at", false },
            { "billing_address_id", false },
            { "nosso_numero", false },
            { "interest", false },
            { "fine", false },
            { "max_days_to_pay_past_due", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBoletoPaymentRequest"/> class.
        /// </summary>
        public CreateBoletoPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBoletoPaymentRequest"/> class.
        /// </summary>
        /// <param name="retries">retries.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="documentNumber">document_number.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="bank">bank.</param>
        /// <param name="dueAt">due_at.</param>
        /// <param name="billingAddressId">billing_address_id.</param>
        /// <param name="nossoNumero">nosso_numero.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public CreateBoletoPaymentRequest(
            int retries,
            string instructions,
            Models.CreateAddressRequest billingAddress,
            string documentNumber,
            string statementDescriptor,
            string bank = null,
            DateTime? dueAt = null,
            string billingAddressId = null,
            string nossoNumero = null,
            Models.CreateInterestRequest interest = null,
            Models.CreateFineRequest fine = null,
            int? maxDaysToPayPastDue = null)
        {
            this.Retries = retries;

            if (bank != null)
            {
                this.Bank = bank;
            }
            this.Instructions = instructions;

            if (dueAt != null)
            {
                this.DueAt = dueAt;
            }
            this.BillingAddress = billingAddress;

            if (billingAddressId != null)
            {
                this.BillingAddressId = billingAddressId;
            }

            if (nossoNumero != null)
            {
                this.NossoNumero = nossoNumero;
            }
            this.DocumentNumber = documentNumber;
            this.StatementDescriptor = statementDescriptor;

            if (interest != null)
            {
                this.Interest = interest;
            }

            if (fine != null)
            {
                this.Fine = fine;
            }

            if (maxDaysToPayPastDue != null)
            {
                this.MaxDaysToPayPastDue = maxDaysToPayPastDue;
            }
        }

        /// <summary>
        /// Number of retries
        /// </summary>
        [JsonProperty("retries")]
        public int Retries { get; set; }

        /// <summary>
        /// The bank code, containing three characters. The available codes are on the API specification
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
        /// The instructions field that will be printed on the boleto.
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// Boleto due date
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
        /// Card's billing address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress { get; set; }

        /// <summary>
        /// The address id for the billing address
        /// </summary>
        [JsonProperty("billing_address_id")]
        public string BillingAddressId
        {
            get
            {
                return this.billingAddressId;
            }

            set
            {
                this.shouldSerialize["billing_address_id"] = true;
                this.billingAddressId = value;
            }
        }

        /// <summary>
        /// Customer identification number with the bank
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
        /// Boleto identification
        /// </summary>
        [JsonProperty("document_number")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Soft Descriptor
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Gets or sets Interest.
        /// </summary>
        [JsonProperty("interest")]
        public Models.CreateInterestRequest Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                this.shouldSerialize["interest"] = true;
                this.interest = value;
            }
        }

        /// <summary>
        /// Gets or sets Fine.
        /// </summary>
        [JsonProperty("fine")]
        public Models.CreateFineRequest Fine
        {
            get
            {
                return this.fine;
            }

            set
            {
                this.shouldSerialize["fine"] = true;
                this.fine = value;
            }
        }

        /// <summary>
        /// Gets or sets MaxDaysToPayPastDue.
        /// </summary>
        [JsonProperty("max_days_to_pay_past_due")]
        public int? MaxDaysToPayPastDue
        {
            get
            {
                return this.maxDaysToPayPastDue;
            }

            set
            {
                this.shouldSerialize["max_days_to_pay_past_due"] = true;
                this.maxDaysToPayPastDue = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateBoletoPaymentRequest : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingAddressId()
        {
            this.shouldSerialize["billing_address_id"] = false;
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
        public void UnsetInterest()
        {
            this.shouldSerialize["interest"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFine()
        {
            this.shouldSerialize["fine"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaxDaysToPayPastDue()
        {
            this.shouldSerialize["max_days_to_pay_past_due"] = false;
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
        public bool ShouldSerializeDueAt()
        {
            return this.shouldSerialize["due_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingAddressId()
        {
            return this.shouldSerialize["billing_address_id"];
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
        public bool ShouldSerializeInterest()
        {
            return this.shouldSerialize["interest"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFine()
        {
            return this.shouldSerialize["fine"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxDaysToPayPastDue()
        {
            return this.shouldSerialize["max_days_to_pay_past_due"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateBoletoPaymentRequest other &&
                (this.Retries.Equals(other.Retries)) &&
                (this.Bank == null && other.Bank == null ||
                 this.Bank?.Equals(other.Bank) == true) &&
                (this.Instructions == null && other.Instructions == null ||
                 this.Instructions?.Equals(other.Instructions) == true) &&
                (this.DueAt == null && other.DueAt == null ||
                 this.DueAt?.Equals(other.DueAt) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.BillingAddressId == null && other.BillingAddressId == null ||
                 this.BillingAddressId?.Equals(other.BillingAddressId) == true) &&
                (this.NossoNumero == null && other.NossoNumero == null ||
                 this.NossoNumero?.Equals(other.NossoNumero) == true) &&
                (this.DocumentNumber == null && other.DocumentNumber == null ||
                 this.DocumentNumber?.Equals(other.DocumentNumber) == true) &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.Interest == null && other.Interest == null ||
                 this.Interest?.Equals(other.Interest) == true) &&
                (this.Fine == null && other.Fine == null ||
                 this.Fine?.Equals(other.Fine) == true) &&
                (this.MaxDaysToPayPastDue == null && other.MaxDaysToPayPastDue == null ||
                 this.MaxDaysToPayPastDue?.Equals(other.MaxDaysToPayPastDue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Retries = {this.Retries}");
            toStringOutput.Add($"Bank = {this.Bank ?? "null"}");
            toStringOutput.Add($"Instructions = {this.Instructions ?? "null"}");
            toStringOutput.Add($"DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"BillingAddressId = {this.BillingAddressId ?? "null"}");
            toStringOutput.Add($"NossoNumero = {this.NossoNumero ?? "null"}");
            toStringOutput.Add($"DocumentNumber = {this.DocumentNumber ?? "null"}");
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"Interest = {(this.Interest == null ? "null" : this.Interest.ToString())}");
            toStringOutput.Add($"Fine = {(this.Fine == null ? "null" : this.Fine.ToString())}");
            toStringOutput.Add($"MaxDaysToPayPastDue = {(this.MaxDaysToPayPastDue == null ? "null" : this.MaxDaysToPayPastDue.ToString())}");
        }
    }
}