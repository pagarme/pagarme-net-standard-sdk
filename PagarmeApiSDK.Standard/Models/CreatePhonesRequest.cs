// <copyright file="CreatePhonesRequest.cs" company="APIMatic">
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
    /// CreatePhonesRequest.
    /// </summary>
    public class CreatePhonesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhonesRequest"/> class.
        /// </summary>
        public CreatePhonesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhonesRequest"/> class.
        /// </summary>
        /// <param name="homePhone">home_phone.</param>
        /// <param name="mobilePhone">mobile_phone.</param>
        public CreatePhonesRequest(
            Models.CreatePhoneRequest homePhone = null,
            Models.CreatePhoneRequest mobilePhone = null)
        {
            this.HomePhone = homePhone;
            this.MobilePhone = mobilePhone;
        }

        /// <summary>
        /// Gets or sets HomePhone.
        /// </summary>
        [JsonProperty("home_phone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePhoneRequest HomePhone { get; set; }

        /// <summary>
        /// Gets or sets MobilePhone.
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePhoneRequest MobilePhone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePhonesRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePhonesRequest other &&
                (this.HomePhone == null && other.HomePhone == null ||
                 this.HomePhone?.Equals(other.HomePhone) == true) &&
                (this.MobilePhone == null && other.MobilePhone == null ||
                 this.MobilePhone?.Equals(other.MobilePhone) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"HomePhone = {(this.HomePhone == null ? "null" : this.HomePhone.ToString())}");
            toStringOutput.Add($"MobilePhone = {(this.MobilePhone == null ? "null" : this.MobilePhone.ToString())}");
        }
    }
}