// <copyright file="UpdateRecipientBankAccountRequest.cs" company="APIMatic">
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
    /// UpdateRecipientBankAccountRequest.
    /// </summary>
    public class UpdateRecipientBankAccountRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecipientBankAccountRequest"/> class.
        /// </summary>
        public UpdateRecipientBankAccountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecipientBankAccountRequest"/> class.
        /// </summary>
        /// <param name="bankAccount">bank_account.</param>
        /// <param name="paymentMode">payment_mode.</param>
        public UpdateRecipientBankAccountRequest(
            Models.CreateBankAccountRequest bankAccount,
            string paymentMode)
        {
            this.BankAccount = bankAccount;
            this.PaymentMode = paymentMode;
        }

        /// <summary>
        /// Bank account
        /// </summary>
        [JsonProperty("bank_account")]
        public Models.CreateBankAccountRequest BankAccount { get; set; }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("payment_mode")]
        public string PaymentMode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateRecipientBankAccountRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateRecipientBankAccountRequest other &&
                (this.BankAccount == null && other.BankAccount == null ||
                 this.BankAccount?.Equals(other.BankAccount) == true) &&
                (this.PaymentMode == null && other.PaymentMode == null ||
                 this.PaymentMode?.Equals(other.PaymentMode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BankAccount = {(this.BankAccount == null ? "null" : this.BankAccount.ToString())}");
            toStringOutput.Add($"PaymentMode = {this.PaymentMode ?? "null"}");
        }
    }
}