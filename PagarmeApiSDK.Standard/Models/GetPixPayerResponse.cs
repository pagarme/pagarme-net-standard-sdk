// <copyright file="GetPixPayerResponse.cs" company="APIMatic">
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
    /// GetPixPayerResponse.
    /// </summary>
    public class GetPixPayerResponse
    {
        private string name;
        private string document;
        private string documentType;
        private Models.GetPixBankAccountResponse bankAccount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "document", false },
            { "document_type", false },
            { "bank_account", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixPayerResponse"/> class.
        /// </summary>
        public GetPixPayerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPixPayerResponse"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="document">document.</param>
        /// <param name="documentType">document_type.</param>
        /// <param name="bankAccount">bank_account.</param>
        public GetPixPayerResponse(
            string name = null,
            string document = null,
            string documentType = null,
            Models.GetPixBankAccountResponse bankAccount = null)
        {

            if (name != null)
            {
                this.Name = name;
            }

            if (document != null)
            {
                this.Document = document;
            }

            if (documentType != null)
            {
                this.DocumentType = documentType;
            }

            if (bankAccount != null)
            {
                this.BankAccount = bankAccount;
            }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
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
        /// Gets or sets BankAccount.
        /// </summary>
        [JsonProperty("bank_account")]
        public Models.GetPixBankAccountResponse BankAccount
        {
            get
            {
                return this.bankAccount;
            }

            set
            {
                this.shouldSerialize["bank_account"] = true;
                this.bankAccount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPixPayerResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDocument()
        {
            this.shouldSerialize["document"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDocumentType()
        {
            this.shouldSerialize["document_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankAccount()
        {
            this.shouldSerialize["bank_account"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
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
        public bool ShouldSerializeDocumentType()
        {
            return this.shouldSerialize["document_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankAccount()
        {
            return this.shouldSerialize["bank_account"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPixPayerResponse other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Document == null && other.Document == null ||
                 this.Document?.Equals(other.Document) == true) &&
                (this.DocumentType == null && other.DocumentType == null ||
                 this.DocumentType?.Equals(other.DocumentType) == true) &&
                (this.BankAccount == null && other.BankAccount == null ||
                 this.BankAccount?.Equals(other.BankAccount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Document = {this.Document ?? "null"}");
            toStringOutput.Add($"DocumentType = {this.DocumentType ?? "null"}");
            toStringOutput.Add($"BankAccount = {(this.BankAccount == null ? "null" : this.BankAccount.ToString())}");
        }
    }
}