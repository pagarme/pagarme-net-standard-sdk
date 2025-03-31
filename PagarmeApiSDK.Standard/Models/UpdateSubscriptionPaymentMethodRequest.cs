// <copyright file="UpdateSubscriptionPaymentMethodRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionPaymentMethodRequest.
    /// </summary>
    public class UpdateSubscriptionPaymentMethodRequest
    {
        private string indirectAcceptor;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "indirect_acceptor", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionPaymentMethodRequest"/> class.
        /// </summary>
        public UpdateSubscriptionPaymentMethodRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionPaymentMethodRequest"/> class.
        /// </summary>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="card">card.</param>
        /// <param name="cardToken">card_token.</param>
        /// <param name="boleto">boleto.</param>
        /// <param name="indirectAcceptor">indirect_acceptor.</param>
        public UpdateSubscriptionPaymentMethodRequest(
            string paymentMethod,
            string cardId,
            Models.CreateCardRequest card,
            string cardToken = null,
            Models.CreateSubscriptionBoletoRequest boleto = null,
            string indirectAcceptor = null)
        {
            this.PaymentMethod = paymentMethod;
            this.CardId = cardId;
            this.Card = card;
            this.CardToken = cardToken;
            this.Boleto = boleto;

            if (indirectAcceptor != null)
            {
                this.IndirectAcceptor = indirectAcceptor;
            }
        }

        /// <summary>
        /// The new payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

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
        /// The Card Token
        /// </summary>
        [JsonProperty("card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string CardToken { get; set; }

        /// <summary>
        /// Information about fines and interest on the "boleto" used from payment
        /// </summary>
        [JsonProperty("boleto", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubscriptionBoletoRequest Boleto { get; set; }

        /// <summary>
        /// Business model identifier
        /// </summary>
        [JsonProperty("indirect_acceptor")]
        public string IndirectAcceptor
        {
            get
            {
                return this.indirectAcceptor;
            }

            set
            {
                this.shouldSerialize["indirect_acceptor"] = true;
                this.indirectAcceptor = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionPaymentMethodRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIndirectAcceptor()
        {
            this.shouldSerialize["indirect_acceptor"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIndirectAcceptor()
        {
            return this.shouldSerialize["indirect_acceptor"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionPaymentMethodRequest other &&
                (this.PaymentMethod == null && other.PaymentMethod == null ||
                 this.PaymentMethod?.Equals(other.PaymentMethod) == true) &&
                (this.CardId == null && other.CardId == null ||
                 this.CardId?.Equals(other.CardId) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.CardToken == null && other.CardToken == null ||
                 this.CardToken?.Equals(other.CardToken) == true) &&
                (this.Boleto == null && other.Boleto == null ||
                 this.Boleto?.Equals(other.Boleto) == true) &&
                (this.IndirectAcceptor == null && other.IndirectAcceptor == null ||
                 this.IndirectAcceptor?.Equals(other.IndirectAcceptor) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentMethod = {this.PaymentMethod ?? "null"}");
            toStringOutput.Add($"CardId = {this.CardId ?? "null"}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"CardToken = {this.CardToken ?? "null"}");
            toStringOutput.Add($"Boleto = {(this.Boleto == null ? "null" : this.Boleto.ToString())}");
            toStringOutput.Add($"IndirectAcceptor = {this.IndirectAcceptor ?? "null"}");
        }
    }
}