// <copyright file="ITransfersController.cs" company="APIMatic">
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
    /// ITransfersController.
    /// </summary>
    public interface ITransfersController
    {
        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        Models.ListTransfers GetTransfers();

        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        Task<Models.ListTransfers> GetTransfersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Models.GetTransfer GetTransferById(
                string transferId);

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Task<Models.GetTransfer> GetTransferByIdAsync(
                string transferId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Models.GetTransfer CreateTransfer(
                Models.CreateTransfer request);

        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Task<Models.GetTransfer> CreateTransferAsync(
                Models.CreateTransfer request,
                CancellationToken cancellationToken = default);
    }
}