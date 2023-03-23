// <copyright file="ApiException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Exceptions
{
    using APIMatic.Core.Types.Sdk;
    using PagarmeApiSDK.Standard.Http.Client;
    using PagarmeApiSDK.Standard.Http.Request;
    using PagarmeApiSDK.Standard.Http.Response;

    /// <summary>
    /// This is the base class for all exceptions that represent an error response
    /// from the server.
    /// </summary>
    public class ApiException : CoreApiException<HttpRequest, HttpResponse, HttpContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ApiException(string reason, HttpContext context = null) : base(reason, context) { }
    }
}