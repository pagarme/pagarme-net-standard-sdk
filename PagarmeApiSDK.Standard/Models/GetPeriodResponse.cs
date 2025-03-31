// <copyright file="GetPeriodResponse.cs" company="APIMatic">
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
    /// GetPeriodResponse.
    /// </summary>
    public class GetPeriodResponse
    {
        private DateTime? startAt;
        private DateTime? endAt;
        private string id;
        private DateTime? billingAt;
        private Models.GetSubscriptionResponse subscription;
        private string status;
        private int? duration;
        private string createdAt;
        private string updatedAt;
        private int? cycle;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "start_at", false },
            { "end_at", false },
            { "id", false },
            { "billing_at", false },
            { "subscription", false },
            { "status", false },
            { "duration", false },
            { "created_at", false },
            { "updated_at", false },
            { "cycle", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPeriodResponse"/> class.
        /// </summary>
        public GetPeriodResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPeriodResponse"/> class.
        /// </summary>
        /// <param name="startAt">start_at.</param>
        /// <param name="endAt">end_at.</param>
        /// <param name="id">id.</param>
        /// <param name="billingAt">billing_at.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="status">status.</param>
        /// <param name="duration">duration.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="cycle">cycle.</param>
        public GetPeriodResponse(
            DateTime? startAt = null,
            DateTime? endAt = null,
            string id = null,
            DateTime? billingAt = null,
            Models.GetSubscriptionResponse subscription = null,
            string status = null,
            int? duration = null,
            string createdAt = null,
            string updatedAt = null,
            int? cycle = null)
        {

            if (startAt != null)
            {
                this.StartAt = startAt;
            }

            if (endAt != null)
            {
                this.EndAt = endAt;
            }

            if (id != null)
            {
                this.Id = id;
            }

            if (billingAt != null)
            {
                this.BillingAt = billingAt;
            }

            if (subscription != null)
            {
                this.Subscription = subscription;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (duration != null)
            {
                this.Duration = duration;
            }

            if (createdAt != null)
            {
                this.CreatedAt = createdAt;
            }

            if (updatedAt != null)
            {
                this.UpdatedAt = updatedAt;
            }

            if (cycle != null)
            {
                this.Cycle = cycle;
            }
        }

        /// <summary>
        /// Gets or sets StartAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime? StartAt
        {
            get
            {
                return this.startAt;
            }

            set
            {
                this.shouldSerialize["start_at"] = true;
                this.startAt = value;
            }
        }

        /// <summary>
        /// Gets or sets EndAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_at")]
        public DateTime? EndAt
        {
            get
            {
                return this.endAt;
            }

            set
            {
                this.shouldSerialize["end_at"] = true;
                this.endAt = value;
            }
        }

        /// <summary>
        /// Gets or sets Id.
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
        /// Gets or sets BillingAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_at")]
        public DateTime? BillingAt
        {
            get
            {
                return this.billingAt;
            }

            set
            {
                this.shouldSerialize["billing_at"] = true;
                this.billingAt = value;
            }
        }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription
        {
            get
            {
                return this.subscription;
            }

            set
            {
                this.shouldSerialize["subscription"] = true;
                this.subscription = value;
            }
        }

        /// <summary>
        /// Gets or sets Status.
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
        /// Gets or sets Duration.
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                this.shouldSerialize["duration"] = true;
                this.duration = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt
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
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt
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
        /// Gets or sets Cycle.
        /// </summary>
        [JsonProperty("cycle")]
        public int? Cycle
        {
            get
            {
                return this.cycle;
            }

            set
            {
                this.shouldSerialize["cycle"] = true;
                this.cycle = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetPeriodResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStartAt()
        {
            this.shouldSerialize["start_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEndAt()
        {
            this.shouldSerialize["end_at"] = false;
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
        public void UnsetBillingAt()
        {
            this.shouldSerialize["billing_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubscription()
        {
            this.shouldSerialize["subscription"] = false;
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
        public void UnsetDuration()
        {
            this.shouldSerialize["duration"] = false;
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
        public void UnsetCycle()
        {
            this.shouldSerialize["cycle"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStartAt()
        {
            return this.shouldSerialize["start_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndAt()
        {
            return this.shouldSerialize["end_at"];
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
        public bool ShouldSerializeBillingAt()
        {
            return this.shouldSerialize["billing_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscription()
        {
            return this.shouldSerialize["subscription"];
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
        public bool ShouldSerializeDuration()
        {
            return this.shouldSerialize["duration"];
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
        public bool ShouldSerializeCycle()
        {
            return this.shouldSerialize["cycle"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetPeriodResponse other &&
                (this.StartAt == null && other.StartAt == null ||
                 this.StartAt?.Equals(other.StartAt) == true) &&
                (this.EndAt == null && other.EndAt == null ||
                 this.EndAt?.Equals(other.EndAt) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.BillingAt == null && other.BillingAt == null ||
                 this.BillingAt?.Equals(other.BillingAt) == true) &&
                (this.Subscription == null && other.Subscription == null ||
                 this.Subscription?.Equals(other.Subscription) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Duration == null && other.Duration == null ||
                 this.Duration?.Equals(other.Duration) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                (this.Cycle == null && other.Cycle == null ||
                 this.Cycle?.Equals(other.Cycle) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartAt = {(this.StartAt == null ? "null" : this.StartAt.ToString())}");
            toStringOutput.Add($"EndAt = {(this.EndAt == null ? "null" : this.EndAt.ToString())}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"BillingAt = {(this.BillingAt == null ? "null" : this.BillingAt.ToString())}");
            toStringOutput.Add($"Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Duration = {(this.Duration == null ? "null" : this.Duration.ToString())}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"UpdatedAt = {this.UpdatedAt ?? "null"}");
            toStringOutput.Add($"Cycle = {(this.Cycle == null ? "null" : this.Cycle.ToString())}");
        }
    }
}