// <copyright file="CreatePlanItemRequest.cs" company="APIMatic">
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
    /// CreatePlanItemRequest.
    /// </summary>
    public class CreatePlanItemRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlanItemRequest"/> class.
        /// </summary>
        public CreatePlanItemRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlanItemRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="quantity">quantity.</param>
        public CreatePlanItemRequest(
            string name,
            Models.CreatePricingSchemeRequest pricingScheme,
            string id,
            string description,
            int? cycles = null,
            int? quantity = null)
        {
            this.Name = name;
            this.PricingScheme = pricingScheme;
            this.Id = id;
            this.Description = description;
            this.Cycles = cycles;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Item name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Item's pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.CreatePricingSchemeRequest PricingScheme { get; set; }

        /// <summary>
        /// Item's id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Item's description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Number of cycles where the item will be charged
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreatePlanItemRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreatePlanItemRequest other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.PricingScheme == null && other.PricingScheme == null ||
                 this.PricingScheme?.Equals(other.PricingScheme) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Cycles == null && other.Cycles == null ||
                 this.Cycles?.Equals(other.Cycles) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
        }
    }
}