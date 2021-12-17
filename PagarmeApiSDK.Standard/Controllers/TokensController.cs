// <copyright file="TokensController.cs" company="APIMatic">
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
    /// TokensController.
    /// </summary>
    internal class TokensController : BaseController, ITokensController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal TokensController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// CreateToken EndPoint.
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="request">Required parameter: Request for creating a token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public Models.GetTokenResponse CreateToken(
                string publicKey,
                Models.CreateTokenRequest request,
                string idempotencyKey = null)
        {
            Task<Models.GetTokenResponse> t = this.CreateTokenAsync(publicKey, request, idempotencyKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// CreateToken EndPoint.
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="request">Required parameter: Request for creating a token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public async Task<Models.GetTokenResponse> CreateTokenAsync(
                string publicKey,
                Models.CreateTokenRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/tokens?appId={public_key}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "public_key", publicKey },
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

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetTokenResponse>(response.Body);
        }

        /// <summary>
        /// Gets a token from its id.
        /// </summary>
        /// <param name="id">Required parameter: Token id.</param>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public Models.GetTokenResponse GetToken(
                string id,
                string publicKey)
        {
            Task<Models.GetTokenResponse> t = this.GetTokenAsync(id, publicKey);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a token from its id.
        /// </summary>
        /// <param name="id">Required parameter: Token id.</param>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public async Task<Models.GetTokenResponse> GetTokenAsync(
                string id,
                string publicKey,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/tokens/{id}?appId={public_key}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "id", id },
                { "public_key", publicKey },
            });

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.GetTokenResponse>(response.Body);
        }
    }
}