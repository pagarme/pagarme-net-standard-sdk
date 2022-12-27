// <copyright file="GetFineResponse.cs" company="APIMatic">
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
    /// GetFineResponse.
    /// </summary>
    public class GetFineResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineResponse"/> class.
        /// </summary>
        public GetFineResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFineResponse"/> class.
        /// </summary>
        /// <param name="days">days.</param>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        public GetFineResponse(
            int? days = null,
            string type = null,
            int? amount = null)
        {
            this.Days = days;
            this.Type = type;
            this.Amount = amount;
        }

        /// <summary>
        /// Days
        /// </summary>
        [JsonProperty("days", NullValueHandling = NullValueHandling.Include)]
        public int? Days { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetFineResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetFineResponse other &&
                ((this.Days == null && other.Days == null) || (this.Days?.Equals(other.Days) == true)) &&
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
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
        }
    }
}