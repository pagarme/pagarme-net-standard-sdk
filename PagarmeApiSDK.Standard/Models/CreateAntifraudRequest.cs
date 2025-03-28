// <copyright file="CreateAntifraudRequest.cs" company="APIMatic">
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
    /// CreateAntifraudRequest.
    /// </summary>
    public class CreateAntifraudRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAntifraudRequest"/> class.
        /// </summary>
        public CreateAntifraudRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAntifraudRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="clearsale">clearsale.</param>
        public CreateAntifraudRequest(
            string type,
            Models.CreateClearSaleRequest clearsale)
        {
            this.Type = type;
            this.Clearsale = clearsale;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Clearsale.
        /// </summary>
        [JsonProperty("clearsale")]
        public Models.CreateClearSaleRequest Clearsale { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateAntifraudRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateAntifraudRequest other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Clearsale == null && other.Clearsale == null ||
                 this.Clearsale?.Equals(other.Clearsale) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Clearsale = {(this.Clearsale == null ? "null" : this.Clearsale.ToString())}");
        }
    }
}