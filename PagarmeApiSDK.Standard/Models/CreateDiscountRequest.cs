// <copyright file="CreateDiscountRequest.cs" company="APIMatic">
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
    /// CreateDiscountRequest.
    /// </summary>
    public class CreateDiscountRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscountRequest"/> class.
        /// </summary>
        public CreateDiscountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscountRequest"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="discountType">discount_type.</param>
        /// <param name="itemId">item_id.</param>
        /// <param name="cycles">cycles.</param>
        /// <param name="description">description.</param>
        public CreateDiscountRequest(
            double mValue,
            string discountType,
            string itemId,
            int? cycles = null,
            string description = null)
        {
            this.MValue = mValue;
            this.DiscountType = discountType;
            this.ItemId = itemId;
            this.Cycles = cycles;
            this.Description = description;
        }

        /// <summary>
        /// The discount value
        /// </summary>
        [JsonProperty("value")]
        public double MValue { get; set; }

        /// <summary>
        /// Discount type. Can be either flat or percentage.
        /// </summary>
        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// The item where the discount will be applied
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Number of cycles that the discount will be applied
        /// </summary>
        [JsonProperty("cycles", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cycles { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateDiscountRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateDiscountRequest other &&
                (this.MValue.Equals(other.MValue)) &&
                (this.DiscountType == null && other.DiscountType == null ||
                 this.DiscountType?.Equals(other.DiscountType) == true) &&
                (this.ItemId == null && other.ItemId == null ||
                 this.ItemId?.Equals(other.ItemId) == true) &&
                (this.Cycles == null && other.Cycles == null ||
                 this.Cycles?.Equals(other.Cycles) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MValue = {this.MValue}");
            toStringOutput.Add($"DiscountType = {this.DiscountType ?? "null"}");
            toStringOutput.Add($"ItemId = {this.ItemId ?? "null"}");
            toStringOutput.Add($"Cycles = {(this.Cycles == null ? "null" : this.Cycles.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
        }
    }
}