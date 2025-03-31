// <copyright file="GetPaymentAuthenticationResponse.cs" company="APIMatic">
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
    /// GetPaymentAuthenticationResponse.
    /// </summary>
    public class GetPaymentAuthenticationResponse
    {
        private string type;
        private Models.GetThreeDSecureResponse threedSecure;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "type", false },
            { "threed_secure", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPaymentAuthenticationResponse"/> class.
        /// </summary>
        public GetPaymentAuthenticationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPaymentAuthenticationResponse"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="threedSecure">threed_secure.</param>
        public GetPaymentAuthenticationResponse(
            string type = null,
            Models.GetThreeDSecureResponse threedSecure = null)
        {

            if (type != null)
            {
                this.Type = type;
            }

            if (threedSecure != null)
            {
                this.ThreedSecure = threedSecure;
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
        /// 3D-S payment authentication response
        /// </summary>
        [JsonProperty("threed_secure")]
        public Models.GetThreeDSecureResponse ThreedSecure
        {
            get
            {
                return this.threedSecure;
            }

            set
            {
                this.shouldSerialize["threed_secure"] = true;
                this.threedSecure = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPaymentAuthenticationResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetThreedSecure()
        {
            this.shouldSerialize["threed_secure"] = false;
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
        public bool ShouldSerializeThreedSecure()
        {
            return this.shouldSerialize["threed_secure"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPaymentAuthenticationResponse other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.ThreedSecure == null && other.ThreedSecure == null ||
                 this.ThreedSecure?.Equals(other.ThreedSecure) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"ThreedSecure = {(this.ThreedSecure == null ? "null" : this.ThreedSecure.ToString())}");
        }
    }
}