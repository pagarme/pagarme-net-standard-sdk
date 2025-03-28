// <copyright file="CreateRegisterInformationCorporationRequest.cs" company="APIMatic">
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
    /// CreateRegisterInformationCorporationRequest.
    /// </summary>
    public class CreateRegisterInformationCorporationRequest : CreateRegisterInformationBaseRequest
    {
        private string corporationType;
        private string foundingDate;
        private string cnae;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "corporation_type", false },
            { "founding_date", false },
            { "cnae", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationCorporationRequest"/> class.
        /// </summary>
        public CreateRegisterInformationCorporationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRegisterInformationCorporationRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="phoneNumbers">phone_numbers.</param>
        /// <param name="companyName">company_name.</param>
        /// <param name="tradingName">trading_name.</param>
        /// <param name="annualRevenue">annual_revenue.</param>
        /// <param name="managingPartners">managing_partners.</param>
        /// <param name="mainAddress">main_address.</param>
        /// <param name="siteUrl">site_url.</param>
        /// <param name="corporationType">corporation_type.</param>
        /// <param name="foundingDate">founding_date.</param>
        /// <param name="cnae">cnae.</param>
        public CreateRegisterInformationCorporationRequest(
            string email,
            string document,
            string type,
            List<Models.CreateRegisterInformationPhoneRequest> phoneNumbers,
            string companyName,
            string tradingName,
            long annualRevenue,
            List<Models.CreateManagingPartnerRequest> managingPartners,
            Models.CreateRegisterInformationAddressRequest mainAddress,
            string siteUrl = null,
            string corporationType = null,
            string foundingDate = null,
            string cnae = null)
            : base(
                email,
                document,
                type,
                phoneNumbers,
                siteUrl)
        {
            this.CompanyName = companyName;
            this.TradingName = tradingName;
            this.AnnualRevenue = annualRevenue;

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
            this.ManagingPartners = managingPartners;
            this.MainAddress = mainAddress;
        }

        /// <summary>
        /// Gets or sets CompanyName.
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets TradingName.
        /// </summary>
        [JsonProperty("trading_name")]
        public string TradingName { get; set; }

        /// <summary>
        /// Gets or sets AnnualRevenue.
        /// </summary>
        [JsonProperty("annual_revenue")]
        public long AnnualRevenue { get; set; }

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
        /// Gets or sets ManagingPartners.
        /// </summary>
        [JsonProperty("managing_partners")]
        public List<Models.CreateManagingPartnerRequest> ManagingPartners { get; set; }

        /// <summary>
        /// Gets or sets MainAddress.
        /// </summary>
        [JsonProperty("main_address")]
        public Models.CreateRegisterInformationAddressRequest MainAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateRegisterInformationCorporationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCorporationType()
        {
            this.shouldSerialize["corporation_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFoundingDate()
        {
            this.shouldSerialize["founding_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCnae()
        {
            this.shouldSerialize["cnae"] = false;
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateRegisterInformationCorporationRequest other &&
                (this.CompanyName == null && other.CompanyName == null ||
                 this.CompanyName?.Equals(other.CompanyName) == true) &&
                (this.TradingName == null && other.TradingName == null ||
                 this.TradingName?.Equals(other.TradingName) == true) &&
                (this.AnnualRevenue.Equals(other.AnnualRevenue)) &&
                (this.CorporationType == null && other.CorporationType == null ||
                 this.CorporationType?.Equals(other.CorporationType) == true) &&
                (this.FoundingDate == null && other.FoundingDate == null ||
                 this.FoundingDate?.Equals(other.FoundingDate) == true) &&
                (this.Cnae == null && other.Cnae == null ||
                 this.Cnae?.Equals(other.Cnae) == true) &&
                (this.ManagingPartners == null && other.ManagingPartners == null ||
                 this.ManagingPartners?.Equals(other.ManagingPartners) == true) &&
                (this.MainAddress == null && other.MainAddress == null ||
                 this.MainAddress?.Equals(other.MainAddress) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CompanyName = {this.CompanyName ?? "null"}");
            toStringOutput.Add($"TradingName = {this.TradingName ?? "null"}");
            toStringOutput.Add($"AnnualRevenue = {this.AnnualRevenue}");
            toStringOutput.Add($"CorporationType = {this.CorporationType ?? "null"}");
            toStringOutput.Add($"FoundingDate = {this.FoundingDate ?? "null"}");
            toStringOutput.Add($"Cnae = {this.Cnae ?? "null"}");
            toStringOutput.Add($"ManagingPartners = {(this.ManagingPartners == null ? "null" : $"[{string.Join(", ", this.ManagingPartners)} ]")}");
            toStringOutput.Add($"MainAddress = {(this.MainAddress == null ? "null" : this.MainAddress.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}