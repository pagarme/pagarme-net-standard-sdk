// <copyright file="GetCustomerResponse.cs" company="APIMatic">
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
    /// GetCustomerResponse.
    /// </summary>
    public class GetCustomerResponse
    {
        private string id;
        private string name;
        private string email;
        private bool? delinquent;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private string document;
        private string type;
        private string fbAccessToken;
        private Models.GetAddressResponse address;
        private Dictionary<string, string> metadata;
        private Models.GetPhonesResponse phones;
        private long? fbId;
        private string code;
        private string documentType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "name", false },
            { "email", false },
            { "delinquent", false },
            { "created_at", false },
            { "updated_at", false },
            { "document", false },
            { "type", false },
            { "fb_access_token", false },
            { "address", false },
            { "metadata", false },
            { "phones", false },
            { "fb_id", false },
            { "code", false },
            { "document_type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerResponse"/> class.
        /// </summary>
        public GetCustomerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="delinquent">delinquent.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="fbAccessToken">fb_access_token.</param>
        /// <param name="address">address.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="phones">phones.</param>
        /// <param name="fbId">fb_id.</param>
        /// <param name="code">code.</param>
        /// <param name="documentType">document_type.</param>
        public GetCustomerResponse(
            string id = null,
            string name = null,
            string email = null,
            bool? delinquent = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            string document = null,
            string type = null,
            string fbAccessToken = null,
            Models.GetAddressResponse address = null,
            Dictionary<string, string> metadata = null,
            Models.GetPhonesResponse phones = null,
            long? fbId = null,
            string code = null,
            string documentType = null)
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

            if (delinquent != null)
            {
                this.Delinquent = delinquent;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (document != null)
            {
                this.Document = document;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (fbAccessToken != null)
            {
                this.FbAccessToken = fbAccessToken;
            }

            if (address != null)
            {
                this.Address = address;
            }

            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (phones != null)
            {
                this.Phones = phones;
            }

            if (fbId != null)
            {
                this.FbId = fbId;
            }

            if (code != null)
            {
                this.Code = code;
            }

            if (documentType != null)
            {
                this.DocumentType = documentType;
            }
        }

        /// <summary>
        /// Gets or sets Id.
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
        /// Gets or sets Email.
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
        /// Gets or sets Delinquent.
        /// </summary>
        [JsonProperty("delinquent")]
        public bool? Delinquent
        {
            get
            {
                return this.delinquent;
            }

            set
            {
                this.shouldSerialize["delinquent"] = true;
                this.delinquent = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
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
        /// Gets or sets UpdatedAt.
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
        /// Gets or sets FbAccessToken.
        /// </summary>
        [JsonProperty("fb_access_token")]
        public string FbAccessToken
        {
            get
            {
                return this.fbAccessToken;
            }

            set
            {
                this.shouldSerialize["fb_access_token"] = true;
                this.fbAccessToken = value;
            }
        }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public Models.GetAddressResponse Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.shouldSerialize["address"] = true;
                this.address = value;
            }
        }

        /// <summary>
        /// Gets or sets Metadata.
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
        /// Gets or sets Phones.
        /// </summary>
        [JsonProperty("phones")]
        public Models.GetPhonesResponse Phones
        {
            get
            {
                return this.phones;
            }

            set
            {
                this.shouldSerialize["phones"] = true;
                this.phones = value;
            }
        }

        /// <summary>
        /// Gets or sets FbId.
        /// </summary>
        [JsonProperty("fb_id")]
        public long? FbId
        {
            get
            {
                return this.fbId;
            }

            set
            {
                this.shouldSerialize["fb_id"] = true;
                this.fbId = value;
            }
        }

        /// <summary>
        /// Código de referência do cliente no sistema da loja. Max: 52 caracteres
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCustomerResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetDelinquent()
        {
            this.shouldSerialize["delinquent"] = false;
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
        public void UnsetFbAccessToken()
        {
            this.shouldSerialize["fb_access_token"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAddress()
        {
            this.shouldSerialize["address"] = false;
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
        public void UnsetPhones()
        {
            this.shouldSerialize["phones"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFbId()
        {
            this.shouldSerialize["fb_id"] = false;
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
        public void UnsetDocumentType()
        {
            this.shouldSerialize["document_type"] = false;
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
        public bool ShouldSerializeDelinquent()
        {
            return this.shouldSerialize["delinquent"];
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
        public bool ShouldSerializeFbAccessToken()
        {
            return this.shouldSerialize["fb_access_token"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddress()
        {
            return this.shouldSerialize["address"];
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
        public bool ShouldSerializePhones()
        {
            return this.shouldSerialize["phones"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFbId()
        {
            return this.shouldSerialize["fb_id"];
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
        public bool ShouldSerializeDocumentType()
        {
            return this.shouldSerialize["document_type"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCustomerResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Delinquent == null && other.Delinquent == null ||
                 this.Delinquent?.Equals(other.Delinquent) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.Document == null && other.Document == null ||
                 this.Document?.Equals(other.Document) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.FbAccessToken == null && other.FbAccessToken == null ||
                 this.FbAccessToken?.Equals(other.FbAccessToken) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Phones == null && other.Phones == null ||
                 this.Phones?.Equals(other.Phones) == true) &&
                (this.FbId == null && other.FbId == null ||
                 this.FbId?.Equals(other.FbId) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.DocumentType == null && other.DocumentType == null ||
                 this.DocumentType?.Equals(other.DocumentType) == true);
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
            toStringOutput.Add($"Delinquent = {(this.Delinquent == null ? "null" : this.Delinquent.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"Document = {this.Document ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"FbAccessToken = {this.FbAccessToken ?? "null"}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Phones = {(this.Phones == null ? "null" : this.Phones.ToString())}");
            toStringOutput.Add($"FbId = {(this.FbId == null ? "null" : this.FbId.ToString())}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"DocumentType = {this.DocumentType ?? "null"}");
        }
    }
}