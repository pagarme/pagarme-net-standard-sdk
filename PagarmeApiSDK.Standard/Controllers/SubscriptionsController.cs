// <copyright file="SubscriptionsController.cs" company="APIMatic">
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
    /// SubscriptionsController.
    /// </summary>
    internal class SubscriptionsController : BaseController, ISubscriptionsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal SubscriptionsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// RenewSubscription EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public Models.GetPeriodResponse RenewSubscription(
                string subscriptionId,
                string idempotencyKey = null)
        {
            Task<Models.GetPeriodResponse> t = this.RenewSubscriptionAsync(subscriptionId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// RenewSubscription EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public async Task<Models.GetPeriodResponse> RenewSubscriptionAsync(
                string subscriptionId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/cycles");

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

            return ApiHelper.JsonDeserialize<Models.GetPeriodResponse>(response.Body);
        }

        /// <summary>
        /// Deletes a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="discountId">Required parameter: Discount Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public Models.GetDiscountResponse DeleteDiscount(
                string subscriptionId,
                string discountId,
                string idempotencyKey = null)
        {
            Task<Models.GetDiscountResponse> t = this.DeleteDiscountAsync(subscriptionId, discountId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="discountId">Required parameter: Discount Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public async Task<Models.GetDiscountResponse> DeleteDiscountAsync(
                string subscriptionId,
                string discountId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/discounts/{discount_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "discount_id", discountId },
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

            return ApiHelper.JsonDeserialize<Models.GetDiscountResponse>(response.Body);
        }

        /// <summary>
        /// Gets all subscriptions.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for subscription's code.</param>
        /// <param name="billingType">Optional parameter: Filter for subscription's billing type.</param>
        /// <param name="customerId">Optional parameter: Filter for subscription's customer id.</param>
        /// <param name="planId">Optional parameter: Filter for subscription's plan id.</param>
        /// <param name="cardId">Optional parameter: Filter for subscription's card id.</param>
        /// <param name="status">Optional parameter: Filter for subscription's status.</param>
        /// <param name="nextBillingSince">Optional parameter: Filter for subscription's next billing date start range.</param>
        /// <param name="nextBillingUntil">Optional parameter: Filter for subscription's next billing date end range.</param>
        /// <param name="createdSince">Optional parameter: Filter for subscription's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for subscriptions creation date end range.</param>
        /// <returns>Returns the Models.ListSubscriptionsResponse response from the API call.</returns>
        public Models.ListSubscriptionsResponse GetSubscriptions(
                int? page = null,
                int? size = null,
                string code = null,
                string billingType = null,
                string customerId = null,
                string planId = null,
                string cardId = null,
                string status = null,
                DateTime? nextBillingSince = null,
                DateTime? nextBillingUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null)
        {
            Task<Models.ListSubscriptionsResponse> t = this.GetSubscriptionsAsync(page, size, code, billingType, customerId, planId, cardId, status, nextBillingSince, nextBillingUntil, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all subscriptions.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for subscription's code.</param>
        /// <param name="billingType">Optional parameter: Filter for subscription's billing type.</param>
        /// <param name="customerId">Optional parameter: Filter for subscription's customer id.</param>
        /// <param name="planId">Optional parameter: Filter for subscription's plan id.</param>
        /// <param name="cardId">Optional parameter: Filter for subscription's card id.</param>
        /// <param name="status">Optional parameter: Filter for subscription's status.</param>
        /// <param name="nextBillingSince">Optional parameter: Filter for subscription's next billing date start range.</param>
        /// <param name="nextBillingUntil">Optional parameter: Filter for subscription's next billing date end range.</param>
        /// <param name="createdSince">Optional parameter: Filter for subscription's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for subscriptions creation date end range.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSubscriptionsResponse response from the API call.</returns>
        public async Task<Models.ListSubscriptionsResponse> GetSubscriptionsAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string billingType = null,
                string customerId = null,
                string planId = null,
                string cardId = null,
                string status = null,
                DateTime? nextBillingSince = null,
                DateTime? nextBillingUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "billing_type", billingType },
                { "customer_id", customerId },
                { "plan_id", planId },
                { "card_id", cardId },
                { "status", status },
                { "next_billing_since", nextBillingSince.HasValue ? nextBillingSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "next_billing_until", nextBillingUntil.HasValue ? nextBillingUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
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

            return ApiHelper.JsonDeserialize<Models.ListSubscriptionsResponse>(response.Body);
        }

        /// <summary>
        /// GetDiscountById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="discountId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public Models.GetDiscountResponse GetDiscountById(
                string subscriptionId,
                string discountId)
        {
            Task<Models.GetDiscountResponse> t = this.GetDiscountByIdAsync(subscriptionId, discountId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetDiscountById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="discountId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public async Task<Models.GetDiscountResponse> GetDiscountByIdAsync(
                string subscriptionId,
                string discountId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/discounts/{discountId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "discountId", discountId },
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

            return ApiHelper.JsonDeserialize<Models.GetDiscountResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse CreateSubscription(
                Models.CreateSubscriptionRequest body,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.CreateSubscriptionAsync(body, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> CreateSubscriptionAsync(
                Models.CreateSubscriptionRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// GetIncrementById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="incrementId">Required parameter: The increment Id.</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public Models.GetIncrementResponse GetIncrementById(
                string subscriptionId,
                string incrementId)
        {
            Task<Models.GetIncrementResponse> t = this.GetIncrementByIdAsync(subscriptionId, incrementId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetIncrementById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="incrementId">Required parameter: The increment Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public async Task<Models.GetIncrementResponse> GetIncrementByIdAsync(
                string subscriptionId,
                string incrementId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/increments/{increment_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "increment_id", incrementId },
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

            return ApiHelper.JsonDeserialize<Models.GetIncrementResponse>(response.Body);
        }

        /// <summary>
        /// Updates the metadata from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionMetadata(
                string subscriptionId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionMetadataAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionMetadataAsync(
                string subscriptionId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/Subscriptions/{subscription_id}/metadata");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// Deletes a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="incrementId">Required parameter: Increment id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public Models.GetIncrementResponse DeleteIncrement(
                string subscriptionId,
                string incrementId,
                string idempotencyKey = null)
        {
            Task<Models.GetIncrementResponse> t = this.DeleteIncrementAsync(subscriptionId, incrementId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="incrementId">Required parameter: Increment id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public async Task<Models.GetIncrementResponse> DeleteIncrementAsync(
                string subscriptionId,
                string incrementId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/increments/{increment_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "increment_id", incrementId },
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

            return ApiHelper.JsonDeserialize<Models.GetIncrementResponse>(response.Body);
        }

        /// <summary>
        /// Gets a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse GetSubscription(
                string subscriptionId)
        {
            Task<Models.GetSubscriptionResponse> t = this.GetSubscriptionAsync(subscriptionId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> GetSubscriptionAsync(
                string subscriptionId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// UpdateLatestPeriodEndAt EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateLatestPeriodEndAt(
                string subscriptionId,
                Models.UpdateCurrentCycleEndDateRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateLatestPeriodEndAtAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// UpdateLatestPeriodEndAt EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateLatestPeriodEndAtAsync(
                string subscriptionId,
                Models.UpdateCurrentCycleEndDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/periods/latest/end-at");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// UpdateCurrentCycleStatus EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request for updating the end date of the subscription current status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        public void UpdateCurrentCycleStatus(
                string subscriptionId,
                Models.UpdateCurrentCycleStatusRequest request,
                string idempotencyKey = null)
        {
            Task t = this.UpdateCurrentCycleStatusAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// UpdateCurrentCycleStatus EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request for updating the end date of the subscription current status.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdateCurrentCycleStatusAsync(
                string subscriptionId,
                Models.UpdateCurrentCycleStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/cycle-status");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
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
        }

        /// <summary>
        /// Get Subscription Items.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: The item name.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="status">Optional parameter: The item statis.</param>
        /// <param name="description">Optional parameter: The item description.</param>
        /// <param name="createdSince">Optional parameter: Filter for item's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for item's creation date end range.</param>
        /// <returns>Returns the Models.ListSubscriptionItemsResponse response from the API call.</returns>
        public Models.ListSubscriptionItemsResponse GetSubscriptionItems(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null)
        {
            Task<Models.ListSubscriptionItemsResponse> t = this.GetSubscriptionItemsAsync(subscriptionId, page, size, name, code, status, description, createdSince, createdUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Subscription Items.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="name">Optional parameter: The item name.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="status">Optional parameter: The item statis.</param>
        /// <param name="description">Optional parameter: The item description.</param>
        /// <param name="createdSince">Optional parameter: Filter for item's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for item's creation date end range.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSubscriptionItemsResponse response from the API call.</returns>
        public async Task<Models.ListSubscriptionItemsResponse> GetSubscriptionItemsAsync(
                string subscriptionId,
                int? page = null,
                int? size = null,
                string name = null,
                string code = null,
                string status = null,
                string description = null,
                string createdSince = null,
                string createdUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "name", name },
                { "code", code },
                { "status", status },
                { "description", description },
                { "created_since", createdSince },
                { "created_until", createdUntil },
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

            return ApiHelper.JsonDeserialize<Models.ListSubscriptionItemsResponse>(response.Body);
        }

        /// <summary>
        /// Get Subscription Item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse GetSubscriptionItem(
                string subscriptionId,
                string itemId)
        {
            Task<Models.GetSubscriptionItemResponse> t = this.GetSubscriptionItemAsync(subscriptionId, itemId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Subscription Item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> GetSubscriptionItemAsync(
                string subscriptionId,
                string itemId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items/{item_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "item_id", itemId },
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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(response.Body);
        }

        /// <summary>
        /// UpdateSubscriptionAffiliationId EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionAffiliationId(
                string subscriptionId,
                Models.UpdateSubscriptionAffiliationIdRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionAffiliationIdAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// UpdateSubscriptionAffiliationId EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionAffiliationIdAsync(
                string subscriptionId,
                Models.UpdateSubscriptionAffiliationIdRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/gateway-affiliation-id");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// GetDiscounts EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <returns>Returns the Models.ListDiscountsResponse response from the API call.</returns>
        public Models.ListDiscountsResponse GetDiscounts(
                string subscriptionId,
                int page,
                int size)
        {
            Task<Models.ListDiscountsResponse> t = this.GetDiscountsAsync(subscriptionId, page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetDiscounts EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListDiscountsResponse response from the API call.</returns>
        public async Task<Models.ListDiscountsResponse> GetDiscountsAsync(
                string subscriptionId,
                int page,
                int size,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/discounts/");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
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

            return ApiHelper.JsonDeserialize<Models.ListDiscountsResponse>(response.Body);
        }

        /// <summary>
        /// Updates a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for updating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse UpdateSubscriptionItem(
                string subscriptionId,
                string itemId,
                Models.UpdateSubscriptionItemRequest body,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionItemResponse> t = this.UpdateSubscriptionItemAsync(subscriptionId, itemId, body, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for updating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> UpdateSubscriptionItemAsync(
                string subscriptionId,
                string itemId,
                Models.UpdateSubscriptionItemRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items/{item_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "item_id", itemId },
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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new Subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse CreateSubscriptionItem(
                string subscriptionId,
                Models.CreateSubscriptionItemRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionItemResponse> t = this.CreateSubscriptionItemAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new Subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a subscription item.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> CreateSubscriptionItemAsync(
                string subscriptionId,
                Models.CreateSubscriptionItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(response.Body);
        }

        /// <summary>
        /// Lists all usages from a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="mGroup">Optional parameter: Identification group in the client system.</param>
        /// <param name="usedSince">Optional parameter: Example: .</param>
        /// <param name="usedUntil">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListUsagesResponse response from the API call.</returns>
        public Models.ListUsagesResponse GetUsages(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mGroup = null,
                DateTime? usedSince = null,
                DateTime? usedUntil = null)
        {
            Task<Models.ListUsagesResponse> t = this.GetUsagesAsync(subscriptionId, itemId, page, size, code, mGroup, usedSince, usedUntil);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Lists all usages from a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Identification code in the client system.</param>
        /// <param name="mGroup">Optional parameter: Identification group in the client system.</param>
        /// <param name="usedSince">Optional parameter: Example: .</param>
        /// <param name="usedUntil">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListUsagesResponse response from the API call.</returns>
        public async Task<Models.ListUsagesResponse> GetUsagesAsync(
                string subscriptionId,
                string itemId,
                int? page = null,
                int? size = null,
                string code = null,
                string mGroup = null,
                DateTime? usedSince = null,
                DateTime? usedUntil = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items/{item_id}/usages");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "item_id", itemId },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "size", size },
                { "code", code },
                { "group", mGroup },
                { "used_since", usedSince.HasValue ? usedSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "used_until", usedUntil.HasValue ? usedUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
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

            return ApiHelper.JsonDeserialize<Models.ListUsagesResponse>(response.Body);
        }

        /// <summary>
        /// Atualização do valor mínimo da assinatura.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionMiniumPrice(
                string subscriptionId,
                Models.UpdateSubscriptionMinimumPriceRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionMiniumPriceAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Atualização do valor mínimo da assinatura.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionMiniumPriceAsync(
                string subscriptionId,
                Models.UpdateSubscriptionMinimumPriceRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/minimum_price");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// GetSubscriptionCycleById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="cycleId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public Models.GetPeriodResponse GetSubscriptionCycleById(
                string subscriptionId,
                string cycleId)
        {
            Task<Models.GetPeriodResponse> t = this.GetSubscriptionCycleByIdAsync(subscriptionId, cycleId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetSubscriptionCycleById EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="cycleId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetPeriodResponse response from the API call.</returns>
        public async Task<Models.GetPeriodResponse> GetSubscriptionCycleByIdAsync(
                string subscriptionId,
                string cycleId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/cycles/{cycleId}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "cycleId", cycleId },
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

            return ApiHelper.JsonDeserialize<Models.GetPeriodResponse>(response.Body);
        }

        /// <summary>
        /// Create Usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public Models.GetUsageResponse CreateAnUsage(
                string subscriptionId,
                string itemId,
                string idempotencyKey = null)
        {
            Task<Models.GetUsageResponse> t = this.CreateAnUsageAsync(subscriptionId, itemId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create Usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public async Task<Models.GetUsageResponse> CreateAnUsageAsync(
                string subscriptionId,
                string itemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items/{item_id}/usages");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "item_id", itemId },
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

            return ApiHelper.JsonDeserialize<Models.GetUsageResponse>(response.Body);
        }

        /// <summary>
        /// Cancels a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse CancelSubscription(
                string subscriptionId,
                Models.CreateCancelSubscriptionRequest request = null,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.CancelSubscriptionAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Cancels a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> CancelSubscriptionAsync(
                string subscriptionId,
                Models.CreateCancelSubscriptionRequest request = null,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// Deletes a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public Models.GetSubscriptionItemResponse DeleteSubscriptionItem(
                string subscriptionId,
                string subscriptionItemId,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionItemResponse> t = this.DeleteSubscriptionItemAsync(subscriptionId, subscriptionItemId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a subscription item.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionItemResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionItemResponse> DeleteSubscriptionItemAsync(
                string subscriptionId,
                string subscriptionItemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items/{subscription_item_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "subscription_item_id", subscriptionItemId },
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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionItemResponse>(response.Body);
        }

        /// <summary>
        /// GetIncrements EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListIncrementsResponse response from the API call.</returns>
        public Models.ListIncrementsResponse GetIncrements(
                string subscriptionId,
                int? page = null,
                int? size = null)
        {
            Task<Models.ListIncrementsResponse> t = this.GetIncrementsAsync(subscriptionId, page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetIncrements EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListIncrementsResponse response from the API call.</returns>
        public async Task<Models.ListIncrementsResponse> GetIncrementsAsync(
                string subscriptionId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/increments/");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
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

            return ApiHelper.JsonDeserialize<Models.ListIncrementsResponse>(response.Body);
        }

        /// <summary>
        /// Updates the boleto due days from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionDueDays(
                string subscriptionId,
                Models.UpdateSubscriptionDueDaysRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionDueDaysAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the boleto due days from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionDueDaysAsync(
                string subscriptionId,
                Models.UpdateSubscriptionDueDaysRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/boleto-due-days");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// Updates the credit card from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionCard(
                string subscriptionId,
                Models.UpdateSubscriptionCardRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionCardAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the credit card from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionCardAsync(
                string subscriptionId,
                Models.UpdateSubscriptionCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/card");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// Deletes a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="usageId">Required parameter: The usage id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public Models.GetUsageResponse DeleteUsage(
                string subscriptionId,
                string itemId,
                string usageId,
                string idempotencyKey = null)
        {
            Task<Models.GetUsageResponse> t = this.DeleteUsageAsync(subscriptionId, itemId, usageId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="itemId">Required parameter: The subscription item id.</param>
        /// <param name="usageId">Required parameter: The usage id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public async Task<Models.GetUsageResponse> DeleteUsageAsync(
                string subscriptionId,
                string itemId,
                string usageId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items/{item_id}/usages/{usage_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "item_id", itemId },
                { "usage_id", usageId },
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

            return ApiHelper.JsonDeserialize<Models.GetUsageResponse>(response.Body);
        }

        /// <summary>
        /// Creates a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a discount.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public Models.GetDiscountResponse CreateDiscount(
                string subscriptionId,
                Models.CreateDiscountRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetDiscountResponse> t = this.CreateDiscountAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a discount.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a discount.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetDiscountResponse response from the API call.</returns>
        public async Task<Models.GetDiscountResponse> CreateDiscountAsync(
                string subscriptionId,
                Models.CreateDiscountRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/discounts");

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

            return ApiHelper.JsonDeserialize<Models.GetDiscountResponse>(response.Body);
        }

        /// <summary>
        /// Updates the payment method from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionPaymentMethod(
                string subscriptionId,
                Models.UpdateSubscriptionPaymentMethodRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionPaymentMethodAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the payment method from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethodAsync(
                string subscriptionId,
                Models.UpdateSubscriptionPaymentMethodRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/payment-method");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// Creates a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a increment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public Models.GetIncrementResponse CreateIncrement(
                string subscriptionId,
                Models.CreateIncrementRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetIncrementResponse> t = this.CreateIncrementAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a increment.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id.</param>
        /// <param name="request">Required parameter: Request for creating a increment.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetIncrementResponse response from the API call.</returns>
        public async Task<Models.GetIncrementResponse> CreateIncrementAsync(
                string subscriptionId,
                Models.CreateIncrementRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/increments");

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

            return ApiHelper.JsonDeserialize<Models.GetIncrementResponse>(response.Body);
        }

        /// <summary>
        /// Creates a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for creating a usage.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public Models.GetUsageResponse CreateUsage(
                string subscriptionId,
                string itemId,
                Models.CreateUsageRequest body,
                string idempotencyKey = null)
        {
            Task<Models.GetUsageResponse> t = this.CreateUsageAsync(subscriptionId, itemId, body, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a usage.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="itemId">Required parameter: Item id.</param>
        /// <param name="body">Required parameter: Request for creating a usage.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageResponse response from the API call.</returns>
        public async Task<Models.GetUsageResponse> CreateUsageAsync(
                string subscriptionId,
                string itemId,
                Models.CreateUsageRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/items/{item_id}/usages");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "item_id", itemId },
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
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetUsageResponse>(response.Body);
        }

        /// <summary>
        /// GetSubscriptionCycles EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <returns>Returns the Models.ListCyclesResponse response from the API call.</returns>
        public Models.ListCyclesResponse GetSubscriptionCycles(
                string subscriptionId,
                string page,
                string size)
        {
            Task<Models.ListCyclesResponse> t = this.GetSubscriptionCyclesAsync(subscriptionId, page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetSubscriptionCycles EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id.</param>
        /// <param name="page">Required parameter: Page number.</param>
        /// <param name="size">Required parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCyclesResponse response from the API call.</returns>
        public async Task<Models.ListCyclesResponse> GetSubscriptionCyclesAsync(
                string subscriptionId,
                string page,
                string size,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/cycles");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
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

            return ApiHelper.JsonDeserialize<Models.ListCyclesResponse>(response.Body);
        }

        /// <summary>
        /// Updates the billing date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionBillingDate(
                string subscriptionId,
                Models.UpdateSubscriptionBillingDateRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionBillingDateAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the billing date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionBillingDateAsync(
                string subscriptionId,
                Models.UpdateSubscriptionBillingDateRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/billing-date");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// Updates the start at date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSubscriptionStartAt(
                string subscriptionId,
                Models.UpdateSubscriptionStartAtRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSubscriptionStartAtAsync(subscriptionId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the start at date from a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id.</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSubscriptionStartAtAsync(
                string subscriptionId,
                Models.UpdateSubscriptionStartAtRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/start-at");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }

        /// <summary>
        /// GetUsageReport EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="periodId">Required parameter: The period Id.</param>
        /// <returns>Returns the Models.GetUsageReportResponse response from the API call.</returns>
        public Models.GetUsageReportResponse GetUsageReport(
                string subscriptionId,
                string periodId)
        {
            Task<Models.GetUsageReportResponse> t = this.GetUsageReportAsync(subscriptionId, periodId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetUsageReport EndPoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id.</param>
        /// <param name="periodId">Required parameter: The period Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetUsageReportResponse response from the API call.</returns>
        public async Task<Models.GetUsageReportResponse> GetUsageReportAsync(
                string subscriptionId,
                string periodId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{subscription_id}/periods/{period_id}/usages/report");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "subscription_id", subscriptionId },
                { "period_id", periodId },
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

            return ApiHelper.JsonDeserialize<Models.GetUsageReportResponse>(response.Body);
        }

        /// <summary>
        /// UpdateSplitSubscription EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Subscription's id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public Models.GetSubscriptionResponse UpdateSplitSubscription(
                string id,
                Models.UpdateSubscriptionSplitRequest request)
        {
            Task<Models.GetSubscriptionResponse> t = this.UpdateSplitSubscriptionAsync(id, request);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// UpdateSplitSubscription EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Subscription's id.</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetSubscriptionResponse response from the API call.</returns>
        public async Task<Models.GetSubscriptionResponse> UpdateSplitSubscriptionAsync(
                string id,
                Models.UpdateSubscriptionSplitRequest request,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscriptions/{id}/split");

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

            return ApiHelper.JsonDeserialize<Models.GetSubscriptionResponse>(response.Body);
        }
    }
}