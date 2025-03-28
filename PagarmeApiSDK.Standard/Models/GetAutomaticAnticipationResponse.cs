// <copyright file="GetAutomaticAnticipationResponse.cs" company="APIMatic">
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
    /// GetAutomaticAnticipationResponse.
    /// </summary>
    public class GetAutomaticAnticipationResponse
    {
        private bool? enabled;
        private string type;
        private int? volumePercentage;
        private int? delay;
        private List<int> days;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "enabled", false },
            { "type", false },
            { "volume_percentage", false },
            { "delay", false },
            { "days", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAutomaticAnticipationResponse"/> class.
        /// </summary>
        public GetAutomaticAnticipationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAutomaticAnticipationResponse"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="type">type.</param>
        /// <param name="volumePercentage">volume_percentage.</param>
        /// <param name="delay">delay.</param>
        /// <param name="days">days.</param>
        public GetAutomaticAnticipationResponse(
            bool? enabled = null,
            string type = null,
            int? volumePercentage = null,
            int? delay = null,
            List<int> days = null)
        {

            if (enabled != null)
            {
                this.Enabled = enabled;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (volumePercentage != null)
            {
                this.VolumePercentage = volumePercentage;
            }

            if (delay != null)
            {
                this.Delay = delay;
            }

            if (days != null)
            {
                this.Days = days;
            }
        }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled
        {
            get
            {
                return this.enabled;
            }

            set
            {
                this.shouldSerialize["enabled"] = true;
                this.enabled = value;
            }
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// Gets or sets VolumePercentage.
        /// </summary>
        [JsonProperty("volume_percentage")]
        public int? VolumePercentage
        {
            get
            {
                return this.volumePercentage;
            }

            set
            {
                this.shouldSerialize["volume_percentage"] = true;
                this.volumePercentage = value;
            }
        }

        /// <summary>
        /// Gets or sets Delay.
        /// </summary>
        [JsonProperty("delay")]
        public int? Delay
        {
            get
            {
                return this.delay;
            }

            set
            {
                this.shouldSerialize["delay"] = true;
                this.delay = value;
            }
        }

        /// <summary>
        /// Gets or sets Days.
        /// </summary>
        [JsonProperty("days")]
        public List<int> Days
        {
            get
            {
                return this.days;
            }

            set
            {
                this.shouldSerialize["days"] = true;
                this.days = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetAutomaticAnticipationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEnabled()
        {
            this.shouldSerialize["enabled"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVolumePercentage()
        {
            this.shouldSerialize["volume_percentage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDelay()
        {
            this.shouldSerialize["delay"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDays()
        {
            this.shouldSerialize["days"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEnabled()
        {
            return this.shouldSerialize["enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVolumePercentage()
        {
            return this.shouldSerialize["volume_percentage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelay()
        {
            return this.shouldSerialize["delay"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDays()
        {
            return this.shouldSerialize["days"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetAutomaticAnticipationResponse other &&
                (this.Enabled == null && other.Enabled == null ||
                 this.Enabled?.Equals(other.Enabled) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.VolumePercentage == null && other.VolumePercentage == null ||
                 this.VolumePercentage?.Equals(other.VolumePercentage) == true) &&
                (this.Delay == null && other.Delay == null ||
                 this.Delay?.Equals(other.Delay) == true) &&
                (this.Days == null && other.Days == null ||
                 this.Days?.Equals(other.Days) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"VolumePercentage = {(this.VolumePercentage == null ? "null" : this.VolumePercentage.ToString())}");
            toStringOutput.Add($"Delay = {(this.Delay == null ? "null" : this.Delay.ToString())}");
            toStringOutput.Add($"Days = {(this.Days == null ? "null" : $"[{string.Join(", ", this.Days)} ]")}");
        }
    }
}