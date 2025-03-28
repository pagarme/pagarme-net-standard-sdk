// <copyright file="CreateLocationRequest.cs" company="APIMatic">
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
    /// CreateLocationRequest.
    /// </summary>
    public class CreateLocationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLocationRequest"/> class.
        /// </summary>
        public CreateLocationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLocationRequest"/> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public CreateLocationRequest(
            string latitude,
            string longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateLocationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateLocationRequest other &&
                (this.Latitude == null && other.Latitude == null ||
                 this.Latitude?.Equals(other.Latitude) == true) &&
                (this.Longitude == null && other.Longitude == null ||
                 this.Longitude?.Equals(other.Longitude) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Latitude = {this.Latitude ?? "null"}");
            toStringOutput.Add($"Longitude = {this.Longitude ?? "null"}");
        }
    }
}