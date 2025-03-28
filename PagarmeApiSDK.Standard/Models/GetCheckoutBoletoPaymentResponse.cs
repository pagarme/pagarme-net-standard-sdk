// <copyright file="GetCheckoutBoletoPaymentResponse.cs" company="APIMatic">
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
    /// GetCheckoutBoletoPaymentResponse.
    /// </summary>
    public class GetCheckoutBoletoPaymentResponse
    {
        private DateTime? dueAt;
        private string instructions;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "due_at", false },
            { "instructions", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBoletoPaymentResponse"/> class.
        /// </summary>
        public GetCheckoutBoletoPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCheckoutBoletoPaymentResponse"/> class.
        /// </summary>
        /// <param name="dueAt">due_at.</param>
        /// <param name="instructions">instructions.</param>
        public GetCheckoutBoletoPaymentResponse(
            DateTime? dueAt = null,
            string instructions = null)
        {

            if (dueAt != null)
            {
                this.DueAt = dueAt;
            }

            if (instructions != null)
            {
                this.Instructions = instructions;
            }
        }

        /// <summary>
        /// Data de vencimento do boleto
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime? DueAt
        {
            get
            {
                return this.dueAt;
            }

            set
            {
                this.shouldSerialize["due_at"] = true;
                this.dueAt = value;
            }
        }

        /// <summary>
        /// Instruções do boleto
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions
        {
            get
            {
                return this.instructions;
            }

            set
            {
                this.shouldSerialize["instructions"] = true;
                this.instructions = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetCheckoutBoletoPaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDueAt()
        {
            this.shouldSerialize["due_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInstructions()
        {
            this.shouldSerialize["instructions"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueAt()
        {
            return this.shouldSerialize["due_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstructions()
        {
            return this.shouldSerialize["instructions"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetCheckoutBoletoPaymentResponse other &&
                (this.DueAt == null && other.DueAt == null ||
                 this.DueAt?.Equals(other.DueAt) == true) &&
                (this.Instructions == null && other.Instructions == null ||
                 this.Instructions?.Equals(other.Instructions) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DueAt = {(this.DueAt == null ? "null" : this.DueAt.ToString())}");
            toStringOutput.Add($"Instructions = {this.Instructions ?? "null"}");
        }
    }
}