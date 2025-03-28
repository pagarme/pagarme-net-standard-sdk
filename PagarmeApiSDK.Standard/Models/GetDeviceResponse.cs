// <copyright file="GetDeviceResponse.cs" company="APIMatic">
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
    /// GetDeviceResponse.
    /// </summary>
    public class GetDeviceResponse
    {
        private string platform;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "platform", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceResponse"/> class.
        /// </summary>
        public GetDeviceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceResponse"/> class.
        /// </summary>
        /// <param name="platform">platform.</param>
        public GetDeviceResponse(
            string platform = null)
        {

            if (platform != null)
            {
                this.Platform = platform;
            }
        }

        /// <summary>
        /// Device's platform name
        /// </summary>
        [JsonProperty("platform")]
        public string Platform
        {
            get
            {
                return this.platform;
            }

            set
            {
                this.shouldSerialize["platform"] = true;
                this.platform = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetDeviceResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPlatform()
        {
            this.shouldSerialize["platform"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePlatform()
        {
            return this.shouldSerialize["platform"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetDeviceResponse other &&
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