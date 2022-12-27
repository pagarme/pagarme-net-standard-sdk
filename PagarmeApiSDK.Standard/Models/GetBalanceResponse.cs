// <copyright file="GetBalanceResponse.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetBalanceResponse.
    /// </summary>
    public class GetBalanceResponse
    {
        private Models.GetRecipientResponse recipient;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recipient", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceResponse"/> class.
        /// </summary>
        public GetBalanceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceResponse"/> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="availableAmount">available_amount.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="transferredAmount">transferred_amount.</param>
        /// <param name="waitingFundsAmount">waiting_funds_amount.</param>
        public GetBalanceResponse(
            string currency = null,
            long? availableAmount = null,
            Models.GetRecipientResponse recipient = null,
            long? transferredAmount = null,
            long? waitingFundsAmount = null)
        {
            this.Currency = currency;
            this.AvailableAmount = availableAmount;
            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            this.TransferredAmount = transferredAmount;
            this.WaitingFundsAmount = waitingFundsAmount;
        }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Include)]
        public string Currency { get; set; }

        /// <summary>
        /// Amount available for transferring
        /// </summary>
        [JsonProperty("available_amount", NullValueHandling = NullValueHandling.Include)]
        public long? AvailableAmount { get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient")]
        public Models.GetRecipientResponse Recipient
        {
            get
            {
                return this.recipient;
            }

            set
            {
                this.shouldSerialize["recipient"] = true;
                this.recipient = value;
            }
        }

        /// <summary>
        /// Gets or sets TransferredAmount.
        /// </summary>
        [JsonProperty("transferred_amount", NullValueHandling = NullValueHandling.Include)]
        public long? TransferredAmount { get; set; }

        /// <summary>
        /// Gets or sets WaitingFundsAmount.
        /// </summary>
        [JsonProperty("waiting_funds_amount", NullValueHandling = NullValueHandling.Include)]
        public long? WaitingFundsAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetBalanceResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRecipient()
        {
            this.shouldSerialize["recipient"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipient()
        {
            return this.shouldSerialize["recipient"];
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

            return obj is GetBalanceResponse other &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.AvailableAmount == null && other.AvailableAmount == null) || (this.AvailableAmount?.Equals(other.AvailableAmount) == true)) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.TransferredAmount == null && other.TransferredAmount == null) || (this.TransferredAmount?.Equals(other.TransferredAmount) == true)) &&
                ((this.WaitingFundsAmount == null && other.WaitingFundsAmount == null) || (this.WaitingFundsAmount?.Equals(other.WaitingFundsAmount) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.AvailableAmount = {(this.AvailableAmount == null ? "null" : this.AvailableAmount.ToString())}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"this.TransferredAmount = {(this.TransferredAmount == null ? "null" : this.TransferredAmount.ToString())}");
            toStringOutput.Add($"this.WaitingFundsAmount = {(this.WaitingFundsAmount == null ? "null" : this.WaitingFundsAmount.ToString())}");
        }
    }
}