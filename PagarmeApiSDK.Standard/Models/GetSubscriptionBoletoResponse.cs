// <copyright file="GetSubscriptionBoletoResponse.cs" company="APIMatic">
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
    /// GetSubscriptionBoletoResponse.
    /// </summary>
    public class GetSubscriptionBoletoResponse
    {
        private int? maxDaysToPayPastDue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "max_days_to_pay_past_due", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionBoletoResponse"/> class.
        /// </summary>
        public GetSubscriptionBoletoResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionBoletoResponse"/> class.
        /// </summary>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public GetSubscriptionBoletoResponse(
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null)
        {
            this.Interest = interest;
            this.Fine = fine;
            if (maxDaysToPayPastDue != null)
            {
                this.MaxDaysToPayPastDue = maxDaysToPayPastDue;
            }

        }

        /// <summary>
        /// Interest
        /// </summary>
        [JsonProperty("interest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetInterestResponse Interest { get; set; }

        /// <summary>
        /// Fine
        /// </summary>
        [JsonProperty("fine", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GetFineResponse Fine { get; set; }

        /// <summary>
        /// Gets or sets MaxDaysToPayPastDue.
        /// </summary>
        [JsonProperty("max_days_to_pay_past_due")]
        public int? MaxDaysToPayPastDue
        {
            get
            {
                return this.maxDaysToPayPastDue;
            }

            set
            {
                this.shouldSerialize["max_days_to_pay_past_due"] = true;
                this.maxDaysToPayPastDue = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSubscriptionBoletoResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMaxDaysToPayPastDue()
        {
            this.shouldSerialize["max_days_to_pay_past_due"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxDaysToPayPastDue()
        {
            return this.shouldSerialize["max_days_to_pay_past_due"];
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

            return obj is GetSubscriptionBoletoResponse other &&
                ((this.Interest == null && other.Interest == null) || (this.Interest?.Equals(other.Interest) == true)) &&
                ((this.Fine == null && other.Fine == null) || (this.Fine?.Equals(other.Fine) == true)) &&
                ((this.MaxDaysToPayPastDue == null && other.MaxDaysToPayPastDue == null) || (this.MaxDaysToPayPastDue?.Equals(other.MaxDaysToPayPastDue) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Interest = {(this.Interest == null ? "null" : this.Interest.ToString())}");
            toStringOutput.Add($"this.Fine = {(this.Fine == null ? "null" : this.Fine.ToString())}");
            toStringOutput.Add($"this.MaxDaysToPayPastDue = {(this.MaxDaysToPayPastDue == null ? "null" : this.MaxDaysToPayPastDue.ToString())}");
        }
    }
}