// <copyright file="CreateApplePayHeaderRequest.cs" company="APIMatic">
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
    /// CreateApplePayHeaderRequest.
    /// </summary>
    public class CreateApplePayHeaderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplePayHeaderRequest"/> class.
        /// </summary>
        public CreateApplePayHeaderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplePayHeaderRequest"/> class.
        /// </summary>
        /// <param name="ephemeralPublicKey">ephemeral_public_key.</param>
        /// <param name="publicKeyHash">public_key_hash.</param>
        /// <param name="transactionId">transaction_id.</param>
        public CreateApplePayHeaderRequest(
            string ephemeralPublicKey,
            string publicKeyHash = null,
            string transactionId = null)
        {
            this.PublicKeyHash = publicKeyHash;
            this.EphemeralPublicKey = ephemeralPublicKey;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// SHA–256 hash, Base64 string codified
        /// </summary>
        [JsonProperty("public_key_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKeyHash { get; set; }

        /// <summary>
        /// X.509 encoded key bytes, Base64 encoded as a string
        /// </summary>
        [JsonProperty("ephemeral_public_key")]
        public string EphemeralPublicKey { get; set; }

        /// <summary>
        /// Transaction identifier, generated on Device
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateApplePayHeaderRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateApplePayHeaderRequest other &&
                (this.PublicKeyHash == null && other.PublicKeyHash == null ||
                 this.PublicKeyHash?.Equals(other.PublicKeyHash) == true) &&
                (this.EphemeralPublicKey == null && other.EphemeralPublicKey == null ||
                 this.EphemeralPublicKey?.Equals(other.EphemeralPublicKey) == true) &&
                (this.TransactionId == null && other.TransactionId == null ||
                 this.TransactionId?.Equals(other.TransactionId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PublicKeyHash = {this.PublicKeyHash ?? "null"}");
            toStringOutput.Add($"EphemeralPublicKey = {this.EphemeralPublicKey ?? "null"}");
            toStringOutput.Add($"TransactionId = {this.TransactionId ?? "null"}");
        }
    }
}