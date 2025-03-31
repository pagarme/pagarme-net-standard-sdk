// <copyright file="GetAnticipationLimitResponse.cs" company="APIMatic">
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
    /// GetAnticipationLimitResponse.
    /// </summary>
    public class GetAnticipationLimitResponse
    {
        private int? amount;
        private int? anticipationFee;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "amount", false },
            { "anticipation_fee", false },
        };

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

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (anticipationFee != null)
            {
                this.AnticipationFee = anticipationFee;
            }
        }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.shouldSerialize["amount"] = true;
                this.amount = value;
            }
        }

        /// <summary>
        /// Anticipation fee
        /// </summary>
        [JsonProperty("anticipation_fee")]
        public int? AnticipationFee
        {
            get
            {
                return this.anticipationFee;
            }

            set
            {
                this.shouldSerialize["anticipation_fee"] = true;
                this.anticipationFee = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetAnticipationLimitResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAnticipationFee()
        {
            this.shouldSerialize["anticipation_fee"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnticipationFee()
        {
            return this.shouldSerialize["anticipation_fee"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetAnticipationLimitResponse other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.AnticipationFee == null && other.AnticipationFee == null ||
                 this.AnticipationFee?.Equals(other.AnticipationFee) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"AnticipationFee = {(this.AnticipationFee == null ? "null" : this.AnticipationFee.ToString())}");
        }
    }
}