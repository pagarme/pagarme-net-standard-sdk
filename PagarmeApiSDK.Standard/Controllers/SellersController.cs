// <copyright file="SellersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Authentication;
    using PagarmeApiSDK.Standard.Http.Client;
    using PagarmeApiSDK.Standard.Http.Request;
    using PagarmeApiSDK.Standard.Http.Response;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// SellersController.
    /// </summary>
    internal class SellersController : BaseController, ISellersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellersController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal SellersController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// CreateSeller EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Seller Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public Models.GetSellerResponse CreateSeller(
                Models.CreateSellerRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSellerResponse> t = this.CreateSellerAsync(request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// CreateSeller EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Seller Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public async Task<Models.GetSellerResponse> CreateSellerAsync(
                Models.CreateSellerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/sellers/");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "idempotency-key", idempotencyKey },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(request);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetSellerResponse>(response.Body);
        }

        /// <summary>
        /// UpdateSellerMetadata EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public Models.GetSellerResponse UpdateSellerMetadata(
                string sellerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSellerResponse> t = this.UpdateSellerMetadataAsync(sellerId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// UpdateSellerMetadata EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public async Task<Models.GetSellerResponse> UpdateSellerMetadataAsync(
                string sellerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/sellers/{seller_id}/metadata");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "seller_id", sellerId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "idempotency-key", idempotencyKey },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(request);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PatchBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetSellerResponse>(response.Body);
        }

        /// <summary>
        /// UpdateSeller EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Update Seller model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public Models.GetSellerResponse UpdateSeller(
                string id,
                Models.UpdateSellerRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSellerResponse> t = this.UpdateSellerAsync(id, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// UpdateSeller EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Update Seller model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public async Task<Models.GetSellerResponse> UpdateSellerAsync(
                string id,
                Models.UpdateSellerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/sellers/{id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "idempotency-key", idempotencyKey },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(request);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetSellerResponse>(response.Body);
        }

        /// <summary>
        /// DeleteSeller EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public Models.GetSellerResponse DeleteSeller(
                string sellerId,
                string idempotencyKey = null)
        {
            Task<Models.GetSellerResponse> t = this.DeleteSellerAsync(sellerId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// DeleteSeller EndPoint.
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public async Task<Models.GetSellerResponse> DeleteSellerAsync(
                string sellerId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/sellers/{sellerId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "sellerId", sellerId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "idempotency-key", idempotencyKey },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Delete(queryBuilder.ToString(), headers, null);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetSellerResponse>(response.Body);
        }

        /// <summary>
        /// GetSellerById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Seller Id.</param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public Models.GetSellerResponse GetSellerById(
                string id)
        {
            Task<Models.GetSellerResponse> t = this.GetSellerByIdAsync(id);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetSellerById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Seller Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSellerResponse response from the API call.</returns>
        public async Task<Models.GetSellerResponse> GetSellerByIdAsync(
                string id,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/sellers/{id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetSellerResponse>(response.Body);
        }

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
        public Models.ListSellerResponse GetSellers(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListSellerResponse> t = this.GetSellersAsync(page, size, name, document, code, status, type, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

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
        public async Task<Models.ListSellerResponse> GetSellersAsync(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/sellers");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "name", name },
                { "document", document },
                { "code", code },
                { "status", status },
                { "type", type },
                { "created_Since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_Until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ListSellerResponse>(response.Body);
        }
    }
}
