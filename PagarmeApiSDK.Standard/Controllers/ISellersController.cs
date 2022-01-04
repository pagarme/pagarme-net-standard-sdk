// <copyright file="ISellersController.cs" company="APIMatic">
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
    /// ISellersController.
    /// </summary>
    public interface ISellersController
    {
        /// <summary>
        /// CreateSeller EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Seller Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Models.GetSellerResponse CreateSeller(
                Models.CreateSellerRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// CreateSeller EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Seller Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Task<Models.GetSellerResponse> CreateSellerAsync(
                Models.CreateSellerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateSeller EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Update Seller model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Models.GetSellerResponse UpdateSeller(
                string id,
                Models.UpdateSellerRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateSeller EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Update Seller model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Task<Models.GetSellerResponse> UpdateSellerAsync(
                string id,
                Models.UpdateSellerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateSellerMetadata EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Models.GetSellerResponse UpdateSellerMetadata(
                string sellerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateSellerMetadata EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Task<Models.GetSellerResponse> UpdateSellerMetadataAsync(
                string sellerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetSellers EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="document">Optional parameter: Example: .</param>
        /// <param name="code">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="type">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListSellerResponse response from the API call.</returns>
        Models.ListSellerResponse GetSellers(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// GetSellers EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="document">Optional parameter: Example: .</param>
        /// <param name="code">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="type">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSellerResponse response from the API call.</returns>
        Task<Models.ListSellerResponse> GetSellersAsync(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetSellerById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Seller Id.</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Models.GetSellerResponse GetSellerById(
                string id);

        /// <summary>
        /// GetSellerById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Seller Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Task<Models.GetSellerResponse> GetSellerByIdAsync(
                string id,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteSeller EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Models.GetSellerResponse DeleteSeller(
                string sellerId,
                string idempotencyKey = null);

        /// <summary>
        /// DeleteSeller EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        Task<Models.GetSellerResponse> DeleteSellerAsync(
                string sellerId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);
    }
}