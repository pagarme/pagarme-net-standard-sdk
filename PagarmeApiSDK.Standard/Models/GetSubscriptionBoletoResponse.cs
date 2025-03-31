// <copyright file="GetSubscriptionBoletoResponse.cs" company="APIMatic">
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
    /// GetSubscriptionBoletoResponse.
    /// </summary>
    public class GetSubscriptionBoletoResponse
    {
        private Models.GetInterestResponse interest;
        private Models.GetFineResponse fine;
        private int? maxDaysToPayPastDue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "interest", false },
            { "fine", false },
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

            if (interest != null)
            {
                this.Interest = interest;
            }

            if (fine != null)
            {
                this.Fine = fine;
            }

            if (maxDaysToPayPastDue != null)
            {
                this.MaxDaysToPayPastDue = maxDaysToPayPastDue;
            }
        }

        /// <summary>
        /// Interest
        /// </summary>
        [JsonProperty("interest")]
        public Models.GetInterestResponse Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                this.shouldSerialize["interest"] = true;
                this.interest = value;
            }
        }

        /// <summary>
        /// Fine
        /// </summary>
        [JsonProperty("fine")]
        public Models.GetFineResponse Fine
        {
            get
            {
                return this.fine;
            }

            set
            {
                this.shouldSerialize["fine"] = true;
                this.fine = value;
            }
        }

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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInterest()
        {
            this.shouldSerialize["interest"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFine()
        {
            this.shouldSerialize["fine"] = false;
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
        public bool ShouldSerializeInterest()
        {
            return this.shouldSerialize["interest"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFine()
        {
            return this.shouldSerialize["fine"];
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

            return obj is GetSubscriptionBoletoResponse other &&
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