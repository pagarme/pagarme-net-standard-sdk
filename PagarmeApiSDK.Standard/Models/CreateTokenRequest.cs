// <copyright file="CreateTokenRequest.cs" company="APIMatic">
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
    /// CreateTokenRequest.
    /// </summary>
    public class CreateTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenRequest"/> class.
        /// </summary>
        public CreateTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="card">card.</param>
        public CreateTokenRequest(
            string type,
            Models.CreateCardTokenRequest card)
        {
            this.Type = type;
            this.Card = card;
        }

        /// <summary>
        /// Token type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardTokenRequest Card { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateTokenRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateTokenRequest other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
        }
    }
}