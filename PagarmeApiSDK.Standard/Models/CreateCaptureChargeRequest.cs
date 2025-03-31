// <copyright file="CreateCaptureChargeRequest.cs" company="APIMatic">
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
    /// CreateCaptureChargeRequest.
    /// </summary>
    public class CreateCaptureChargeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCaptureChargeRequest"/> class.
        /// </summary>
        public CreateCaptureChargeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCaptureChargeRequest"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="operationReference">operation_reference.</param>
        /// <param name="amount">amount.</param>
        /// <param name="split">split.</param>
        public CreateCaptureChargeRequest(
            string code,
            string operationReference,
            int? amount = null,
            List<Models.CreateSplitRequest> split = null)
        {
            this.Code = code;
            this.Amount = amount;
            this.Split = split;
            this.OperationReference = operationReference;
        }

        /// <summary>
        /// Code for the charge. Sending this field will update the code send on the charge and order creation.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The amount that will be captured
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("split", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateSplitRequest> Split { get; set; }

        /// <summary>
        /// Gets or sets OperationReference.
        /// </summary>
        [JsonProperty("operation_reference")]
        public string OperationReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCaptureChargeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCaptureChargeRequest other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Split == null && other.Split == null ||
                 this.Split?.Equals(other.Split) == true) &&
                (this.OperationReference == null && other.OperationReference == null ||
                 this.OperationReference?.Equals(other.OperationReference) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Split = {(this.Split == null ? "null" : $"[{string.Join(", ", this.Split)} ]")}");
            toStringOutput.Add($"OperationReference = {this.OperationReference ?? "null"}");
        }
    }
}