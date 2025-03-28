// <copyright file="CreatePaymentOriginRequest.cs" company="APIMatic">
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
    /// CreatePaymentOriginRequest.
    /// </summary>
    public class CreatePaymentOriginRequest
    {
        private string brandId;
        private string chargeId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "brand_id", false },
            { "charge_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentOriginRequest"/> class.
        /// </summary>
        public CreatePaymentOriginRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePaymentOriginRequest"/> class.
        /// </summary>
        /// <param name="brandId">brand_id.</param>
        /// <param name="chargeId">charge_id.</param>
        public CreatePaymentOriginRequest(
            string brandId = null,
            string chargeId = null)
        {

            if (brandId != null)
            {
                this.BrandId = brandId;
            }

            if (chargeId != null)
            {
                this.ChargeId = chargeId;
            }
        }

        /// <summary>
        /// Gets or sets BrandId.
        /// </summary>
        [JsonProperty("brand_id")]
        public string BrandId
        {
            get
            {
                return this.brandId;
            }

            set
            {
                this.shouldSerialize["brand_id"] = true;
                this.brandId = value;
            }
        }

        /// <summary>
        /// Gets or sets ChargeId.
        /// </summary>
        [JsonProperty("charge_id")]
        public string ChargeId
        {
            get
            {
                return this.chargeId;
            }

            set
            {
                this.shouldSerialize["charge_id"] = true;
                this.chargeId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePaymentOriginRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBrandId()
        {
            this.shouldSerialize["brand_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeId()
        {
            this.shouldSerialize["charge_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBrandId()
        {
            return this.shouldSerialize["brand_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeId()
        {
            return this.shouldSerialize["charge_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePaymentOriginRequest other &&
                (this.BrandId == null && other.BrandId == null ||
                 this.BrandId?.Equals(other.BrandId) == true) &&
                (this.ChargeId == null && other.ChargeId == null ||
                 this.ChargeId?.Equals(other.ChargeId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BrandId = {this.BrandId ?? "null"}");
            toStringOutput.Add($"ChargeId = {this.ChargeId ?? "null"}");
        }
    }
}