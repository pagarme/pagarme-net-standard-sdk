// <copyright file="GetAnticipationLimitResponse.cs" company="APIMatic">
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
    /// GetAnticipationLimitResponse.
    /// </summary>
    public class GetAnticipationLimitResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitResponse"/> class.
        /// </summary>
        public GetAnticipationLimitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationLimitResponse"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="anticipationFee">anticipation_fee.</param>
        public GetAnticipationLimitResponse(
            int? amount = null,
            int? anticipationFee = null)
        {
            this.Amount = amount;
            this.AnticipationFee = anticipationFee;
        }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

        /// <summary>
        /// Anticipation fee
        /// </summary>
        [JsonProperty("anticipation_fee", NullValueHandling = NullValueHandling.Include)]
        public int? AnticipationFee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAnticipationLimitResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetAnticipationLimitResponse other &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.AnticipationFee == null && other.AnticipationFee == null) || (this.AnticipationFee?.Equals(other.AnticipationFee) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.AnticipationFee = {(this.AnticipationFee == null ? "null" : this.AnticipationFee.ToString())}");
        }
    }
}