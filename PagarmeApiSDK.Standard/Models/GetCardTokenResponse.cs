// <copyright file="GetCardTokenResponse.cs" company="APIMatic">
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
    /// GetCardTokenResponse.
    /// </summary>
    public class GetCardTokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardTokenResponse"/> class.
        /// </summary>
        public GetCardTokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardTokenResponse"/> class.
        /// </summary>
        /// <param name="lastFourDigits">last_four_digits.</param>
        /// <param name="holderName">holder_name.</param>
        /// <param name="holderDocument">holder_document.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="brand">brand.</param>
        /// <param name="type">type.</param>
        /// <param name="label">label.</param>
        public GetCardTokenResponse(
            string lastFourDigits = null,
            string holderName = null,
            string holderDocument = null,
            string expMonth = null,
            string expYear = null,
            string brand = null,
            string type = null,
            string label = null)
        {
            this.LastFourDigits = lastFourDigits;
            this.HolderName = holderName;
            this.HolderDocument = holderDocument;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Brand = brand;
            this.Type = type;
            this.Label = label;
        }

        /// <summary>
        /// Gets or sets LastFourDigits.
        /// </summary>
        [JsonProperty("last_four_digits", NullValueHandling = NullValueHandling.Include)]
        public string LastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets HolderName.
        /// </summary>
        [JsonProperty("holder_name", NullValueHandling = NullValueHandling.Include)]
        public string HolderName { get; set; }

        /// <summary>
        /// Gets or sets HolderDocument.
        /// </summary>
        [JsonProperty("holder_document", NullValueHandling = NullValueHandling.Include)]
        public string HolderDocument { get; set; }

        /// <summary>
        /// Gets or sets ExpMonth.
        /// </summary>
        [JsonProperty("exp_month", NullValueHandling = NullValueHandling.Include)]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Gets or sets ExpYear.
        /// </summary>
        [JsonProperty("exp_year", NullValueHandling = NullValueHandling.Include)]
        public string ExpYear { get; set; }

        /// <summary>
        /// Gets or sets Brand.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Include)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Include)]
        public string Label { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCardTokenResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCardTokenResponse other &&
                ((this.LastFourDigits == null && other.LastFourDigits == null) || (this.LastFourDigits?.Equals(other.LastFourDigits) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.HolderDocument == null && other.HolderDocument == null) || (this.HolderDocument?.Equals(other.HolderDocument) == true)) &&
                ((this.ExpMonth == null && other.ExpMonth == null) || (this.ExpMonth?.Equals(other.ExpMonth) == true)) &&
                ((this.ExpYear == null && other.ExpYear == null) || (this.ExpYear?.Equals(other.ExpYear) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastFourDigits = {(this.LastFourDigits == null ? "null" : this.LastFourDigits == string.Empty ? "" : this.LastFourDigits)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.HolderDocument = {(this.HolderDocument == null ? "null" : this.HolderDocument == string.Empty ? "" : this.HolderDocument)}");
            toStringOutput.Add($"this.ExpMonth = {(this.ExpMonth == null ? "null" : this.ExpMonth == string.Empty ? "" : this.ExpMonth)}");
            toStringOutput.Add($"this.ExpYear = {(this.ExpYear == null ? "null" : this.ExpYear == string.Empty ? "" : this.ExpYear)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand == string.Empty ? "" : this.Brand)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label == string.Empty ? "" : this.Label)}");
        }
    }
}