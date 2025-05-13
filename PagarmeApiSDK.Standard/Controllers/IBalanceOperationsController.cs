// <copyright file="IBalanceOperationsController.cs" company="APIMatic">
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
    /// IBalanceOperationsController.
    /// </summary>
    public interface IBalanceOperationsController
    {
        /// <summary>
        /// GetBalanceOperationById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetBalanceOperationResponse response from the API call.</returns>
        Models.GetBalanceOperationResponse GetBalanceOperationById(
                long id);

        /// <summary>
        /// GetBalanceOperationById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetBalanceOperationResponse response from the API call.</returns>
        Task<Models.GetBalanceOperationResponse> GetBalanceOperationByIdAsync(
                long id,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetBalanceOperations EndPoint.
        /// </summary>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="recipientId">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListBalanceOperationResponse response from the API call.</returns>
        Models.ListBalanceOperationResponse GetBalanceOperations(
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string recipientId = null);

        /// <summary>
        /// GetBalanceOperations EndPoint.
        /// </summary>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="recipientId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListBalanceOperationResponse response from the API call.</returns>
        Task<Models.ListBalanceOperationResponse> GetBalanceOperationsAsync(
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string recipientId = null,
                CancellationToken cancellationToken = default);
    }
}