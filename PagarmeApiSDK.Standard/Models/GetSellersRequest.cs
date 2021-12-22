// <copyright file="GetSellersRequest.cs" company="APIMatic">
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
    /// GetSellersRequest.
    /// </summary>
    public class GetSellersRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSellersRequest"/> class.
        /// </summary>
        public GetSellersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSellersRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="document">document.</param>
        /// <param name="code">code.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type.</param>
        /// <param name="createdSince">created_Since.</param>
        /// <param name="createdUntil">created_Until.</param>
        public GetSellersRequest(
            string name,
            string document,
            string code,
            string status,
            string type,
            string createdSince = null,
            string createdUntil = null)
        {
            this.Name = name;
            this.Document = document;
            this.Code = code;
            this.Status = status;
            this.Type = type;
            this.CreatedSince = createdSince;
            this.CreatedUntil = createdUntil;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Document.
        /// </summary>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets CreatedSince.
        /// </summary>
        [JsonProperty("created_Since", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedSince { get; set; }

        /// <summary>
        /// Gets or sets CreatedUntil.
        /// </summary>
        [JsonProperty("created_Until", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUntil { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetSellersRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetSellersRequest other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.CreatedSince == null && other.CreatedSince == null) || (this.CreatedSince?.Equals(other.CreatedSince) == true)) &&
                ((this.CreatedUntil == null && other.CreatedUntil == null) || (this.CreatedUntil?.Equals(other.CreatedUntil) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document == string.Empty ? "" : this.Document)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.CreatedSince = {(this.CreatedSince == null ? "null" : this.CreatedSince == string.Empty ? "" : this.CreatedSince)}");
            toStringOutput.Add($"this.CreatedUntil = {(this.CreatedUntil == null ? "null" : this.CreatedUntil == string.Empty ? "" : this.CreatedUntil)}");
        }
    }
}