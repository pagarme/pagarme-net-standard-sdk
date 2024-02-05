// <copyright file="CreateRegisterInformationAddressRequest.cs" company="APIMatic">
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
    /// CreateRegisterInformationAddressRequest.
    /// </summary>
    public class CreateRegisterInformationAddressRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationAddressRequest"/> class.
        /// </summary>
        public CreateRegisterInformationAddressRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationAddressRequest"/> class.
        /// </summary>
        /// <param name="street">street.</param>
        /// <param name="complementary">complementary.</param>
        /// <param name="streetNumber">street_number.</param>
        /// <param name="neighborhood">neighborhood.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="referencePoint">reference_point.</param>
        public CreateRegisterInformationAddressRequest(
            string street,
            string complementary,
            string streetNumber,
            string neighborhood,
            string city,
            string state,
            string zipCode,
            string referencePoint)
        {
            this.Street = street;
            this.Complementary = complementary;
            this.StreetNumber = streetNumber;
            this.Neighborhood = neighborhood;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.ReferencePoint = referencePoint;
        }

        /// <summary>
        /// Gets or sets Street.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets Complementary.
        /// </summary>
        [JsonProperty("complementary")]
        public string Complementary { get; set; }

        /// <summary>
        /// Gets or sets StreetNumber.
        /// </summary>
        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Gets or sets Neighborhood.
        /// </summary>
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets ZipCode.
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets ReferencePoint.
        /// </summary>
        [JsonProperty("reference_point")]
        public string ReferencePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateRegisterInformationAddressRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateRegisterInformationAddressRequest other &&                ((this.Street == null && other.Street == null) || (this.Street?.Equals(other.Street) == true)) &&
                ((this.Complementary == null && other.Complementary == null) || (this.Complementary?.Equals(other.Complementary) == true)) &&
                ((this.StreetNumber == null && other.StreetNumber == null) || (this.StreetNumber?.Equals(other.StreetNumber) == true)) &&
                ((this.Neighborhood == null && other.Neighborhood == null) || (this.Neighborhood?.Equals(other.Neighborhood) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.ReferencePoint == null && other.ReferencePoint == null) || (this.ReferencePoint?.Equals(other.ReferencePoint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Street = {(this.Street == null ? "null" : this.Street)}");
            toStringOutput.Add($"this.Complementary = {(this.Complementary == null ? "null" : this.Complementary)}");
            toStringOutput.Add($"this.StreetNumber = {(this.StreetNumber == null ? "null" : this.StreetNumber)}");
            toStringOutput.Add($"this.Neighborhood = {(this.Neighborhood == null ? "null" : this.Neighborhood)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.ReferencePoint = {(this.ReferencePoint == null ? "null" : this.ReferencePoint)}");
        }
    }
}