// <copyright file="GetCardTokenResponse.cs" company="APIMatic">
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
    /// GetCardTokenResponse.
    /// </summary>
    public class GetCardTokenResponse
    {
        private string lastFourDigits;
        private string holderName;
        private string holderDocument;
        private int? expMonth;
        private int? expYear;
        private string brand;
        private string type;
        private string label;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "last_four_digits", false },
            { "holder_name", false },
            { "holder_document", false },
            { "exp_month", false },
            { "exp_year", false },
            { "brand", false },
            { "type", false },
            { "label", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardTokenResponse"/> class.
        /// </summary>
        public GetCardTokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCardTokenResponse"/> class.
        /// </summary>
        /// <param name="lastFourDigits">last_four_digits.</param>
        /// <param name="holderName">holder_name.</param>
        /// <param name="holderDocument">holder_document.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="brand">brand.</param>
        /// <param name="type">type.</param>
        /// <param name="label">label.</param>
        public GetCardTokenResponse(
            string lastFourDigits = null,
            string holderName = null,
            string holderDocument = null,
            int? expMonth = null,
            int? expYear = null,
            string brand = null,
            string type = null,
            string label = null)
        {

            if (lastFourDigits != null)
            {
                this.LastFourDigits = lastFourDigits;
            }

            if (holderName != null)
            {
                this.HolderName = holderName;
            }

            if (holderDocument != null)
            {
                this.HolderDocument = holderDocument;
            }

            if (expMonth != null)
            {
                this.ExpMonth = expMonth;
            }

            if (expYear != null)
            {
                this.ExpYear = expYear;
            }

            if (brand != null)
            {
                this.Brand = brand;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (label != null)
            {
                this.Label = label;
            }
        }

        /// <summary>
        /// Gets or sets LastFourDigits.
        /// </summary>
        [JsonProperty("last_four_digits")]
        public string LastFourDigits
        {
            get
            {
                return this.lastFourDigits;
            }

            set
            {
                this.shouldSerialize["last_four_digits"] = true;
                this.lastFourDigits = value;
            }
        }

        /// <summary>
        /// Gets or sets HolderName.
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName
        {
            get
            {
                return this.holderName;
            }

            set
            {
                this.shouldSerialize["holder_name"] = true;
                this.holderName = value;
            }
        }

        /// <summary>
        /// Gets or sets HolderDocument.
        /// </summary>
        [JsonProperty("holder_document")]
        public string HolderDocument
        {
            get
            {
                return this.holderDocument;
            }

            set
            {
                this.shouldSerialize["holder_document"] = true;
                this.holderDocument = value;
            }
        }

        /// <summary>
        /// Gets or sets ExpMonth.
        /// </summary>
        [JsonProperty("exp_month")]
        public int? ExpMonth
        {
            get
            {
                return this.expMonth;
            }

            set
            {
                this.shouldSerialize["exp_month"] = true;
                this.expMonth = value;
            }
        }

        /// <summary>
        /// Gets or sets ExpYear.
        /// </summary>
        [JsonProperty("exp_year")]
        public int? ExpYear
        {
            get
            {
                return this.expYear;
            }

            set
            {
                this.shouldSerialize["exp_year"] = true;
                this.expYear = value;
            }
        }

        /// <summary>
        /// Gets or sets Brand.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.shouldSerialize["brand"] = true;
                this.brand = value;
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
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label")]
        public string Label
        {
            get
            {
                return this.label;
            }

            set
            {
                this.shouldSerialize["label"] = true;
                this.label = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCardTokenResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLastFourDigits()
        {
            this.shouldSerialize["last_four_digits"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetHolderName()
        {
            this.shouldSerialize["holder_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetHolderDocument()
        {
            this.shouldSerialize["holder_document"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpMonth()
        {
            this.shouldSerialize["exp_month"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpYear()
        {
            this.shouldSerialize["exp_year"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBrand()
        {
            this.shouldSerialize["brand"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLabel()
        {
            this.shouldSerialize["label"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastFourDigits()
        {
            return this.shouldSerialize["last_four_digits"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHolderName()
        {
            return this.shouldSerialize["holder_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHolderDocument()
        {
            return this.shouldSerialize["holder_document"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpMonth()
        {
            return this.shouldSerialize["exp_month"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpYear()
        {
            return this.shouldSerialize["exp_year"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBrand()
        {
            return this.shouldSerialize["brand"];
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
        public bool ShouldSerializeLabel()
        {
            return this.shouldSerialize["label"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCardTokenResponse other &&
                (this.LastFourDigits == null && other.LastFourDigits == null ||
                 this.LastFourDigits?.Equals(other.LastFourDigits) == true) &&
                (this.HolderName == null && other.HolderName == null ||
                 this.HolderName?.Equals(other.HolderName) == true) &&
                (this.HolderDocument == null && other.HolderDocument == null ||
                 this.HolderDocument?.Equals(other.HolderDocument) == true) &&
                (this.ExpMonth == null && other.ExpMonth == null ||
                 this.ExpMonth?.Equals(other.ExpMonth) == true) &&
                (this.ExpYear == null && other.ExpYear == null ||
                 this.ExpYear?.Equals(other.ExpYear) == true) &&
                (this.Brand == null && other.Brand == null ||
                 this.Brand?.Equals(other.Brand) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Label == null && other.Label == null ||
                 this.Label?.Equals(other.Label) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LastFourDigits = {this.LastFourDigits ?? "null"}");
            toStringOutput.Add($"HolderName = {this.HolderName ?? "null"}");
            toStringOutput.Add($"HolderDocument = {this.HolderDocument ?? "null"}");
            toStringOutput.Add($"ExpMonth = {(this.ExpMonth == null ? "null" : this.ExpMonth.ToString())}");
            toStringOutput.Add($"ExpYear = {(this.ExpYear == null ? "null" : this.ExpYear.ToString())}");
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Label = {this.Label ?? "null"}");
        }
    }
}