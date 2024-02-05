// <copyright file="GetRegisterInformationAddressResponse.cs" company="APIMatic">
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
    /// GetRegisterInformationAddressResponse.
    /// </summary>
    public class GetRegisterInformationAddressResponse
    {
        private string street;
        private string complementary;
        private string streetNumber;
        private string neighborhood;
        private string city;
        private string state;
        private string zipCode;
        private string referencePoint;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "street", false },
            { "complementary", false },
            { "street_number", false },
            { "neighborhood", false },
            { "city", false },
            { "state", false },
            { "zip_code", false },
            { "reference_point", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegisterInformationAddressResponse"/> class.
        /// </summary>
        public GetRegisterInformationAddressResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegisterInformationAddressResponse"/> class.
        /// </summary>
        /// <param name="street">street.</param>
        /// <param name="complementary">complementary.</param>
        /// <param name="streetNumber">street_number.</param>
        /// <param name="neighborhood">neighborhood.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="referencePoint">reference_point.</param>
        public GetRegisterInformationAddressResponse(
            string street = null,
            string complementary = null,
            string streetNumber = null,
            string neighborhood = null,
            string city = null,
            string state = null,
            string zipCode = null,
            string referencePoint = null)
        {
            if (street != null)
            {
                this.Street = street;
            }

            if (complementary != null)
            {
                this.Complementary = complementary;
            }

            if (streetNumber != null)
            {
                this.StreetNumber = streetNumber;
            }

            if (neighborhood != null)
            {
                this.Neighborhood = neighborhood;
            }

            if (city != null)
            {
                this.City = city;
            }

            if (state != null)
            {
                this.State = state;
            }

            if (zipCode != null)
            {
                this.ZipCode = zipCode;
            }

            if (referencePoint != null)
            {
                this.ReferencePoint = referencePoint;
            }

        }

        /// <summary>
        /// Gets or sets Street.
        /// </summary>
        [JsonProperty("street")]
        public string Street
        {
            get
            {
                return this.street;
            }

            set
            {
                this.shouldSerialize["street"] = true;
                this.street = value;
            }
        }

        /// <summary>
        /// Gets or sets Complementary.
        /// </summary>
        [JsonProperty("complementary")]
        public string Complementary
        {
            get
            {
                return this.complementary;
            }

            set
            {
                this.shouldSerialize["complementary"] = true;
                this.complementary = value;
            }
        }

        /// <summary>
        /// Gets or sets StreetNumber.
        /// </summary>
        [JsonProperty("street_number")]
        public string StreetNumber
        {
            get
            {
                return this.streetNumber;
            }

            set
            {
                this.shouldSerialize["street_number"] = true;
                this.streetNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets Neighborhood.
        /// </summary>
        [JsonProperty("neighborhood")]
        public string Neighborhood
        {
            get
            {
                return this.neighborhood;
            }

            set
            {
                this.shouldSerialize["neighborhood"] = true;
                this.neighborhood = value;
            }
        }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["city"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.shouldSerialize["state"] = true;
                this.state = value;
            }
        }

        /// <summary>
        /// Gets or sets ZipCode.
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode
        {
            get
            {
                return this.zipCode;
            }

            set
            {
                this.shouldSerialize["zip_code"] = true;
                this.zipCode = value;
            }
        }

        /// <summary>
        /// Gets or sets ReferencePoint.
        /// </summary>
        [JsonProperty("reference_point")]
        public string ReferencePoint
        {
            get
            {
                return this.referencePoint;
            }

            set
            {
                this.shouldSerialize["reference_point"] = true;
                this.referencePoint = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetRegisterInformationAddressResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStreet()
        {
            this.shouldSerialize["street"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetComplementary()
        {
            this.shouldSerialize["complementary"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStreetNumber()
        {
            this.shouldSerialize["street_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNeighborhood()
        {
            this.shouldSerialize["neighborhood"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["city"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetState()
        {
            this.shouldSerialize["state"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetZipCode()
        {
            this.shouldSerialize["zip_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReferencePoint()
        {
            this.shouldSerialize["reference_point"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStreet()
        {
            return this.shouldSerialize["street"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeComplementary()
        {
            return this.shouldSerialize["complementary"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStreetNumber()
        {
            return this.shouldSerialize["street_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNeighborhood()
        {
            return this.shouldSerialize["neighborhood"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["city"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeState()
        {
            return this.shouldSerialize["state"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeZipCode()
        {
            return this.shouldSerialize["zip_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReferencePoint()
        {
            return this.shouldSerialize["reference_point"];
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
            return obj is GetRegisterInformationAddressResponse other &&                ((this.Street == null && other.Street == null) || (this.Street?.Equals(other.Street) == true)) &&
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