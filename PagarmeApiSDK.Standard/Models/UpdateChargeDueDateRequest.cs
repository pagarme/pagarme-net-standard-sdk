// <copyright file="UpdateChargeDueDateRequest.cs" company="APIMatic">
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
    /// UpdateChargeDueDateRequest.
    /// </summary>
    public class UpdateChargeDueDateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeDueDateRequest"/> class.
        /// </summary>
        public UpdateChargeDueDateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeDueDateRequest"/> class.
        /// </summary>
        /// <param name="dueAt">due_at.</param>
        public UpdateChargeDueDateRequest(
            DateTime? dueAt = null)
        {
            this.DueAt = dueAt;
        }

        /// <summary>
        /// The charge's new due date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateChargeDueDateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateChargeDueDateRequest other &&
                (this.DueAt == null && other.DueAt == null ||
                 this.DueAt?.Equals(other.DueAt) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
        }
    }
}