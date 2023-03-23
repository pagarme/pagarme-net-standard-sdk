// <copyright file="GetGatewayResponseResponse.cs" company="APIMatic">
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
    /// GetGatewayResponseResponse.
    /// </summary>
    public class GetGatewayResponseResponse
    {
        private string code;
        private List<Models.GetGatewayErrorResponse> errors;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "code", false },
            { "errors", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayResponseResponse"/> class.
        /// </summary>
        public GetGatewayResponseResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayResponseResponse"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="errors">errors.</param>
        public GetGatewayResponseResponse(
            string code = null,
            List<Models.GetGatewayErrorResponse> errors = null)
        {
            if (code != null)
            {
                this.Code = code;
            }

            if (errors != null)
            {
                this.Errors = errors;
            }

        }

        /// <summary>
        /// The error code
        /// </summary>
        [JsonProperty("code")]
        public string Code
        {
            get
            {
                return this.code;
            }

            set
            {
                this.shouldSerialize["code"] = true;
                this.code = value;
            }
        }

        /// <summary>
        /// The gateway response errors list
        /// </summary>
        [JsonProperty("errors")]
        public List<Models.GetGatewayErrorResponse> Errors
        {
            get
            {
                return this.errors;
            }

            set
            {
                this.shouldSerialize["errors"] = true;
                this.errors = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetGatewayResponseResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCode()
        {
            this.shouldSerialize["code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrors()
        {
            this.shouldSerialize["errors"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCode()
        {
            return this.shouldSerialize["code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrors()
        {
            return this.shouldSerialize["errors"];
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

            return obj is GetGatewayResponseResponse other &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
        }
    }
}