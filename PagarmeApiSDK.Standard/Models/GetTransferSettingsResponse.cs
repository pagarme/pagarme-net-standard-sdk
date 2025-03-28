// <copyright file="GetTransferSettingsResponse.cs" company="APIMatic">
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
    /// GetTransferSettingsResponse.
    /// </summary>
    public class GetTransferSettingsResponse
    {
        private bool? transferEnabled;
        private string transferInterval;
        private int? transferDay;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "transfer_enabled", false },
            { "transfer_interval", false },
            { "transfer_day", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferSettingsResponse"/> class.
        /// </summary>
        public GetTransferSettingsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferSettingsResponse"/> class.
        /// </summary>
        /// <param name="transferEnabled">transfer_enabled.</param>
        /// <param name="transferInterval">transfer_interval.</param>
        /// <param name="transferDay">transfer_day.</param>
        public GetTransferSettingsResponse(
            bool? transferEnabled = null,
            string transferInterval = null,
            int? transferDay = null)
        {

            if (transferEnabled != null)
            {
                this.TransferEnabled = transferEnabled;
            }

            if (transferInterval != null)
            {
                this.TransferInterval = transferInterval;
            }

            if (transferDay != null)
            {
                this.TransferDay = transferDay;
            }
        }

        /// <summary>
        /// Gets or sets TransferEnabled.
        /// </summary>
        [JsonProperty("transfer_enabled")]
        public bool? TransferEnabled
        {
            get
            {
                return this.transferEnabled;
            }

            set
            {
                this.shouldSerialize["transfer_enabled"] = true;
                this.transferEnabled = value;
            }
        }

        /// <summary>
        /// Gets or sets TransferInterval.
        /// </summary>
        [JsonProperty("transfer_interval")]
        public string TransferInterval
        {
            get
            {
                return this.transferInterval;
            }

            set
            {
                this.shouldSerialize["transfer_interval"] = true;
                this.transferInterval = value;
            }
        }

        /// <summary>
        /// Gets or sets TransferDay.
        /// </summary>
        [JsonProperty("transfer_day")]
        public int? TransferDay
        {
            get
            {
                return this.transferDay;
            }

            set
            {
                this.shouldSerialize["transfer_day"] = true;
                this.transferDay = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetTransferSettingsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransferEnabled()
        {
            this.shouldSerialize["transfer_enabled"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransferInterval()
        {
            this.shouldSerialize["transfer_interval"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransferDay()
        {
            this.shouldSerialize["transfer_day"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransferEnabled()
        {
            return this.shouldSerialize["transfer_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransferInterval()
        {
            return this.shouldSerialize["transfer_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransferDay()
        {
            return this.shouldSerialize["transfer_day"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetTransferSettingsResponse other &&
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
            toStringOutput.Add($"TransferEnabled = {(this.TransferEnabled == null ? "null" : this.TransferEnabled.ToString())}");
            toStringOutput.Add($"TransferInterval = {this.TransferInterval ?? "null"}");
            toStringOutput.Add($"TransferDay = {(this.TransferDay == null ? "null" : this.TransferDay.ToString())}");
        }
    }
}