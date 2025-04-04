// <copyright file="GetTransfer.cs" company="APIMatic">
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
    /// GetTransfer.
    /// </summary>
    public class GetTransfer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransfer"/> class.
        /// </summary>
        public GetTransfer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransfer"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="type">type.</param>
        /// <param name="source">source.</param>
        /// <param name="target">target.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="fee">fee.</param>
        /// <param name="fundingDate">funding_date.</param>
        /// <param name="fundingEstimatedDate">funding_estimated_date.</param>
        public GetTransfer(
            string id,
            string gatewayId,
            int amount,
            string status,
            DateTime createdAt,
            DateTime updatedAt,
            string type,
            Models.GetTransferSourceResponse source,
            Models.GetTransferTargetResponse target,
            Dictionary<string, string> metadata = null,
            int? fee = null,
            DateTime? fundingDate = null,
            DateTime? fundingEstimatedDate = null)
        {
            this.Id = id;
            this.GatewayId = gatewayId;
            this.Amount = amount;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Metadata = metadata;
            this.Fee = fee;
            this.FundingDate = fundingDate;
            this.FundingEstimatedDate = fundingEstimatedDate;
            this.Type = type;
            this.Source = source;
            this.Target = target;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets GatewayId.
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fee { get; set; }

        /// <summary>
        /// Gets or sets FundingDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("funding_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FundingDate { get; set; }

        /// <summary>
        /// Gets or sets FundingEstimatedDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("funding_estimated_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FundingEstimatedDate { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source")]
        public Models.GetTransferSourceResponse Source { get; set; }

        /// <summary>
        /// Gets or sets Target.
        /// </summary>
        [JsonProperty("target")]
        public Models.GetTransferTargetResponse Target { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetTransfer : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetTransfer other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.GatewayId == null && other.GatewayId == null ||
                 this.GatewayId?.Equals(other.GatewayId) == true) &&
                (this.Amount.Equals(other.Amount)) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.CreatedAt.Equals(other.CreatedAt)) &&
                (this.UpdatedAt.Equals(other.UpdatedAt)) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Fee == null && other.Fee == null ||
                 this.Fee?.Equals(other.Fee) == true) &&
                (this.FundingDate == null && other.FundingDate == null ||
                 this.FundingDate?.Equals(other.FundingDate) == true) &&
                (this.FundingEstimatedDate == null && other.FundingEstimatedDate == null ||
                 this.FundingEstimatedDate?.Equals(other.FundingEstimatedDate) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Source == null && other.Source == null ||
                 this.Source?.Equals(other.Source) == true) &&
                (this.Target == null && other.Target == null ||
                 this.Target?.Equals(other.Target) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"GatewayId = {this.GatewayId ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"FundingDate = {(this.FundingDate == null ? "null" : this.FundingDate.ToString())}");
            toStringOutput.Add($"FundingEstimatedDate = {(this.FundingEstimatedDate == null ? "null" : this.FundingEstimatedDate.ToString())}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
            toStringOutput.Add($"Target = {(this.Target == null ? "null" : this.Target.ToString())}");
        }
    }
}