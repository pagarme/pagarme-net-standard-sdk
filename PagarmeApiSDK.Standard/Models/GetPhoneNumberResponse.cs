// <copyright file="GetPhoneNumberResponse.cs" company="APIMatic">
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
    /// GetPhoneNumberResponse.
    /// </summary>
    public class GetPhoneNumberResponse
    {
        private string ddd;
        private string number;
        private string type;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ddd", false },
            { "number", false },
            { "type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberResponse"/> class.
        /// </summary>
        public GetPhoneNumberResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberResponse"/> class.
        /// </summary>
        /// <param name="ddd">ddd.</param>
        /// <param name="number">number.</param>
        /// <param name="type">type.</param>
        public GetPhoneNumberResponse(
            string ddd = null,
            string number = null,
            string type = null)
        {
            if (ddd != null)
            {
                this.Ddd = ddd;
            }

            if (number != null)
            {
                this.Number = number;
            }

            if (type != null)
            {
                this.Type = type;
            }

        }

        /// <summary>
        /// Gets or sets Ddd.
        /// </summary>
        [JsonProperty("ddd")]
        public string Ddd
        {
            get
            {
                return this.ddd;
            }

            set
            {
                this.shouldSerialize["ddd"] = true;
                this.ddd = value;
            }
        }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number")]
        public string Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.shouldSerialize["number"] = true;
                this.number = value;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPhoneNumberResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDdd()
        {
            this.shouldSerialize["ddd"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNumber()
        {
            this.shouldSerialize["number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDdd()
        {
            return this.shouldSerialize["ddd"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNumber()
        {
            return this.shouldSerialize["number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
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
            return obj is GetPhoneNumberResponse other &&                ((this.Ddd == null && other.Ddd == null) || (this.Ddd?.Equals(other.Ddd) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ddd = {(this.Ddd == null ? "null" : this.Ddd)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}