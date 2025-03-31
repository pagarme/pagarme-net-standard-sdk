// <copyright file="GetWithdrawTargetResponse.cs" company="APIMatic">
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
    /// GetWithdrawTargetResponse.
    /// </summary>
    public class GetWithdrawTargetResponse
    {
        private string targetId;
        private string type;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "target_id", false },
            { "type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawTargetResponse"/> class.
        /// </summary>
        public GetWithdrawTargetResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawTargetResponse"/> class.
        /// </summary>
        /// <param name="targetId">target_id.</param>
        /// <param name="type">type.</param>
        public GetWithdrawTargetResponse(
            string targetId = null,
            string type = null)
        {

            if (targetId != null)
            {
                this.TargetId = targetId;
            }

            if (type != null)
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or sets TargetId.
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId
        {
            get
            {
                return this.targetId;
            }

            set
            {
                this.shouldSerialize["target_id"] = true;
                this.targetId = value;
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
            return $"GetWithdrawTargetResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTargetId()
        {
            this.shouldSerialize["target_id"] = false;
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
        public bool ShouldSerializeTargetId()
        {
            return this.shouldSerialize["target_id"];
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

            return obj is GetWithdrawTargetResponse other &&
                (this.TargetId == null && other.TargetId == null ||
                 this.TargetId?.Equals(other.TargetId) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TargetId = {this.TargetId ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
        }
    }
}