// <copyright file="GetSplitOptionsResponse.cs" company="APIMatic">
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
    /// GetSplitOptionsResponse.
    /// </summary>
    public class GetSplitOptionsResponse
    {
        private bool? liable;
        private bool? chargeProcessingFee;
        private string chargeRemainderFee;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "liable", false },
            { "charge_processing_fee", false },
            { "charge_remainder_fee", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitOptionsResponse"/> class.
        /// </summary>
        public GetSplitOptionsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitOptionsResponse"/> class.
        /// </summary>
        /// <param name="liable">liable.</param>
        /// <param name="chargeProcessingFee">charge_processing_fee.</param>
        /// <param name="chargeRemainderFee">charge_remainder_fee.</param>
        public GetSplitOptionsResponse(
            bool? liable = null,
            bool? chargeProcessingFee = null,
            string chargeRemainderFee = null)
        {

            if (liable != null)
            {
                this.Liable = liable;
            }

            if (chargeProcessingFee != null)
            {
                this.ChargeProcessingFee = chargeProcessingFee;
            }

            if (chargeRemainderFee != null)
            {
                this.ChargeRemainderFee = chargeRemainderFee;
            }
        }

        /// <summary>
        /// Gets or sets Liable.
        /// </summary>
        [JsonProperty("liable")]
        public bool? Liable
        {
            get
            {
                return this.liable;
            }

            set
            {
                this.shouldSerialize["liable"] = true;
                this.liable = value;
            }
        }

        /// <summary>
        /// Gets or sets ChargeProcessingFee.
        /// </summary>
        [JsonProperty("charge_processing_fee")]
        public bool? ChargeProcessingFee
        {
            get
            {
                return this.chargeProcessingFee;
            }

            set
            {
                this.shouldSerialize["charge_processing_fee"] = true;
                this.chargeProcessingFee = value;
            }
        }

        /// <summary>
        /// Gets or sets ChargeRemainderFee.
        /// </summary>
        [JsonProperty("charge_remainder_fee")]
        public string ChargeRemainderFee
        {
            get
            {
                return this.chargeRemainderFee;
            }

            set
            {
                this.shouldSerialize["charge_remainder_fee"] = true;
                this.chargeRemainderFee = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetSplitOptionsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLiable()
        {
            this.shouldSerialize["liable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeProcessingFee()
        {
            this.shouldSerialize["charge_processing_fee"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeRemainderFee()
        {
            this.shouldSerialize["charge_remainder_fee"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLiable()
        {
            return this.shouldSerialize["liable"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeProcessingFee()
        {
            return this.shouldSerialize["charge_processing_fee"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeRemainderFee()
        {
            return this.shouldSerialize["charge_remainder_fee"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetSplitOptionsResponse other &&
                (this.Liable == null && other.Liable == null ||
                 this.Liable?.Equals(other.Liable) == true) &&
                (this.ChargeProcessingFee == null && other.ChargeProcessingFee == null ||
                 this.ChargeProcessingFee?.Equals(other.ChargeProcessingFee) == true) &&
                (this.ChargeRemainderFee == null && other.ChargeRemainderFee == null ||
                 this.ChargeRemainderFee?.Equals(other.ChargeRemainderFee) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Liable = {(this.Liable == null ? "null" : this.Liable.ToString())}");
            toStringOutput.Add($"ChargeProcessingFee = {(this.ChargeProcessingFee == null ? "null" : this.ChargeProcessingFee.ToString())}");
            toStringOutput.Add($"ChargeRemainderFee = {this.ChargeRemainderFee ?? "null"}");
        }
    }
}