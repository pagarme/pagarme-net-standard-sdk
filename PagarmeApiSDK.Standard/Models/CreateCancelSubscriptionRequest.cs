// <copyright file="CreateCancelSubscriptionRequest.cs" company="APIMatic">
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
    /// CreateCancelSubscriptionRequest.
    /// </summary>
    public class CreateCancelSubscriptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCancelSubscriptionRequest"/> class.
        /// </summary>
        public CreateCancelSubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCancelSubscriptionRequest"/> class.
        /// </summary>
        /// <param name="cancelPendingInvoices">cancel_pending_invoices.</param>
        public CreateCancelSubscriptionRequest(
            bool cancelPendingInvoices)
        {
            this.CancelPendingInvoices = cancelPendingInvoices;
        }

        /// <summary>
        /// Indicates if the pending invoices must also be canceled.
        /// </summary>
        [JsonProperty("cancel_pending_invoices")]
        public bool CancelPendingInvoices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateCancelSubscriptionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateCancelSubscriptionRequest other &&
                (this.CancelPendingInvoices.Equals(other.CancelPendingInvoices));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CancelPendingInvoices = {this.CancelPendingInvoices}");
        }
    }
}