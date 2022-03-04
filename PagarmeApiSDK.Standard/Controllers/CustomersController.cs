// <copyright file="CustomersController.cs" company="APIMatic">
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
    /// CustomersController.
    /// </summary>
    internal class CustomersController : BaseController, ICustomersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal CustomersController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Updates a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse UpdateCard(
                string customerId,
                string cardId,
                Models.UpdateCardRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetCardResponse> t = this.UpdateCardAsync(customerId, cardId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <param name="request">Required parameter: Request for updating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> UpdateCardAsync(
                string customerId,
                string cardId,
                Models.UpdateCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/cards/{card_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "card_id", cardId },
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

            return ApiHelper.JsonDeserialize<Models.GetCardResponse>(response.Body);
        }

        /// <summary>
        /// Updates an address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="request">Required parameter: Request for updating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse UpdateAddress(
                string customerId,
                string addressId,
                Models.UpdateAddressRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetAddressResponse> t = this.UpdateAddressAsync(customerId, addressId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates an address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="request">Required parameter: Request for updating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> UpdateAddressAsync(
                string customerId,
                string addressId,
                Models.UpdateAddressRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/addresses/{address_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "address_id", addressId },
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

            return ApiHelper.JsonDeserialize<Models.GetAddressResponse>(response.Body);
        }

        /// <summary>
        /// Delete a customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public Models.GetAccessTokenResponse DeleteAccessToken(
                string customerId,
                string tokenId,
                string idempotencyKey = null)
        {
            Task<Models.GetAccessTokenResponse> t = this.DeleteAccessTokenAsync(customerId, tokenId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public async Task<Models.GetAccessTokenResponse> DeleteAccessTokenAsync(
                string customerId,
                string tokenId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/access-tokens/{token_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "token_id", tokenId },
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

            return ApiHelper.JsonDeserialize<Models.GetAccessTokenResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new address for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse CreateAddress(
                string customerId,
                Models.CreateAddressRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetAddressResponse> t = this.CreateAddressAsync(customerId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new address for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating an address.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> CreateAddressAsync(
                string customerId,
                Models.CreateAddressRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/addresses");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.GetAddressResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse CreateCustomer(
                Models.CreateCustomerRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetCustomerResponse> t = this.CreateCustomerAsync(request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> CreateCustomerAsync(
                Models.CreateCustomerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers");

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

            return ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(response.Body);
        }

        /// <summary>
        /// Creates a new card for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for creating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse CreateCard(
                string customerId,
                Models.CreateCardRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetCardResponse> t = this.CreateCardAsync(customerId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new card for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for creating a card.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> CreateCardAsync(
                string customerId,
                Models.CreateCardRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/cards");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.GetCardResponse>(response.Body);
        }

        /// <summary>
        /// Get all cards from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListCardsResponse response from the API call.</returns>
        public Models.ListCardsResponse GetCards(
                string customerId,
                int? page = null,
                int? size = null)
        {
            Task<Models.ListCardsResponse> t = this.GetCardsAsync(customerId, page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get all cards from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCardsResponse response from the API call.</returns>
        public async Task<Models.ListCardsResponse> GetCardsAsync(
                string customerId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/cards");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.ListCardsResponse>(response.Body);
        }

        /// <summary>
        /// Renew a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse RenewCard(
                string customerId,
                string cardId,
                string idempotencyKey = null)
        {
            Task<Models.GetCardResponse> t = this.RenewCardAsync(customerId, cardId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Renew a card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> RenewCardAsync(
                string customerId,
                string cardId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/cards/{card_id}/renew");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "card_id", cardId },
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

            return ApiHelper.JsonDeserialize<Models.GetCardResponse>(response.Body);
        }

        /// <summary>
        /// Get a customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse GetAddress(
                string customerId,
                string addressId)
        {
            Task<Models.GetAddressResponse> t = this.GetAddressAsync(customerId, addressId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> GetAddressAsync(
                string customerId,
                string addressId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/addresses/{address_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "address_id", addressId },
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

            return ApiHelper.JsonDeserialize<Models.GetAddressResponse>(response.Body);
        }

        /// <summary>
        /// Delete a Customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public Models.GetAddressResponse DeleteAddress(
                string customerId,
                string addressId,
                string idempotencyKey = null)
        {
            Task<Models.GetAddressResponse> t = this.DeleteAddressAsync(customerId, addressId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a Customer's address.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="addressId">Required parameter: Address Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAddressResponse response from the API call.</returns>
        public async Task<Models.GetAddressResponse> DeleteAddressAsync(
                string customerId,
                string addressId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/addresses/{address_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "address_id", addressId },
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

            return ApiHelper.JsonDeserialize<Models.GetAddressResponse>(response.Body);
        }

        /// <summary>
        /// Get a Customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public Models.GetAccessTokenResponse GetAccessToken(
                string customerId,
                string tokenId)
        {
            Task<Models.GetAccessTokenResponse> t = this.GetAccessTokenAsync(customerId, tokenId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a Customer's access token.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="tokenId">Required parameter: Token Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public async Task<Models.GetAccessTokenResponse> GetAccessTokenAsync(
                string customerId,
                string tokenId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/access-tokens/{token_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "token_id", tokenId },
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

            return ApiHelper.JsonDeserialize<Models.GetAccessTokenResponse>(response.Body);
        }

        /// <summary>
        /// Updates the metadata a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id.</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse UpdateCustomerMetadata(
                string customerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetCustomerResponse> t = this.UpdateCustomerMetadataAsync(customerId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the metadata a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id.</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> UpdateCustomerMetadataAsync(
                string customerId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/Customers/{customer_id}/metadata");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(response.Body);
        }

        /// <summary>
        /// Get a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse GetCard(
                string customerId,
                string cardId)
        {
            Task<Models.GetCardResponse> t = this.GetCardAsync(customerId, cardId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="cardId">Required parameter: Card id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> GetCardAsync(
                string customerId,
                string cardId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/cards/{card_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "card_id", cardId },
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

            return ApiHelper.JsonDeserialize<Models.GetCardResponse>(response.Body);
        }

        /// <summary>
        /// Delete a Customer's access tokens.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public Models.ListAccessTokensResponse DeleteAccessTokens(
                string customerId)
        {
            Task<Models.ListAccessTokensResponse> t = this.DeleteAccessTokensAsync(customerId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a Customer's access tokens.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public async Task<Models.ListAccessTokensResponse> DeleteAccessTokensAsync(
                string customerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/access-tokens/");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.ListAccessTokensResponse>(response.Body);
        }

        /// <summary>
        /// Creates a access token for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating a access token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public Models.GetAccessTokenResponse CreateAccessToken(
                string customerId,
                Models.CreateAccessTokenRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetAccessTokenResponse> t = this.CreateAccessTokenAsync(customerId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a access token for a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="request">Required parameter: Request for creating a access token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetAccessTokenResponse response from the API call.</returns>
        public async Task<Models.GetAccessTokenResponse> CreateAccessTokenAsync(
                string customerId,
                Models.CreateAccessTokenRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/access-tokens");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.GetAccessTokenResponse>(response.Body);
        }

        /// <summary>
        /// Get all access tokens from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public Models.ListAccessTokensResponse GetAccessTokens(
                string customerId,
                int? page = null,
                int? size = null)
        {
            Task<Models.ListAccessTokensResponse> t = this.GetAccessTokensAsync(customerId, page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get all access tokens from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAccessTokensResponse response from the API call.</returns>
        public async Task<Models.ListAccessTokensResponse> GetAccessTokensAsync(
                string customerId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/access-tokens");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.ListAccessTokensResponse>(response.Body);
        }

        /// <summary>
        /// Get all Customers.
        /// </summary>
        /// <param name="name">Optional parameter: Name of the Customer.</param>
        /// <param name="document">Optional parameter: Document of the Customer.</param>
        /// <param name="page">Optional parameter: Current page the the search.</param>
        /// <param name="size">Optional parameter: Quantity pages of the search.</param>
        /// <param name="email">Optional parameter: Customer's email.</param>
        /// <param name="code">Optional parameter: Customer's code.</param>
        /// <returns>Returns the Models.ListCustomersResponse response from the API call.</returns>
        public Models.ListCustomersResponse GetCustomers(
                string name = null,
                string document = null,
                int? page = 1,
                int? size = 10,
                string email = null,
                string code = null)
        {
            Task<Models.ListCustomersResponse> t = this.GetCustomersAsync(name, document, page, size, email, code);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get all Customers.
        /// </summary>
        /// <param name="name">Optional parameter: Name of the Customer.</param>
        /// <param name="document">Optional parameter: Document of the Customer.</param>
        /// <param name="page">Optional parameter: Current page the the search.</param>
        /// <param name="size">Optional parameter: Quantity pages of the search.</param>
        /// <param name="email">Optional parameter: Customer's email.</param>
        /// <param name="code">Optional parameter: Customer's code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListCustomersResponse response from the API call.</returns>
        public async Task<Models.ListCustomersResponse> GetCustomersAsync(
                string name = null,
                string document = null,
                int? page = 1,
                int? size = 10,
                string email = null,
                string code = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "name", name },
                { "document", document },
                { "page", (page != null) ? page : 1 },
                { "size", (size != null) ? size : 10 },
                { "email", email },
                { "Code", code },
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

            return ApiHelper.JsonDeserialize<Models.ListCustomersResponse>(response.Body);
        }

        /// <summary>
        /// Updates a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for updating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse UpdateCustomer(
                string customerId,
                Models.UpdateCustomerRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetCustomerResponse> t = this.UpdateCustomerAsync(customerId, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="request">Required parameter: Request for updating a customer.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> UpdateCustomerAsync(
                string customerId,
                Models.UpdateCustomerRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(response.Body);
        }

        /// <summary>
        /// Delete a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public Models.GetCardResponse DeleteCard(
                string customerId,
                string cardId,
                string idempotencyKey = null)
        {
            Task<Models.GetCardResponse> t = this.DeleteCardAsync(customerId, cardId, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a customer's card.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cardId">Required parameter: Card Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCardResponse response from the API call.</returns>
        public async Task<Models.GetCardResponse> DeleteCardAsync(
                string customerId,
                string cardId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/cards/{card_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
                { "card_id", cardId },
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

            return ApiHelper.JsonDeserialize<Models.GetCardResponse>(response.Body);
        }

        /// <summary>
        /// Gets all adressess from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <returns>Returns the Models.ListAddressesResponse response from the API call.</returns>
        public Models.ListAddressesResponse GetAddresses(
                string customerId,
                int? page = null,
                int? size = null)
        {
            Task<Models.ListAddressesResponse> t = this.GetAddressesAsync(customerId, page, size);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all adressess from a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id.</param>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListAddressesResponse response from the API call.</returns>
        public async Task<Models.ListAddressesResponse> GetAddressesAsync(
                string customerId,
                int? page = null,
                int? size = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}/addresses");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.ListAddressesResponse>(response.Body);
        }

        /// <summary>
        /// Get a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public Models.GetCustomerResponse GetCustomer(
                string customerId)
        {
            Task<Models.GetCustomerResponse> t = this.GetCustomerAsync(customerId);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetCustomerResponse response from the API call.</returns>
        public async Task<Models.GetCustomerResponse> GetCustomerAsync(
                string customerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/customers/{customer_id}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "customer_id", customerId },
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

            return ApiHelper.JsonDeserialize<Models.GetCustomerResponse>(response.Body);
        }
    }
}