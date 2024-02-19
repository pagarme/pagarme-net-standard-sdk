// <copyright file="GetRetryTransactionInformationResponse.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetRetryTransactionInformationResponse.
    /// </summary>
    public class GetRetryTransactionInformationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRetryTransactionInformationResponse"/> class.
        /// </summary>
        public GetRetryTransactionInformationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRetryTransactionInformationResponse"/> class.
        /// </summary>
        /// <param name="brandFailureReturnCode">brand_failure_return_code.</param>
        /// <param name="transactionLimit">transaction_limit.</param>
        /// <param name="transactionDateLimit">transaction_date_limit.</param>
        public GetRetryTransactionInformationResponse(
            string brandFailureReturnCode = null,
            int? transactionLimit = null,
            DateTime? transactionDateLimit = null)
        {
            this.BrandFailureReturnCode = brandFailureReturnCode;
            this.TransactionLimit = transactionLimit;
            this.TransactionDateLimit = transactionDateLimit;
        }

        /// <summary>
        /// Gets or sets BrandFailureReturnCode.
        /// </summary>
        [JsonProperty("brand_failure_return_code", NullValueHandling = NullValueHandling.Include)]
        public string BrandFailureReturnCode { get; set; }

        /// <summary>
        /// Gets or sets TransactionLimit.
        /// </summary>
        [JsonProperty("transaction_limit", NullValueHandling = NullValueHandling.Include)]
        public int? TransactionLimit { get; set; }

        /// <summary>
        /// Gets or sets TransactionDateLimit.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_date_limit", NullValueHandling = NullValueHandling.Include)]
        public DateTime? TransactionDateLimit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetRetryTransactionInformationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetRetryTransactionInformationResponse other &&                ((this.BrandFailureReturnCode == null && other.BrandFailureReturnCode == null) || (this.BrandFailureReturnCode?.Equals(other.BrandFailureReturnCode) == true)) &&
                ((this.TransactionLimit == null && other.TransactionLimit == null) || (this.TransactionLimit?.Equals(other.TransactionLimit) == true)) &&
                ((this.TransactionDateLimit == null && other.TransactionDateLimit == null) || (this.TransactionDateLimit?.Equals(other.TransactionDateLimit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BrandFailureReturnCode = {(this.BrandFailureReturnCode == null ? "null" : this.BrandFailureReturnCode)}");
            toStringOutput.Add($"this.TransactionLimit = {(this.TransactionLimit == null ? "null" : this.TransactionLimit.ToString())}");
            toStringOutput.Add($"this.TransactionDateLimit = {(this.TransactionDateLimit == null ? "null" : this.TransactionDateLimit.ToString())}");
        }
    }
}