// <copyright file="GetWithdrawResponse.cs" company="APIMatic">
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
    /// GetWithdrawResponse.
    /// </summary>
    public class GetWithdrawResponse
    {
        private string id;
        private string gatewayId;
        private int? amount;
        private string status;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private List<string> metadata;
        private int? fee;
        private DateTime? fundingDate;
        private DateTime? fundingEstimatedDate;
        private string type;
        private Models.GetWithdrawSourceResponse source;
        private Models.GetWithdrawTargetResponse target;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "gateway_id", false },
            { "amount", false },
            { "status", false },
            { "created_at", false },
            { "updated_at", false },
            { "metadata", false },
            { "fee", false },
            { "funding_date", false },
            { "funding_estimated_date", false },
            { "type", false },
            { "source", false },
            { "target", false },
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

            if (id != null)
            {
                this.Id = id;
            }

            if (gatewayId != null)
            {
                this.GatewayId = gatewayId;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

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

            if (type != null)
            {
                this.Type = type;
            }

            if (source != null)
            {
                this.Source = source;
            }

            if (target != null)
            {
                this.Target = target;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets GatewayId.
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId
        {
            get
            {
                return this.gatewayId;
            }

            set
            {
                this.shouldSerialize["gateway_id"] = true;
                this.gatewayId = value;
            }
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.shouldSerialize["amount"] = true;
                this.amount = value;
            }
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime? CreatedAt
        {
            get
            {
                return this.createdAt;
            }

            set
            {
                this.shouldSerialize["created_at"] = true;
                this.createdAt = value;
            }
        }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt
        {
            get
            {
                return this.updatedAt;
            }

            set
            {
                this.shouldSerialize["updated_at"] = true;
                this.updatedAt = value;
            }
        }

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
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source")]
        public Models.GetWithdrawSourceResponse Source
        {
            get
            {
                return this.source;
            }

            set
            {
                this.shouldSerialize["source"] = true;
                this.source = value;
            }
        }

        /// <summary>
        /// Gets or sets Target.
        /// </summary>
        [JsonProperty("target")]
        public Models.GetWithdrawTargetResponse Target
        {
            get
            {
                return this.target;
            }

            set
            {
                this.shouldSerialize["target"] = true;
                this.target = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetWithdrawResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGatewayId()
        {
            this.shouldSerialize["gateway_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdatedAt()
        {
            this.shouldSerialize["updated_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMetadata()
        {
            this.shouldSerialize["metadata"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFee()
        {
            this.shouldSerialize["fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFundingDate()
        {
            this.shouldSerialize["funding_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFundingEstimatedDate()
        {
            this.shouldSerialize["funding_estimated_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSource()
        {
            this.shouldSerialize["source"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTarget()
        {
            this.shouldSerialize["target"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGatewayId()
        {
            return this.shouldSerialize["gateway_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return this.shouldSerialize["updated_at"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSource()
        {
            return this.shouldSerialize["source"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTarget()
        {
            return this.shouldSerialize["target"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetWithdrawResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.GatewayId == null && other.GatewayId == null ||
                 this.GatewayId?.Equals(other.GatewayId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
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
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : $"[{string.Join(", ", this.Metadata)} ]")}");
            toStringOutput.Add($"Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"FundingDate = {(this.FundingDate == null ? "null" : this.FundingDate.ToString())}");
            toStringOutput.Add($"FundingEstimatedDate = {(this.FundingEstimatedDate == null ? "null" : this.FundingEstimatedDate.ToString())}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
            toStringOutput.Add($"Target = {(this.Target == null ? "null" : this.Target.ToString())}");
        }
    }
}