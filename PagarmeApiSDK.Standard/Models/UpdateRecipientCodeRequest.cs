// <copyright file="UpdateRecipientCodeRequest.cs" company="APIMatic">
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
    /// UpdateRecipientCodeRequest.
    /// </summary>
    public class UpdateRecipientCodeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecipientCodeRequest"/> class.
        /// </summary>
        public UpdateRecipientCodeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecipientCodeRequest"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        public UpdateRecipientCodeRequest(
            string code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateRecipientCodeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateRecipientCodeRequest other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
        }
    }
}