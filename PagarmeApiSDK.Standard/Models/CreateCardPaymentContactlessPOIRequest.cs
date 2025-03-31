// <copyright file="CreateCardPaymentContactlessPOIRequest.cs" company="APIMatic">
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
    /// CreateCardPaymentContactlessPOIRequest.
    /// </summary>
    public class CreateCardPaymentContactlessPOIRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardPaymentContactlessPOIRequest"/> class.
        /// </summary>
        public CreateCardPaymentContactlessPOIRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardPaymentContactlessPOIRequest"/> class.
        /// </summary>
        /// <param name="systemName">system_name.</param>
        /// <param name="model">model.</param>
        /// <param name="provider">provider.</param>
        /// <param name="serialNumber">serial_number.</param>
        /// <param name="versionNumber">version_number.</param>
        public CreateCardPaymentContactlessPOIRequest(
            string systemName,
            string model,
            string provider,
            string serialNumber,
            string versionNumber)
        {
            this.SystemName = systemName;
            this.Model = model;
            this.Provider = provider;
            this.SerialNumber = serialNumber;
            this.VersionNumber = versionNumber;
        }

        /// <summary>
        /// system name
        /// </summary>
        [JsonProperty("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// model
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// provider
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// serial number
        /// </summary>
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// version number
        /// </summary>
        [JsonProperty("version_number")]
        public string VersionNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCardPaymentContactlessPOIRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCardPaymentContactlessPOIRequest other &&
                (this.SystemName == null && other.SystemName == null ||
                 this.SystemName?.Equals(other.SystemName) == true) &&
                (this.Model == null && other.Model == null ||
                 this.Model?.Equals(other.Model) == true) &&
                (this.Provider == null && other.Provider == null ||
                 this.Provider?.Equals(other.Provider) == true) &&
                (this.SerialNumber == null && other.SerialNumber == null ||
                 this.SerialNumber?.Equals(other.SerialNumber) == true) &&
                (this.VersionNumber == null && other.VersionNumber == null ||
                 this.VersionNumber?.Equals(other.VersionNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SystemName = {this.SystemName ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"Provider = {this.Provider ?? "null"}");
            toStringOutput.Add($"SerialNumber = {this.SerialNumber ?? "null"}");
            toStringOutput.Add($"VersionNumber = {this.VersionNumber ?? "null"}");
        }
    }
}