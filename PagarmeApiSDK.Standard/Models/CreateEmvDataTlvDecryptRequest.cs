// <copyright file="CreateEmvDataTlvDecryptRequest.cs" company="APIMatic">
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
    /// CreateEmvDataTlvDecryptRequest.
    /// </summary>
    public class CreateEmvDataTlvDecryptRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataTlvDecryptRequest"/> class.
        /// </summary>
        public CreateEmvDataTlvDecryptRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataTlvDecryptRequest"/> class.
        /// </summary>
        /// <param name="tag">tag.</param>
        /// <param name="lenght">lenght.</param>
        /// <param name="mValue">value.</param>
        public CreateEmvDataTlvDecryptRequest(
            string tag,
            string lenght,
            string mValue)
        {
            this.Tag = tag;
            this.Lenght = lenght;
            this.MValue = mValue;
        }

        /// <summary>
        /// Emv tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Emv lenght
        /// </summary>
        [JsonProperty("lenght")]
        public string Lenght { get; set; }

        /// <summary>
        /// Emv value
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateEmvDataTlvDecryptRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateEmvDataTlvDecryptRequest other &&
                (this.Tag == null && other.Tag == null ||
                 this.Tag?.Equals(other.Tag) == true) &&
                (this.Lenght == null && other.Lenght == null ||
                 this.Lenght?.Equals(other.Lenght) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Tag = {this.Tag ?? "null"}");
            toStringOutput.Add($"Lenght = {this.Lenght ?? "null"}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
        }
    }
}