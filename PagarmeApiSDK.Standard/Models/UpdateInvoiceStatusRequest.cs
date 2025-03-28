// <copyright file="UpdateInvoiceStatusRequest.cs" company="APIMatic">
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
    /// UpdateInvoiceStatusRequest.
    /// </summary>
    public class UpdateInvoiceStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoiceStatusRequest"/> class.
        /// </summary>
        public UpdateInvoiceStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoiceStatusRequest"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        public UpdateInvoiceStatusRequest(
            string status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateInvoiceStatusRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateInvoiceStatusRequest other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
        }
    }
}