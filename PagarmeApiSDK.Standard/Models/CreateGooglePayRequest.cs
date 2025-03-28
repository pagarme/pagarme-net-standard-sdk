// <copyright file="CreateGooglePayRequest.cs" company="APIMatic">
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
    /// CreateGooglePayRequest.
    /// </summary>
    public class CreateGooglePayRequest
    {
        private string version;
        private string data;
        private Models.CreateGooglePayIntermediateSigningKeyRequest intermediateSigningKey;
        private string signature;
        private string signedMessage;
        private string merchantIdentifier;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "version", false },
            { "data", false },
            { "intermediate_signing_key", false },
            { "signature", false },
            { "signed_message", false },
            { "merchant_identifier", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGooglePayRequest"/> class.
        /// </summary>
        public CreateGooglePayRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGooglePayRequest"/> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="data">data.</param>
        /// <param name="intermediateSigningKey">intermediate_signing_key.</param>
        /// <param name="signature">signature.</param>
        /// <param name="signedMessage">signed_message.</param>
        /// <param name="merchantIdentifier">merchant_identifier.</param>
        public CreateGooglePayRequest(
            string version = null,
            string data = null,
            Models.CreateGooglePayIntermediateSigningKeyRequest intermediateSigningKey = null,
            string signature = null,
            string signedMessage = null,
            string merchantIdentifier = null)
        {

            if (version != null)
            {
                this.Version = version;
            }

            if (data != null)
            {
                this.Data = data;
            }

            if (intermediateSigningKey != null)
            {
                this.IntermediateSigningKey = intermediateSigningKey;
            }

            if (signature != null)
            {
                this.Signature = signature;
            }

            if (signedMessage != null)
            {
                this.SignedMessage = signedMessage;
            }

            if (merchantIdentifier != null)
            {
                this.MerchantIdentifier = merchantIdentifier;
            }
        }

        /// <summary>
        /// Informação sobre a versão do token. Único valor aceito é EC_v2
        /// </summary>
        [JsonProperty("version")]
        public string Version
        {
            get
            {
                return this.version;
            }

            set
            {
                this.shouldSerialize["version"] = true;
                this.version = value;
            }
        }

        /// <summary>
        /// Dados de pagamento criptografados. Corresponde ao encryptedMessage do token Google.
        /// </summary>
        [JsonProperty("data")]
        public string Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.shouldSerialize["data"] = true;
                this.data = value;
            }
        }

        /// <summary>
        /// The GooglePay intermediate signing key request
        /// </summary>
        [JsonProperty("intermediate_signing_key")]
        public Models.CreateGooglePayIntermediateSigningKeyRequest IntermediateSigningKey
        {
            get
            {
                return this.intermediateSigningKey;
            }

            set
            {
                this.shouldSerialize["intermediate_signing_key"] = true;
                this.intermediateSigningKey = value;
            }
        }

        /// <summary>
        /// Assinatura dos dados de pagamento. Verifica se a origem da mensagem é o Google. Corresponde ao signature do token Google.
        /// </summary>
        [JsonProperty("signature")]
        public string Signature
        {
            get
            {
                return this.signature;
            }

            set
            {
                this.shouldSerialize["signature"] = true;
                this.signature = value;
            }
        }

        /// <summary>
        /// Gets or sets SignedMessage.
        /// </summary>
        [JsonProperty("signed_message")]
        public string SignedMessage
        {
            get
            {
                return this.signedMessage;
            }

            set
            {
                this.shouldSerialize["signed_message"] = true;
                this.signedMessage = value;
            }
        }

        /// <summary>
        /// Gets or sets MerchantIdentifier.
        /// </summary>
        [JsonProperty("merchant_identifier")]
        public string MerchantIdentifier
        {
            get
            {
                return this.merchantIdentifier;
            }

            set
            {
                this.shouldSerialize["merchant_identifier"] = true;
                this.merchantIdentifier = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateGooglePayRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVersion()
        {
            this.shouldSerialize["version"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetData()
        {
            this.shouldSerialize["data"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIntermediateSigningKey()
        {
            this.shouldSerialize["intermediate_signing_key"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSignature()
        {
            this.shouldSerialize["signature"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSignedMessage()
        {
            this.shouldSerialize["signed_message"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMerchantIdentifier()
        {
            this.shouldSerialize["merchant_identifier"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVersion()
        {
            return this.shouldSerialize["version"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeData()
        {
            return this.shouldSerialize["data"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIntermediateSigningKey()
        {
            return this.shouldSerialize["intermediate_signing_key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSignature()
        {
            return this.shouldSerialize["signature"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSignedMessage()
        {
            return this.shouldSerialize["signed_message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMerchantIdentifier()
        {
            return this.shouldSerialize["merchant_identifier"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateGooglePayRequest other &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true) &&
                (this.IntermediateSigningKey == null && other.IntermediateSigningKey == null ||
                 this.IntermediateSigningKey?.Equals(other.IntermediateSigningKey) == true) &&
                (this.Signature == null && other.Signature == null ||
                 this.Signature?.Equals(other.Signature) == true) &&
                (this.SignedMessage == null && other.SignedMessage == null ||
                 this.SignedMessage?.Equals(other.SignedMessage) == true) &&
                (this.MerchantIdentifier == null && other.MerchantIdentifier == null ||
                 this.MerchantIdentifier?.Equals(other.MerchantIdentifier) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Data = {this.Data ?? "null"}");
            toStringOutput.Add($"IntermediateSigningKey = {(this.IntermediateSigningKey == null ? "null" : this.IntermediateSigningKey.ToString())}");
            toStringOutput.Add($"Signature = {this.Signature ?? "null"}");
            toStringOutput.Add($"SignedMessage = {this.SignedMessage ?? "null"}");
            toStringOutput.Add($"MerchantIdentifier = {this.MerchantIdentifier ?? "null"}");
        }
    }
}