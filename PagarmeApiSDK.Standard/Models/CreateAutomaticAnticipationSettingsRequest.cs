// <copyright file="CreateAutomaticAnticipationSettingsRequest.cs" company="APIMatic">
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
    /// CreateAutomaticAnticipationSettingsRequest.
    /// </summary>
    public class CreateAutomaticAnticipationSettingsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomaticAnticipationSettingsRequest"/> class.
        /// </summary>
        public CreateAutomaticAnticipationSettingsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutomaticAnticipationSettingsRequest"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="type">type.</param>
        /// <param name="volumePercentage">volume_percentage.</param>
        /// <param name="delay">delay.</param>
        /// <param name="days">days.</param>
        public CreateAutomaticAnticipationSettingsRequest(
            bool enabled,
            string type,
            int volumePercentage,
            int delay,
            List<int> days)
        {
            this.Enabled = enabled;
            this.Type = type;
            this.VolumePercentage = volumePercentage;
            this.Delay = delay;
            this.Days = days;
        }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets VolumePercentage.
        /// </summary>
        [JsonProperty("volume_percentage")]
        public int VolumePercentage { get; set; }

        /// <summary>
        /// Gets or sets Delay.
        /// </summary>
        [JsonProperty("delay")]
        public int Delay { get; set; }

        /// <summary>
        /// Gets or sets Days.
        /// </summary>
        [JsonProperty("days")]
        public List<int> Days { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateAutomaticAnticipationSettingsRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateAutomaticAnticipationSettingsRequest other &&
                (this.Enabled.Equals(other.Enabled)) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.VolumePercentage.Equals(other.VolumePercentage)) &&
                (this.Delay.Equals(other.Delay)) &&
                (this.Days == null && other.Days == null ||
                 this.Days?.Equals(other.Days) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {this.Enabled}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"VolumePercentage = {this.VolumePercentage}");
            toStringOutput.Add($"Delay = {this.Delay}");
            toStringOutput.Add($"Days = {(this.Days == null ? "null" : $"[{string.Join(", ", this.Days)} ]")}");
        }
    }
}