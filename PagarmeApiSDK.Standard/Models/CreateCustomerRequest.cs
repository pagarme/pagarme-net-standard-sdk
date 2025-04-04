// <copyright file="CreateCustomerRequest.cs" company="APIMatic">
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
    /// CreateCustomerRequest.
    /// </summary>
    public class CreateCustomerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerRequest"/> class.
        /// </summary>
        public CreateCustomerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="address">address.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="phones">phones.</param>
        /// <param name="code">code.</param>
        /// <param name="gender">gender.</param>
        /// <param name="documentType">document_type.</param>
        public CreateCustomerRequest(
            string name,
            string email,
            string document,
            string type,
            Models.CreateAddressRequest address,
            Dictionary<string, string> metadata,
            Models.CreatePhonesRequest phones,
            string code,
            string gender = null,
            string documentType = null)
        {
            this.Name = name;
            this.Email = email;
            this.Document = document;
            this.Type = type;
            this.Address = address;
            this.Metadata = metadata;
            this.Phones = phones;
            this.Code = code;
            this.Gender = gender;
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Document number. Only numbers, no special characters.
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Person type. Can be either 'individual' or 'company'
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The customer's address
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateAddressRequest Address { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Phones.
        /// </summary>
        [JsonProperty("phones")]
        public Models.CreatePhonesRequest Phones { get; set; }

        /// <summary>
        /// Customer code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Customer Gender
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets DocumentType.
        /// </summary>
        [JsonProperty("document_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCustomerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCustomerRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Document == null && other.Document == null ||
                 this.Document?.Equals(other.Document) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Phones == null && other.Phones == null ||
                 this.Phones?.Equals(other.Phones) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Gender == null && other.Gender == null ||
                 this.Gender?.Equals(other.Gender) == true) &&
                (this.DocumentType == null && other.DocumentType == null ||
                 this.DocumentType?.Equals(other.DocumentType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Document = {this.Document ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Phones = {(this.Phones == null ? "null" : this.Phones.ToString())}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Gender = {this.Gender ?? "null"}");
            toStringOutput.Add($"DocumentType = {this.DocumentType ?? "null"}");
        }
    }
}