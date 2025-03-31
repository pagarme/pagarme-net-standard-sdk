// <copyright file="UpdateTransferSettingsRequest.cs" company="APIMatic">
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
    /// UpdateTransferSettingsRequest.
    /// </summary>
    public class UpdateTransferSettingsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransferSettingsRequest"/> class.
        /// </summary>
        public UpdateTransferSettingsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransferSettingsRequest"/> class.
        /// </summary>
        /// <param name="transferEnabled">transfer_enabled.</param>
        /// <param name="transferInterval">transfer_interval.</param>
        /// <param name="transferDay">transfer_day.</param>
        public UpdateTransferSettingsRequest(
            string transferEnabled,
            string transferInterval,
            string transferDay)
        {
            this.TransferEnabled = transferEnabled;
            this.TransferInterval = transferInterval;
            this.TransferDay = transferDay;
        }

        /// <summary>
        /// Gets or sets TransferEnabled.
        /// </summary>
        [JsonProperty("transfer_enabled")]
        public string TransferEnabled { get; set; }

        /// <summary>
        /// Gets or sets TransferInterval.
        /// </summary>
        [JsonProperty("transfer_interval")]
        public string TransferInterval { get; set; }

        /// <summary>
        /// Gets or sets TransferDay.
        /// </summary>
        [JsonProperty("transfer_day")]
        public string TransferDay { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateTransferSettingsRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateTransferSettingsRequest other &&
                (this.TransferEnabled == null && other.TransferEnabled == null ||
                 this.TransferEnabled?.Equals(other.TransferEnabled) == true) &&
                (this.TransferInterval == null && other.TransferInterval == null ||
                 this.TransferInterval?.Equals(other.TransferInterval) == true) &&
                (this.TransferDay == null && other.TransferDay == null ||
                 this.TransferDay?.Equals(other.TransferDay) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransferEnabled = {this.TransferEnabled ?? "null"}");
            toStringOutput.Add($"TransferInterval = {this.TransferInterval ?? "null"}");
            toStringOutput.Add($"TransferDay = {this.TransferDay ?? "null"}");
        }
    }
}