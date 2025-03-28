// <copyright file="CreateManagingPartnerRequest.cs" company="APIMatic">
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
    /// CreateManagingPartnerRequest.
    /// </summary>
    public class CreateManagingPartnerRequest
    {
        private string motherName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "mother_name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagingPartnerRequest"/> class.
        /// </summary>
        public CreateManagingPartnerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManagingPartnerRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="birthdate">birthdate.</param>
        /// <param name="monthlyIncome">monthly_income.</param>
        /// <param name="professionalOccupation">professional_occupation.</param>
        /// <param name="selfDeclaredLegalRepresentative">self_declared_legal_representative.</param>
        /// <param name="address">address.</param>
        /// <param name="phoneNumbers">phone_numbers.</param>
        /// <param name="motherName">mother_name.</param>
        public CreateManagingPartnerRequest(
            string name,
            string email,
            string document,
            string birthdate,
            long monthlyIncome,
            string professionalOccupation,
            bool selfDeclaredLegalRepresentative,
            Models.CreateRegisterInformationAddressRequest address,
            List<Models.CreateRegisterInformationPhoneRequest> phoneNumbers,
            string motherName = null)
        {
            this.Name = name;
            this.Email = email;
            this.Document = document;

            if (motherName != null)
            {
                this.MotherName = motherName;
            }
            this.Birthdate = birthdate;
            this.MonthlyIncome = monthlyIncome;
            this.ProfessionalOccupation = professionalOccupation;
            this.SelfDeclaredLegalRepresentative = selfDeclaredLegalRepresentative;
            this.Address = address;
            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Document.
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Gets or sets MotherName.
        /// </summary>
        [JsonProperty("mother_name")]
        public string MotherName
        {
            get
            {
                return this.motherName;
            }

            set
            {
                this.shouldSerialize["mother_name"] = true;
                this.motherName = value;
            }
        }

        /// <summary>
        /// Gets or sets Birthdate.
        /// </summary>
        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        /// <summary>
        /// Gets or sets MonthlyIncome.
        /// </summary>
        [JsonProperty("monthly_income")]
        public long MonthlyIncome { get; set; }

        /// <summary>
        /// Gets or sets ProfessionalOccupation.
        /// </summary>
        [JsonProperty("professional_occupation")]
        public string ProfessionalOccupation { get; set; }

        /// <summary>
        /// Gets or sets SelfDeclaredLegalRepresentative.
        /// </summary>
        [JsonProperty("self_declared_legal_representative")]
        public bool SelfDeclaredLegalRepresentative { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateRegisterInformationAddressRequest Address { get; set; }

        /// <summary>
        /// Gets or sets PhoneNumbers.
        /// </summary>
        [JsonProperty("phone_numbers")]
        public List<Models.CreateRegisterInformationPhoneRequest> PhoneNumbers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateManagingPartnerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMotherName()
        {
            this.shouldSerialize["mother_name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMotherName()
        {
            return this.shouldSerialize["mother_name"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateManagingPartnerRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Document == null && other.Document == null ||
                 this.Document?.Equals(other.Document) == true) &&
                (this.MotherName == null && other.MotherName == null ||
                 this.MotherName?.Equals(other.MotherName) == true) &&
                (this.Birthdate == null && other.Birthdate == null ||
                 this.Birthdate?.Equals(other.Birthdate) == true) &&
                (this.MonthlyIncome.Equals(other.MonthlyIncome)) &&
                (this.ProfessionalOccupation == null && other.ProfessionalOccupation == null ||
                 this.ProfessionalOccupation?.Equals(other.ProfessionalOccupation) == true) &&
                (this.SelfDeclaredLegalRepresentative.Equals(other.SelfDeclaredLegalRepresentative)) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.PhoneNumbers == null && other.PhoneNumbers == null ||
                 this.PhoneNumbers?.Equals(other.PhoneNumbers) == true);
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
            toStringOutput.Add($"MotherName = {this.MotherName ?? "null"}");
            toStringOutput.Add($"Birthdate = {this.Birthdate ?? "null"}");
            toStringOutput.Add($"MonthlyIncome = {this.MonthlyIncome}");
            toStringOutput.Add($"ProfessionalOccupation = {this.ProfessionalOccupation ?? "null"}");
            toStringOutput.Add($"SelfDeclaredLegalRepresentative = {this.SelfDeclaredLegalRepresentative}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"PhoneNumbers = {(this.PhoneNumbers == null ? "null" : $"[{string.Join(", ", this.PhoneNumbers)} ]")}");
        }
    }
}