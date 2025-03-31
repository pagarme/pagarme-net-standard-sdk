// <copyright file="CreateKYCLinkResponse.cs" company="APIMatic">
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
    /// CreateKYCLinkResponse.
    /// </summary>
    public class CreateKYCLinkResponse
    {
        private string base64;
        private string url;
        private string expirationDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "base64", false },
            { "url", false },
            { "expiration_date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKYCLinkResponse"/> class.
        /// </summary>
        public CreateKYCLinkResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKYCLinkResponse"/> class.
        /// </summary>
        /// <param name="base64">base64.</param>
        /// <param name="url">url.</param>
        /// <param name="expirationDate">expiration_date.</param>
        public CreateKYCLinkResponse(
            string base64 = null,
            string url = null,
            string expirationDate = null)
        {

            if (base64 != null)
            {
                this.Base64 = base64;
            }

            if (url != null)
            {
                this.Url = url;
            }

            if (expirationDate != null)
            {
                this.ExpirationDate = expirationDate;
            }
        }

        /// <summary>
        /// Base64
        /// </summary>
        [JsonProperty("base64")]
        public string Base64
        {
            get
            {
                return this.base64;
            }

            set
            {
                this.shouldSerialize["base64"] = true;
                this.base64 = value;
            }
        }

        /// <summary>
        /// URL
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
        /// Expiration Date
        /// </summary>
        [JsonProperty("expiration_date")]
        public string ExpirationDate
        {
            get
            {
                return this.expirationDate;
            }

            set
            {
                this.shouldSerialize["expiration_date"] = true;
                this.expirationDate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateKYCLinkResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBase64()
        {
            this.shouldSerialize["base64"] = false;
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
        public void UnsetExpirationDate()
        {
            this.shouldSerialize["expiration_date"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBase64()
        {
            return this.shouldSerialize["base64"];
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
        public bool ShouldSerializeExpirationDate()
        {
            return this.shouldSerialize["expiration_date"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateKYCLinkResponse other &&
                (this.Base64 == null && other.Base64 == null ||
                 this.Base64?.Equals(other.Base64) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.ExpirationDate == null && other.ExpirationDate == null ||
                 this.ExpirationDate?.Equals(other.ExpirationDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Base64 = {this.Base64 ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"ExpirationDate = {this.ExpirationDate ?? "null"}");
        }
    }
}