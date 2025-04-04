// <copyright file="CreateDeviceRequest.cs" company="APIMatic">
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
    /// CreateDeviceRequest.
    /// </summary>
    public class CreateDeviceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceRequest"/> class.
        /// </summary>
        public CreateDeviceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceRequest"/> class.
        /// </summary>
        /// <param name="platform">platform.</param>
        public CreateDeviceRequest(
            string platform = null)
        {
            this.Platform = platform;
        }

        /// <summary>
        /// Device's platform
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateDeviceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateDeviceRequest other &&
                (this.Platform == null && other.Platform == null ||
                 this.Platform?.Equals(other.Platform) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Platform = {this.Platform ?? "null"}");
        }
    }
}