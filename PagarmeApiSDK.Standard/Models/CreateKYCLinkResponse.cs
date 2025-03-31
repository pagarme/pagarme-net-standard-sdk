// <copyright file="CreateKYCLinkResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Collections.Generic;
using Newtonsoft.Json;

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
            { "base64_qrcode", false },
            { "url", false },
            { "expires_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKYCLinkResponse"/> class.
        /// </summary>
        public CreateKYCLinkResponse() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKYCLinkResponse"/> class.
        /// </summary>
        /// <param name="base64">base64.</param>
        /// <param name="url">url.</param>
        /// <param name="expirationDate">expiration_date.</param>
        public CreateKYCLinkResponse(
            string base64 = null,
            string url = null,
            string expirationDate = null
        )
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
        [JsonProperty("base64_qrcode")]
        public string Base64
        {
            get { return this.base64; }
            set
            {
                this.shouldSerialize["base64_qrcode"] = true;
                this.base64 = value;
            }
        }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get { return this.url; }
            set
            {
                this.shouldSerialize["url"] = true;
                this.url = value;
            }
        }

        /// <summary>
        /// Expiration Date
        /// </summary>
        [JsonProperty("expires_at")]
        public string ExpirationDate
        {
            get { return this.expirationDate; }
            set
            {
                this.shouldSerialize["expires_at"] = true;
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
            this.shouldSerialize["base64_qrcode"] = false;
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
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBase64()
        {
            return this.shouldSerialize["base64_qrcode"];
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
            return this.shouldSerialize["expires_at"];
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
            return obj is CreateKYCLinkResponse other
                && (
                    (this.Base64 == null && other.Base64 == null)
                    || (this.Base64?.Equals(other.Base64) == true)
                )
                && (
                    (this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)
                )
                && (
                    (this.ExpirationDate == null && other.ExpirationDate == null)
                    || (this.ExpirationDate?.Equals(other.ExpirationDate) == true)
                );
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Base64 = {(this.Base64 == null ? "null" : this.Base64)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add(
                $"this.ExpirationDate = {(this.ExpirationDate == null ? "null" : this.ExpirationDate)}"
            );
        }
    }
}
