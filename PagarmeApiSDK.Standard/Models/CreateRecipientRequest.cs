// <copyright file="CreateRecipientRequest.cs" company="APIMatic">
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
    /// CreateRecipientRequest.
    /// </summary>
    public class CreateRecipientRequest
    {
        private string name;
        private string email;
        private string description;
        private string document;
        private string type;
        private Models.CreateRegisterInformationBaseRequest registerInformation;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "email", false },
            { "description", false },
            { "document", false },
            { "type", false },
            { "register_information", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipientRequest"/> class.
        /// </summary>
        public CreateRecipientRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipientRequest"/> class.
        /// </summary>
        /// <param name="defaultBankAccount">default_bank_account.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="code">code.</param>
        /// <param name="paymentMode">payment_mode.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="description">description.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="transferSettings">transfer_settings.</param>
        /// <param name="registerInformation">register_information.</param>
        public CreateRecipientRequest(
            Models.CreateBankAccountRequest defaultBankAccount,
            Dictionary<string, string> metadata,
            string code,
            string paymentMode,
            string name = null,
            string email = null,
            string description = null,
            string document = null,
            string type = null,
            Models.CreateTransferSettingsRequest transferSettings = null,
            Models.CreateRegisterInformationBaseRequest registerInformation = null)
        {

            if (name != null)
            {
                this.Name = name;
            }

            if (email != null)
            {
                this.Email = email;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (document != null)
            {
                this.Document = document;
            }

            if (type != null)
            {
                this.Type = type;
            }
            this.DefaultBankAccount = defaultBankAccount;
            this.Metadata = metadata;
            this.TransferSettings = transferSettings;
            this.Code = code;
            this.PaymentMode = paymentMode;

            if (registerInformation != null)
            {
                this.RegisterInformation = registerInformation;
            }
        }

        /// <summary>
        /// Recipient name. Required if the register_information field isn't populated.
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
        /// Recipient email. Required if the register_information field isn't populated.
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.shouldSerialize["email"] = true;
                this.email = value;
            }
        }

        /// <summary>
        /// Recipient description
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Recipient document number. Required if the register_information field isn't populated.
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
        /// Recipient type. Required if the register_information field isn't populated.
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
        /// Bank account
        /// </summary>
        [JsonProperty("default_bank_account")]
        public Models.CreateBankAccountRequest DefaultBankAccount { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Receiver Transfer Information
        /// </summary>
        [JsonProperty("transfer_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateTransferSettingsRequest TransferSettings { get; set; }

        /// <summary>
        /// Recipient code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// Register Information
        /// </summary>
        [JsonProperty("register_information")]
        public Models.CreateRegisterInformationBaseRequest RegisterInformation
        {
            get
            {
                return this.registerInformation;
            }

            set
            {
                this.shouldSerialize["register_information"] = true;
                this.registerInformation = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateRecipientRequest : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetEmail()
        {
            this.shouldSerialize["email"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
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
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRegisterInformation()
        {
            this.shouldSerialize["register_information"] = false;
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
        public bool ShouldSerializeEmail()
        {
            return this.shouldSerialize["email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
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
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegisterInformation()
        {
            return this.shouldSerialize["register_information"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateRecipientRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Document == null && other.Document == null ||
                 this.Document?.Equals(other.Document) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.DefaultBankAccount == null && other.DefaultBankAccount == null ||
                 this.DefaultBankAccount?.Equals(other.DefaultBankAccount) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.TransferSettings == null && other.TransferSettings == null ||
                 this.TransferSettings?.Equals(other.TransferSettings) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.PaymentMode == null && other.PaymentMode == null ||
                 this.PaymentMode?.Equals(other.PaymentMode) == true) &&
                (this.RegisterInformation == null && other.RegisterInformation == null ||
                 this.RegisterInformation?.Equals(other.RegisterInformation) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Document = {this.Document ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"DefaultBankAccount = {(this.DefaultBankAccount == null ? "null" : this.DefaultBankAccount.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"TransferSettings = {(this.TransferSettings == null ? "null" : this.TransferSettings.ToString())}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"PaymentMode = {this.PaymentMode ?? "null"}");
            toStringOutput.Add($"RegisterInformation = {(this.RegisterInformation == null ? "null" : this.RegisterInformation.ToString())}");
        }
    }
}