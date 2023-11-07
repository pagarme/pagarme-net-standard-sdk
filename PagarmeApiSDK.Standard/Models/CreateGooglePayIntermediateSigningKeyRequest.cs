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
            string signedKey,
            List<string> signatures)
        {
            this.SignedKey = signedKey;
            this.Signatures = signatures;
        }

        /// <summary>
        /// Uma mensagem codificada em Base64 com a descrição de pagamento da chave.
        /// </summary>
        [JsonProperty("signed_key")]
        public string SignedKey { get; set; }

        /// <summary>
        /// Verifica se a origem da chave de assinatura intermediária é o Google. É codificada em Base64 e criada usando o ECDSA.
        /// </summary>
        [JsonProperty("signatures")]
        public List<string> Signatures { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateGooglePayIntermediateSigningKeyRequest : ({string.Join(", ", toStringOutput)})";
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