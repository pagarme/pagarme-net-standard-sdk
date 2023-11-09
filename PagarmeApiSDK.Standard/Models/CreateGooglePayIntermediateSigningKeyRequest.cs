// <copyright file="CreateGooglePayIntermediateSigningKeyRequest.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// CreateGooglePayIntermediateSigningKeyRequest.
    /// </summary>
    public class CreateGooglePayIntermediateSigningKeyRequest
    {
        private string signedKey;
        private List<string> signatures;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "signed_key", false },
            { "signatures", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGooglePayIntermediateSigningKeyRequest"/> class.
        /// </summary>
        public CreateGooglePayIntermediateSigningKeyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGooglePayIntermediateSigningKeyRequest"/> class.
        /// </summary>
        /// <param name="signedKey">signed_key.</param>
        /// <param name="signatures">signatures.</param>
        public CreateGooglePayIntermediateSigningKeyRequest(
            string signedKey = null,
            List<string> signatures = null)
        {
            if (signedKey != null)
            {
                this.SignedKey = signedKey;
            }

            if (signatures != null)
            {
                this.Signatures = signatures;
            }

        }

        /// <summary>
        /// Uma mensagem codificada em Base64 com a descrição de pagamento da chave.
        /// </summary>
        [JsonProperty("signed_key")]
        public string SignedKey
        {
            get
            {
                return this.signedKey;
            }

            set
            {
                this.shouldSerialize["signed_key"] = true;
                this.signedKey = value;
            }
        }

        /// <summary>
        /// Verifica se a origem da chave de assinatura intermediária é o Google. É codificada em Base64 e criada usando o ECDSA.
        /// </summary>
        [JsonProperty("signatures")]
        public List<string> Signatures
        {
            get
            {
                return this.signatures;
            }

            set
            {
                this.shouldSerialize["signatures"] = true;
                this.signatures = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateGooglePayIntermediateSigningKeyRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSignedKey()
        {
            this.shouldSerialize["signed_key"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSignatures()
        {
            this.shouldSerialize["signatures"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSignedKey()
        {
            return this.shouldSerialize["signed_key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSignatures()
        {
            return this.shouldSerialize["signatures"];
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
            return obj is CreateGooglePayIntermediateSigningKeyRequest other &&                ((this.SignedKey == null && other.SignedKey == null) || (this.SignedKey?.Equals(other.SignedKey) == true)) &&
                ((this.Signatures == null && other.Signatures == null) || (this.Signatures?.Equals(other.Signatures) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SignedKey = {(this.SignedKey == null ? "null" : this.SignedKey)}");
            toStringOutput.Add($"this.Signatures = {(this.Signatures == null ? "null" : $"[{string.Join(", ", this.Signatures)} ]")}");
        }
    }
}