// <copyright file="GetGatewayRecipientResponse.cs" company="APIMatic">
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
    /// GetGatewayRecipientResponse.
    /// </summary>
    public class GetGatewayRecipientResponse
    {
        private string gateway;
        private string status;
        private string pgid;
        private string createdAt;
        private string updatedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "gateway", false },
            { "status", false },
            { "pgid", false },
            { "created_at", false },
            { "updated_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayRecipientResponse"/> class.
        /// </summary>
        public GetGatewayRecipientResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayRecipientResponse"/> class.
        /// </summary>
        /// <param name="gateway">gateway.</param>
        /// <param name="status">status.</param>
        /// <param name="pgid">pgid.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        public GetGatewayRecipientResponse(
            string gateway = null,
            string status = null,
            string pgid = null,
            string createdAt = null,
            string updatedAt = null)
        {

            if (gateway != null)
            {
                this.Gateway = gateway;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (pgid != null)
            {
                this.Pgid = pgid;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }
        }

        /// <summary>
        /// Gateway name
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway
        {
            get
            {
                return this.gateway;
            }

            set
            {
                this.shouldSerialize["gateway"] = true;
                this.gateway = value;
            }
        }

        /// <summary>
        /// Status of the recipient on the gateway
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
        /// Recipient id on the gateway
        /// </summary>
        [JsonProperty("pgid")]
        public string Pgid
        {
            get
            {
                return this.pgid;
            }

            set
            {
                this.shouldSerialize["pgid"] = true;
                this.pgid = value;
            }
        }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt
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
        /// Last update date
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetGatewayRecipientResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGateway()
        {
            this.shouldSerialize["gateway"] = false;
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
        public void UnsetPgid()
        {
            this.shouldSerialize["pgid"] = false;
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
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGateway()
        {
            return this.shouldSerialize["gateway"];
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
        public bool ShouldSerializePgid()
        {
            return this.shouldSerialize["pgid"];
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetGatewayRecipientResponse other &&
                (this.Gateway == null && other.Gateway == null ||
                 this.Gateway?.Equals(other.Gateway) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Pgid == null && other.Pgid == null ||
                 this.Pgid?.Equals(other.Pgid) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Gateway = {this.Gateway ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Pgid = {this.Pgid ?? "null"}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"UpdatedAt = {this.UpdatedAt ?? "null"}");
        }
    }
}