// <copyright file="CreateSubMerchantRequest.cs" company="APIMatic">
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
    /// CreateSubMerchantRequest.
    /// </summary>
    public class CreateSubMerchantRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubMerchantRequest"/> class.
        /// </summary>
        public CreateSubMerchantRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubMerchantRequest"/> class.
        /// </summary>
        /// <param name="paymentFacilitatorCode">payment_facilitator_code.</param>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="merchantCategoryCode">merchant_category_code.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="phone">phone.</param>
        /// <param name="address">address.</param>
        /// <param name="legalName">legal_name.</param>
        /// <param name="siteUrl">site_url.</param>
        public CreateSubMerchantRequest(
            string paymentFacilitatorCode,
            string code,
            string name,
            string merchantCategoryCode,
            string document,
            string type,
            Models.CreatePhoneRequest phone,
            Models.CreateAddressRequest address,
            string legalName,
            string siteUrl)
        {
            this.PaymentFacilitatorCode = paymentFacilitatorCode;
            this.Code = code;
            this.Name = name;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.Document = document;
            this.Type = type;
            this.Phone = phone;
            this.Address = address;
            this.LegalName = legalName;
            this.SiteUrl = siteUrl;
        }

        /// <summary>
        /// Payment Facilitator Code
        /// </summary>
        [JsonProperty("payment_facilitator_code")]
        public string PaymentFacilitatorCode { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Merchant Category Code
        /// </summary>
        [JsonProperty("merchant_category_code")]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Document number. Only numbers, no special characters.
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Document type. Can be either 'individual' or 'company'
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [JsonProperty("phone")]
        public Models.CreatePhoneRequest Phone { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateAddressRequest Address { get; set; }

        /// <summary>
        /// Legal name
        /// </summary>
        [JsonProperty("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// Site Url
        /// </summary>
        [JsonProperty("site_url")]
        public string SiteUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSubMerchantRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSubMerchantRequest other &&
                (this.PaymentFacilitatorCode == null && other.PaymentFacilitatorCode == null ||
                 this.PaymentFacilitatorCode?.Equals(other.PaymentFacilitatorCode) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.MerchantCategoryCode == null && other.MerchantCategoryCode == null ||
                 this.MerchantCategoryCode?.Equals(other.MerchantCategoryCode) == true) &&
                (this.Document == null && other.Document == null ||
                 this.Document?.Equals(other.Document) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Phone == null && other.Phone == null ||
                 this.Phone?.Equals(other.Phone) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.LegalName == null && other.LegalName == null ||
                 this.LegalName?.Equals(other.LegalName) == true) &&
                (this.SiteUrl == null && other.SiteUrl == null ||
                 this.SiteUrl?.Equals(other.SiteUrl) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentFacilitatorCode = {this.PaymentFacilitatorCode ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"MerchantCategoryCode = {this.MerchantCategoryCode ?? "null"}");
            toStringOutput.Add($"Document = {this.Document ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Phone = {(this.Phone == null ? "null" : this.Phone.ToString())}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"LegalName = {this.LegalName ?? "null"}");
            toStringOutput.Add($"SiteUrl = {this.SiteUrl ?? "null"}");
        }
    }
}