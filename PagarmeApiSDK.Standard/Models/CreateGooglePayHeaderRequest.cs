// <copyright file="CreateGooglePayHeaderRequest.cs" company="APIMatic">
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
    /// CreateGooglePayHeaderRequest.
    /// </summary>
    public class CreateGooglePayHeaderRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGooglePayHeaderRequest"/> class.
        /// </summary>
        public CreateGooglePayHeaderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGooglePayHeaderRequest"/> class.
        /// </summary>
        /// <param name="ephemeralPublicKey">ephemeral_public_key.</param>
        public CreateGooglePayHeaderRequest(
            string ephemeralPublicKey)
        {
            this.EphemeralPublicKey = ephemeralPublicKey;
        }

        /// <summary>
        /// X.509 encoded key bytes, Base64 encoded as a string
        /// </summary>
        [JsonProperty("ephemeral_public_key")]
        public string EphemeralPublicKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateGooglePayHeaderRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateGooglePayHeaderRequest other &&
                (this.EphemeralPublicKey == null && other.EphemeralPublicKey == null ||
                 this.EphemeralPublicKey?.Equals(other.EphemeralPublicKey) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EphemeralPublicKey = {this.EphemeralPublicKey ?? "null"}");
        }
    }
}