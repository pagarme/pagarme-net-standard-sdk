// <copyright file="CreateSubscriptionBoletoRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionBoletoRequest.
    /// </summary>
    public class CreateSubscriptionBoletoRequest
    {
        private int? maxDaysToPayPastDue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "max_days_to_pay_past_due", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionBoletoRequest"/> class.
        /// </summary>
        public CreateSubscriptionBoletoRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionBoletoRequest"/> class.
        /// </summary>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        public CreateSubscriptionBoletoRequest(
            Models.CreateInterestRequest interest = null,
            Models.CreateFineRequest fine = null,
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
        /// Gets or sets Interest.
        /// </summary>
        [JsonProperty("interest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInterestRequest Interest { get; set; }

        /// <summary>
        /// Gets or sets Fine.
        /// </summary>
        [JsonProperty("fine", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateFineRequest Fine { get; set; }

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
            return $"CreateSubscriptionBoletoRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSubscriptionBoletoRequest other &&
                (this.Interest == null && other.Interest == null ||
                 this.Interest?.Equals(other.Interest) == true) &&
                (this.Fine == null && other.Fine == null ||
                 this.Fine?.Equals(other.Fine) == true) &&
                (this.MaxDaysToPayPastDue == null && other.MaxDaysToPayPastDue == null ||
                 this.MaxDaysToPayPastDue?.Equals(other.MaxDaysToPayPastDue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Interest = {(this.Interest == null ? "null" : this.Interest.ToString())}");
            toStringOutput.Add($"Fine = {(this.Fine == null ? "null" : this.Fine.ToString())}");
            toStringOutput.Add($"MaxDaysToPayPastDue = {(this.MaxDaysToPayPastDue == null ? "null" : this.MaxDaysToPayPastDue.ToString())}");
        }
    }
}