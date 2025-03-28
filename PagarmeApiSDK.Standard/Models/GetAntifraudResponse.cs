// <copyright file="GetAntifraudResponse.cs" company="APIMatic">
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
    /// GetAntifraudResponse.
    /// </summary>
    public class GetAntifraudResponse
    {
        private string status;
        private string returnCode;
        private string returnMessage;
        private string providerName;
        private string score;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "status", false },
            { "return_code", false },
            { "return_message", false },
            { "provider_name", false },
            { "score", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAntifraudResponse"/> class.
        /// </summary>
        public GetAntifraudResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAntifraudResponse"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="returnCode">return_code.</param>
        /// <param name="returnMessage">return_message.</param>
        /// <param name="providerName">provider_name.</param>
        /// <param name="score">score.</param>
        public GetAntifraudResponse(
            string status = null,
            string returnCode = null,
            string returnMessage = null,
            string providerName = null,
            string score = null)
        {

            if (status != null)
            {
                this.Status = status;
            }

            if (returnCode != null)
            {
                this.ReturnCode = returnCode;
            }

            if (returnMessage != null)
            {
                this.ReturnMessage = returnMessage;
            }

            if (providerName != null)
            {
                this.ProviderName = providerName;
            }

            if (score != null)
            {
                this.Score = score;
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
        /// Gets or sets ReturnCode.
        /// </summary>
        [JsonProperty("return_code")]
        public string ReturnCode
        {
            get
            {
                return this.returnCode;
            }

            set
            {
                this.shouldSerialize["return_code"] = true;
                this.returnCode = value;
            }
        }

        /// <summary>
        /// Gets or sets ReturnMessage.
        /// </summary>
        [JsonProperty("return_message")]
        public string ReturnMessage
        {
            get
            {
                return this.returnMessage;
            }

            set
            {
                this.shouldSerialize["return_message"] = true;
                this.returnMessage = value;
            }
        }

        /// <summary>
        /// Gets or sets ProviderName.
        /// </summary>
        [JsonProperty("provider_name")]
        public string ProviderName
        {
            get
            {
                return this.providerName;
            }

            set
            {
                this.shouldSerialize["provider_name"] = true;
                this.providerName = value;
            }
        }

        /// <summary>
        /// Gets or sets Score.
        /// </summary>
        [JsonProperty("score")]
        public string Score
        {
            get
            {
                return this.score;
            }

            set
            {
                this.shouldSerialize["score"] = true;
                this.score = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetAntifraudResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetReturnCode()
        {
            this.shouldSerialize["return_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReturnMessage()
        {
            this.shouldSerialize["return_message"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetProviderName()
        {
            this.shouldSerialize["provider_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetScore()
        {
            this.shouldSerialize["score"] = false;
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
        public bool ShouldSerializeReturnCode()
        {
            return this.shouldSerialize["return_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReturnMessage()
        {
            return this.shouldSerialize["return_message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProviderName()
        {
            return this.shouldSerialize["provider_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeScore()
        {
            return this.shouldSerialize["score"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetAntifraudResponse other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.ReturnCode == null && other.ReturnCode == null ||
                 this.ReturnCode?.Equals(other.ReturnCode) == true) &&
                (this.ReturnMessage == null && other.ReturnMessage == null ||
                 this.ReturnMessage?.Equals(other.ReturnMessage) == true) &&
                (this.ProviderName == null && other.ProviderName == null ||
                 this.ProviderName?.Equals(other.ProviderName) == true) &&
                (this.Score == null && other.Score == null ||
                 this.Score?.Equals(other.Score) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"ReturnCode = {this.ReturnCode ?? "null"}");
            toStringOutput.Add($"ReturnMessage = {this.ReturnMessage ?? "null"}");
            toStringOutput.Add($"ProviderName = {this.ProviderName ?? "null"}");
            toStringOutput.Add($"Score = {this.Score ?? "null"}");
        }
    }
}