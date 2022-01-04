// <copyright file="ChargesController.cs" company="APIMatic">
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
    /// ChargesController.
    /// </summary>
    internal class ChargesController : BaseController, IChargesController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal ChargesController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Updates the metadata from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargeMetadata(
                string chargeId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.UpdateChargeMetadataAsync(chargeId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id.</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargeMetadataAsync(
                string chargeId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/Charges/{charge_id}/metadata");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// Updates a charge's payment method.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargePaymentMethod(
                string chargeId,
                Models.UpdateChargePaymentMethodRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.UpdateChargePaymentMethodAsync(chargeId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a charge's payment method.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargePaymentMethodAsync(
                string chargeId,
                Models.UpdateChargePaymentMethodRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}/payment-method");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// Updates the card from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating a charge's card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargeCard(
                string chargeId,
                Models.UpdateChargeCardRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.UpdateChargeCardAsync(chargeId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the card from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Required parameter: Request for updating a charge's card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargeCardAsync(
                string chargeId,
                Models.UpdateChargeCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}/card");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// GetChargesSummary EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargesSummaryResponse response from the API call.</returns>
        public Models.GetChargesSummaryResponse GetChargesSummary(
                string status,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.GetChargesSummaryResponse> t = this.GetChargesSummaryAsync(status, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetChargesSummary EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargesSummaryResponse response from the API call.</returns>
        public async Task<Models.GetChargesSummaryResponse> GetChargesSummaryAsync(
                string status,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/summary");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "status", status },
                { "created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargesSummaryResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new charge.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse CreateCharge(
                Models.CreateChargeRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.CreateChargeAsync(request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new charge.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> CreateChargeAsync(
                Models.CreateChargeRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/Charges");

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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// GetChargeTransactions EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListChargeTransactionsResponse response from the API call.</returns>
        public Models.ListChargeTransactionsResponse GetChargeTransactions(
                string chargeId,
                int? page = null,
                int? size = null)
        {
            Task<Models.ListChargeTransactionsResponse> t = this.GetChargeTransactionsAsync(chargeId, page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetChargeTransactions EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListChargeTransactionsResponse response from the API call.</returns>
        public async Task<Models.ListChargeTransactionsResponse> GetChargeTransactionsAsync(
                string chargeId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}/transactions");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ListChargeTransactionsResponse>(response.Body);
        }

        /// <summary>
        /// Captures a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for capturing a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse CaptureCharge(
                string chargeId,
                Models.CreateCaptureChargeRequest request = null,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.CaptureChargeAsync(chargeId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Captures a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for capturing a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> CaptureChargeAsync(
                string chargeId,
                Models.CreateCaptureChargeRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}/capture");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// Get a charge from its id.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse GetCharge(
                string chargeId)
        {
            Task<Models.GetChargeResponse> t = this.GetChargeAsync(chargeId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a charge from its id.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> GetChargeAsync(
                string chargeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// Cancel a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse CancelCharge(
                string chargeId,
                Models.CreateCancelChargeRequest request = null,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.CancelChargeAsync(chargeId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Cancel a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> CancelChargeAsync(
                string chargeId,
                Models.CreateCancelChargeRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpRequest httpRequest = this.GetClientInstance().DeleteBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// Lists all charges.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for charge's code.</param>
        /// <param name="status">Optional parameter: Filter for charge's status.</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method.</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id.</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id.</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation.</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation.</param>
        /// <returns>Returns the Models.ListChargesResponse response from the API call.</returns>
        public Models.ListChargesResponse GetCharges(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListChargesResponse> t = this.GetChargesAsync(page, size, code, status, paymentMethod, customerId, orderId, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Lists all charges.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for charge's code.</param>
        /// <param name="status">Optional parameter: Filter for charge's status.</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method.</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id.</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id.</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation.</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListChargesResponse response from the API call.</returns>
        public async Task<Models.ListChargesResponse> GetChargesAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "status", status },
                { "payment_method", paymentMethod },
                { "customer_id", customerId },
                { "order_id", orderId },
                { "created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ListChargesResponse>(response.Body);
        }

        /// <summary>
        /// ConfirmPayment EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: .</param>
        /// <param name="request">Optional parameter: Request for confirm payment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse ConfirmPayment(
                string chargeId,
                Models.CreateConfirmPaymentRequest request = null,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.ConfirmPaymentAsync(chargeId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// ConfirmPayment EndPoint.
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: .</param>
        /// <param name="request">Optional parameter: Request for confirm payment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> ConfirmPaymentAsync(
                string chargeId,
                Models.CreateConfirmPaymentRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}/confirm-payment");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// Updates the due date from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="request">Required parameter: Request for updating the due date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse UpdateChargeDueDate(
                string chargeId,
                Models.UpdateChargeDueDateRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.UpdateChargeDueDateAsync(chargeId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the due date from a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id.</param>
        /// <param name="request">Required parameter: Request for updating the due date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> UpdateChargeDueDateAsync(
                string chargeId,
                Models.UpdateChargeDueDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/Charges/{charge_id}/due-date");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }

        /// <summary>
        /// Retries a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public Models.GetChargeResponse RetryCharge(
                string chargeId,
                string idempotencyKey = null)
        {
            Task<Models.GetChargeResponse> t = this.RetryChargeAsync(chargeId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retries a charge.
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call.</returns>
        public async Task<Models.GetChargeResponse> RetryChargeAsync(
                string chargeId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/charges/{charge_id}/retry");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "charge_id", chargeId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "idempotency-key", idempotencyKey },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetChargeResponse>(response.Body);
        }
    }
}