// <copyright file="CreateClearSaleRequest.cs" company="APIMatic">
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
    /// CreateClearSaleRequest.
    /// </summary>
    public class CreateClearSaleRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClearSaleRequest"/> class.
        /// </summary>
        public CreateClearSaleRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClearSaleRequest"/> class.
        /// </summary>
        /// <param name="customSla">custom_sla.</param>
        public CreateClearSaleRequest(
            int customSla)
        {
            this.CustomSla = customSla;
        }

        /// <summary>
        /// Gets or sets CustomSla.
        /// </summary>
        [JsonProperty("custom_sla")]
        public int CustomSla { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateClearSaleRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateClearSaleRequest other &&
                (this.CustomSla.Equals(other.CustomSla));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomSla = {this.CustomSla}");
        }
    }
}