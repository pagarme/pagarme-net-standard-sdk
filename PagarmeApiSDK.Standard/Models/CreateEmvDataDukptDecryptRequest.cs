// <copyright file="CreateEmvDataDukptDecryptRequest.cs" company="APIMatic">
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
    /// CreateEmvDataDukptDecryptRequest.
    /// </summary>
    public class CreateEmvDataDukptDecryptRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataDukptDecryptRequest"/> class.
        /// </summary>
        public CreateEmvDataDukptDecryptRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmvDataDukptDecryptRequest"/> class.
        /// </summary>
        /// <param name="ksn">ksn.</param>
        public CreateEmvDataDukptDecryptRequest(
            string ksn)
        {
            this.Ksn = ksn;
        }

        /// <summary>
        /// Key serial number
        /// </summary>
        [JsonProperty("ksn")]
        public string Ksn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateEmvDataDukptDecryptRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateEmvDataDukptDecryptRequest other &&
                (this.Ksn == null && other.Ksn == null ||
                 this.Ksn?.Equals(other.Ksn) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ksn = {this.Ksn ?? "null"}");
        }
    }
}