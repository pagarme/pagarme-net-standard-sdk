// <copyright file="GetRegisterInformationResponse.cs" company="APIMatic">
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
    /// GetRegisterInformationResponse.
    /// </summary>
    public class GetRegisterInformationResponse
    {
        private string email;
        private string document;
        private string type;
        private string siteUrl;
        private List<Models.GetPhoneNumberResponse> phoneNumbers;
        private string name;
        private string motherName;
        private string birthdate;
        private string monthlyIncome;
        private string professionalOccupation;
        private Models.GetRegisterInformationAddressResponse address;
        private string companyName;
        private string tradingName;
        private string annualRevenue;
        private string corporationType;
        private string foundingDate;
        private string cnae;
        private Models.GetRegisterInformationAddressResponse mainAddress;
        private List<Models.GetManagingPartnerResponse> managingPartners;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "email", false },
            { "document", false },
            { "type", false },
            { "site_url", false },
            { "phone_numbers", false },
            { "name", false },
            { "mother_name", false },
            { "birthdate", false },
            { "monthly_income", false },
            { "professional_occupation", false },
            { "address", false },
            { "company_name", false },
            { "trading_name", false },
            { "annual_revenue", false },
            { "corporation_type", false },
            { "founding_date", false },
            { "cnae", false },
            { "main_address", false },
            { "managing_partners", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegisterInformationResponse"/> class.
        /// </summary>
        public GetRegisterInformationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegisterInformationResponse"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="siteUrl">site_url.</param>
        /// <param name="phoneNumbers">phone_numbers.</param>
        /// <param name="name">name.</param>
        /// <param name="motherName">mother_name.</param>
        /// <param name="birthdate">birthdate.</param>
        /// <param name="monthlyIncome">monthly_income.</param>
        /// <param name="professionalOccupation">professional_occupation.</param>
        /// <param name="address">address.</param>
        /// <param name="companyName">company_name.</param>
        /// <param name="tradingName">trading_name.</param>
        /// <param name="annualRevenue">annual_revenue.</param>
        /// <param name="corporationType">corporation_type.</param>
        /// <param name="foundingDate">founding_date.</param>
        /// <param name="cnae">cnae.</param>
        /// <param name="mainAddress">main_address.</param>
        /// <param name="managingPartners">managing_partners.</param>
        public GetRegisterInformationResponse(
            string email = null,
            string document = null,
            string type = null,
            string siteUrl = null,
            List<Models.GetPhoneNumberResponse> phoneNumbers = null,
            string name = null,
            string motherName = null,
            string birthdate = null,
            string monthlyIncome = null,
            string professionalOccupation = null,
            Models.GetRegisterInformationAddressResponse address = null,
            string companyName = null,
            string tradingName = null,
            string annualRevenue = null,
            string corporationType = null,
            string foundingDate = null,
            string cnae = null,
            Models.GetRegisterInformationAddressResponse mainAddress = null,
            List<Models.GetManagingPartnerResponse> managingPartners = null)
        {
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

            if (siteUrl != null)
            {
                this.SiteUrl = siteUrl;
            }

            if (phoneNumbers != null)
            {
                this.PhoneNumbers = phoneNumbers;
            }

            if (name != null)
            {
                this.Name = name;
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

            if (address != null)
            {
                this.Address = address;
            }

            if (companyName != null)
            {
                this.CompanyName = companyName;
            }

            if (tradingName != null)
            {
                this.TradingName = tradingName;
            }

            if (annualRevenue != null)
            {
                this.AnnualRevenue = annualRevenue;
            }

            if (corporationType != null)
            {
                this.CorporationType = corporationType;
            }

            if (foundingDate != null)
            {
                this.FoundingDate = foundingDate;
            }

            if (cnae != null)
            {
                this.Cnae = cnae;
            }

            if (mainAddress != null)
            {
                this.MainAddress = mainAddress;
            }

            if (managingPartners != null)
            {
                this.ManagingPartners = managingPartners;
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
        /// Gets or sets SiteUrl.
        /// </summary>
        [JsonProperty("site_url")]
        public string SiteUrl
        {
            get
            {
                return this.siteUrl;
            }

            set
            {
                this.shouldSerialize["site_url"] = true;
                this.siteUrl = value;
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
        /// Gets or sets CompanyName.
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            set
            {
                this.shouldSerialize["company_name"] = true;
                this.companyName = value;
            }
        }

        /// <summary>
        /// Gets or sets TradingName.
        /// </summary>
        [JsonProperty("trading_name")]
        public string TradingName
        {
            get
            {
                return this.tradingName;
            }

            set
            {
                this.shouldSerialize["trading_name"] = true;
                this.tradingName = value;
            }
        }

        /// <summary>
        /// Gets or sets AnnualRevenue.
        /// </summary>
        [JsonProperty("annual_revenue")]
        public string AnnualRevenue
        {
            get
            {
                return this.annualRevenue;
            }

            set
            {
                this.shouldSerialize["annual_revenue"] = true;
                this.annualRevenue = value;
            }
        }

        /// <summary>
        /// Gets or sets CorporationType.
        /// </summary>
        [JsonProperty("corporation_type")]
        public string CorporationType
        {
            get
            {
                return this.corporationType;
            }

            set
            {
                this.shouldSerialize["corporation_type"] = true;
                this.corporationType = value;
            }
        }

        /// <summary>
        /// Gets or sets FoundingDate.
        /// </summary>
        [JsonProperty("founding_date")]
        public string FoundingDate
        {
            get
            {
                return this.foundingDate;
            }

            set
            {
                this.shouldSerialize["founding_date"] = true;
                this.foundingDate = value;
            }
        }

        /// <summary>
        /// Gets or sets Cnae.
        /// </summary>
        [JsonProperty("cnae")]
        public string Cnae
        {
            get
            {
                return this.cnae;
            }

            set
            {
                this.shouldSerialize["cnae"] = true;
                this.cnae = value;
            }
        }

        /// <summary>
        /// Gets or sets MainAddress.
        /// </summary>
        [JsonProperty("main_address")]
        public Models.GetRegisterInformationAddressResponse MainAddress
        {
            get
            {
                return this.mainAddress;
            }

            set
            {
                this.shouldSerialize["main_address"] = true;
                this.mainAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets ManagingPartners.
        /// </summary>
        [JsonProperty("managing_partners")]
        public List<Models.GetManagingPartnerResponse> ManagingPartners
        {
            get
            {
                return this.managingPartners;
            }

            set
            {
                this.shouldSerialize["managing_partners"] = true;
                this.managingPartners = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetRegisterInformationResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetSiteUrl()
        {
            this.shouldSerialize["site_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPhoneNumbers()
        {
            this.shouldSerialize["phone_numbers"] = false;
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
        public void UnsetCompanyName()
        {
            this.shouldSerialize["company_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTradingName()
        {
            this.shouldSerialize["trading_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnnualRevenue()
        {
            this.shouldSerialize["annual_revenue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCorporationType()
        {
            this.shouldSerialize["corporation_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFoundingDate()
        {
            this.shouldSerialize["founding_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCnae()
        {
            this.shouldSerialize["cnae"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMainAddress()
        {
            this.shouldSerialize["main_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetManagingPartners()
        {
            this.shouldSerialize["managing_partners"] = false;
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
        public bool ShouldSerializeSiteUrl()
        {
            return this.shouldSerialize["site_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePhoneNumbers()
        {
            return this.shouldSerialize["phone_numbers"];
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
        public bool ShouldSerializeCompanyName()
        {
            return this.shouldSerialize["company_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTradingName()
        {
            return this.shouldSerialize["trading_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnualRevenue()
        {
            return this.shouldSerialize["annual_revenue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCorporationType()
        {
            return this.shouldSerialize["corporation_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFoundingDate()
        {
            return this.shouldSerialize["founding_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCnae()
        {
            return this.shouldSerialize["cnae"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMainAddress()
        {
            return this.shouldSerialize["main_address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeManagingPartners()
        {
            return this.shouldSerialize["managing_partners"];
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
            return obj is GetRegisterInformationResponse other &&                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.SiteUrl == null && other.SiteUrl == null) || (this.SiteUrl?.Equals(other.SiteUrl) == true)) &&
                ((this.PhoneNumbers == null && other.PhoneNumbers == null) || (this.PhoneNumbers?.Equals(other.PhoneNumbers) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MotherName == null && other.MotherName == null) || (this.MotherName?.Equals(other.MotherName) == true)) &&
                ((this.Birthdate == null && other.Birthdate == null) || (this.Birthdate?.Equals(other.Birthdate) == true)) &&
                ((this.MonthlyIncome == null && other.MonthlyIncome == null) || (this.MonthlyIncome?.Equals(other.MonthlyIncome) == true)) &&
                ((this.ProfessionalOccupation == null && other.ProfessionalOccupation == null) || (this.ProfessionalOccupation?.Equals(other.ProfessionalOccupation) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.CompanyName == null && other.CompanyName == null) || (this.CompanyName?.Equals(other.CompanyName) == true)) &&
                ((this.TradingName == null && other.TradingName == null) || (this.TradingName?.Equals(other.TradingName) == true)) &&
                ((this.AnnualRevenue == null && other.AnnualRevenue == null) || (this.AnnualRevenue?.Equals(other.AnnualRevenue) == true)) &&
                ((this.CorporationType == null && other.CorporationType == null) || (this.CorporationType?.Equals(other.CorporationType) == true)) &&
                ((this.FoundingDate == null && other.FoundingDate == null) || (this.FoundingDate?.Equals(other.FoundingDate) == true)) &&
                ((this.Cnae == null && other.Cnae == null) || (this.Cnae?.Equals(other.Cnae) == true)) &&
                ((this.MainAddress == null && other.MainAddress == null) || (this.MainAddress?.Equals(other.MainAddress) == true)) &&
                ((this.ManagingPartners == null && other.ManagingPartners == null) || (this.ManagingPartners?.Equals(other.ManagingPartners) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.SiteUrl = {(this.SiteUrl == null ? "null" : this.SiteUrl)}");
            toStringOutput.Add($"this.PhoneNumbers = {(this.PhoneNumbers == null ? "null" : $"[{string.Join(", ", this.PhoneNumbers)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.MotherName = {(this.MotherName == null ? "null" : this.MotherName)}");
            toStringOutput.Add($"this.Birthdate = {(this.Birthdate == null ? "null" : this.Birthdate)}");
            toStringOutput.Add($"this.MonthlyIncome = {(this.MonthlyIncome == null ? "null" : this.MonthlyIncome)}");
            toStringOutput.Add($"this.ProfessionalOccupation = {(this.ProfessionalOccupation == null ? "null" : this.ProfessionalOccupation)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.CompanyName = {(this.CompanyName == null ? "null" : this.CompanyName)}");
            toStringOutput.Add($"this.TradingName = {(this.TradingName == null ? "null" : this.TradingName)}");
            toStringOutput.Add($"this.AnnualRevenue = {(this.AnnualRevenue == null ? "null" : this.AnnualRevenue)}");
            toStringOutput.Add($"this.CorporationType = {(this.CorporationType == null ? "null" : this.CorporationType)}");
            toStringOutput.Add($"this.FoundingDate = {(this.FoundingDate == null ? "null" : this.FoundingDate)}");
            toStringOutput.Add($"this.Cnae = {(this.Cnae == null ? "null" : this.Cnae)}");
            toStringOutput.Add($"this.MainAddress = {(this.MainAddress == null ? "null" : this.MainAddress.ToString())}");
            toStringOutput.Add($"this.ManagingPartners = {(this.ManagingPartners == null ? "null" : $"[{string.Join(", ", this.ManagingPartners)} ]")}");
        }
    }
}