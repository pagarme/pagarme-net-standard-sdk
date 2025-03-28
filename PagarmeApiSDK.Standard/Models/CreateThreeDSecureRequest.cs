// <copyright file="CreateThreeDSecureRequest.cs" company="APIMatic">
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
    /// CreateThreeDSecureRequest.
    /// </summary>
    public class CreateThreeDSecureRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreeDSecureRequest"/> class.
        /// </summary>
        public CreateThreeDSecureRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreeDSecureRequest"/> class.
        /// </summary>
        /// <param name="mpi">mpi.</param>
        /// <param name="cavv">cavv.</param>
        /// <param name="eci">eci.</param>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="successUrl">success_url.</param>
        /// <param name="dsTransactionId">ds_transaction_id.</param>
        /// <param name="version">version.</param>
        public CreateThreeDSecureRequest(
            string mpi,
            string cavv = null,
            string eci = null,
            string transactionId = null,
            string successUrl = null,
            string dsTransactionId = null,
            string version = null)
        {
            this.Mpi = mpi;
            this.Cavv = cavv;
            this.Eci = eci;
            this.TransactionId = transactionId;
            this.SuccessUrl = successUrl;
            this.DsTransactionId = dsTransactionId;
            this.Version = version;
        }

        /// <summary>
        /// The MPI Vendor (MerchantPlugin)
        /// </summary>
        [JsonProperty("mpi")]
        public string Mpi { get; set; }

        /// <summary>
        /// The Cardholder Authentication Verification value
        /// </summary>
        [JsonProperty("cavv", NullValueHandling = NullValueHandling.Ignore)]
        public string Cavv { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator value
        /// </summary>
        [JsonProperty("eci", NullValueHandling = NullValueHandling.Ignore)]
        public string Eci { get; set; }

        /// <summary>
        /// The TransactionId value (XID)
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The success URL after the authentication
        /// </summary>
        [JsonProperty("success_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Directory Service Transaction Identifier
        /// </summary>
        [JsonProperty("ds_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DsTransactionId { get; set; }

        /// <summary>
        /// ThreeDSecure Version
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateThreeDSecureRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateThreeDSecureRequest other &&
                (this.Mpi == null && other.Mpi == null ||
                 this.Mpi?.Equals(other.Mpi) == true) &&
                (this.Cavv == null && other.Cavv == null ||
                 this.Cavv?.Equals(other.Cavv) == true) &&
                (this.Eci == null && other.Eci == null ||
                 this.Eci?.Equals(other.Eci) == true) &&
                (this.TransactionId == null && other.TransactionId == null ||
                 this.TransactionId?.Equals(other.TransactionId) == true) &&
                (this.SuccessUrl == null && other.SuccessUrl == null ||
                 this.SuccessUrl?.Equals(other.SuccessUrl) == true) &&
                (this.DsTransactionId == null && other.DsTransactionId == null ||
                 this.DsTransactionId?.Equals(other.DsTransactionId) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Mpi = {this.Mpi ?? "null"}");
            toStringOutput.Add($"Cavv = {this.Cavv ?? "null"}");
            toStringOutput.Add($"Eci = {this.Eci ?? "null"}");
            toStringOutput.Add($"TransactionId = {this.TransactionId ?? "null"}");
            toStringOutput.Add($"SuccessUrl = {this.SuccessUrl ?? "null"}");
            toStringOutput.Add($"DsTransactionId = {this.DsTransactionId ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
        }
    }
}