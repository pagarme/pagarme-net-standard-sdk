// <copyright file="GetVoucherTransactionResponse.cs" company="APIMatic">
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
    /// GetVoucherTransactionResponse.
    /// </summary>
    public class GetVoucherTransactionResponse : GetTransactionResponse
    {
        private string statementDescriptor;
        private string acquirerName;
        private string acquirerAffiliationCode;
        private string acquirerTid;
        private string acquirerNsu;
        private string acquirerAuthCode;
        private string acquirerMessage;
        private string acquirerReturnCode;
        private string operationType;
        private Models.GetCardResponse card;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "statement_descriptor", false },
            { "acquirer_name", false },
            { "acquirer_affiliation_code", false },
            { "acquirer_tid", false },
            { "acquirer_nsu", false },
            { "acquirer_auth_code", false },
            { "acquirer_message", false },
            { "acquirer_return_code", false },
            { "operation_type", false },
            { "card", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoucherTransactionResponse"/> class.
        /// </summary>
        public GetVoucherTransactionResponse()
        {
            this.TransactionType = "voucher";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoucherTransactionResponse"/> class.
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
        /// <param name="acquirerMessage">acquirer_message.</param>
        /// <param name="acquirerReturnCode">acquirer_return_code.</param>
        /// <param name="operationType">operation_type.</param>
        /// <param name="card">card.</param>
        public GetVoucherTransactionResponse(
            string transactionType = "voucher",
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
            string acquirerMessage = null,
            string acquirerReturnCode = null,
            string operationType = null,
            Models.GetCardResponse card = null)
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

            if (acquirerMessage != null)
            {
                this.AcquirerMessage = acquirerMessage;
            }

            if (acquirerReturnCode != null)
            {
                this.AcquirerReturnCode = acquirerReturnCode;
            }

            if (operationType != null)
            {
                this.OperationType = operationType;
            }

            if (card != null)
            {
                this.Card = card;
            }
        }

        /// <summary>
        /// Text that will appear on the voucher's statement
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
        /// Acquirer affiliation code
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
        /// acquirer_message
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
        /// Acquirer return code
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetVoucherTransactionResponse : ({string.Join(", ", toStringOutput)})";
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

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetVoucherTransactionResponse other &&
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
                (this.AcquirerMessage == null && other.AcquirerMessage == null ||
                 this.AcquirerMessage?.Equals(other.AcquirerMessage) == true) &&
                (this.AcquirerReturnCode == null && other.AcquirerReturnCode == null ||
                 this.AcquirerReturnCode?.Equals(other.AcquirerReturnCode) == true) &&
                (this.OperationType == null && other.OperationType == null ||
                 this.OperationType?.Equals(other.OperationType) == true) &&
                (this.Card == null && other.Card == null ||
                 this.Card?.Equals(other.Card) == true) &&
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
            toStringOutput.Add($"AcquirerMessage = {this.AcquirerMessage ?? "null"}");
            toStringOutput.Add($"AcquirerReturnCode = {this.AcquirerReturnCode ?? "null"}");
            toStringOutput.Add($"OperationType = {this.OperationType ?? "null"}");
            toStringOutput.Add($"Card = {(this.Card == null ? "null" : this.Card.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}