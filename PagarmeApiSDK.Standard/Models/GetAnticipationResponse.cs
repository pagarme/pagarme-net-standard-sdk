// <copyright file="GetAnticipationResponse.cs" company="APIMatic">
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
    /// GetAnticipationResponse.
    /// </summary>
    public class GetAnticipationResponse
    {
        private Models.GetRecipientResponse recipient;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "recipient", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationResponse"/> class.
        /// </summary>
        public GetAnticipationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnticipationResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="requestedAmount">requested_amount.</param>
        /// <param name="approvedAmount">approved_amount.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="pgid">pgid.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="paymentDate">payment_date.</param>
        /// <param name="status">status.</param>
        /// <param name="timeframe">timeframe.</param>
        public GetAnticipationResponse(
            string id = null,
            int? requestedAmount = null,
            int? approvedAmount = null,
            Models.GetRecipientResponse recipient = null,
            string pgid = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? paymentDate = null,
            string status = null,
            string timeframe = null)
        {
            this.Id = id;
            this.RequestedAmount = requestedAmount;
            this.ApprovedAmount = approvedAmount;
            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            this.Pgid = pgid;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PaymentDate = paymentDate;
            this.Status = status;
            this.Timeframe = timeframe;
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Requested amount
        /// </summary>
        [JsonProperty("requested_amount", NullValueHandling = NullValueHandling.Include)]
        public int? RequestedAmount { get; set; }

        /// <summary>
        /// Approved amount
        /// </summary>
        [JsonProperty("approved_amount", NullValueHandling = NullValueHandling.Include)]
        public int? ApprovedAmount { get; set; }

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
        /// Anticipation id on the gateway
        /// </summary>
        [JsonProperty("pgid", NullValueHandling = NullValueHandling.Include)]
        public string Pgid { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date", NullValueHandling = NullValueHandling.Include)]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Include)]
        public string Status { get; set; }

        /// <summary>
        /// Timeframe
        /// </summary>
        [JsonProperty("timeframe", NullValueHandling = NullValueHandling.Include)]
        public string Timeframe { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAnticipationResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetAnticipationResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.RequestedAmount == null && other.RequestedAmount == null) || (this.RequestedAmount?.Equals(other.RequestedAmount) == true)) &&
                ((this.ApprovedAmount == null && other.ApprovedAmount == null) || (this.ApprovedAmount?.Equals(other.ApprovedAmount) == true)) &&
                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.Pgid == null && other.Pgid == null) || (this.Pgid?.Equals(other.Pgid) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.PaymentDate == null && other.PaymentDate == null) || (this.PaymentDate?.Equals(other.PaymentDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Timeframe == null && other.Timeframe == null) || (this.Timeframe?.Equals(other.Timeframe) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.RequestedAmount = {(this.RequestedAmount == null ? "null" : this.RequestedAmount.ToString())}");
            toStringOutput.Add($"this.ApprovedAmount = {(this.ApprovedAmount == null ? "null" : this.ApprovedAmount.ToString())}");
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"this.Pgid = {(this.Pgid == null ? "null" : this.Pgid == string.Empty ? "" : this.Pgid)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.PaymentDate = {(this.PaymentDate == null ? "null" : this.PaymentDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Timeframe = {(this.Timeframe == null ? "null" : this.Timeframe == string.Empty ? "" : this.Timeframe)}");
        }
    }
}