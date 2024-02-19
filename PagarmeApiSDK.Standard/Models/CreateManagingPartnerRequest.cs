// <copyright file="CreateManagingPartnerRequest.cs" company="APIMatic">
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
    /// CreateManagingPartnerRequest.
    /// </summary>
    public class CreateManagingPartnerRequest
    {
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
        /// <param name="motherName">mother_name.</param>
        /// <param name="birthdate">birthdate.</param>
        /// <param name="monthlyIncome">monthly_income.</param>
        /// <param name="professionalOccupation">professional_occupation.</param>
        /// <param name="selfDeclaredLegalRepresentative">self_declared_legal_representative.</param>
        /// <param name="address">address.</param>
        /// <param name="phoneNumbers">phone_numbers.</param>
        public CreateManagingPartnerRequest(
            string name,
            string email,
            string document,
            string motherName,
            string birthdate,
            int monthlyIncome,
            string professionalOccupation,
            bool selfDeclaredLegalRepresentative,
            Models.CreateRegisterInformationAddressRequest address,
            List<Models.CreateRegisterInformationPhoneRequest> phoneNumbers)
        {
            this.Name = name;
            this.Email = email;
            this.Document = document;
            this.MotherName = motherName;
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
        public string MotherName { get; set; }

        /// <summary>
        /// Gets or sets Birthdate.
        /// </summary>
        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        /// <summary>
        /// Gets or sets MonthlyIncome.
        /// </summary>
        [JsonProperty("monthly_income")]
        public int MonthlyIncome { get; set; }

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
            return obj is CreateManagingPartnerRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.MotherName == null && other.MotherName == null) || (this.MotherName?.Equals(other.MotherName) == true)) &&
                ((this.Birthdate == null && other.Birthdate == null) || (this.Birthdate?.Equals(other.Birthdate) == true)) &&
                this.MonthlyIncome.Equals(other.MonthlyIncome) &&
                ((this.ProfessionalOccupation == null && other.ProfessionalOccupation == null) || (this.ProfessionalOccupation?.Equals(other.ProfessionalOccupation) == true)) &&
                this.SelfDeclaredLegalRepresentative.Equals(other.SelfDeclaredLegalRepresentative) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.PhoneNumbers == null && other.PhoneNumbers == null) || (this.PhoneNumbers?.Equals(other.PhoneNumbers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document)}");
            toStringOutput.Add($"this.MotherName = {(this.MotherName == null ? "null" : this.MotherName)}");
            toStringOutput.Add($"this.Birthdate = {(this.Birthdate == null ? "null" : this.Birthdate)}");
            toStringOutput.Add($"this.MonthlyIncome = {this.MonthlyIncome}");
            toStringOutput.Add($"this.ProfessionalOccupation = {(this.ProfessionalOccupation == null ? "null" : this.ProfessionalOccupation)}");
            toStringOutput.Add($"this.SelfDeclaredLegalRepresentative = {this.SelfDeclaredLegalRepresentative}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.PhoneNumbers = {(this.PhoneNumbers == null ? "null" : $"[{string.Join(", ", this.PhoneNumbers)} ]")}");
        }
    }
}