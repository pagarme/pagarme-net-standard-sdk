// <copyright file="GetPhonesResponse.cs" company="APIMatic">
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
    /// GetPhonesResponse.
    /// </summary>
    public class GetPhonesResponse
    {
        private Models.GetPhoneResponse homePhone;
        private Models.GetPhoneResponse mobilePhone;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "home_phone", false },
            { "mobile_phone", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhonesResponse"/> class.
        /// </summary>
        public GetPhonesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhonesResponse"/> class.
        /// </summary>
        /// <param name="homePhone">home_phone.</param>
        /// <param name="mobilePhone">mobile_phone.</param>
        public GetPhonesResponse(
            Models.GetPhoneResponse homePhone = null,
            Models.GetPhoneResponse mobilePhone = null)
        {

            if (homePhone != null)
            {
                this.HomePhone = homePhone;
            }

            if (mobilePhone != null)
            {
                this.MobilePhone = mobilePhone;
            }
        }

        /// <summary>
        /// Gets or sets HomePhone.
        /// </summary>
        [JsonProperty("home_phone")]
        public Models.GetPhoneResponse HomePhone
        {
            get
            {
                return this.homePhone;
            }

            set
            {
                this.shouldSerialize["home_phone"] = true;
                this.homePhone = value;
            }
        }

        /// <summary>
        /// Gets or sets MobilePhone.
        /// </summary>
        [JsonProperty("mobile_phone")]
        public Models.GetPhoneResponse MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                this.shouldSerialize["mobile_phone"] = true;
                this.mobilePhone = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPhonesResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetHomePhone()
        {
            this.shouldSerialize["home_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMobilePhone()
        {
            this.shouldSerialize["mobile_phone"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHomePhone()
        {
            return this.shouldSerialize["home_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMobilePhone()
        {
            return this.shouldSerialize["mobile_phone"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPhonesResponse other &&
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