// <copyright file="GetCheckoutBankTransferPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutBankTransferPaymentResponse.
    /// </summary>
    public class GetCheckoutBankTransferPaymentResponse
    {
        private List<string> bank;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "bank", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBankTransferPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutBankTransferPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBankTransferPaymentResponse"/> class.
        /// </summary>
        /// <param name="bank">bank.</param>
        public GetCheckoutBankTransferPaymentResponse(
            List<string> bank = null)
        {
            if (bank != null)
            {
                this.Bank = bank;
            }

        }

        /// <summary>
        /// bank list response
        /// </summary>
        [JsonProperty("bank")]
        public List<string> Bank
        {
            get
            {
                return this.bank;
            }

            set
            {
                this.shouldSerialize["bank"] = true;
                this.bank = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCheckoutBankTransferPaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBank()
        {
            this.shouldSerialize["bank"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBank()
        {
            return this.shouldSerialize["bank"];
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
            return obj is GetCheckoutBankTransferPaymentResponse other &&                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : $"[{string.Join(", ", this.Bank)} ]")}");
        }
    }
}