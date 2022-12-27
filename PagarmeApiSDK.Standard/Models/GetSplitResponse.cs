// <copyright file="GetSplitResponse.cs" company="APIMatic">
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
    /// GetSplitResponse.
    /// </summary>
    public class GetSplitResponse
    {
        private Models.GetRecipientResponse recipient;
        private Models.GetSplitOptionsResponse options;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recipient", false },
            { "options", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitResponse"/> class.
        /// </summary>
        public GetSplitResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSplitResponse"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="options">options.</param>
        /// <param name="id">id.</param>
        public GetSplitResponse(
            string type = null,
            int? amount = null,
            Models.GetRecipientResponse recipient = null,
            string gatewayId = null,
            Models.GetSplitOptionsResponse options = null,
            string id = null)
        {
            this.Type = type;
            this.Amount = amount;
            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            this.GatewayId = gatewayId;
            if (options != null)
            {
                this.Options = options;
            }

            this.Id = id;
        }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Include)]
        public int? Amount { get; set; }

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
        /// The split rule gateway id
        /// </summary>
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Include)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options")]
        public Models.GetSplitOptionsResponse Options
        {
            get
            {
                return this.options;
            }

            set
            {
                this.shouldSerialize["options"] = true;
                this.options = value;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSplitResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRecipient()
        {
            this.shouldSerialize["recipient"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOptions()
        {
            this.shouldSerialize["options"] = false;
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
        public bool ShouldSerializeOptions()
        {
            return this.shouldSerialize["options"];
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

            return obj is GetSplitResponse other &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.GatewayId == null && other.GatewayId == null) || (this.GatewayId?.Equals(other.GatewayId) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"this.GatewayId = {(this.GatewayId == null ? "null" : this.GatewayId == string.Empty ? "" : this.GatewayId)}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
        }
    }
}