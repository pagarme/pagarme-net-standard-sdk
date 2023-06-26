// <copyright file="IBalanceOperationsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Controllers
{
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

    /// <summary>
    /// IBalanceOperationsController.
    /// </summary>
    public interface IBalanceOperationsController
    {
        /// <summary>
        /// GetBalanceOperations EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Required parameter: Example: .</param>
        /// <param name="createdUntil">Required parameter: Example: .</param>
        void GetBalanceOperations(
                string status,
                DateTime createdSince,
                DateTime createdUntil);

        /// <summary>
        /// GetBalanceOperations EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Required parameter: Example: .</param>
        /// <param name="createdUntil">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        Task GetBalanceOperationsAsync(
                string status,
                DateTime createdSince,
                DateTime createdUntil,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetBalanceOperationById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        void GetBalanceOperationById(
                string id);

        /// <summary>
        /// GetBalanceOperationById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        Task GetBalanceOperationByIdAsync(
                string id,
                CancellationToken cancellationToken = default);
    }
}