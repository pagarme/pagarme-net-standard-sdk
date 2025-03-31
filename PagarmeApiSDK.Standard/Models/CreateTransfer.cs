// <copyright file="CreateTransfer.cs" company="APIMatic">
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
    /// CreateTransfer.
    /// </summary>
    public class CreateTransfer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransfer"/> class.
        /// </summary>
        public CreateTransfer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransfer"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="sourceId">source_id.</param>
        /// <param name="targetId">target_id.</param>
        /// <param name="metadata">metadata.</param>
        public CreateTransfer(
            int amount,
            string sourceId,
            string targetId,
            List<string> metadata = null)
        {
            this.Amount = amount;
            this.SourceId = sourceId;
            this.TargetId = targetId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets SourceId.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or sets TargetId.
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateTransfer : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateTransfer other &&
                (this.Amount.Equals(other.Amount)) &&
                (this.SourceId == null && other.SourceId == null ||
                 this.SourceId?.Equals(other.SourceId) == true) &&
                (this.TargetId == null && other.TargetId == null ||
                 this.TargetId?.Equals(other.TargetId) == true) &&
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
            toStringOutput.Add($"SourceId = {this.SourceId ?? "null"}");
            toStringOutput.Add($"TargetId = {this.TargetId ?? "null"}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : $"[{string.Join(", ", this.Metadata)} ]")}");
        }
    }
}