// <copyright file="CreateGooglePayRequest.cs" company="APIMatic">
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
    /// CreateGooglePayRequest.
    /// </summary>
    public class CreateGooglePayRequest
    {
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
        public CreateGooglePayRequest(
            string version,
            string data,
            Models.CreateGooglePayIntermediateSigningKeyRequest intermediateSigningKey,
            string signature,
            string signedMessage)
        {
            this.Version = version;
            this.Data = data;
            this.IntermediateSigningKey = intermediateSigningKey;
            this.Signature = signature;
            this.SignedMessage = signedMessage;
        }

        /// <summary>
        /// Informação sobre a versão do token. Único valor aceito é EC_v2
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Dados de pagamento criptografados. Corresponde ao encryptedMessage do token Google.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// The GooglePay intermediate signing key request
        /// </summary>
        [JsonProperty("intermediate_signing_key")]
        public Models.CreateGooglePayIntermediateSigningKeyRequest IntermediateSigningKey { get; set; }

        /// <summary>
        /// Assinatura dos dados de pagamento. Verifica se a origem da mensagem é o Google. Corresponde ao signature do token Google.
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or sets SignedMessage.
        /// </summary>
        [JsonProperty("signed_message")]
        public string SignedMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateGooglePayRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateGooglePayRequest other &&                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.IntermediateSigningKey == null && other.IntermediateSigningKey == null) || (this.IntermediateSigningKey?.Equals(other.IntermediateSigningKey) == true)) &&
                ((this.Signature == null && other.Signature == null) || (this.Signature?.Equals(other.Signature) == true)) &&
                ((this.SignedMessage == null && other.SignedMessage == null) || (this.SignedMessage?.Equals(other.SignedMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data)}");
            toStringOutput.Add($"this.IntermediateSigningKey = {(this.IntermediateSigningKey == null ? "null" : this.IntermediateSigningKey.ToString())}");
            toStringOutput.Add($"this.Signature = {(this.Signature == null ? "null" : this.Signature)}");
            toStringOutput.Add($"this.SignedMessage = {(this.SignedMessage == null ? "null" : this.SignedMessage)}");
        }
    }
}