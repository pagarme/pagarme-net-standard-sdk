// <copyright file="GetAnticipationResponse.cs" company="APIMatic">
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
    /// GetAnticipationResponse.
    /// </summary>
    public class GetAnticipationResponse
    {
        private string id;
        private int? requestedAmount;
        private int? approvedAmount;
        private Models.GetRecipientResponse recipient;
        private string pgid;
        private DateTime? createdAt;
        private DateTime? updatedAt;
        private DateTime? paymentDate;
        private string status;
        private string timeframe;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "requested_amount", false },
            { "approved_amount", false },
            { "recipient", false },
            { "pgid", false },
            { "created_at", false },
            { "updated_at", false },
            { "payment_date", false },
            { "status", false },
            { "timeframe", false },
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

            if (id != null)
            {
                this.Id = id;
            }

            if (requestedAmount != null)
            {
                this.RequestedAmount = requestedAmount;
            }

            if (approvedAmount != null)
            {
                this.ApprovedAmount = approvedAmount;
            }

            if (recipient != null)
            {
                this.Recipient = recipient;
            }

            if (pgid != null)
            {
                this.Pgid = pgid;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (paymentDate != null)
            {
                this.PaymentDate = paymentDate;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (timeframe != null)
            {
                this.Timeframe = timeframe;
            }
        }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Requested amount
        /// </summary>
        [JsonProperty("requested_amount")]
        public int? RequestedAmount
        {
            get
            {
                return this.requestedAmount;
            }

            set
            {
                this.shouldSerialize["requested_amount"] = true;
                this.requestedAmount = value;
            }
        }

        /// <summary>
        /// Approved amount
        /// </summary>
        [JsonProperty("approved_amount")]
        public int? ApprovedAmount
        {
            get
            {
                return this.approvedAmount;
            }

            set
            {
                this.shouldSerialize["approved_amount"] = true;
                this.approvedAmount = value;
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
        /// Anticipation id on the gateway
        /// </summary>
        [JsonProperty("pgid")]
        public string Pgid
        {
            get
            {
                return this.pgid;
            }

            set
            {
                this.shouldSerialize["pgid"] = true;
                this.pgid = value;
            }
        }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime? CreatedAt
        {
            get
            {
                return this.createdAt;
            }

            set
            {
                this.shouldSerialize["created_at"] = true;
                this.createdAt = value;
            }
        }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt
        {
            get
            {
                return this.updatedAt;
            }

            set
            {
                this.shouldSerialize["updated_at"] = true;
                this.updatedAt = value;
            }
        }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date")]
        public DateTime? PaymentDate
        {
            get
            {
                return this.paymentDate;
            }

            set
            {
                this.shouldSerialize["payment_date"] = true;
                this.paymentDate = value;
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Timeframe
        /// </summary>
        [JsonProperty("timeframe")]
        public string Timeframe
        {
            get
            {
                return this.timeframe;
            }

            set
            {
                this.shouldSerialize["timeframe"] = true;
                this.timeframe = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetAnticipationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRequestedAmount()
        {
            this.shouldSerialize["requested_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetApprovedAmount()
        {
            this.shouldSerialize["approved_amount"] = false;
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
        public void UnsetPgid()
        {
            this.shouldSerialize["pgid"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCreatedAt()
        {
            this.shouldSerialize["created_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpdatedAt()
        {
            this.shouldSerialize["updated_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaymentDate()
        {
            this.shouldSerialize["payment_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTimeframe()
        {
            this.shouldSerialize["timeframe"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestedAmount()
        {
            return this.shouldSerialize["requested_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeApprovedAmount()
        {
            return this.shouldSerialize["approved_amount"];
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
        public bool ShouldSerializePgid()
        {
            return this.shouldSerialize["pgid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return this.shouldSerialize["created_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return this.shouldSerialize["updated_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentDate()
        {
            return this.shouldSerialize["payment_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTimeframe()
        {
            return this.shouldSerialize["timeframe"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetAnticipationResponse other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.RequestedAmount == null && other.RequestedAmount == null ||
                 this.RequestedAmount?.Equals(other.RequestedAmount) == true) &&
                (this.ApprovedAmount == null && other.ApprovedAmount == null ||
                 this.ApprovedAmount?.Equals(other.ApprovedAmount) == true) &&
                (this.Recipient == null && other.Recipient == null ||
                 this.Recipient?.Equals(other.Recipient) == true) &&
                (this.Pgid == null && other.Pgid == null ||
                 this.Pgid?.Equals(other.Pgid) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.PaymentDate == null && other.PaymentDate == null ||
                 this.PaymentDate?.Equals(other.PaymentDate) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Timeframe == null && other.Timeframe == null ||
                 this.Timeframe?.Equals(other.Timeframe) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"RequestedAmount = {(this.RequestedAmount == null ? "null" : this.RequestedAmount.ToString())}");
            toStringOutput.Add($"ApprovedAmount = {(this.ApprovedAmount == null ? "null" : this.ApprovedAmount.ToString())}");
            toStringOutput.Add($"Recipient = {(this.Recipient == null ? "null" : this.Recipient.ToString())}");
            toStringOutput.Add($"Pgid = {this.Pgid ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"PaymentDate = {(this.PaymentDate == null ? "null" : this.PaymentDate.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Timeframe = {this.Timeframe ?? "null"}");
        }
    }
}