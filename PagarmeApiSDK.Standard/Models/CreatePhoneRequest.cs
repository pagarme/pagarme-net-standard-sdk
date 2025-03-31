// <copyright file="CreatePhoneRequest.cs" company="APIMatic">
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
    /// CreatePhoneRequest.
    /// </summary>
    public class CreatePhoneRequest
    {
        private string type;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneRequest"/> class.
        /// </summary>
        public CreatePhoneRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneRequest"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="number">number.</param>
        /// <param name="areaCode">area_code.</param>
        /// <param name="type">Type.</param>
        public CreatePhoneRequest(
            string countryCode = null,
            string number = null,
            string areaCode = null,
            string type = null)
        {
            this.CountryCode = countryCode;
            this.Number = number;
            this.AreaCode = areaCode;

            if (type != null)
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or sets CountryCode.
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets AreaCode.
        /// </summary>
        [JsonProperty("area_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["Type"] = true;
                this.type = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePhoneRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["Type"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["Type"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePhoneRequest other &&
                (this.CountryCode == null && other.CountryCode == null ||
                 this.CountryCode?.Equals(other.CountryCode) == true) &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.AreaCode == null && other.AreaCode == null ||
                 this.AreaCode?.Equals(other.AreaCode) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true);
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
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
        }
    }
}