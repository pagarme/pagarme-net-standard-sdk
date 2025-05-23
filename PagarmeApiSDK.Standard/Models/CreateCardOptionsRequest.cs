// <copyright file="CreateCardOptionsRequest.cs" company="APIMatic">
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
    /// CreateCardOptionsRequest.
    /// </summary>
    public class CreateCardOptionsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardOptionsRequest"/> class.
        /// </summary>
        public CreateCardOptionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardOptionsRequest"/> class.
        /// </summary>
        /// <param name="verifyCard">verify_card.</param>
        public CreateCardOptionsRequest(
            bool verifyCard)
        {
            this.VerifyCard = verifyCard;
        }

        /// <summary>
        /// Indicates if the card should be verified before creation. If true, executes an authorization before saving the card.
        /// </summary>
        [JsonProperty("verify_card")]
        public bool VerifyCard { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCardOptionsRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCardOptionsRequest other &&
                (this.VerifyCard.Equals(other.VerifyCard));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"VerifyCard = {this.VerifyCard}");
        }
    }
}