// <copyright file="ListTransfers.cs" company="APIMatic">
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
    /// ListTransfers.
    /// </summary>
    public class ListTransfers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransfers"/> class.
        /// </summary>
        public ListTransfers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransfers"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="paging">paging.</param>
        public ListTransfers(
            List<Models.GetTransfer> data,
            Models.PagingResponse paging)
        {
            this.Data = data;
            this.Paging = paging;
        }

        /// <summary>
        /// The Increments response
        /// </summary>
        [JsonProperty("data")]
        public List<Models.GetTransfer> Data { get; set; }

        /// <summary>
        /// Paging object
        /// </summary>
        [JsonProperty("paging")]
        public Models.PagingResponse Paging { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListTransfers : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListTransfers other &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true) &&
                (this.Paging == null && other.Paging == null ||
                 this.Paging?.Equals(other.Paging) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"Paging = {(this.Paging == null ? "null" : this.Paging.ToString())}");
        }
    }
}