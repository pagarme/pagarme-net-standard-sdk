// <copyright file="GetBalanceResponse.cs" company="APIMatic">
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
    /// GetBalanceResponse.
    /// </summary>
    public class GetBalanceResponse
    {
        private string currency;
        private long? availableAmount;
        private Models.GetRecipientResponse recipient;
        private long? transferredAmount;
        private long? waitingFundsAmount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "currency", false },
            { "available_amount", false },
            { "recipient", false },
            { "transferred_amount", false },
            { "waiting_funds_amount", false },
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

            if (currency != null)
            {
                this.Currency = currency;
            }

            if (availableAmount != null)
            {
                this.AvailableAmount = availableAmount;
            }

            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            if (transferredAmount != null)
            {
                this.TransferredAmount = transferredAmount;
            }

            if (waitingFundsAmount != null)
            {
                this.WaitingFundsAmount = waitingFundsAmount;
            }
        }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency
        {
            get
            {
                return this.currency;
            }

            set
            {
                this.shouldSerialize["currency"] = true;
                this.currency = value;
            }
        }

        /// <summary>
        /// Amount available for transferring
        /// </summary>
        [JsonProperty("available_amount")]
        public long? AvailableAmount
        {
            get
            {
                return this.availableAmount;
            }

            set
            {
                this.shouldSerialize["available_amount"] = true;
                this.availableAmount = value;
            }
        }

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
        [JsonProperty("transferred_amount")]
        public long? TransferredAmount
        {
            get
            {
                return this.transferredAmount;
            }

            set
            {
                this.shouldSerialize["transferred_amount"] = true;
                this.transferredAmount = value;
            }
        }

        /// <summary>
        /// Gets or sets WaitingFundsAmount.
        /// </summary>
        [JsonProperty("waiting_funds_amount")]
        public long? WaitingFundsAmount
        {
            get
            {
                return this.waitingFundsAmount;
            }

            set
            {
                this.shouldSerialize["waiting_funds_amount"] = true;
                this.waitingFundsAmount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetBalanceResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCurrency()
        {
            this.shouldSerialize["currency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAvailableAmount()
        {
            this.shouldSerialize["available_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRecipient()
        {
            this.shouldSerialize["recipient"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransferredAmount()
        {
            this.shouldSerialize["transferred_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWaitingFundsAmount()
        {
            this.shouldSerialize["waiting_funds_amount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrency()
        {
            return this.shouldSerialize["currency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAvailableAmount()
        {
            return this.shouldSerialize["available_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecipient()
        {
            return this.shouldSerialize["recipient"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransferredAmount()
        {
            return this.shouldSerialize["transferred_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWaitingFundsAmount()
        {
            return this.shouldSerialize["waiting_funds_amount"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetBalanceResponse other &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.AvailableAmount == null && other.AvailableAmount == null ||
                 this.AvailableAmount?.Equals(other.AvailableAmount) == true) &&
                (this.Recipient == null && other.Recipient == null ||
                 this.Recipient?.Equals(other.Recipient) == true) &&
                (this.TransferredAmount == null && other.TransferredAmount == null ||
                 this.TransferredAmount?.Equals(other.TransferredAmount) == true) &&
                (this.WaitingFundsAmount == null && other.WaitingFundsAmount == null ||
                 this.WaitingFundsAmount?.Equals(other.WaitingFundsAmount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"AvailableAmount = {(this.AvailableAmount == null ? "null" : this.AvailableAmount.ToString())}");
            toStringOutput.Add($"Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"TransferredAmount = {(this.TransferredAmount == null ? "null" : this.TransferredAmount.ToString())}");
            toStringOutput.Add($"WaitingFundsAmount = {(this.WaitingFundsAmount == null ? "null" : this.WaitingFundsAmount.ToString())}");
        }
    }
}