// <copyright file="GetCheckoutPixPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutPixPaymentResponse.
    /// </summary>
    public class GetCheckoutPixPaymentResponse
    {
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
            DateTime expiresAt,
            List<Models.PixAdditionalInformation> additionalInformation)
        {
            this.ExpiresAt = expiresAt;
            this.AdditionalInformation = additionalInformation;
        }

        /// <summary>
        /// Expires at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional information
        /// </summary>
        [JsonProperty("additional_information")]
        public List<Models.PixAdditionalInformation> AdditionalInformation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutPixPaymentResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCheckoutPixPaymentResponse other &&
                this.ExpiresAt.Equals(other.ExpiresAt) &&
                ((this.AdditionalInformation == null && other.AdditionalInformation == null) || (this.AdditionalInformation?.Equals(other.AdditionalInformation) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExpiresAt = {this.ExpiresAt}");
            toStringOutput.Add($"this.AdditionalInformation = {(this.AdditionalInformation == null ? "null" : $"[{string.Join(", ", this.AdditionalInformation)} ]")}");
        }
    }
}