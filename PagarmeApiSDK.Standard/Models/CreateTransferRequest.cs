// <copyright file="CreateTransferRequest.cs" company="APIMatic">
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
    /// CreateTransferRequest.
    /// </summary>
    public class CreateTransferRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransferRequest"/> class.
        /// </summary>
        public CreateTransferRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransferRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="metadata">metadata.</param>
        public CreateTransferRequest(
            int amount,
            Dictionary<string, string> metadata)
        {
            this.Amount = amount;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Transfer amount
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateTransferRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateTransferRequest other &&
                (this.Amount.Equals(other.Amount)) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
        }
    }
}