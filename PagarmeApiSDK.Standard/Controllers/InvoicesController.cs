// <copyright file="InvoicesController.cs" company="APIMatic">
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
    /// InvoicesController.
    /// </summary>
    internal class InvoicesController : BaseController, IInvoicesController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal InvoicesController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Create an Invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cycleId">Required parameter: Cycle Id.</param>
        /// <param name="request">Optional parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse CreateInvoice(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = this.CreateInvoiceAsync(subscriptionId, cycleId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create an Invoice.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cycleId">Required parameter: Cycle Id.</param>
        /// <param name="request">Optional parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> CreateInvoiceAsync(
                string subscriptionId,
                string cycleId,
                Models.CreateInvoiceRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/cycles/{cycle_id}/pay");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "cycle_id", cycleId },
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

            return ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(response.Body);
        }

        /// <summary>
        /// Gets all invoices.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code.</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id.</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id.</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range.</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status.</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range.</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range.</param>
        /// <param name="customerDocument">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListInvoicesResponse response from the API call.</returns>
        public Models.ListInvoicesResponse GetInvoices(
                int? page = null,
                int? size = null,
                string code = null,
                string customerId = null,
                string subscriptionId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string status = null,
                DateTime? dueSince = null,
                DateTime? dueUntil = null,
                string customerDocument = null)
        {
            Task<Models.ListInvoicesResponse> t = this.GetInvoicesAsync(page, size, code, customerId, subscriptionId, createdSince, createdUntil, status, dueSince, dueUntil, customerDocument);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all invoices.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for Invoice's code.</param>
        /// <param name="customerId">Optional parameter: Filter for Invoice's customer id.</param>
        /// <param name="subscriptionId">Optional parameter: Filter for Invoice's subscription id.</param>
        /// <param name="createdSince">Optional parameter: Filter for Invoice's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for Invoices creation date end range.</param>
        /// <param name="status">Optional parameter: Filter for Invoice's status.</param>
        /// <param name="dueSince">Optional parameter: Filter for Invoice's due date start range.</param>
        /// <param name="dueUntil">Optional parameter: Filter for Invoice's due date end range.</param>
        /// <param name="customerDocument">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListInvoicesResponse response from the API call.</returns>
        public async Task<Models.ListInvoicesResponse> GetInvoicesAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string customerId = null,
                string subscriptionId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string status = null,
                DateTime? dueSince = null,
                DateTime? dueUntil = null,
                string customerDocument = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/invoices");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "customer_id", customerId },
                { "subscription_id", subscriptionId },
                { "created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "status", status },
                { "due_since", dueSince.HasValue ? dueSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "due_until", dueUntil.HasValue ? dueUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "customer_document", customerDocument },
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

            return ApiHelper.JsonDeserialize<Models.ListInvoicesResponse>(response.Body);
        }

        /// <summary>
        /// Cancels an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse CancelInvoice(
                string invoiceId,
                string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = this.CancelInvoiceAsync(invoiceId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Cancels an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> CancelInvoiceAsync(
                string invoiceId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/invoices/{invoice_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(response.Body);
        }

        /// <summary>
        /// Updates the metadata from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id.</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse UpdateInvoiceMetadata(
                string invoiceId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = this.UpdateInvoiceMetadataAsync(invoiceId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id.</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> UpdateInvoiceMetadataAsync(
                string invoiceId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/invoices/{invoice_id}/metadata");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId },
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

            return ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(response.Body);
        }

        /// <summary>
        /// GetPartialInvoice EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse GetPartialInvoice(
                string subscriptionId)
        {
            Task<Models.GetInvoiceResponse> t = this.GetPartialInvoiceAsync(subscriptionId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetPartialInvoice EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> GetPartialInvoiceAsync(
                string subscriptionId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/partial-invoice");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
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

            return ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(response.Body);
        }

        /// <summary>
        /// Updates the status from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse UpdateInvoiceStatus(
                string invoiceId,
                Models.UpdateInvoiceStatusRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetInvoiceResponse> t = this.UpdateInvoiceStatusAsync(invoiceId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the status from an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> UpdateInvoiceStatusAsync(
                string invoiceId,
                Models.UpdateInvoiceStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/invoices/{invoice_id}/status");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId },
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

            return ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(response.Body);
        }

        /// <summary>
        /// Gets an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public Models.GetInvoiceResponse GetInvoice(
                string invoiceId)
        {
            Task<Models.GetInvoiceResponse> t = this.GetInvoiceAsync(invoiceId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets an invoice.
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetInvoiceResponse response from the API call.</returns>
        public async Task<Models.GetInvoiceResponse> GetInvoiceAsync(
                string invoiceId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/invoices/{invoice_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "invoice_id", invoiceId },
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

            return ApiHelper.JsonDeserialize<Models.GetInvoiceResponse>(response.Body);
        }
    }
}