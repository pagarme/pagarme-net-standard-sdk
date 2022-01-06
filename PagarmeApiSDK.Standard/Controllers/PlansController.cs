// <copyright file="PlansController.cs" company="APIMatic">
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
    /// PlansController.
    /// </summary>
    internal class PlansController : BaseController, IPlansController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlansController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal PlansController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Gets a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse GetPlan(
                string planId)
        {
            Task<Models.GetPlanResponse> t = this.GetPlanAsync(planId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> GetPlanAsync(
                string planId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans/{plan_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
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

            return ApiHelper.JsonDeserialize<Models.GetPlanResponse>(response.Body);
        }

        /// <summary>
        /// Updates a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for updating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse UpdatePlan(
                string planId,
                Models.UpdatePlanRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetPlanResponse> t = this.UpdatePlanAsync(planId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for updating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> UpdatePlanAsync(
                string planId,
                Models.UpdatePlanRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans/{plan_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
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

            return ApiHelper.JsonDeserialize<Models.GetPlanResponse>(response.Body);
        }

        /// <summary>
        /// Updates the metadata from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: The plan id.</param>
        /// <param name="request">Required parameter: Request for updating the plan metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse UpdatePlanMetadata(
                string planId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetPlanResponse> t = this.UpdatePlanMetadataAsync(planId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: The plan id.</param>
        /// <param name="request">Required parameter: Request for updating the plan metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> UpdatePlanMetadataAsync(
                string planId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/Plans/{plan_id}/metadata");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
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

            return ApiHelper.JsonDeserialize<Models.GetPlanResponse>(response.Body);
        }

        /// <summary>
        /// Removes an item from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse DeletePlanItem(
                string planId,
                string planItemId,
                string idempotencyKey = null)
        {
            Task<Models.GetPlanItemResponse> t = this.DeletePlanItemAsync(planId, planItemId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Removes an item from a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> DeletePlanItemAsync(
                string planId,
                string planItemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans/{plan_id}/items/{plan_item_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
                { "plan_item_id", planItemId },
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

            return ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(response.Body);
        }

        /// <summary>
        /// Gets all plans.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: Filter for Plan's name.</param>
        /// <param name="status">Optional parameter: Filter for Plan's status.</param>
        /// <param name="billingType">Optional parameter: Filter for plan's billing type.</param>
        /// <param name="createdSince">Optional parameter: Filter for plan's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for plan's creation date end range.</param>
        /// <returns>Returns the Models.ListPlansResponse response from the API call.</returns>
        public Models.ListPlansResponse GetPlans(
                int? page = null,
                int? size = null,
                string name = null,
                string status = null,
                string billingType = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListPlansResponse> t = this.GetPlansAsync(page, size, name, status, billingType, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all plans.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: Filter for Plan's name.</param>
        /// <param name="status">Optional parameter: Filter for Plan's status.</param>
        /// <param name="billingType">Optional parameter: Filter for plan's billing type.</param>
        /// <param name="createdSince">Optional parameter: Filter for plan's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for plan's creation date end range.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListPlansResponse response from the API call.</returns>
        public async Task<Models.ListPlansResponse> GetPlansAsync(
                int? page = null,
                int? size = null,
                string name = null,
                string status = null,
                string billingType = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "name", name },
                { "status", status },
                { "billing_type", billingType },
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

            return ApiHelper.JsonDeserialize<Models.ListPlansResponse>(response.Body);
        }

        /// <summary>
        /// Gets a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse GetPlanItem(
                string planId,
                string planItemId)
        {
            Task<Models.GetPlanItemResponse> t = this.GetPlanItemAsync(planId, planItemId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> GetPlanItemAsync(
                string planId,
                string planItemId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans/{plan_id}/items/{plan_item_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
                { "plan_item_id", planItemId },
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

            return ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(response.Body);
        }

        /// <summary>
        /// Deletes a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse DeletePlan(
                string planId,
                string idempotencyKey = null)
        {
            Task<Models.GetPlanResponse> t = this.DeletePlanAsync(planId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> DeletePlanAsync(
                string planId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans/{plan_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
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

            return ApiHelper.JsonDeserialize<Models.GetPlanResponse>(response.Body);
        }

        /// <summary>
        /// Updates a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="body">Required parameter: Request for updating the plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse UpdatePlanItem(
                string planId,
                string planItemId,
                Models.UpdatePlanItemRequest body,
                string idempotencyKey = null)
        {
            Task<Models.GetPlanItemResponse> t = this.UpdatePlanItemAsync(planId, planItemId, body, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a plan item.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="planItemId">Required parameter: Plan item id.</param>
        /// <param name="body">Required parameter: Request for updating the plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> UpdatePlanItemAsync(
                string planId,
                string planItemId,
                Models.UpdatePlanItemRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans/{plan_id}/items/{plan_item_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
                { "plan_item_id", planItemId },
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
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(response.Body);
        }

        /// <summary>
        /// Adds a new item to a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for creating a plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public Models.GetPlanItemResponse CreatePlanItem(
                string planId,
                Models.CreatePlanItemRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetPlanItemResponse> t = this.CreatePlanItemAsync(planId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Adds a new item to a plan.
        /// </summary>
        /// <param name="planId">Required parameter: Plan id.</param>
        /// <param name="request">Required parameter: Request for creating a plan item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanItemResponse response from the API call.</returns>
        public async Task<Models.GetPlanItemResponse> CreatePlanItemAsync(
                string planId,
                Models.CreatePlanItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans/{plan_id}/items");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
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

            return ApiHelper.JsonDeserialize<Models.GetPlanItemResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new plan.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public Models.GetPlanResponse CreatePlan(
                Models.CreatePlanRequest body,
                string idempotencyKey = null)
        {
            Task<Models.GetPlanResponse> t = this.CreatePlanAsync(body, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new plan.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPlanResponse response from the API call.</returns>
        public async Task<Models.GetPlanResponse> CreatePlanAsync(
                Models.CreatePlanRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/plans");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "idempotency-key", idempotencyKey },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetPlanResponse>(response.Body);
        }
    }
}