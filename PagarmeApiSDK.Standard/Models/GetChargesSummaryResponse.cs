// <copyright file="GetChargesSummaryResponse.cs" company="APIMatic">
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
    /// GetChargesSummaryResponse.
    /// </summary>
    public class GetChargesSummaryResponse
    {
        private int? total;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "total", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargesSummaryResponse"/> class.
        /// </summary>
        public GetChargesSummaryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargesSummaryResponse"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        public GetChargesSummaryResponse(
            int? total = null)
        {

            if (total != null)
            {
                this.Total = total;
            }
        }

        /// <summary>
        /// Gets or sets Total.
        /// </summary>
        [JsonProperty("total")]
        public int? Total
        {
            get
            {
                return this.total;
            }

            set
            {
                this.shouldSerialize["total"] = true;
                this.total = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetChargesSummaryResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTotal()
        {
            this.shouldSerialize["total"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotal()
        {
            return this.shouldSerialize["total"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetChargesSummaryResponse other &&
                (this.Total == null && other.Total == null ||
                 this.Total?.Equals(other.Total) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Total = {(this.Total == null ? "null" : this.Total.ToString())}");
        }
    }
}