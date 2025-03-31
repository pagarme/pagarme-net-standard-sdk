// <copyright file="GetAnticipationLimitsResponse.cs" company="APIMatic">
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
    /// GetAnticipationLimitsResponse.
    /// </summary>
    public class GetAnticipationLimitsResponse
    {
        private Models.GetAnticipationLimitResponse max;
        private Models.GetAnticipationLimitResponse min;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "max", false },
            { "min", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitsResponse"/> class.
        /// </summary>
        public GetAnticipationLimitsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitsResponse"/> class.
        /// </summary>
        /// <param name="max">max.</param>
        /// <param name="min">min.</param>
        public GetAnticipationLimitsResponse(
            Models.GetAnticipationLimitResponse max = null,
            Models.GetAnticipationLimitResponse min = null)
        {

            if (max != null)
            {
                this.Max = max;
            }

            if (min != null)
            {
                this.Min = min;
            }
        }

        /// <summary>
        /// Max limit
        /// </summary>
        [JsonProperty("max")]
        public Models.GetAnticipationLimitResponse Max
        {
            get
            {
                return this.max;
            }

            set
            {
                this.shouldSerialize["max"] = true;
                this.max = value;
            }
        }

        /// <summary>
        /// Min limit
        /// </summary>
        [JsonProperty("min")]
        public Models.GetAnticipationLimitResponse Min
        {
            get
            {
                return this.min;
            }

            set
            {
                this.shouldSerialize["min"] = true;
                this.min = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetAnticipationLimitsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMax()
        {
            this.shouldSerialize["max"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMin()
        {
            this.shouldSerialize["min"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMax()
        {
            return this.shouldSerialize["max"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMin()
        {
            return this.shouldSerialize["min"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetAnticipationLimitsResponse other &&
                (this.Max == null && other.Max == null ||
                 this.Max?.Equals(other.Max) == true) &&
                (this.Min == null && other.Min == null ||
                 this.Min?.Equals(other.Min) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Max = {(this.Max == null ? "null" : this.Max.ToString())}");
            toStringOutput.Add($"Min = {(this.Min == null ? "null" : this.Min.ToString())}");
        }
    }
}