// <copyright file="CreateCheckoutCardInstallmentOptionRequest.cs" company="APIMatic">
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
    /// CreateCheckoutCardInstallmentOptionRequest.
    /// </summary>
    public class CreateCheckoutCardInstallmentOptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutCardInstallmentOptionRequest"/> class.
        /// </summary>
        public CreateCheckoutCardInstallmentOptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutCardInstallmentOptionRequest"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="total">total.</param>
        public CreateCheckoutCardInstallmentOptionRequest(
            int number,
            int total)
        {
            this.Number = number;
            this.Total = total;
        }

        /// <summary>
        /// Installment quantity
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCheckoutCardInstallmentOptionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCheckoutCardInstallmentOptionRequest other &&
                (this.Number.Equals(other.Number)) &&
                (this.Total.Equals(other.Total));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Number = {this.Number}");
            toStringOutput.Add($"Total = {this.Total}");
        }
    }
}