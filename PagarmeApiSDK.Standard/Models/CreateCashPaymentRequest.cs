// <copyright file="CreateCashPaymentRequest.cs" company="APIMatic">
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
    /// CreateCashPaymentRequest.
    /// </summary>
    public class CreateCashPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCashPaymentRequest"/> class.
        /// </summary>
        public CreateCashPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCashPaymentRequest"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="confirm">confirm.</param>
        public CreateCashPaymentRequest(
            string description,
            bool confirm)
        {
            this.Description = description;
            this.Confirm = confirm;
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether cash collection will be confirmed in the act of creation
        /// </summary>
        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCashPaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCashPaymentRequest other &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Confirm.Equals(other.Confirm));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Confirm = {this.Confirm}");
        }
    }
}