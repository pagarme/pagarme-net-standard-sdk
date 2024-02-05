// <copyright file="GetManagingPartnerResponse.cs" company="APIMatic">
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
    /// GetManagingPartnerResponse.
    /// </summary>
    public class GetManagingPartnerResponse
    {
        private string name;
        private string email;
        private string document;
        private string type;
        private string motherName;
        private string birthdate;
        private string monthlyIncome;
        private string professionalOccupation;
        private Models.GetRegisterInformationAddressResponse address;
        private List<Models.GetPhoneNumberResponse> phoneNumbers;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "email", false },
            { "document", false },
            { "type", false },
            { "mother_name", false },
            { "birthdate", false },
            { "monthly_income", false },
            { "professional_occupation", false },
            { "address", false },
            { "phone_numbers", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetManagingPartnerResponse"/> class.
        /// </summary>
        public GetManagingPartnerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetManagingPartnerResponse"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="motherName">mother_name.</param>
        /// <param name="birthdate">birthdate.</param>
        /// <param name="monthlyIncome">monthly_income.</param>
        /// <param name="professionalOccupation">professional_occupation.</param>
        /// <param name="selfDeclaredRepresentative">self_declared_representative.</param>
        /// <param name="address">address.</param>
        /// <param name="phoneNumbers">phone_numbers.</param>
        public GetManagingPartnerResponse(
            string name = null,
            string email = null,
            string document = null,
            string type = null,
            string motherName = null,
            string birthdate = null,
            string monthlyIncome = null,
            string professionalOccupation = null,
            bool? selfDeclaredRepresentative = null,
            Models.GetRegisterInformationAddressResponse address = null,
            List<Models.GetPhoneNumberResponse> phoneNumbers = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            if (email != null)
            {
                this.Email = email;
            }

            if (document != null)
            {
                this.Document = document;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (motherName != null)
            {
                this.MotherName = motherName;
            }

            if (birthdate != null)
            {
                this.Birthdate = birthdate;
            }

            if (monthlyIncome != null)
            {
                this.MonthlyIncome = monthlyIncome;
            }

            if (professionalOccupation != null)
            {
                this.ProfessionalOccupation = professionalOccupation;
            }

            this.SelfDeclaredRepresentative = selfDeclaredRepresentative;
            if (address != null)
            {
                this.Address = address;
            }

            if (phoneNumbers != null)
            {
                this.PhoneNumbers = phoneNumbers;
            }

        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.shouldSerialize["email"] = true;
                this.email = value;
            }
        }

        /// <summary>
        /// Gets or sets Document.
        /// </summary>
        [JsonProperty("document")]
        public string Document
        {
            get
            {
                return this.document;
            }

            set
            {
                this.shouldSerialize["document"] = true;
                this.document = value;
            }
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["type"] = true;
                this.type = value;
            }
        }

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
        public string Birthdate
        {
            get
            {
                return this.birthdate;
            }

            set
            {
                this.shouldSerialize["birthdate"] = true;
                this.birthdate = value;
            }
        }

        /// <summary>
        /// Gets or sets MonthlyIncome.
        /// </summary>
        [JsonProperty("monthly_income")]
        public string MonthlyIncome
        {
            get
            {
                return this.monthlyIncome;
            }

            set
            {
                this.shouldSerialize["monthly_income"] = true;
                this.monthlyIncome = value;
            }
        }

        /// <summary>
        /// Gets or sets ProfessionalOccupation.
        /// </summary>
        [JsonProperty("professional_occupation")]
        public string ProfessionalOccupation
        {
            get
            {
                return this.professionalOccupation;
            }

            set
            {
                this.shouldSerialize["professional_occupation"] = true;
                this.professionalOccupation = value;
            }
        }

        /// <summary>
        /// Gets or sets SelfDeclaredRepresentative.
        /// </summary>
        [JsonProperty("self_declared_representative", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelfDeclaredRepresentative { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public Models.GetRegisterInformationAddressResponse Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.shouldSerialize["address"] = true;
                this.address = value;
            }
        }

        /// <summary>
        /// Gets or sets PhoneNumbers.
        /// </summary>
        [JsonProperty("phone_numbers")]
        public List<Models.GetPhoneNumberResponse> PhoneNumbers
        {
            get
            {
                return this.phoneNumbers;
            }

            set
            {
                this.shouldSerialize["phone_numbers"] = true;
                this.phoneNumbers = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetManagingPartnerResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEmail()
        {
            this.shouldSerialize["email"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocument()
        {
            this.shouldSerialize["document"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMotherName()
        {
            this.shouldSerialize["mother_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBirthdate()
        {
            this.shouldSerialize["birthdate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMonthlyIncome()
        {
            this.shouldSerialize["monthly_income"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProfessionalOccupation()
        {
            this.shouldSerialize["professional_occupation"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddress()
        {
            this.shouldSerialize["address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPhoneNumbers()
        {
            this.shouldSerialize["phone_numbers"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmail()
        {
            return this.shouldSerialize["email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocument()
        {
            return this.shouldSerialize["document"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMotherName()
        {
            return this.shouldSerialize["mother_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBirthdate()
        {
            return this.shouldSerialize["birthdate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlyIncome()
        {
            return this.shouldSerialize["monthly_income"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProfessionalOccupation()
        {
            return this.shouldSerialize["professional_occupation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddress()
        {
            return this.shouldSerialize["address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePhoneNumbers()
        {
            return this.shouldSerialize["phone_numbers"];
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
            return obj is GetManagingPartnerResponse other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MotherName == null && other.MotherName == null) || (this.MotherName?.Equals(other.MotherName) == true)) &&
                ((this.Birthdate == null && other.Birthdate == null) || (this.Birthdate?.Equals(other.Birthdate) == true)) &&
                ((this.MonthlyIncome == null && other.MonthlyIncome == null) || (this.MonthlyIncome?.Equals(other.MonthlyIncome) == true)) &&
                ((this.ProfessionalOccupation == null && other.ProfessionalOccupation == null) || (this.ProfessionalOccupation?.Equals(other.ProfessionalOccupation) == true)) &&
                ((this.SelfDeclaredRepresentative == null && other.SelfDeclaredRepresentative == null) || (this.SelfDeclaredRepresentative?.Equals(other.SelfDeclaredRepresentative) == true)) &&
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
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.MotherName = {(this.MotherName == null ? "null" : this.MotherName)}");
            toStringOutput.Add($"this.Birthdate = {(this.Birthdate == null ? "null" : this.Birthdate)}");
            toStringOutput.Add($"this.MonthlyIncome = {(this.MonthlyIncome == null ? "null" : this.MonthlyIncome)}");
            toStringOutput.Add($"this.ProfessionalOccupation = {(this.ProfessionalOccupation == null ? "null" : this.ProfessionalOccupation)}");
            toStringOutput.Add($"this.SelfDeclaredRepresentative = {(this.SelfDeclaredRepresentative == null ? "null" : this.SelfDeclaredRepresentative.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.PhoneNumbers = {(this.PhoneNumbers == null ? "null" : $"[{string.Join(", ", this.PhoneNumbers)} ]")}");
        }
    }
}