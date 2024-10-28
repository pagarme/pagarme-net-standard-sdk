// <copyright file="TransfersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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
using PagarmeApiSDK.Standard.Http.Client;
using PagarmeApiSDK.Standard.Utilities;
using System.Net.Http;

namespace PagarmeApiSDK.Standard.Controllers
{
    /// <summary>
    /// TransfersController.
    /// </summary>
    internal class TransfersController : BaseController, ITransfersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransfersController"/> class.
        /// </summary>
        internal TransfersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public Models.GetTransfer GetTransferById(
                string transferId)
            => CoreHelper.RunTask(GetTransferByIdAsync(transferId));

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public async Task<Models.GetTransfer> GetTransferByIdAsync(
                string transferId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTransfer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transfers/{transfer_id}")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transfer_id", transferId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        public Models.ListTransfers GetTransfers()
            => CoreHelper.RunTask(GetTransfersAsync());

        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        public async Task<Models.ListTransfers> GetTransfersAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListTransfers>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transfers")
                  .WithAuth("httpBasic"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public Models.GetTransfer CreateTransfer(
                Models.CreateTransfer request)
            => CoreHelper.RunTask(CreateTransferAsync(request));

        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public async Task<Models.GetTransfer> CreateTransferAsync(
                Models.CreateTransfer request,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTransfer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transfers/recipients")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}