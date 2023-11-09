// <copyright file="GetInterestResponse.cs" company="APIMatic">
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
    /// GetInterestResponse.
    /// </summary>
    public class GetInterestResponse
    {
        private int? days;
        private string type;
        private int? amount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "days", false },
            { "type", false },
            { "amount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInterestResponse"/> class.
        /// </summary>
        public GetInterestResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInterestResponse"/> class.
        /// </summary>
        /// <param name="days">days.</param>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        public GetInterestResponse(
            int? days = null,
            string type = null,
            int? amount = null)
        {
            if (days != null)
            {
                this.Days = days;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

        }

        /// <summary>
        /// Days
        /// </summary>
        [JsonProperty("days")]
        public int? Days
        {
            get
            {
                return this.days;
            }

            set
            {
                this.shouldSerialize["days"] = true;
                this.days = value;
            }
        }

        /// <summary>
        /// Type
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetInterestResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDays()
        {
            this.shouldSerialize["days"] = false;
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
        public void UnsetAmount()
        {
            this.shouldSerialize["amount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDays()
        {
            return this.shouldSerialize["days"];
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
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["amount"];
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
            return obj is GetInterestResponse other &&                ((this.Days == null && other.Days == null) || (this.Days?.Equals(other.Days) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Days = {(this.Days == null ? "null" : this.Days.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}