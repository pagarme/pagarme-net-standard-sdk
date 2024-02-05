// <copyright file="CreateRegisterInformationBaseRequest.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// CreateRegisterInformationBaseRequest.
    /// </summary>
    public class CreateRegisterInformationBaseRequest
    {
        private string siteUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "site_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationBaseRequest"/> class.
        /// </summary>
        public CreateRegisterInformationBaseRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationBaseRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="phoneNumbers">phone_numbers.</param>
        /// <param name="siteUrl">site_url.</param>
        public CreateRegisterInformationBaseRequest(
            string email,
            string document,
            string type,
            List<Models.CreateRegisterInformationPhoneRequest> phoneNumbers,
            string siteUrl = null)
        {
            this.Email = email;
            this.Document = document;
            this.Type = type;
            if (siteUrl != null)
            {
                this.SiteUrl = siteUrl;
            }

            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Document.
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// "individual" ou "corporation"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets SiteUrl.
        /// </summary>
        [JsonProperty("site_url")]
        public string SiteUrl
        {
            get
            {
                return this.siteUrl;
            }

            set
            {
                this.shouldSerialize["site_url"] = true;
                this.siteUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets PhoneNumbers.
        /// </summary>
        [JsonProperty("phone_numbers")]
        public List<Models.CreateRegisterInformationPhoneRequest> PhoneNumbers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateRegisterInformationBaseRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteUrl()
        {
            this.shouldSerialize["site_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteUrl()
        {
            return this.shouldSerialize["site_url"];
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
            return obj is CreateRegisterInformationBaseRequest other &&                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.SiteUrl == null && other.SiteUrl == null) || (this.SiteUrl?.Equals(other.SiteUrl) == true)) &&
                ((this.PhoneNumbers == null && other.PhoneNumbers == null) || (this.PhoneNumbers?.Equals(other.PhoneNumbers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.SiteUrl = {(this.SiteUrl == null ? "null" : this.SiteUrl)}");
            toStringOutput.Add($"this.PhoneNumbers = {(this.PhoneNumbers == null ? "null" : $"[{string.Join(", ", this.PhoneNumbers)} ]")}");
        }
    }
}