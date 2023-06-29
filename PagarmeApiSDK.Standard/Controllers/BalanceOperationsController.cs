// <copyright file="BalanceOperationsController.cs" company="APIMatic">
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
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Authentication;
    using PagarmeApiSDK.Standard.Http.Client;
    using PagarmeApiSDK.Standard.Utilities;
    using System.Net.Http;

    /// <summary>
    /// BalanceOperationsController.
    /// </summary>
    internal class BalanceOperationsController : BaseController, IBalanceOperationsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceOperationsController"/> class.
        /// </summary>
        internal BalanceOperationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// GetBalanceOperations EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Required parameter: Example: .</param>
        /// <param name="createdUntil">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ListBalanceOperationResponse response from the API call.</returns>
        public Models.ListBalanceOperationResponse GetBalanceOperations(
                string status,
                DateTime createdSince,
                DateTime createdUntil)
            => CoreHelper.RunTask(GetBalanceOperationsAsync(status, createdSince, createdUntil));

        /// <summary>
        /// GetBalanceOperations EndPoint.
        /// </summary>
        /// <param name="status">Required parameter: Example: .</param>
        /// <param name="createdSince">Required parameter: Example: .</param>
        /// <param name="createdUntil">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListBalanceOperationResponse response from the API call.</returns>
        public async Task<Models.ListBalanceOperationResponse> GetBalanceOperationsAsync(
                string status,
                DateTime createdSince,
                DateTime createdUntil,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListBalanceOperationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/balance/operations")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("created_since", createdSince.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")))
                      .Query(_query => _query.Setup("created_until", createdUntil.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListBalanceOperationResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetBalanceOperationById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetBalanceOperationResponse response from the API call.</returns>
        public Models.GetBalanceOperationResponse GetBalanceOperationById(
                long id)
            => CoreHelper.RunTask(GetBalanceOperationByIdAsync(id));

        /// <summary>
        /// GetBalanceOperationById EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetBalanceOperationResponse response from the API call.</returns>
        public async Task<Models.GetBalanceOperationResponse> GetBalanceOperationByIdAsync(
                long id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetBalanceOperationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/balance/operations/{id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetBalanceOperationResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}