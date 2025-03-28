// <copyright file="CreatePaymentAuthenticationRequest.cs" company="APIMatic">
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
    /// CreatePaymentAuthenticationRequest.
    /// </summary>
    public class CreatePaymentAuthenticationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentAuthenticationRequest"/> class.
        /// </summary>
        public CreatePaymentAuthenticationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentAuthenticationRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="threedSecure">threed_secure.</param>
        public CreatePaymentAuthenticationRequest(
            string type,
            Models.CreateThreeDSecureRequest threedSecure)
        {
            this.Type = type;
            this.ThreedSecure = threedSecure;
        }

        /// <summary>
        /// The Authentication type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The 3D-S authentication object
        /// </summary>
        [JsonProperty("threed_secure")]
        public Models.CreateThreeDSecureRequest ThreedSecure { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePaymentAuthenticationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePaymentAuthenticationRequest other &&
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