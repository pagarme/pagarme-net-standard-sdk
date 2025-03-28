// <copyright file="GetPixBankAccountResponse.cs" company="APIMatic">
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
    /// GetPixBankAccountResponse.
    /// </summary>
    public class GetPixBankAccountResponse
    {
        private string bankName;
        private string ispb;
        private string branchCode;
        private string accountNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "bank_name", false },
            { "ispb", false },
            { "branch_code", false },
            { "account_number", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixBankAccountResponse"/> class.
        /// </summary>
        public GetPixBankAccountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixBankAccountResponse"/> class.
        /// </summary>
        /// <param name="bankName">bank_name.</param>
        /// <param name="ispb">ispb.</param>
        /// <param name="branchCode">branch_code.</param>
        /// <param name="accountNumber">account_number.</param>
        public GetPixBankAccountResponse(
            string bankName = null,
            string ispb = null,
            string branchCode = null,
            string accountNumber = null)
        {

            if (bankName != null)
            {
                this.BankName = bankName;
            }

            if (ispb != null)
            {
                this.Ispb = ispb;
            }

            if (branchCode != null)
            {
                this.BranchCode = branchCode;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }
        }

        /// <summary>
        /// Gets or sets BankName.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName
        {
            get
            {
                return this.bankName;
            }

            set
            {
                this.shouldSerialize["bank_name"] = true;
                this.bankName = value;
            }
        }

        /// <summary>
        /// Gets or sets Ispb.
        /// </summary>
        [JsonProperty("ispb")]
        public string Ispb
        {
            get
            {
                return this.ispb;
            }

            set
            {
                this.shouldSerialize["ispb"] = true;
                this.ispb = value;
            }
        }

        /// <summary>
        /// Gets or sets BranchCode.
        /// </summary>
        [JsonProperty("branch_code")]
        public string BranchCode
        {
            get
            {
                return this.branchCode;
            }

            set
            {
                this.shouldSerialize["branch_code"] = true;
                this.branchCode = value;
            }
        }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["account_number"] = true;
                this.accountNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPixBankAccountResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankName()
        {
            this.shouldSerialize["bank_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIspb()
        {
            this.shouldSerialize["ispb"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBranchCode()
        {
            this.shouldSerialize["branch_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["account_number"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankName()
        {
            return this.shouldSerialize["bank_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIspb()
        {
            return this.shouldSerialize["ispb"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBranchCode()
        {
            return this.shouldSerialize["branch_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["account_number"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPixBankAccountResponse other &&
                (this.BankName == null && other.BankName == null ||
                 this.BankName?.Equals(other.BankName) == true) &&
                (this.Ispb == null && other.Ispb == null ||
                 this.Ispb?.Equals(other.Ispb) == true) &&
                (this.BranchCode == null && other.BranchCode == null ||
                 this.BranchCode?.Equals(other.BranchCode) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BankName = {this.BankName ?? "null"}");
            toStringOutput.Add($"Ispb = {this.Ispb ?? "null"}");
            toStringOutput.Add($"BranchCode = {this.BranchCode ?? "null"}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
        }
    }
}