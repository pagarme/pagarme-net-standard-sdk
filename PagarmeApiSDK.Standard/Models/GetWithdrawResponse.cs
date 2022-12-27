// <copyright file="GetWithdrawResponse.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetWithdrawResponse.
    /// </summary>
    public class GetWithdrawResponse
    {
        private List<string> metadata;
        private int? fee;
        private DateTime? fundingDate;
        private DateTime? fundingEstimatedDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "metadata", false },
            { "fee", false },
            { "funding_date", false },
            { "funding_estimated_date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawResponse"/> class.
        /// </summary>
        public GetWithdrawResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="fee">fee.</param>
        /// <param name="fundingDate">funding_date.</param>
        /// <param name="fundingEstimatedDate">funding_estimated_date.</param>
        /// <param name="type">type.</param>
        /// <param name="source">source.</param>
        /// <param name="target">target.</param>
        public GetWithdrawResponse(
            string id = null,
            string gatewayId = null,
            int? amount = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            List<string> metadata = null,
            int? fee = null,
            DateTime? fundingDate = null,
            DateTime? fundingEstimatedDate = null,
            string type = null,
            Models.GetWithdrawSourceResponse source = null,
            Models.GetWithdrawTargetResponse target = null)
        {
            this.Id = id;
            this.GatewayId = gatewayId;
            this.Amount = amount;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (metadata != null)
            {
                this.Metadata = metadata;
            }

            if (fee != null)
            {
                this.Fee = fee;
            }

            if (fundingDate != null)
            {
                this.FundingDate = fundingDate;
            }

            if (fundingEstimatedDate != null)
            {
                this.FundingEstimatedDate = fundingEstimatedDate;
            }

            this.Type = type;
            this.Source = source;
            this.Target = target;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets GatewayId.
        /// </summary>
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Include)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public List<string> Metadata
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
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee")]
        public int? Fee
        {
            get
            {
                return this.fee;
            }

            set
            {
                this.shouldSerialize["fee"] = true;
                this.fee = value;
            }
        }

        /// <summary>
        /// Gets or sets FundingDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("funding_date")]
        public DateTime? FundingDate
        {
            get
            {
                return this.fundingDate;
            }

            set
            {
                this.shouldSerialize["funding_date"] = true;
                this.fundingDate = value;
            }
        }

        /// <summary>
        /// Gets or sets FundingEstimatedDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("funding_estimated_date")]
        public DateTime? FundingEstimatedDate
        {
            get
            {
                return this.fundingEstimatedDate;
            }

            set
            {
                this.shouldSerialize["funding_estimated_date"] = true;
                this.fundingEstimatedDate = value;
            }
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Include)]
        public Models.GetWithdrawSourceResponse Source { get; set; }

        /// <summary>
        /// Gets or sets Target.
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Include)]
        public Models.GetWithdrawTargetResponse Target { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetWithdrawResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMetadata()
        {
            this.shouldSerialize["metadata"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFee()
        {
            this.shouldSerialize["fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFundingDate()
        {
            this.shouldSerialize["funding_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFundingEstimatedDate()
        {
            this.shouldSerialize["funding_estimated_date"] = false;
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
        public bool ShouldSerializeFee()
        {
            return this.shouldSerialize["fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFundingDate()
        {
            return this.shouldSerialize["funding_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFundingEstimatedDate()
        {
            return this.shouldSerialize["funding_estimated_date"];
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

            return obj is GetWithdrawResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.GatewayId == null && other.GatewayId == null) || (this.GatewayId?.Equals(other.GatewayId) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Fee == null && other.Fee == null) || (this.Fee?.Equals(other.Fee) == true)) &&
                ((this.FundingDate == null && other.FundingDate == null) || (this.FundingDate?.Equals(other.FundingDate) == true)) &&
                ((this.FundingEstimatedDate == null && other.FundingEstimatedDate == null) || (this.FundingEstimatedDate?.Equals(other.FundingEstimatedDate) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.Target == null && other.Target == null) || (this.Target?.Equals(other.Target) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.GatewayId = {(this.GatewayId == null ? "null" : this.GatewayId == string.Empty ? "" : this.GatewayId)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : $"[{string.Join(", ", this.Metadata)} ]")}");
            toStringOutput.Add($"this.Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"this.FundingDate = {(this.FundingDate == null ? "null" : this.FundingDate.ToString())}");
            toStringOutput.Add($"this.FundingEstimatedDate = {(this.FundingEstimatedDate == null ? "null" : this.FundingEstimatedDate.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source.ToString())}");
            toStringOutput.Add($"this.Target = {(this.Target == null ? "null" : this.Target.ToString())}");
        }
    }
}