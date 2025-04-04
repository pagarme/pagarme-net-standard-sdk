// <copyright file="CreatePeriodRequest.cs" company="APIMatic">
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
    /// CreatePeriodRequest.
    /// </summary>
    public class CreatePeriodRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePeriodRequest"/> class.
        /// </summary>
        public CreatePeriodRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePeriodRequest"/> class.
        /// </summary>
        /// <param name="endAt">end_at.</param>
        public CreatePeriodRequest(
            DateTime? endAt = null)
        {
            this.EndAt = endAt;
        }

        /// <summary>
        /// Gets or sets EndAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePeriodRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePeriodRequest other &&
                (this.EndAt == null && other.EndAt == null ||
                 this.EndAt?.Equals(other.EndAt) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EndAt = {(this.EndAt == null ? "null" : this.EndAt.ToString())}");
        }
    }
}