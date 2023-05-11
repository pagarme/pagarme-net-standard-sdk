// <copyright file="GetTransactionReportFileResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetTransactionReportFileResponse.
    /// </summary>
    public class GetTransactionReportFileResponse
    {
        private string name;
        private DateTime? date;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionReportFileResponse"/> class.
        /// </summary>
        public GetTransactionReportFileResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionReportFileResponse"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="date">date.</param>
        public GetTransactionReportFileResponse(
            string name = null,
            DateTime? date = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            if (date != null)
            {
                this.Date = date;
            }

        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date")]
        public DateTime? Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.shouldSerialize["date"] = true;
                this.date = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTransactionReportFileResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDate()
        {
            this.shouldSerialize["date"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDate()
        {
            return this.shouldSerialize["date"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is GetTransactionReportFileResponse other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date.ToString())}");
        }
    }
}