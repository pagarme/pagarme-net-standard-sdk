// <copyright file="GetCardResponse.cs" company="APIMatic">
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
    /// GetCardResponse.
    /// </summary>
    public class GetCardResponse
    {
        private Models.GetCustomerResponse customer;
        private DateTime? deletedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "customer", false },
            { "deleted_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardResponse"/> class.
        /// </summary>
        public GetCardResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="lastFourDigits">last_four_digits.</param>
        /// <param name="brand">brand.</param>
        /// <param name="holderName">holder_name.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="customer">customer.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="type">type.</param>
        /// <param name="holderDocument">holder_document.</param>
        /// <param name="deletedAt">deleted_at.</param>
        /// <param name="firstSixDigits">first_six_digits.</param>
        /// <param name="label">label.</param>
        public GetCardResponse(
            string id = null,
            string lastFourDigits = null,
            string brand = null,
            string holderName = null,
            int? expMonth = null,
            int? expYear = null,
            string status = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            Models.GetBillingAddressResponse billingAddress = null,
            Models.GetCustomerResponse customer = null,
            Dictionary<string, string> metadata = null,
            string type = null,
            string holderDocument = null,
            DateTime? deletedAt = null,
            string firstSixDigits = null,
            string label = null)
        {
            this.Id = id;
            this.LastFourDigits = lastFourDigits;
            this.Brand = brand;
            this.HolderName = holderName;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.BillingAddress = billingAddress;
            if (customer != null)
            {
                this.Customer = customer;
            }

            this.Metadata = metadata;
            this.Type = type;
            this.HolderDocument = holderDocument;
            if (deletedAt != null)
            {
                this.DeletedAt = deletedAt;
            }

            this.FirstSixDigits = firstSixDigits;
            this.Label = label;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets LastFourDigits.
        /// </summary>
        [JsonProperty("last_four_digits", NullValueHandling = NullValueHandling.Include)]
        public string LastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets Brand.
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Include)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets HolderName.
        /// </summary>
        [JsonProperty("holder_name", NullValueHandling = NullValueHandling.Include)]
        public string HolderName { get; set; }

        /// <summary>
        /// Gets or sets ExpMonth.
        /// </summary>
        [JsonProperty("exp_month", NullValueHandling = NullValueHandling.Include)]
        public int? ExpMonth { get; set; }

        /// <summary>
        /// Gets or sets ExpYear.
        /// </summary>
        [JsonProperty("exp_year", NullValueHandling = NullValueHandling.Include)]
        public int? ExpYear { get; set; }

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
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Include)]
        public Models.GetBillingAddressResponse BillingAddress { get; set; }

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
        /// Card type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <summary>
        /// Document number for the card's holder
        /// </summary>
        [JsonProperty("holder_document", NullValueHandling = NullValueHandling.Include)]
        public string HolderDocument { get; set; }

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

        /// <summary>
        /// First six digits
        /// </summary>
        [JsonProperty("first_six_digits", NullValueHandling = NullValueHandling.Include)]
        public string FirstSixDigits { get; set; }

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

            return $"GetCardResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetCardResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.LastFourDigits == null && other.LastFourDigits == null) || (this.LastFourDigits?.Equals(other.LastFourDigits) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.HolderName == null && other.HolderName == null) || (this.HolderName?.Equals(other.HolderName) == true)) &&
                ((this.ExpMonth == null && other.ExpMonth == null) || (this.ExpMonth?.Equals(other.ExpMonth) == true)) &&
                ((this.ExpYear == null && other.ExpYear == null) || (this.ExpYear?.Equals(other.ExpYear) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.HolderDocument == null && other.HolderDocument == null) || (this.HolderDocument?.Equals(other.HolderDocument) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.FirstSixDigits == null && other.FirstSixDigits == null) || (this.FirstSixDigits?.Equals(other.FirstSixDigits) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.LastFourDigits = {(this.LastFourDigits == null ? "null" : this.LastFourDigits == string.Empty ? "" : this.LastFourDigits)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand == string.Empty ? "" : this.Brand)}");
            toStringOutput.Add($"this.HolderName = {(this.HolderName == null ? "null" : this.HolderName == string.Empty ? "" : this.HolderName)}");
            toStringOutput.Add($"this.ExpMonth = {(this.ExpMonth == null ? "null" : this.ExpMonth.ToString())}");
            toStringOutput.Add($"this.ExpYear = {(this.ExpYear == null ? "null" : this.ExpYear.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.HolderDocument = {(this.HolderDocument == null ? "null" : this.HolderDocument == string.Empty ? "" : this.HolderDocument)}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.FirstSixDigits = {(this.FirstSixDigits == null ? "null" : this.FirstSixDigits == string.Empty ? "" : this.FirstSixDigits)}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label == string.Empty ? "" : this.Label)}");
        }
    }
}