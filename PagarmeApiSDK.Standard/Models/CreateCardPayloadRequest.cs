// <copyright file="CreateCardPayloadRequest.cs" company="APIMatic">
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
    /// CreateCardPayloadRequest.
    /// </summary>
    public class CreateCardPayloadRequest
    {
        private string type;
        private Models.CreateGooglePayRequest googlePay;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "type", false },
            { "google_pay", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardPayloadRequest"/> class.
        /// </summary>
        public CreateCardPayloadRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCardPayloadRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="googlePay">google_pay.</param>
        public CreateCardPayloadRequest(
            string type = null,
            Models.CreateGooglePayRequest googlePay = null)
        {
            if (type != null)
            {
                this.Type = type;
            }

            if (googlePay != null)
            {
                this.GooglePay = googlePay;
            }

        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// Gets or sets GooglePay.
        /// </summary>
        [JsonProperty("google_pay")]
        public Models.CreateGooglePayRequest GooglePay
        {
            get
            {
                return this.googlePay;
            }

            set
            {
                this.shouldSerialize["google_pay"] = true;
                this.googlePay = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateCardPayloadRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGooglePay()
        {
            this.shouldSerialize["google_pay"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGooglePay()
        {
            return this.shouldSerialize["google_pay"];
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
            return obj is CreateCardPayloadRequest other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.GooglePay == null && other.GooglePay == null) || (this.GooglePay?.Equals(other.GooglePay) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.GooglePay = {(this.GooglePay == null ? "null" : this.GooglePay.ToString())}");
        }
    }
}