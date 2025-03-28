// <copyright file="PagingResponse.cs" company="APIMatic">
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
    /// PagingResponse.
    /// </summary>
    public class PagingResponse
    {
        private int? total;
        private string previous;
        private string next;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "total", false },
            { "previous", false },
            { "next", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingResponse"/> class.
        /// </summary>
        public PagingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingResponse"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="previous">previous.</param>
        /// <param name="next">next.</param>
        public PagingResponse(
            int? total = null,
            string previous = null,
            string next = null)
        {

            if (total != null)
            {
                this.Total = total;
            }

            if (previous != null)
            {
                this.Previous = previous;
            }

            if (next != null)
            {
                this.Next = next;
            }
        }

        /// <summary>
        /// Total number of pages
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

        /// <summary>
        /// Previous page
        /// </summary>
        [JsonProperty("previous")]
        public string Previous
        {
            get
            {
                return this.previous;
            }

            set
            {
                this.shouldSerialize["previous"] = true;
                this.previous = value;
            }
        }

        /// <summary>
        /// Next page
        /// </summary>
        [JsonProperty("next")]
        public string Next
        {
            get
            {
                return this.next;
            }

            set
            {
                this.shouldSerialize["next"] = true;
                this.next = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PagingResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTotal()
        {
            this.shouldSerialize["total"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPrevious()
        {
            this.shouldSerialize["previous"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNext()
        {
            this.shouldSerialize["next"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotal()
        {
            return this.shouldSerialize["total"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrevious()
        {
            return this.shouldSerialize["previous"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNext()
        {
            return this.shouldSerialize["next"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PagingResponse other &&
                (this.Total == null && other.Total == null ||
                 this.Total?.Equals(other.Total) == true) &&
                (this.Previous == null && other.Previous == null ||
                 this.Previous?.Equals(other.Previous) == true) &&
                (this.Next == null && other.Next == null ||
                 this.Next?.Equals(other.Next) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Total = {(this.Total == null ? "null" : this.Total.ToString())}");
            toStringOutput.Add($"Previous = {this.Previous ?? "null"}");
            toStringOutput.Add($"Next = {this.Next ?? "null"}");
        }
    }
}