// <copyright file="GetBankAccountResponse.cs" company="APIMatic">
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
    /// GetBankAccountResponse.
    /// </summary>
    public class GetBankAccountResponse
    {
        private Models.GetRecipientResponse recipient;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recipient", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBankAccountResponse"/> class.
        /// </summary>
        public GetBankAccountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBankAccountResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="holderName">holder_name.</param>
        /// <param name="holderType">holder_type.</param>
        /// <param name="bank">bank.</param>
        /// <param name="branchNumber">branch_number.</param>
        /// <param name="branchCheckDigit">branch_check_digit.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="accountCheckDigit">account_check_digit.</param>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="pixKey">pix_key.</param>
        public GetBankAccountResponse(
            string id = null,
            string holderName = null,
            string holderType = null,
            string bank = null,
            string branchNumber = null,
            string branchCheckDigit = null,
            string accountNumber = null,
            string accountCheckDigit = null,
            string type = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? deletedAt = null,
            Models.GetRecipientResponse recipient = null,
            Dictionary<string, string> metadata = null,
            string pixKey = null)
        {
            this.Id = id;
            this.HolderName = holderName;
            this.HolderType = holderType;
            this.Bank = bank;
            this.BranchNumber = branchNumber;
            this.BranchCheckDigit = branchCheckDigit;
            this.AccountNumber = accountNumber;
            this.AccountCheckDigit = accountCheckDigit;
            this.Type = type;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            this.Metadata = metadata;
            this.PixKey = pixKey;
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Holder name
        /// </summary>
        [JsonProperty("holder_name", NullValueHandling = NullValueHandling.Include)]
        public string HolderName { get; set; }

        /// <summary>
        /// Holder type
        /// </summary>
        [JsonProperty("holder_type", NullValueHandling = NullValueHandling.Include)]
        public string HolderType { get; set; }

        /// <summary>
        /// Bank
        /// </summary>
        [JsonProperty("bank", NullValueHandling = NullValueHandling.Include)]
        public string Bank { get; set; }

        /// <summary>
        /// Branch number
        /// </summary>
        [JsonProperty("branch_number", NullValueHandling = NullValueHandling.Include)]
        public string BranchNumber { get; set; }

        /// <summary>
        /// Branch check digit
        /// </summary>
        [JsonProperty("branch_check_digit", NullValueHandling = NullValueHandling.Include)]
        public string BranchCheckDigit { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        [JsonProperty("account_number", NullValueHandling = NullValueHandling.Include)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account check digit
        /// </summary>
        [JsonProperty("account_check_digit", NullValueHandling = NullValueHandling.Include)]
        public string AccountCheckDigit { get; set; }

        /// <summary>
        /// Bank account type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <summary>
        /// Bank account status
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Deletion date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient")]
        public Models.GetRecipientResponse Recipient
        {
            get
            {
                return this.recipient;
            }

            set
            {
                this.shouldSerialize["recipient"] = true;
                this.recipient = value;
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Pix Key
        /// </summary>
        [JsonProperty("pix_key", NullValueHandling = NullValueHandling.Include)]
        public string PixKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetBankAccountResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRecipient()
        {
            this.shouldSerialize["recipient"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipient()
        {
            return this.shouldSerialize["recipient"];
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

            return obj is GetBankAccountResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.HolderType == null && other.HolderType == null) || (this.HolderType?.Equals(other.HolderType) == true)) &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.BranchNumber == null && other.BranchNumber == null) || (this.BranchNumber?.Equals(other.BranchNumber) == true)) &&
                ((this.BranchCheckDigit == null && other.BranchCheckDigit == null) || (this.BranchCheckDigit?.Equals(other.BranchCheckDigit) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountCheckDigit == null && other.AccountCheckDigit == null) || (this.AccountCheckDigit?.Equals(other.AccountCheckDigit) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.PixKey == null && other.PixKey == null) || (this.PixKey?.Equals(other.PixKey) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.HolderType = {(this.HolderType == null ? "null" : this.HolderType == string.Empty ? "" : this.HolderType)}");
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank == string.Empty ? "" : this.Bank)}");
            toStringOutput.Add($"this.BranchNumber = {(this.BranchNumber == null ? "null" : this.BranchNumber == string.Empty ? "" : this.BranchNumber)}");
            toStringOutput.Add($"this.BranchCheckDigit = {(this.BranchCheckDigit == null ? "null" : this.BranchCheckDigit == string.Empty ? "" : this.BranchCheckDigit)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber == string.Empty ? "" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountCheckDigit = {(this.AccountCheckDigit == null ? "null" : this.AccountCheckDigit == string.Empty ? "" : this.AccountCheckDigit)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.PixKey = {(this.PixKey == null ? "null" : this.PixKey == string.Empty ? "" : this.PixKey)}");
        }
    }
}