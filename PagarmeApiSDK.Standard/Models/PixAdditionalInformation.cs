// <copyright file="PixAdditionalInformation.cs" company="APIMatic">
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
    /// PixAdditionalInformation.
    /// </summary>
    public class PixAdditionalInformation
    {
        private string name;
        private string mValue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Name", false },
            { "Value", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PixAdditionalInformation"/> class.
        /// </summary>
        public PixAdditionalInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PixAdditionalInformation"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="mValue">Value.</param>
        public PixAdditionalInformation(
            string name = null,
            string mValue = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            if (mValue != null)
            {
                this.MValue = mValue;
            }

        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["Name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("Value")]
        public string MValue
        {
            get
            {
                return this.mValue;
            }

            set
            {
                this.shouldSerialize["Value"] = true;
                this.mValue = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PixAdditionalInformation : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["Name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMValue()
        {
            this.shouldSerialize["Value"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["Name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMValue()
        {
            return this.shouldSerialize["Value"];
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
            return obj is PixAdditionalInformation other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}