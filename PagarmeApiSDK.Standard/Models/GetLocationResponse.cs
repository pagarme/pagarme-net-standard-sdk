// <copyright file="GetLocationResponse.cs" company="APIMatic">
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
    /// GetLocationResponse.
    /// </summary>
    public class GetLocationResponse
    {
        private string latitude;
        private string longitude;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "latitude", false },
            { "longitude", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLocationResponse"/> class.
        /// </summary>
        public GetLocationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLocationResponse"/> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public GetLocationResponse(
            string latitude = null,
            string longitude = null)
        {

            if (latitude != null)
            {
                this.Latitude = latitude;
            }

            if (longitude != null)
            {
                this.Longitude = longitude;
            }
        }

        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                this.shouldSerialize["latitude"] = true;
                this.latitude = value;
            }
        }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                this.shouldSerialize["longitude"] = true;
                this.longitude = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetLocationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLatitude()
        {
            this.shouldSerialize["latitude"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLongitude()
        {
            this.shouldSerialize["longitude"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLatitude()
        {
            return this.shouldSerialize["latitude"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLongitude()
        {
            return this.shouldSerialize["longitude"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetLocationResponse other &&
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