// <copyright file="GetThreeDSecureResponse.cs" company="APIMatic">
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
    /// GetThreeDSecureResponse.
    /// </summary>
    public class GetThreeDSecureResponse
    {
        private string mpi;
        private string eci;
        private string cavv;
        private string transactionId;
        private string successUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "mpi", false },
            { "eci", false },
            { "cavv", false },
            { "transaction_Id", false },
            { "success_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetThreeDSecureResponse"/> class.
        /// </summary>
        public GetThreeDSecureResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetThreeDSecureResponse"/> class.
        /// </summary>
        /// <param name="mpi">mpi.</param>
        /// <param name="eci">eci.</param>
        /// <param name="cavv">cavv.</param>
        /// <param name="transactionId">transaction_Id.</param>
        /// <param name="successUrl">success_url.</param>
        public GetThreeDSecureResponse(
            string mpi = null,
            string eci = null,
            string cavv = null,
            string transactionId = null,
            string successUrl = null)
        {

            if (mpi != null)
            {
                this.Mpi = mpi;
            }

            if (eci != null)
            {
                this.Eci = eci;
            }

            if (cavv != null)
            {
                this.Cavv = cavv;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

            if (successUrl != null)
            {
                this.SuccessUrl = successUrl;
            }
        }

        /// <summary>
        /// MPI Vendor
        /// </summary>
        [JsonProperty("mpi")]
        public string Mpi
        {
            get
            {
                return this.mpi;
            }

            set
            {
                this.shouldSerialize["mpi"] = true;
                this.mpi = value;
            }
        }

        /// <summary>
        /// Electronic Commerce Indicator (ECI) (Opcional)
        /// </summary>
        [JsonProperty("eci")]
        public string Eci
        {
            get
            {
                return this.eci;
            }

            set
            {
                this.shouldSerialize["eci"] = true;
                this.eci = value;
            }
        }

        /// <summary>
        /// Online payment cryptogram, definido pelo 3-D Secure.
        /// </summary>
        [JsonProperty("cavv")]
        public string Cavv
        {
            get
            {
                return this.cavv;
            }

            set
            {
                this.shouldSerialize["cavv"] = true;
                this.cavv = value;
            }
        }

        /// <summary>
        /// Identificador da transação (XID)
        /// </summary>
        [JsonProperty("transaction_Id")]
        public string TransactionId
        {
            get
            {
                return this.transactionId;
            }

            set
            {
                this.shouldSerialize["transaction_Id"] = true;
                this.transactionId = value;
            }
        }

        /// <summary>
        /// Url de redirecionamento de sucessso
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl
        {
            get
            {
                return this.successUrl;
            }

            set
            {
                this.shouldSerialize["success_url"] = true;
                this.successUrl = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetThreeDSecureResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMpi()
        {
            this.shouldSerialize["mpi"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEci()
        {
            this.shouldSerialize["eci"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCavv()
        {
            this.shouldSerialize["cavv"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransactionId()
        {
            this.shouldSerialize["transaction_Id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSuccessUrl()
        {
            this.shouldSerialize["success_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMpi()
        {
            return this.shouldSerialize["mpi"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEci()
        {
            return this.shouldSerialize["eci"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCavv()
        {
            return this.shouldSerialize["cavv"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionId()
        {
            return this.shouldSerialize["transaction_Id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSuccessUrl()
        {
            return this.shouldSerialize["success_url"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetThreeDSecureResponse other &&
                (this.Mpi == null && other.Mpi == null ||
                 this.Mpi?.Equals(other.Mpi) == true) &&
                (this.Eci == null && other.Eci == null ||
                 this.Eci?.Equals(other.Eci) == true) &&
                (this.Cavv == null && other.Cavv == null ||
                 this.Cavv?.Equals(other.Cavv) == true) &&
                (this.TransactionId == null && other.TransactionId == null ||
                 this.TransactionId?.Equals(other.TransactionId) == true) &&
                (this.SuccessUrl == null && other.SuccessUrl == null ||
                 this.SuccessUrl?.Equals(other.SuccessUrl) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Mpi = {this.Mpi ?? "null"}");
            toStringOutput.Add($"Eci = {this.Eci ?? "null"}");
            toStringOutput.Add($"Cavv = {this.Cavv ?? "null"}");
            toStringOutput.Add($"TransactionId = {this.TransactionId ?? "null"}");
            toStringOutput.Add($"SuccessUrl = {this.SuccessUrl ?? "null"}");
        }
    }
}