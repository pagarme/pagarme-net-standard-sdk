// <copyright file="GetSplitOptionsResponse.cs" company="APIMatic">
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
    /// GetSplitOptionsResponse.
    /// </summary>
    public class GetSplitOptionsResponse
    {
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
            this.Liable = liable;
            this.ChargeProcessingFee = chargeProcessingFee;
            this.ChargeRemainderFee = chargeRemainderFee;
        }

        /// <summary>
        /// Gets or sets Liable.
        /// </summary>
        [JsonProperty("liable", NullValueHandling = NullValueHandling.Include)]
        public bool? Liable { get; set; }

        /// <summary>
        /// Gets or sets ChargeProcessingFee.
        /// </summary>
        [JsonProperty("charge_processing_fee", NullValueHandling = NullValueHandling.Include)]
        public bool? ChargeProcessingFee { get; set; }

        /// <summary>
        /// Gets or sets ChargeRemainderFee.
        /// </summary>
        [JsonProperty("charge_remainder_fee", NullValueHandling = NullValueHandling.Include)]
        public string ChargeRemainderFee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSplitOptionsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSplitOptionsResponse other &&
                ((this.Liable == null && other.Liable == null) || (this.Liable?.Equals(other.Liable) == true)) &&
                ((this.ChargeProcessingFee == null && other.ChargeProcessingFee == null) || (this.ChargeProcessingFee?.Equals(other.ChargeProcessingFee) == true)) &&
                ((this.ChargeRemainderFee == null && other.ChargeRemainderFee == null) || (this.ChargeRemainderFee?.Equals(other.ChargeRemainderFee) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Liable = {(this.Liable == null ? "null" : this.Liable.ToString())}");
            toStringOutput.Add($"this.ChargeProcessingFee = {(this.ChargeProcessingFee == null ? "null" : this.ChargeProcessingFee.ToString())}");
            toStringOutput.Add($"this.ChargeRemainderFee = {(this.ChargeRemainderFee == null ? "null" : this.ChargeRemainderFee == string.Empty ? "" : this.ChargeRemainderFee)}");
        }
    }
}