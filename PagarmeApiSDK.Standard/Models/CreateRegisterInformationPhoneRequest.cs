// <copyright file="CreateRegisterInformationPhoneRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Models
{
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

    /// <summary>
    /// CreateRegisterInformationPhoneRequest.
    /// </summary>
    public class CreateRegisterInformationPhoneRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationPhoneRequest"/> class.
        /// </summary>
        public CreateRegisterInformationPhoneRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationPhoneRequest"/> class.
        /// </summary>
        /// <param name="ddd">ddd.</param>
        /// <param name="number">number.</param>
        /// <param name="type">type.</param>
        public CreateRegisterInformationPhoneRequest(
            string ddd,
            string number,
            string type)
        {
            this.Ddd = ddd;
            this.Number = number;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Ddd.
        /// </summary>
        [JsonProperty("ddd")]
        public string Ddd { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateRegisterInformationPhoneRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CreateRegisterInformationPhoneRequest other &&                ((this.Ddd == null && other.Ddd == null) || (this.Ddd?.Equals(other.Ddd) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ddd = {(this.Ddd == null ? "null" : this.Ddd)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}