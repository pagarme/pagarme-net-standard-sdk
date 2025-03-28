// <copyright file="GetWithdrawSourceResponse.cs" company="APIMatic">
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
    /// GetWithdrawSourceResponse.
    /// </summary>
    public class GetWithdrawSourceResponse
    {
        private string sourceId;
        private string type;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "source_id", false },
            { "type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawSourceResponse"/> class.
        /// </summary>
        public GetWithdrawSourceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawSourceResponse"/> class.
        /// </summary>
        /// <param name="sourceId">source_id.</param>
        /// <param name="type">type.</param>
        public GetWithdrawSourceResponse(
            string sourceId = null,
            string type = null)
        {

            if (sourceId != null)
            {
                this.SourceId = sourceId;
            }

            if (type != null)
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or sets SourceId.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId
        {
            get
            {
                return this.sourceId;
            }

            set
            {
                this.shouldSerialize["source_id"] = true;
                this.sourceId = value;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetWithdrawSourceResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSourceId()
        {
            this.shouldSerialize["source_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSourceId()
        {
            return this.shouldSerialize["source_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetWithdrawSourceResponse other &&
                (this.SourceId == null && other.SourceId == null ||
                 this.SourceId?.Equals(other.SourceId) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SourceId = {this.SourceId ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
        }
    }
}