// <copyright file="CreateRegisterInformationIndividualRequest.cs" company="APIMatic">
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
    /// CreateRegisterInformationIndividualRequest.
    /// </summary>
    public class CreateRegisterInformationIndividualRequest : CreateRegisterInformationBaseRequest
    {
        private string motherName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "mother_name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationIndividualRequest"/> class.
        /// </summary>
        public CreateRegisterInformationIndividualRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationIndividualRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="phoneNumbers">phone_numbers.</param>
        /// <param name="name">name.</param>
        /// <param name="birthdate">birthdate.</param>
        /// <param name="monthlyIncome">monthly_income.</param>
        /// <param name="professionalOccupation">professional_occupation.</param>
        /// <param name="address">address.</param>
        /// <param name="siteUrl">site_url.</param>
        /// <param name="motherName">mother_name.</param>
        public CreateRegisterInformationIndividualRequest(
            string email,
            string document,
            string type,
            List<Models.CreateRegisterInformationPhoneRequest> phoneNumbers,
            string name,
            string birthdate,
            int monthlyIncome,
            string professionalOccupation,
            Models.CreateRegisterInformationAddressRequest address,
            string siteUrl = null,
            string motherName = null)
            : base(
                email,
                document,
                type,
                phoneNumbers,
                siteUrl)
        {
            this.Name = name;
            if (motherName != null)
            {
                this.MotherName = motherName;
            }

            this.Birthdate = birthdate;
            this.MonthlyIncome = monthlyIncome;
            this.ProfessionalOccupation = professionalOccupation;
            this.Address = address;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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
        public int MonthlyIncome { get; set; }

        /// <summary>
        /// Gets or sets ProfessionalOccupation.
        /// </summary>
        [JsonProperty("professional_occupation")]
        public string ProfessionalOccupation { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateRegisterInformationAddressRequest Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateRegisterInformationIndividualRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CreateRegisterInformationIndividualRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MotherName == null && other.MotherName == null) || (this.MotherName?.Equals(other.MotherName) == true)) &&
                ((this.Birthdate == null && other.Birthdate == null) || (this.Birthdate?.Equals(other.Birthdate) == true)) &&
                this.MonthlyIncome.Equals(other.MonthlyIncome) &&
                ((this.ProfessionalOccupation == null && other.ProfessionalOccupation == null) || (this.ProfessionalOccupation?.Equals(other.ProfessionalOccupation) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.MotherName = {(this.MotherName == null ? "null" : this.MotherName)}");
            toStringOutput.Add($"this.Birthdate = {(this.Birthdate == null ? "null" : this.Birthdate)}");
            toStringOutput.Add($"this.MonthlyIncome = {this.MonthlyIncome}");
            toStringOutput.Add($"this.ProfessionalOccupation = {(this.ProfessionalOccupation == null ? "null" : this.ProfessionalOccupation)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}