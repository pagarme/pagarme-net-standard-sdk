// <copyright file="GetAddressResponse.cs" company="APIMatic">
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
    /// GetAddressResponse.
    /// </summary>
    public class GetAddressResponse
    {
        private Models.GetCustomerResponse customer;
        private DateTime? deletedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "customer", false },
            { "deleted_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressResponse"/> class.
        /// </summary>
        public GetAddressResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="street">street.</param>
        /// <param name="number">number.</param>
        /// <param name="complement">complement.</param>
        /// <param name="zipCode">zip_code.</param>
        /// <param name="neighborhood">neighborhood.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="country">country.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="customer">customer.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="line1">line_1.</param>
        /// <param name="line2">line_2.</param>
        /// <param name="deletedAt">deleted_at.</param>
        public GetAddressResponse(
            string id = null,
            string street = null,
            string number = null,
            string complement = null,
            string zipCode = null,
            string neighborhood = null,
            string city = null,
            string state = null,
            string country = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            Models.GetCustomerResponse customer = null,
            Dictionary<string, string> metadata = null,
            string line1 = null,
            string line2 = null,
            DateTime? deletedAt = null)
        {
            this.Id = id;
            this.Street = street;
            this.Number = number;
            this.Complement = complement;
            this.ZipCode = zipCode;
            this.Neighborhood = neighborhood;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (customer != null)
            {
                this.Customer = customer;
            }

            this.Metadata = metadata;
            this.Line1 = line1;
            this.Line2 = line2;
            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Street.
        /// </summary>
        [JsonProperty("street", NullValueHandling = NullValueHandling.Include)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Include)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets Complement.
        /// </summary>
        [JsonProperty("complement", NullValueHandling = NullValueHandling.Include)]
        public string Complement { get; set; }

        /// <summary>
        /// Gets or sets ZipCode.
        /// </summary>
        [JsonProperty("zip_code", NullValueHandling = NullValueHandling.Include)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets Neighborhood.
        /// </summary>
        [JsonProperty("neighborhood", NullValueHandling = NullValueHandling.Include)]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Include)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Include)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Include)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.shouldSerialize["customer"] = true;
                this.customer = value;
            }
        }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Line 1 for address
        /// </summary>
        [JsonProperty("line_1", NullValueHandling = NullValueHandling.Include)]
        public string Line1 { get; set; }

        /// <summary>
        /// Line 2 for address
        /// </summary>
        [JsonProperty("line_2", NullValueHandling = NullValueHandling.Include)]
        public string Line2 { get; set; }

        /// <summary>
        /// Gets or sets DeletedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt
        {
            get
            {
                return this.deletedAt;
            }

            set
            {
                this.shouldSerialize["deleted_at"] = true;
                this.deletedAt = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAddressResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomer()
        {
            this.shouldSerialize["customer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeletedAt()
        {
            this.shouldSerialize["deleted_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomer()
        {
            return this.shouldSerialize["customer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeletedAt()
        {
            return this.shouldSerialize["deleted_at"];
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

            return obj is GetAddressResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Street == null && other.Street == null) || (this.Street?.Equals(other.Street) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Complement == null && other.Complement == null) || (this.Complement?.Equals(other.Complement) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.Neighborhood == null && other.Neighborhood == null) || (this.Neighborhood?.Equals(other.Neighborhood) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Line1 == null && other.Line1 == null) || (this.Line1?.Equals(other.Line1) == true)) &&
                ((this.Line2 == null && other.Line2 == null) || (this.Line2?.Equals(other.Line2) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Street = {(this.Street == null ? "null" : this.Street == string.Empty ? "" : this.Street)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number == string.Empty ? "" : this.Number)}");
            toStringOutput.Add($"this.Complement = {(this.Complement == null ? "null" : this.Complement == string.Empty ? "" : this.Complement)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode == string.Empty ? "" : this.ZipCode)}");
            toStringOutput.Add($"this.Neighborhood = {(this.Neighborhood == null ? "null" : this.Neighborhood == string.Empty ? "" : this.Neighborhood)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City == string.Empty ? "" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country == string.Empty ? "" : this.Country)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Line1 = {(this.Line1 == null ? "null" : this.Line1 == string.Empty ? "" : this.Line1)}");
            toStringOutput.Add($"this.Line2 = {(this.Line2 == null ? "null" : this.Line2 == string.Empty ? "" : this.Line2)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
        }
    }
}