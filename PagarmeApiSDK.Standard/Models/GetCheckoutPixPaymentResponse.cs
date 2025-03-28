// <copyright file="GetCheckoutPixPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutPixPaymentResponse.
    /// </summary>
    public class GetCheckoutPixPaymentResponse
    {
        private DateTime? expiresAt;
        private List<Models.PixAdditionalInformation> additionalInformation;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "expires_at", false },
            { "additional_information", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPixPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutPixPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutPixPaymentResponse"/> class.
        /// </summary>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="additionalInformation">additional_information.</param>
        public GetCheckoutPixPaymentResponse(
            DateTime? expiresAt = null,
            List<Models.PixAdditionalInformation> additionalInformation = null)
        {

            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }

            if (additionalInformation != null)
            {
                this.AdditionalInformation = additionalInformation;
            }
        }

        /// <summary>
        /// Expires at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt
        {
            get
            {
                return this.expiresAt;
            }

            set
            {
                this.shouldSerialize["expires_at"] = true;
                this.expiresAt = value;
            }
        }

        /// <summary>
        /// Additional information
        /// </summary>
        [JsonProperty("additional_information")]
        public List<Models.PixAdditionalInformation> AdditionalInformation
        {
            get
            {
                return this.additionalInformation;
            }

            set
            {
                this.shouldSerialize["additional_information"] = true;
                this.additionalInformation = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCheckoutPixPaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAdditionalInformation()
        {
            this.shouldSerialize["additional_information"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return this.shouldSerialize["expires_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInformation()
        {
            return this.shouldSerialize["additional_information"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCheckoutPixPaymentResponse other &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                (this.AdditionalInformation == null && other.AdditionalInformation == null ||
                 this.AdditionalInformation?.Equals(other.AdditionalInformation) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"AdditionalInformation = {(this.AdditionalInformation == null ? "null" : $"[{string.Join(", ", this.AdditionalInformation)} ]")}");
        }
    }
}