// <copyright file="IPayablesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Http.Client;
using PagarmeApiSDK.Standard.Http.Request;
using PagarmeApiSDK.Standard.Http.Response;
using PagarmeApiSDK.Standard.Utilities;

namespace PagarmeApiSDK.Standard.Controllers
{
    /// <summary>
    /// IPayablesController.
    /// </summary>
    public interface IPayablesController
    {
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
        Models.ListPayablesResponse GetPayables(
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
                long? gatewayId = null);

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
        Task<Models.ListPayablesResponse> GetPayablesAsync(
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
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetPayableById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetPayableResponse response from the API call.</returns>
        Models.GetPayableResponse GetPayableById(
                long id);

        /// <summary>
        /// GetPayableById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPayableResponse response from the API call.</returns>
        Task<Models.GetPayableResponse> GetPayableByIdAsync(
                long id,
                CancellationToken cancellationToken = default);
    }
}