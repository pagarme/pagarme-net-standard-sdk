// <copyright file="GetPhoneResponse.cs" company="APIMatic">
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
    /// GetPhoneResponse.
    /// </summary>
    public class GetPhoneResponse
    {
        private string countryCode;
        private string number;
        private string areaCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "country_code", false },
            { "number", false },
            { "area_code", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneResponse"/> class.
        /// </summary>
        public GetPhoneResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneResponse"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="number">number.</param>
        /// <param name="areaCode">area_code.</param>
        public GetPhoneResponse(
            string countryCode = null,
            string number = null,
            string areaCode = null)
        {

            if (countryCode != null)
            {
                this.CountryCode = countryCode;
            }

            if (number != null)
            {
                this.Number = number;
            }

            if (areaCode != null)
            {
                this.AreaCode = areaCode;
            }
        }

        /// <summary>
        /// Gets or sets CountryCode.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode
        {
            get
            {
                return this.countryCode;
            }

            set
            {
                this.shouldSerialize["country_code"] = true;
                this.countryCode = value;
            }
        }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number")]
        public string Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.shouldSerialize["number"] = true;
                this.number = value;
            }
        }

        /// <summary>
        /// Gets or sets AreaCode.
        /// </summary>
        [JsonProperty("area_code")]
        public string AreaCode
        {
            get
            {
                return this.areaCode;
            }

            set
            {
                this.shouldSerialize["area_code"] = true;
                this.areaCode = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPhoneResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCountryCode()
        {
            this.shouldSerialize["country_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNumber()
        {
            this.shouldSerialize["number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAreaCode()
        {
            this.shouldSerialize["area_code"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountryCode()
        {
            return this.shouldSerialize["country_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNumber()
        {
            return this.shouldSerialize["number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAreaCode()
        {
            return this.shouldSerialize["area_code"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPhoneResponse other &&
                (this.CountryCode == null && other.CountryCode == null ||
                 this.CountryCode?.Equals(other.CountryCode) == true) &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.AreaCode == null && other.AreaCode == null ||
                 this.AreaCode?.Equals(other.AreaCode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CountryCode = {this.CountryCode ?? "null"}");
            toStringOutput.Add($"Number = {this.Number ?? "null"}");
            toStringOutput.Add($"AreaCode = {this.AreaCode ?? "null"}");
        }
    }
}