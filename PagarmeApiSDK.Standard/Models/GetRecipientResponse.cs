// <copyright file="GetRecipientResponse.cs" company="APIMatic">
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
    /// GetRecipientResponse.
    /// </summary>
    public class GetRecipientResponse
    {
        private string id;
        private string name;
        private string email;
        private string document;
        private string description;
        private string type;
        private string status;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private DateTime? deletedAt;
        private Models.GetBankAccountResponse defaultBankAccount;
        private List<Models.GetGatewayRecipientResponse> gatewayRecipients;
        private Dictionary<string, string> metadata;
        private Models.GetAutomaticAnticipationResponse automaticAnticipationSettings;
        private Models.GetTransferSettingsResponse transferSettings;
        private string code;
        private string paymentMode;
        private Models.GetRegisterInformationResponse registerInformation;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "name", false },
            { "email", false },
            { "document", false },
            { "description", false },
            { "type", false },
            { "status", false },
            { "created_at", false },
            { "updated_at", false },
            { "deleted_at", false },
            { "default_bank_account", false },
            { "gateway_recipients", false },
            { "metadata", false },
            { "automatic_anticipation_settings", false },
            { "transfer_settings", false },
            { "code", false },
            { "payment_mode", true },
            { "register_information", false },
        };

        private Dictionary<string, bool> hasPropertySetterCalledFor = new Dictionary<string, bool>
        {
            { "payment_mode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecipientResponse"/> class.
        /// </summary>
        public GetRecipientResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecipientResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="defaultBankAccount">default_bank_account.</param>
        /// <param name="gatewayRecipients">gateway_recipients.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="automaticAnticipationSettings">automatic_anticipation_settings.</param>
        /// <param name="transferSettings">transfer_settings.</param>
        /// <param name="code">code.</param>
        /// <param name="paymentMode">payment_mode.</param>
        /// <param name="registerInformation">register_information.</param>
        public GetRecipientResponse(
            string id = null,
            string name = null,
            string email = null,
            string document = null,
            string description = null,
            string type = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? deletedAt = null,
            Models.GetBankAccountResponse defaultBankAccount = null,
            List<Models.GetGatewayRecipientResponse> gatewayRecipients = null,
            Dictionary<string, string> metadata = null,
            Models.GetAutomaticAnticipationResponse automaticAnticipationSettings = null,
            Models.GetTransferSettingsResponse transferSettings = null,
            string code = null,
            string paymentMode = "bank_transfer",
            Models.GetRegisterInformationResponse registerInformation = null)
        {

            if (id != null)
            {
                this.Id = id;
            }

            if (name != null)
            {
                this.Name = name;
            }

            if (email != null)
            {
                this.Email = email;
            }

            if (document != null)
            {
                this.Document = document;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

            if (defaultBankAccount != null)
            {
                this.DefaultBankAccount = defaultBankAccount;
            }

            if (gatewayRecipients != null)
            {
                this.GatewayRecipients = gatewayRecipients;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (automaticAnticipationSettings != null)
            {
                this.AutomaticAnticipationSettings = automaticAnticipationSettings;
            }

            if (transferSettings != null)
            {
                this.TransferSettings = transferSettings;
            }

            if (code != null)
            {
                this.Code = code;
            }
            this.PaymentMode = paymentMode;

            if (registerInformation != null)
            {
                this.RegisterInformation = registerInformation;
            }
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Name
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
        /// Email
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
        /// Document
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
        /// Description
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
        /// Type
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
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime? CreatedAt
        {
            get
            {
                return this.createdAt;
            }

            set
            {
                this.shouldSerialize["created_at"] = true;
                this.createdAt = value;
            }
        }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt
        {
            get
            {
                return this.updatedAt;
            }

            set
            {
                this.shouldSerialize["updated_at"] = true;
                this.updatedAt = value;
            }
        }

        /// <summary>
        /// Deletion date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt
        {
            get
            {
                return this.deletedAt;
            }

            set
            {
                this.shouldSerialize["deleted_at"] = true;
                this.deletedAt = value;
            }
        }

        /// <summary>
        /// Default bank account
        /// </summary>
        [JsonProperty("default_bank_account")]
        public Models.GetBankAccountResponse DefaultBankAccount
        {
            get
            {
                return this.defaultBankAccount;
            }

            set
            {
                this.shouldSerialize["default_bank_account"] = true;
                this.defaultBankAccount = value;
            }
        }

        /// <summary>
        /// Info about the recipient on the gateway
        /// </summary>
        [JsonProperty("gateway_recipients")]
        public List<Models.GetGatewayRecipientResponse> GatewayRecipients
        {
            get
            {
                return this.gatewayRecipients;
            }

            set
            {
                this.shouldSerialize["gateway_recipients"] = true;
                this.gatewayRecipients = value;
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata
        {
            get
            {
                return this.metadata;
            }

            set
            {
                this.shouldSerialize["metadata"] = true;
                this.metadata = value;
            }
        }

        /// <summary>
        /// Gets or sets AutomaticAnticipationSettings.
        /// </summary>
        [JsonProperty("automatic_anticipation_settings")]
        public Models.GetAutomaticAnticipationResponse AutomaticAnticipationSettings
        {
            get
            {
                return this.automaticAnticipationSettings;
            }

            set
            {
                this.shouldSerialize["automatic_anticipation_settings"] = true;
                this.automaticAnticipationSettings = value;
            }
        }

        /// <summary>
        /// Gets or sets TransferSettings.
        /// </summary>
        [JsonProperty("transfer_settings")]
        public Models.GetTransferSettingsResponse TransferSettings
        {
            get
            {
                return this.transferSettings;
            }

            set
            {
                this.shouldSerialize["transfer_settings"] = true;
                this.transferSettings = value;
            }
        }

        /// <summary>
        /// Recipient code
        /// </summary>
        [JsonProperty("code")]
        public string Code
        {
            get
            {
                return this.code;
            }

            set
            {
                this.shouldSerialize["code"] = true;
                this.code = value;
            }
        }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("payment_mode")]
        public string PaymentMode
        {
            get
            {
                if (!hasPropertySetterCalledFor["payment_mode"] &&
                    paymentMode == null)
                {
                    return "bank_transfer"; // Default value
                }

                return this.paymentMode;
            }

            set
            {
                this.shouldSerialize["payment_mode"] = true;
                hasPropertySetterCalledFor["payment_mode"] = true;
                this.paymentMode = value;
            }
        }

        /// <summary>
        /// Gets or sets RegisterInformation.
        /// </summary>
        [JsonProperty("register_information")]
        public Models.GetRegisterInformationResponse RegisterInformation
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
            return $"GetRecipientResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
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
        public void UnsetDocument()
        {
            this.shouldSerialize["document"] = false;
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
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdatedAt()
        {
            this.shouldSerialize["updated_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDeletedAt()
        {
            this.shouldSerialize["deleted_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDefaultBankAccount()
        {
            this.shouldSerialize["default_bank_account"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayRecipients()
        {
            this.shouldSerialize["gateway_recipients"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMetadata()
        {
            this.shouldSerialize["metadata"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAutomaticAnticipationSettings()
        {
            this.shouldSerialize["automatic_anticipation_settings"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransferSettings()
        {
            this.shouldSerialize["transfer_settings"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCode()
        {
            this.shouldSerialize["code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentMode()
        {
            this.shouldSerialize["payment_mode"] = false;
            this.hasPropertySetterCalledFor["payment_mode"] = false;
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
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
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
        public bool ShouldSerializeDocument()
        {
            return this.shouldSerialize["document"];
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
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return this.shouldSerialize["updated_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeletedAt()
        {
            return this.shouldSerialize["deleted_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDefaultBankAccount()
        {
            return this.shouldSerialize["default_bank_account"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayRecipients()
        {
            return this.shouldSerialize["gateway_recipients"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMetadata()
        {
            return this.shouldSerialize["metadata"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutomaticAnticipationSettings()
        {
            return this.shouldSerialize["automatic_anticipation_settings"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransferSettings()
        {
            return this.shouldSerialize["transfer_settings"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCode()
        {
            return this.shouldSerialize["code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMode()
        {
            return this.shouldSerialize["payment_mode"];
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

            return obj is GetRecipientResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Document == null && other.Document == null ||
                 this.Document?.Equals(other.Document) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.DeletedAt == null && other.DeletedAt == null ||
                 this.DeletedAt?.Equals(other.DeletedAt) == true) &&
                (this.DefaultBankAccount == null && other.DefaultBankAccount == null ||
                 this.DefaultBankAccount?.Equals(other.DefaultBankAccount) == true) &&
                (this.GatewayRecipients == null && other.GatewayRecipients == null ||
                 this.GatewayRecipients?.Equals(other.GatewayRecipients) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.AutomaticAnticipationSettings == null && other.AutomaticAnticipationSettings == null ||
                 this.AutomaticAnticipationSettings?.Equals(other.AutomaticAnticipationSettings) == true) &&
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
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Document = {this.Document ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"DefaultBankAccount = {(this.DefaultBankAccount == null ? "null" : this.DefaultBankAccount.ToString())}");
            toStringOutput.Add($"GatewayRecipients = {(this.GatewayRecipients == null ? "null" : $"[{string.Join(", ", this.GatewayRecipients)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"AutomaticAnticipationSettings = {(this.AutomaticAnticipationSettings == null ? "null" : this.AutomaticAnticipationSettings.ToString())}");
            toStringOutput.Add($"TransferSettings = {(this.TransferSettings == null ? "null" : this.TransferSettings.ToString())}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"PaymentMode = {this.PaymentMode ?? "null"}");
            toStringOutput.Add($"RegisterInformation = {(this.RegisterInformation == null ? "null" : this.RegisterInformation.ToString())}");
        }
    }
}