// <copyright file="ListCustomersResponse.cs" company="APIMatic">
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
    /// ListCustomersResponse.
    /// </summary>
    public class ListCustomersResponse
    {
        private List<Models.GetCustomerResponse> data;
        private Models.PagingResponse paging;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "data", false },
            { "paging", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomersResponse"/> class.
        /// </summary>
        public ListCustomersResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomersResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="paging">paging.</param>
        public ListCustomersResponse(
            List<Models.GetCustomerResponse> data = null,
            Models.PagingResponse paging = null)
        {
            if (data != null)
            {
                this.Data = data;
            }

            if (paging != null)
            {
                this.Paging = paging;
            }

        }

        /// <summary>
        /// The customer object
        /// </summary>
        [JsonProperty("data")]
        public List<Models.GetCustomerResponse> Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.shouldSerialize["data"] = true;
                this.data = value;
            }
        }

        /// <summary>
        /// Paging object
        /// </summary>
        [JsonProperty("paging")]
        public Models.PagingResponse Paging
        {
            get
            {
                return this.paging;
            }

            set
            {
                this.shouldSerialize["paging"] = true;
                this.paging = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListCustomersResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetData()
        {
            this.shouldSerialize["data"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaging()
        {
            this.shouldSerialize["paging"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeData()
        {
            return this.shouldSerialize["data"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaging()
        {
            return this.shouldSerialize["paging"];
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
            return obj is ListCustomersResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Paging == null && other.Paging == null) || (this.Paging?.Equals(other.Paging) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Paging = {(this.Paging == null ? "null" : this.Paging.ToString())}");
        }
    }
}