// <copyright file="GetUsageReportResponse.cs" company="APIMatic">
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
    /// GetUsageReportResponse.
    /// </summary>
    public class GetUsageReportResponse
    {
        private string url;
        private string usageReportUrl;
        private string groupedReportUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "url", false },
            { "usage_report_url", false },
            { "grouped_report_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageReportResponse"/> class.
        /// </summary>
        public GetUsageReportResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageReportResponse"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="usageReportUrl">usage_report_url.</param>
        /// <param name="groupedReportUrl">grouped_report_url.</param>
        public GetUsageReportResponse(
            string url = null,
            string usageReportUrl = null,
            string groupedReportUrl = null)
        {

            if (url != null)
            {
                this.Url = url;
            }

            if (usageReportUrl != null)
            {
                this.UsageReportUrl = usageReportUrl;
            }

            if (groupedReportUrl != null)
            {
                this.GroupedReportUrl = groupedReportUrl;
            }
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                this.shouldSerialize["url"] = true;
                this.url = value;
            }
        }

        /// <summary>
        /// Gets or sets UsageReportUrl.
        /// </summary>
        [JsonProperty("usage_report_url")]
        public string UsageReportUrl
        {
            get
            {
                return this.usageReportUrl;
            }

            set
            {
                this.shouldSerialize["usage_report_url"] = true;
                this.usageReportUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets GroupedReportUrl.
        /// </summary>
        [JsonProperty("grouped_report_url")]
        public string GroupedReportUrl
        {
            get
            {
                return this.groupedReportUrl;
            }

            set
            {
                this.shouldSerialize["grouped_report_url"] = true;
                this.groupedReportUrl = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetUsageReportResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUrl()
        {
            this.shouldSerialize["url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUsageReportUrl()
        {
            this.shouldSerialize["usage_report_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGroupedReportUrl()
        {
            this.shouldSerialize["grouped_report_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUrl()
        {
            return this.shouldSerialize["url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUsageReportUrl()
        {
            return this.shouldSerialize["usage_report_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGroupedReportUrl()
        {
            return this.shouldSerialize["grouped_report_url"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetUsageReportResponse other &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.UsageReportUrl == null && other.UsageReportUrl == null ||
                 this.UsageReportUrl?.Equals(other.UsageReportUrl) == true) &&
                (this.GroupedReportUrl == null && other.GroupedReportUrl == null ||
                 this.GroupedReportUrl?.Equals(other.GroupedReportUrl) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"UsageReportUrl = {this.UsageReportUrl ?? "null"}");
            toStringOutput.Add($"GroupedReportUrl = {this.GroupedReportUrl ?? "null"}");
        }
    }
}