// <copyright file="UpdateChargeCardRequest.cs" company="APIMatic">
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
    /// UpdateChargeCardRequest.
    /// </summary>
    public class UpdateChargeCardRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeCardRequest"/> class.
        /// </summary>
        public UpdateChargeCardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChargeCardRequest"/> class.
        /// </summary>
        /// <param name="updateSubscription">update_subscription.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="card">card.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="initiatedType">initiated_type.</param>
        /// <param name="recurrenceModel">recurrence_model.</param>
        /// <param name="paymentOrigin">payment_origin.</param>
        /// <param name="indirectAcceptor">indirect_acceptor.</param>
        public UpdateChargeCardRequest(
            bool updateSubscription,
            string cardId,
            Models.CreateCardRequest card,
            bool recurrence,
            string initiatedType = null,
            string recurrenceModel = null,
            Models.CreatePaymentOriginRequest paymentOrigin = null,
            string indirectAcceptor = null)
        {
            this.UpdateSubscription = updateSubscription;
            this.CardId = cardId;
            this.Card = card;
            this.Recurrence = recurrence;
            this.InitiatedType = initiatedType;
            this.RecurrenceModel = recurrenceModel;
            this.PaymentOrigin = paymentOrigin;
            this.IndirectAcceptor = indirectAcceptor;
        }

        /// <summary>
        /// Indicates if the subscriptions using this card must also be updated
        /// </summary>
        [JsonProperty("update_subscription")]
        public bool UpdateSubscription { get; set; }

        /// <summary>
        /// Card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card { get; set; }

        /// <summary>
        /// Indicates a recurrence
        /// </summary>
        [JsonProperty("recurrence")]
        public bool Recurrence { get; set; }

        /// <summary>
        /// Gets or sets InitiatedType.
        /// </summary>
        [JsonProperty("initiated_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InitiatedType { get; set; }

        /// <summary>
        /// Gets or sets RecurrenceModel.
        /// </summary>
        [JsonProperty("recurrence_model", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurrenceModel { get; set; }

        /// <summary>
        /// Gets or sets PaymentOrigin.
        /// </summary>
        [JsonProperty("payment_origin", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatePaymentOriginRequest PaymentOrigin { get; set; }

        /// <summary>
        /// Business model identifier
        /// </summary>
        [JsonProperty("indirect_acceptor", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectAcceptor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateChargeCardRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateChargeCardRequest other &&
                (this.UpdateSubscription.Equals(other.UpdateSubscription)) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.Recurrence.Equals(other.Recurrence)) &&
                (this.InitiatedType == null && other.InitiatedType == null ||
                 this.InitiatedType?.Equals(other.InitiatedType) == true) &&
                (this.RecurrenceModel == null && other.RecurrenceModel == null ||
                 this.RecurrenceModel?.Equals(other.RecurrenceModel) == true) &&
                (this.PaymentOrigin == null && other.PaymentOrigin == null ||
                 this.PaymentOrigin?.Equals(other.PaymentOrigin) == true) &&
                (this.IndirectAcceptor == null && other.IndirectAcceptor == null ||
                 this.IndirectAcceptor?.Equals(other.IndirectAcceptor) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"UpdateSubscription = {this.UpdateSubscription}");
            toStringOutput.Add($"CardId = {this.CardId ?? "null"}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"Recurrence = {this.Recurrence}");
            toStringOutput.Add($"InitiatedType = {this.InitiatedType ?? "null"}");
            toStringOutput.Add($"RecurrenceModel = {this.RecurrenceModel ?? "null"}");
            toStringOutput.Add($"PaymentOrigin = {(this.PaymentOrigin == null ? "null" : this.PaymentOrigin.ToString())}");
            toStringOutput.Add($"IndirectAcceptor = {this.IndirectAcceptor ?? "null"}");
        }
    }
}