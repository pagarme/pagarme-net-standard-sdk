// <copyright file="CreateBankAccountRequest.cs" company="APIMatic">
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
    /// CreateBankAccountRequest.
    /// </summary>
    public class CreateBankAccountRequest
    {
        private string branchCheckDigit;
        private string pixKey;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "branch_check_digit", false },
            { "pix_key", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBankAccountRequest"/> class.
        /// </summary>
        public CreateBankAccountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBankAccountRequest"/> class.
        /// </summary>
        /// <param name="holderName">holder_name.</param>
        /// <param name="holderType">holder_type.</param>
        /// <param name="holderDocument">holder_document.</param>
        /// <param name="bank">bank.</param>
        /// <param name="branchNumber">branch_number.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountCheckDigit">account_check_digit.</param>
        /// <param name="type">type.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="branchCheckDigit">branch_check_digit.</param>
        /// <param name="pixKey">pix_key.</param>
        public CreateBankAccountRequest(
            string holderName,
            string holderType,
            string holderDocument,
            string bank,
            string branchNumber,
            string accountNumber,
            string accountCheckDigit,
            string type,
            Dictionary<string, string> metadata,
            string branchCheckDigit = null,
            string pixKey = null)
        {
            this.HolderName = holderName;
            this.HolderType = holderType;
            this.HolderDocument = holderDocument;
            this.Bank = bank;
            this.BranchNumber = branchNumber;

            if (branchCheckDigit != null)
            {
                this.BranchCheckDigit = branchCheckDigit;
            }
            this.AccountNumber = accountNumber;
            this.AccountCheckDigit = accountCheckDigit;
            this.Type = type;
            this.Metadata = metadata;

            if (pixKey != null)
            {
                this.PixKey = pixKey;
            }
        }

        /// <summary>
        /// Bank account holder name
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        /// <summary>
        /// Bank account holder type
        /// </summary>
        [JsonProperty("holder_type")]
        public string HolderType { get; set; }

        /// <summary>
        /// Bank account holder document
        /// </summary>
        [JsonProperty("holder_document")]
        public string HolderDocument { get; set; }

        /// <summary>
        /// Bank
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// Branch number
        /// </summary>
        [JsonProperty("branch_number")]
        public string BranchNumber { get; set; }

        /// <summary>
        /// Branch check digit
        /// </summary>
        [JsonProperty("branch_check_digit")]
        public string BranchCheckDigit
        {
            get
            {
                return this.branchCheckDigit;
            }

            set
            {
                this.shouldSerialize["branch_check_digit"] = true;
                this.branchCheckDigit = value;
            }
        }

        /// <summary>
        /// Account number
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account check digit
        /// </summary>
        [JsonProperty("account_check_digit")]
        public string AccountCheckDigit { get; set; }

        /// <summary>
        /// Bank account type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Pix key
        /// </summary>
        [JsonProperty("pix_key")]
        public string PixKey
        {
            get
            {
                return this.pixKey;
            }

            set
            {
                this.shouldSerialize["pix_key"] = true;
                this.pixKey = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateBankAccountRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBranchCheckDigit()
        {
            this.shouldSerialize["branch_check_digit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPixKey()
        {
            this.shouldSerialize["pix_key"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBranchCheckDigit()
        {
            return this.shouldSerialize["branch_check_digit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePixKey()
        {
            return this.shouldSerialize["pix_key"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateBankAccountRequest other &&
                (this.HolderName == null && other.HolderName == null ||
                 this.HolderName?.Equals(other.HolderName) == true) &&
                (this.HolderType == null && other.HolderType == null ||
                 this.HolderType?.Equals(other.HolderType) == true) &&
                (this.HolderDocument == null && other.HolderDocument == null ||
                 this.HolderDocument?.Equals(other.HolderDocument) == true) &&
                (this.Bank == null && other.Bank == null ||
                 this.Bank?.Equals(other.Bank) == true) &&
                (this.BranchNumber == null && other.BranchNumber == null ||
                 this.BranchNumber?.Equals(other.BranchNumber) == true) &&
                (this.BranchCheckDigit == null && other.BranchCheckDigit == null ||
                 this.BranchCheckDigit?.Equals(other.BranchCheckDigit) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AccountCheckDigit == null && other.AccountCheckDigit == null ||
                 this.AccountCheckDigit?.Equals(other.AccountCheckDigit) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.PixKey == null && other.PixKey == null ||
                 this.PixKey?.Equals(other.PixKey) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"HolderName = {this.HolderName ?? "null"}");
            toStringOutput.Add($"HolderType = {this.HolderType ?? "null"}");
            toStringOutput.Add($"HolderDocument = {this.HolderDocument ?? "null"}");
            toStringOutput.Add($"Bank = {this.Bank ?? "null"}");
            toStringOutput.Add($"BranchNumber = {this.BranchNumber ?? "null"}");
            toStringOutput.Add($"BranchCheckDigit = {this.BranchCheckDigit ?? "null"}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AccountCheckDigit = {this.AccountCheckDigit ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"PixKey = {this.PixKey ?? "null"}");
        }
    }
}