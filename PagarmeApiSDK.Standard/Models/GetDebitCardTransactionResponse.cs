// <copyright file="GetDebitCardTransactionResponse.cs" company="APIMatic">
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
    /// GetDebitCardTransactionResponse.
    /// </summary>
    public class GetDebitCardTransactionResponse : GetTransactionResponse
    {
        private string statementDescriptor;
        private string acquirerName;
        private string acquirerAffiliationCode;
        private string acquirerTid;
        private string acquirerNsu;
        private string acquirerAuthCode;
        private string operationType;
        private Models.GetCardResponse card;
        private string acquirerMessage;
        private string acquirerReturnCode;
        private string mpi;
        private string eci;
        private string authenticationType;
        private string threedAuthenticationUrl;
        private string fundingSource;
        private Models.GetRetryTransactionInformationResponse retryInfo;
        private string brandId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "statement_descriptor", false },
            { "acquirer_name", false },
            { "acquirer_affiliation_code", false },
            { "acquirer_tid", false },
            { "acquirer_nsu", false },
            { "acquirer_auth_code", false },
            { "operation_type", false },
            { "card", false },
            { "acquirer_message", false },
            { "acquirer_return_code", false },
            { "mpi", false },
            { "eci", false },
            { "authentication_type", false },
            { "threed_authentication_url", false },
            { "funding_source", false },
            { "retry_info", false },
            { "brand_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDebitCardTransactionResponse"/> class.
        /// </summary>
        public GetDebitCardTransactionResponse()
        {
            this.TransactionType = "debit_card";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDebitCardTransactionResponse"/> class.
        /// </summary>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="success">success.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="attemptCount">attempt_count.</param>
        /// <param name="maxAttempts">max_attempts.</param>
        /// <param name="splits">splits.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="id">id.</param>
        /// <param name="gatewayResponse">gateway_response.</param>
        /// <param name="antifraudResponse">antifraud_response.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="split">split.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        /// <param name="statementDescriptor">statement_descriptor.</param>
        /// <param name="acquirerName">acquirer_name.</param>
        /// <param name="acquirerAffiliationCode">acquirer_affiliation_code.</param>
        /// <param name="acquirerTid">acquirer_tid.</param>
        /// <param name="acquirerNsu">acquirer_nsu.</param>
        /// <param name="acquirerAuthCode">acquirer_auth_code.</param>
        /// <param name="operationType">operation_type.</param>
        /// <param name="card">card.</param>
        /// <param name="acquirerMessage">acquirer_message.</param>
        /// <param name="acquirerReturnCode">acquirer_return_code.</param>
        /// <param name="mpi">mpi.</param>
        /// <param name="eci">eci.</param>
        /// <param name="authenticationType">authentication_type.</param>
        /// <param name="threedAuthenticationUrl">threed_authentication_url.</param>
        /// <param name="fundingSource">funding_source.</param>
        /// <param name="retryInfo">retry_info.</param>
        /// <param name="brandId">brand_id.</param>
        public GetDebitCardTransactionResponse(
            string transactionType = "debit_card",
            string gatewayId = null,
            int? amount = null,
            string status = null,
            bool? success = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            int? attemptCount = null,
            int? maxAttempts = null,
            List<Models.GetSplitResponse> splits = null,
            DateTime? nextAttempt = null,
            string id = null,
            Models.GetGatewayResponseResponse gatewayResponse = null,
            Models.GetAntifraudResponse antifraudResponse = null,
            Dictionary<string, string> metadata = null,
            List<Models.GetSplitResponse> split = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null,
            string statementDescriptor = null,
            string acquirerName = null,
            string acquirerAffiliationCode = null,
            string acquirerTid = null,
            string acquirerNsu = null,
            string acquirerAuthCode = null,
            string operationType = null,
            Models.GetCardResponse card = null,
            string acquirerMessage = null,
            string acquirerReturnCode = null,
            string mpi = null,
            string eci = null,
            string authenticationType = null,
            string threedAuthenticationUrl = null,
            string fundingSource = null,
            Models.GetRetryTransactionInformationResponse retryInfo = null,
            string brandId = null)
            : base(
                transactionType,
                gatewayId,
                amount,
                status,
                success,
                createdAt,
                updatedAt,
                attemptCount,
                maxAttempts,
                splits,
                nextAttempt,
                id,
                gatewayResponse,
                antifraudResponse,
                metadata,
                split,
                interest,
                fine,
                maxDaysToPayPastDue)
        {

            if (statementDescriptor != null)
            {
                this.StatementDescriptor = statementDescriptor;
            }

            if (acquirerName != null)
            {
                this.AcquirerName = acquirerName;
            }

            if (acquirerAffiliationCode != null)
            {
                this.AcquirerAffiliationCode = acquirerAffiliationCode;
            }

            if (acquirerTid != null)
            {
                this.AcquirerTid = acquirerTid;
            }

            if (acquirerNsu != null)
            {
                this.AcquirerNsu = acquirerNsu;
            }

            if (acquirerAuthCode != null)
            {
                this.AcquirerAuthCode = acquirerAuthCode;
            }

            if (operationType != null)
            {
                this.OperationType = operationType;
            }

            if (card != null)
            {
                this.Card = card;
            }

            if (acquirerMessage != null)
            {
                this.AcquirerMessage = acquirerMessage;
            }

            if (acquirerReturnCode != null)
            {
                this.AcquirerReturnCode = acquirerReturnCode;
            }

            if (mpi != null)
            {
                this.Mpi = mpi;
            }

            if (eci != null)
            {
                this.Eci = eci;
            }

            if (authenticationType != null)
            {
                this.AuthenticationType = authenticationType;
            }

            if (threedAuthenticationUrl != null)
            {
                this.ThreedAuthenticationUrl = threedAuthenticationUrl;
            }

            if (fundingSource != null)
            {
                this.FundingSource = fundingSource;
            }

            if (retryInfo != null)
            {
                this.RetryInfo = retryInfo;
            }

            if (brandId != null)
            {
                this.BrandId = brandId;
            }
        }

        /// <summary>
        /// Text that will appear on the debit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor
        {
            get
            {
                return this.statementDescriptor;
            }

            set
            {
                this.shouldSerialize["statement_descriptor"] = true;
                this.statementDescriptor = value;
            }
        }

        /// <summary>
        /// Acquirer name
        /// </summary>
        [JsonProperty("acquirer_name")]
        public string AcquirerName
        {
            get
            {
                return this.acquirerName;
            }

            set
            {
                this.shouldSerialize["acquirer_name"] = true;
                this.acquirerName = value;
            }
        }

        /// <summary>
        /// Aquirer affiliation code
        /// </summary>
        [JsonProperty("acquirer_affiliation_code")]
        public string AcquirerAffiliationCode
        {
            get
            {
                return this.acquirerAffiliationCode;
            }

            set
            {
                this.shouldSerialize["acquirer_affiliation_code"] = true;
                this.acquirerAffiliationCode = value;
            }
        }

        /// <summary>
        /// Acquirer TID
        /// </summary>
        [JsonProperty("acquirer_tid")]
        public string AcquirerTid
        {
            get
            {
                return this.acquirerTid;
            }

            set
            {
                this.shouldSerialize["acquirer_tid"] = true;
                this.acquirerTid = value;
            }
        }

        /// <summary>
        /// Acquirer NSU
        /// </summary>
        [JsonProperty("acquirer_nsu")]
        public string AcquirerNsu
        {
            get
            {
                return this.acquirerNsu;
            }

            set
            {
                this.shouldSerialize["acquirer_nsu"] = true;
                this.acquirerNsu = value;
            }
        }

        /// <summary>
        /// Acquirer authorization code
        /// </summary>
        [JsonProperty("acquirer_auth_code")]
        public string AcquirerAuthCode
        {
            get
            {
                return this.acquirerAuthCode;
            }

            set
            {
                this.shouldSerialize["acquirer_auth_code"] = true;
                this.acquirerAuthCode = value;
            }
        }

        /// <summary>
        /// Operation type
        /// </summary>
        [JsonProperty("operation_type")]
        public string OperationType
        {
            get
            {
                return this.operationType;
            }

            set
            {
                this.shouldSerialize["operation_type"] = true;
                this.operationType = value;
            }
        }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card")]
        public Models.GetCardResponse Card
        {
            get
            {
                return this.card;
            }

            set
            {
                this.shouldSerialize["card"] = true;
                this.card = value;
            }
        }

        /// <summary>
        /// Acquirer message
        /// </summary>
        [JsonProperty("acquirer_message")]
        public string AcquirerMessage
        {
            get
            {
                return this.acquirerMessage;
            }

            set
            {
                this.shouldSerialize["acquirer_message"] = true;
                this.acquirerMessage = value;
            }
        }

        /// <summary>
        /// Acquirer Return Code
        /// </summary>
        [JsonProperty("acquirer_return_code")]
        public string AcquirerReturnCode
        {
            get
            {
                return this.acquirerReturnCode;
            }

            set
            {
                this.shouldSerialize["acquirer_return_code"] = true;
                this.acquirerReturnCode = value;
            }
        }

        /// <summary>
        /// Merchant Plugin
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
        /// Electronic Commerce Indicator (ECI)
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
        /// Authentication type
        /// </summary>
        [JsonProperty("authentication_type")]
        public string AuthenticationType
        {
            get
            {
                return this.authenticationType;
            }

            set
            {
                this.shouldSerialize["authentication_type"] = true;
                this.authenticationType = value;
            }
        }

        /// <summary>
        /// 3D-S Authentication Url
        /// </summary>
        [JsonProperty("threed_authentication_url")]
        public string ThreedAuthenticationUrl
        {
            get
            {
                return this.threedAuthenticationUrl;
            }

            set
            {
                this.shouldSerialize["threed_authentication_url"] = true;
                this.threedAuthenticationUrl = value;
            }
        }

        /// <summary>
        /// Identify when a card is prepaid, credit or debit.
        /// </summary>
        [JsonProperty("funding_source")]
        public string FundingSource
        {
            get
            {
                return this.fundingSource;
            }

            set
            {
                this.shouldSerialize["funding_source"] = true;
                this.fundingSource = value;
            }
        }

        /// <summary>
        /// Retry transaction information
        /// </summary>
        [JsonProperty("retry_info")]
        public Models.GetRetryTransactionInformationResponse RetryInfo
        {
            get
            {
                return this.retryInfo;
            }

            set
            {
                this.shouldSerialize["retry_info"] = true;
                this.retryInfo = value;
            }
        }

        /// <summary>
        /// Gets or sets BrandId.
        /// </summary>
        [JsonProperty("brand_id")]
        public string BrandId
        {
            get
            {
                return this.brandId;
            }

            set
            {
                this.shouldSerialize["brand_id"] = true;
                this.brandId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetDebitCardTransactionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStatementDescriptor()
        {
            this.shouldSerialize["statement_descriptor"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcquirerName()
        {
            this.shouldSerialize["acquirer_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcquirerAffiliationCode()
        {
            this.shouldSerialize["acquirer_affiliation_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcquirerTid()
        {
            this.shouldSerialize["acquirer_tid"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcquirerNsu()
        {
            this.shouldSerialize["acquirer_nsu"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcquirerAuthCode()
        {
            this.shouldSerialize["acquirer_auth_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetOperationType()
        {
            this.shouldSerialize["operation_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCard()
        {
            this.shouldSerialize["card"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcquirerMessage()
        {
            this.shouldSerialize["acquirer_message"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAcquirerReturnCode()
        {
            this.shouldSerialize["acquirer_return_code"] = false;
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
        public void UnsetAuthenticationType()
        {
            this.shouldSerialize["authentication_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetThreedAuthenticationUrl()
        {
            this.shouldSerialize["threed_authentication_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFundingSource()
        {
            this.shouldSerialize["funding_source"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRetryInfo()
        {
            this.shouldSerialize["retry_info"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBrandId()
        {
            this.shouldSerialize["brand_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatementDescriptor()
        {
            return this.shouldSerialize["statement_descriptor"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcquirerName()
        {
            return this.shouldSerialize["acquirer_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcquirerAffiliationCode()
        {
            return this.shouldSerialize["acquirer_affiliation_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcquirerTid()
        {
            return this.shouldSerialize["acquirer_tid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcquirerNsu()
        {
            return this.shouldSerialize["acquirer_nsu"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcquirerAuthCode()
        {
            return this.shouldSerialize["acquirer_auth_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOperationType()
        {
            return this.shouldSerialize["operation_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCard()
        {
            return this.shouldSerialize["card"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcquirerMessage()
        {
            return this.shouldSerialize["acquirer_message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAcquirerReturnCode()
        {
            return this.shouldSerialize["acquirer_return_code"];
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
        public bool ShouldSerializeAuthenticationType()
        {
            return this.shouldSerialize["authentication_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeThreedAuthenticationUrl()
        {
            return this.shouldSerialize["threed_authentication_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFundingSource()
        {
            return this.shouldSerialize["funding_source"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRetryInfo()
        {
            return this.shouldSerialize["retry_info"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBrandId()
        {
            return this.shouldSerialize["brand_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetDebitCardTransactionResponse other &&
                (this.StatementDescriptor == null && other.StatementDescriptor == null ||
                 this.StatementDescriptor?.Equals(other.StatementDescriptor) == true) &&
                (this.AcquirerName == null && other.AcquirerName == null ||
                 this.AcquirerName?.Equals(other.AcquirerName) == true) &&
                (this.AcquirerAffiliationCode == null && other.AcquirerAffiliationCode == null ||
                 this.AcquirerAffiliationCode?.Equals(other.AcquirerAffiliationCode) == true) &&
                (this.AcquirerTid == null && other.AcquirerTid == null ||
                 this.AcquirerTid?.Equals(other.AcquirerTid) == true) &&
                (this.AcquirerNsu == null && other.AcquirerNsu == null ||
                 this.AcquirerNsu?.Equals(other.AcquirerNsu) == true) &&
                (this.AcquirerAuthCode == null && other.AcquirerAuthCode == null ||
                 this.AcquirerAuthCode?.Equals(other.AcquirerAuthCode) == true) &&
                (this.OperationType == null && other.OperationType == null ||
                 this.OperationType?.Equals(other.OperationType) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
                (this.AcquirerMessage == null && other.AcquirerMessage == null ||
                 this.AcquirerMessage?.Equals(other.AcquirerMessage) == true) &&
                (this.AcquirerReturnCode == null && other.AcquirerReturnCode == null ||
                 this.AcquirerReturnCode?.Equals(other.AcquirerReturnCode) == true) &&
                (this.Mpi == null && other.Mpi == null ||
                 this.Mpi?.Equals(other.Mpi) == true) &&
                (this.Eci == null && other.Eci == null ||
                 this.Eci?.Equals(other.Eci) == true) &&
                (this.AuthenticationType == null && other.AuthenticationType == null ||
                 this.AuthenticationType?.Equals(other.AuthenticationType) == true) &&
                (this.ThreedAuthenticationUrl == null && other.ThreedAuthenticationUrl == null ||
                 this.ThreedAuthenticationUrl?.Equals(other.ThreedAuthenticationUrl) == true) &&
                (this.FundingSource == null && other.FundingSource == null ||
                 this.FundingSource?.Equals(other.FundingSource) == true) &&
                (this.RetryInfo == null && other.RetryInfo == null ||
                 this.RetryInfo?.Equals(other.RetryInfo) == true) &&
                (this.BrandId == null && other.BrandId == null ||
                 this.BrandId?.Equals(other.BrandId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StatementDescriptor = {this.StatementDescriptor ?? "null"}");
            toStringOutput.Add($"AcquirerName = {this.AcquirerName ?? "null"}");
            toStringOutput.Add($"AcquirerAffiliationCode = {this.AcquirerAffiliationCode ?? "null"}");
            toStringOutput.Add($"AcquirerTid = {this.AcquirerTid ?? "null"}");
            toStringOutput.Add($"AcquirerNsu = {this.AcquirerNsu ?? "null"}");
            toStringOutput.Add($"AcquirerAuthCode = {this.AcquirerAuthCode ?? "null"}");
            toStringOutput.Add($"OperationType = {this.OperationType ?? "null"}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"AcquirerMessage = {this.AcquirerMessage ?? "null"}");
            toStringOutput.Add($"AcquirerReturnCode = {this.AcquirerReturnCode ?? "null"}");
            toStringOutput.Add($"Mpi = {this.Mpi ?? "null"}");
            toStringOutput.Add($"Eci = {this.Eci ?? "null"}");
            toStringOutput.Add($"AuthenticationType = {this.AuthenticationType ?? "null"}");
            toStringOutput.Add($"ThreedAuthenticationUrl = {this.ThreedAuthenticationUrl ?? "null"}");
            toStringOutput.Add($"FundingSource = {this.FundingSource ?? "null"}");
            toStringOutput.Add($"RetryInfo = {(this.RetryInfo == null ? "null" : this.RetryInfo.ToString())}");
            toStringOutput.Add($"BrandId = {this.BrandId ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}