// <copyright file="RecipientsController.cs" company="APIMatic">
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
    /// RecipientsController.
    /// </summary>
    internal class RecipientsController : BaseController, IRecipientsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal RecipientsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Updates a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipient(
                string recipientId,
                Models.UpdateRecipientRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetRecipientResponse> t = this.UpdateRecipientAsync(recipientId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientAsync(
                string recipientId,
                Models.UpdateRecipientRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// Creates an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Anticipation data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public Models.GetAnticipationResponse CreateAnticipation(
                string recipientId,
                Models.CreateAnticipationRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetAnticipationResponse> t = this.CreateAnticipationAsync(recipientId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Anticipation data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public async Task<Models.GetAnticipationResponse> CreateAnticipationAsync(
                string recipientId,
                Models.CreateAnticipationRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/anticipations");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetAnticipationResponse>(response.Body);
        }

        /// <summary>
        /// Gets the anticipation limits for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="timeframe">Required parameter: Timeframe.</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date.</param>
        /// <returns>Returns the Models.GetAnticipationLimitResponse response from the API call.</returns>
        public Models.GetAnticipationLimitResponse GetAnticipationLimits(
                string recipientId,
                string timeframe,
                DateTime paymentDate)
        {
            Task<Models.GetAnticipationLimitResponse> t = this.GetAnticipationLimitsAsync(recipientId, timeframe, paymentDate);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets the anticipation limits for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="timeframe">Required parameter: Timeframe.</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationLimitResponse response from the API call.</returns>
        public async Task<Models.GetAnticipationLimitResponse> GetAnticipationLimitsAsync(
                string recipientId,
                string timeframe,
                DateTime paymentDate,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/anticipation_limits");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "timeframe", timeframe },
                { "payment_date", paymentDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") },
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

            return ApiHelper.JsonDeserialize<Models.GetAnticipationLimitResponse>(response.Body);
        }

        /// <summary>
        /// Retrieves paginated recipients information.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListRecipientResponse response from the API call.</returns>
        public Models.ListRecipientResponse GetRecipients(
                int? page = null,
                int? size = null)
        {
            Task<Models.ListRecipientResponse> t = this.GetRecipientsAsync(page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves paginated recipients information.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListRecipientResponse response from the API call.</returns>
        public async Task<Models.ListRecipientResponse> GetRecipientsAsync(
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients");

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

            return ApiHelper.JsonDeserialize<Models.ListRecipientResponse>(response.Body);
        }

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipientMetadata(
                string recipientId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetRecipientResponse> t = this.UpdateRecipientMetadataAsync(recipientId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientMetadataAsync(
                string recipientId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/metadata");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// Gets a transfer.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="transferId">Required parameter: Transfer id.</param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public Models.GetTransferResponse GetTransfer(
                string recipientId,
                string transferId)
        {
            Task<Models.GetTransferResponse> t = this.GetTransferAsync(recipientId, transferId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a transfer.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="transferId">Required parameter: Transfer id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public async Task<Models.GetTransferResponse> GetTransferAsync(
                string recipientId,
                string transferId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/transfers/{transfer_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
                { "transfer_id", transferId },
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

            return ApiHelper.JsonDeserialize<Models.GetTransferResponse>(response.Body);
        }

        /// <summary>
        /// Gets an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="anticipationId">Required parameter: Anticipation id.</param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public Models.GetAnticipationResponse GetAnticipation(
                string recipientId,
                string anticipationId)
        {
            Task<Models.GetAnticipationResponse> t = this.GetAnticipationAsync(recipientId, anticipationId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets an anticipation.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="anticipationId">Required parameter: Anticipation id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAnticipationResponse response from the API call.</returns>
        public async Task<Models.GetAnticipationResponse> GetAnticipationAsync(
                string recipientId,
                string anticipationId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/anticipations/{anticipation_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
                { "anticipation_id", anticipationId },
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

            return ApiHelper.JsonDeserialize<Models.GetAnticipationResponse>(response.Body);
        }

        /// <summary>
        /// UpdateRecipientTransferSettings EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipientTransferSettings(
                string recipientId,
                Models.UpdateTransferSettingsRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetRecipientResponse> t = this.UpdateRecipientTransferSettingsAsync(recipientId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// UpdateRecipientTransferSettings EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientTransferSettingsAsync(
                string recipientId,
                Models.UpdateTransferSettingsRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/transfer-settings");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// Retrieves a paginated list of anticipations from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for anticipation status.</param>
        /// <param name="timeframe">Optional parameter: Filter for anticipation timeframe.</param>
        /// <param name="paymentDateSince">Optional parameter: Filter for start range for anticipation payment date.</param>
        /// <param name="paymentDateUntil">Optional parameter: Filter for end range for anticipation payment date.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range for anticipation creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range for anticipation creation date.</param>
        /// <returns>Returns the Models.ListAnticipationResponse response from the API call.</returns>
        public Models.ListAnticipationResponse GetAnticipations(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListAnticipationResponse> t = this.GetAnticipationsAsync(recipientId, page, size, status, timeframe, paymentDateSince, paymentDateUntil, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a paginated list of anticipations from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for anticipation status.</param>
        /// <param name="timeframe">Optional parameter: Filter for anticipation timeframe.</param>
        /// <param name="paymentDateSince">Optional parameter: Filter for start range for anticipation payment date.</param>
        /// <param name="paymentDateUntil">Optional parameter: Filter for end range for anticipation payment date.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range for anticipation creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range for anticipation creation date.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAnticipationResponse response from the API call.</returns>
        public async Task<Models.ListAnticipationResponse> GetAnticipationsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/anticipations");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "status", status },
                { "timeframe", timeframe },
                { "payment_date_since", paymentDateSince.HasValue ? paymentDateSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "payment_date_until", paymentDateUntil.HasValue ? paymentDateUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
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

            return ApiHelper.JsonDeserialize<Models.ListAnticipationResponse>(response.Body);
        }

        /// <summary>
        /// Updates the default bank account from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Bank account data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateRecipientDefaultBankAccount(
                string recipientId,
                Models.UpdateRecipientBankAccountRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetRecipientResponse> t = this.UpdateRecipientDefaultBankAccountAsync(recipientId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the default bank account from a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Bank account data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateRecipientDefaultBankAccountAsync(
                string recipientId,
                Models.UpdateRecipientBankAccountRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/default-bank-account");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// CreateWithdraw EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public Models.GetWithdrawResponse CreateWithdraw(
                string recipientId,
                Models.CreateWithdrawRequest request)
        {
            Task<Models.GetWithdrawResponse> t = this.CreateWithdrawAsync(recipientId, request);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// CreateWithdraw EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public async Task<Models.GetWithdrawResponse> CreateWithdrawAsync(
                string recipientId,
                Models.CreateWithdrawRequest request,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/withdrawals");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
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

            return ApiHelper.JsonDeserialize<Models.GetWithdrawResponse>(response.Body);
        }

        /// <summary>
        /// Get balance information for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <returns>Returns the Models.GetBalanceResponse response from the API call.</returns>
        public Models.GetBalanceResponse GetBalance(
                string recipientId)
        {
            Task<Models.GetBalanceResponse> t = this.GetBalanceAsync(recipientId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get balance information for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetBalanceResponse response from the API call.</returns>
        public async Task<Models.GetBalanceResponse> GetBalanceAsync(
                string recipientId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/balance");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetBalanceResponse>(response.Body);
        }

        /// <summary>
        /// Creates a transfer for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id.</param>
        /// <param name="request">Required parameter: Transfer data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public Models.GetTransferResponse CreateTransfer(
                string recipientId,
                Models.CreateTransferRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetTransferResponse> t = this.CreateTransferAsync(recipientId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a transfer for a recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id.</param>
        /// <param name="request">Required parameter: Transfer data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransferResponse response from the API call.</returns>
        public async Task<Models.GetTransferResponse> CreateTransferAsync(
                string recipientId,
                Models.CreateTransferRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/transfers");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetTransferResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new recipient.
        /// </summary>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse CreateRecipient(
                Models.CreateRecipientRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetRecipientResponse> t = this.CreateRecipientAsync(request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new recipient.
        /// </summary>
        /// <param name="request">Required parameter: Recipient data.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> CreateRecipientAsync(
                Models.CreateRecipientRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients");

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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse UpdateAutomaticAnticipationSettings(
                string recipientId,
                Models.UpdateAutomaticAnticipationSettingsRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetRecipientResponse> t = this.UpdateAutomaticAnticipationSettingsAsync(recipientId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates recipient metadata.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="request">Required parameter: Metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> UpdateAutomaticAnticipationSettingsAsync(
                string recipientId,
                Models.UpdateAutomaticAnticipationSettingsRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/automatic-anticipation-settings");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id.</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse GetRecipient(
                string recipientId)
        {
            Task<Models.GetRecipientResponse> t = this.GetRecipientAsync(recipientId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> GetRecipientAsync(
                string recipientId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: .</param>
        /// <param name="size">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListWithdrawals response from the API call.</returns>
        public Models.ListWithdrawals GetWithdrawals(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListWithdrawals> t = this.GetWithdrawalsAsync(recipientId, page, size, status, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="page">Optional parameter: Example: .</param>
        /// <param name="size">Optional parameter: Example: .</param>
        /// <param name="status">Optional parameter: Example: .</param>
        /// <param name="createdSince">Optional parameter: Example: .</param>
        /// <param name="createdUntil">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListWithdrawals response from the API call.</returns>
        public async Task<Models.ListWithdrawals> GetWithdrawalsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/withdrawals");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
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

            return ApiHelper.JsonDeserialize<Models.ListWithdrawals>(response.Body);
        }

        /// <summary>
        /// GetWithdrawById EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="withdrawalId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public Models.GetWithdrawResponse GetWithdrawById(
                string recipientId,
                string withdrawalId)
        {
            Task<Models.GetWithdrawResponse> t = this.GetWithdrawByIdAsync(recipientId, withdrawalId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetWithdrawById EndPoint.
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: .</param>
        /// <param name="withdrawalId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetWithdrawResponse response from the API call.</returns>
        public async Task<Models.GetWithdrawResponse> GetWithdrawByIdAsync(
                string recipientId,
                string withdrawalId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/withdrawals/{withdrawal_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
                { "withdrawal_id", withdrawalId },
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

            return ApiHelper.JsonDeserialize<Models.GetWithdrawResponse>(response.Body);
        }

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for transfer status.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range of transfer creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range of transfer creation date.</param>
        /// <returns>Returns the Models.ListTransferResponse response from the API call.</returns>
        public Models.ListTransferResponse GetTransfers(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListTransferResponse> t = this.GetTransfersAsync(recipientId, page, size, status, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a paginated list of transfers for the recipient.
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="status">Optional parameter: Filter for transfer status.</param>
        /// <param name="createdSince">Optional parameter: Filter for start range of transfer creation date.</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range of transfer creation date.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListTransferResponse response from the API call.</returns>
        public async Task<Models.ListTransferResponse> GetTransfersAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{recipient_id}/transfers");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "recipient_id", recipientId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
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

            return ApiHelper.JsonDeserialize<Models.ListTransferResponse>(response.Body);
        }

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="code">Required parameter: Recipient code.</param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse GetRecipientByCode(
                string code)
        {
            Task<Models.GetRecipientResponse> t = this.GetRecipientByCodeAsync(code);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves recipient information.
        /// </summary>
        /// <param name="code">Required parameter: Recipient code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> GetRecipientByCodeAsync(
                string code,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/{code}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "code", code },
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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }

        /// <summary>
        /// GetDefaultRecipient EndPoint.
        /// </summary>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public Models.GetRecipientResponse GetDefaultRecipient()
        {
            Task<Models.GetRecipientResponse> t = this.GetDefaultRecipientAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetDefaultRecipient EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRecipientResponse response from the API call.</returns>
        public async Task<Models.GetRecipientResponse> GetDefaultRecipientAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recipients/default");

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

            return ApiHelper.JsonDeserialize<Models.GetRecipientResponse>(response.Body);
        }
    }
}