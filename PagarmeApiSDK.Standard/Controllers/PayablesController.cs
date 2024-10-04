// <copyright file="PayablesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Http.Client;
using PagarmeApiSDK.Standard.Utilities;
using System.Net.Http;

namespace PagarmeApiSDK.Standard.Controllers
{
    /// <summary>
    /// PayablesController.
    /// </summary>
    internal class PayablesController : BaseController, IPayablesController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayablesController"/> class.
        /// </summary>
        internal PayablesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// GetPayables EndPoint.
        /// </summary>
        /// <param name="type">Optional parameter: Example: .</param>
        /// <param name="splitId">Optional parameter: Example: .</param>
        /// <param name="bulkAnticipationId">Optional parameter: Example: .</param>
        /// <param name="installment">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="recipientId">Optional parameter: Example: .</param>
        /// <param name="amount">Optional parameter: Example: .</param>
        /// <param name="chargeId">Optional parameter: Example: .</param>
        /// <param name="paymentDateUntil">Optional parameter: Example: .</param>
        /// <param name="paymentDateSince">Optional parameter: Example: .</param>
        /// <param name="updatedUntil">Optional parameter: Example: .</param>
        /// <param name="updatedSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="liquidationArrangementId">Optional parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: .</param>
        /// <param name="size">Optional parameter: Example: .</param>
        /// <param name="gatewayId">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListPayablesResponse response from the API call.</returns>
        public Models.ListPayablesResponse GetPayables(
                string type = null,
                string splitId = null,
                string bulkAnticipationId = null,
                int? installment = null,
                string status = null,
                string recipientId = null,
                int? amount = null,
                string chargeId = null,
                string paymentDateUntil = null,
                DateTime? paymentDateSince = null,
                DateTime? updatedUntil = null,
                DateTime? updatedSince = null,
                DateTime? createdUntil = null,
                DateTime? createdSince = null,
                string liquidationArrangementId = null,
                int? page = null,
                int? size = null,
                long? gatewayId = null)
            => CoreHelper.RunTask(GetPayablesAsync(type, splitId, bulkAnticipationId, installment, status, recipientId, amount, chargeId, paymentDateUntil, paymentDateSince, updatedUntil, updatedSince, createdUntil, createdSince, liquidationArrangementId, page, size, gatewayId));

        /// <summary>
        /// GetPayables EndPoint.
        /// </summary>
        /// <param name="type">Optional parameter: Example: .</param>
        /// <param name="splitId">Optional parameter: Example: .</param>
        /// <param name="bulkAnticipationId">Optional parameter: Example: .</param>
        /// <param name="installment">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="recipientId">Optional parameter: Example: .</param>
        /// <param name="amount">Optional parameter: Example: .</param>
        /// <param name="chargeId">Optional parameter: Example: .</param>
        /// <param name="paymentDateUntil">Optional parameter: Example: .</param>
        /// <param name="paymentDateSince">Optional parameter: Example: .</param>
        /// <param name="updatedUntil">Optional parameter: Example: .</param>
        /// <param name="updatedSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="liquidationArrangementId">Optional parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: .</param>
        /// <param name="size">Optional parameter: Example: .</param>
        /// <param name="gatewayId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListPayablesResponse response from the API call.</returns>
        public async Task<Models.ListPayablesResponse> GetPayablesAsync(
                string type = null,
                string splitId = null,
                string bulkAnticipationId = null,
                int? installment = null,
                string status = null,
                string recipientId = null,
                int? amount = null,
                string chargeId = null,
                string paymentDateUntil = null,
                DateTime? paymentDateSince = null,
                DateTime? updatedUntil = null,
                DateTime? updatedSince = null,
                DateTime? createdUntil = null,
                DateTime? createdSince = null,
                string liquidationArrangementId = null,
                int? page = null,
                int? size = null,
                long? gatewayId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListPayablesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/payables")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("split_id", splitId))
                      .Query(_query => _query.Setup("bulk_anticipation_id", bulkAnticipationId))
                      .Query(_query => _query.Setup("installment", installment))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("recipient_id", recipientId))
                      .Query(_query => _query.Setup("amount", amount))
                      .Query(_query => _query.Setup("charge_id", chargeId))
                      .Query(_query => _query.Setup("payment_date_until", paymentDateUntil))
                      .Query(_query => _query.Setup("payment_date_since", paymentDateSince.HasValue ? paymentDateSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("updated_until", updatedUntil.HasValue ? updatedUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("updated_since", updatedSince.HasValue ? updatedSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("liquidation_arrangement_id", liquidationArrangementId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("gateway_id", gatewayId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetPayableById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetPayableResponse response from the API call.</returns>
        public Models.GetPayableResponse GetPayableById(
                long id)
            => CoreHelper.RunTask(GetPayableByIdAsync(id));

        /// <summary>
        /// GetPayableById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPayableResponse response from the API call.</returns>
        public async Task<Models.GetPayableResponse> GetPayableByIdAsync(
                long id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPayableResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/payables/{id}")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}