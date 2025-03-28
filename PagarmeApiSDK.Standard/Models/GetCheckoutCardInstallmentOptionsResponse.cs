// <copyright file="GetCheckoutCardInstallmentOptionsResponse.cs" company="APIMatic">
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
    /// GetCheckoutCardInstallmentOptionsResponse.
    /// </summary>
    public class GetCheckoutCardInstallmentOptionsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCardInstallmentOptionsResponse"/> class.
        /// </summary>
        public GetCheckoutCardInstallmentOptionsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutCardInstallmentOptionsResponse"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="total">total.</param>
        public GetCheckoutCardInstallmentOptionsResponse(
            long? number = null,
            int? total = null)
        {
            this.Number = number;
            this.Total = total;
        }

        /// <summary>
        /// Número de parcelas
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Include)]
        public long? Number { get; set; }

        /// <summary>
        /// Valor total da compra
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Include)]
        public int? Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCheckoutCardInstallmentOptionsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCheckoutCardInstallmentOptionsResponse other &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.Total == null && other.Total == null ||
                 this.Total?.Equals(other.Total) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Number = {(this.Number == null ? "null" : this.Number.ToString())}");
            toStringOutput.Add($"Total = {(this.Total == null ? "null" : this.Total.ToString())}");
        }
    }
}