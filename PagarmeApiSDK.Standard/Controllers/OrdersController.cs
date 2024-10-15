// <copyright file="OrdersController.cs" company="APIMatic">
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
    /// OrdersController.
    /// </summary>
    internal class OrdersController : BaseController, IOrdersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersController"/> class.
        /// </summary>
        internal OrdersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// DeleteAllOrderItems EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public Models.GetOrderResponse DeleteAllOrderItems(
                string orderId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteAllOrderItemsAsync(orderId, idempotencyKey));

        /// <summary>
        /// DeleteAllOrderItems EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public async Task<Models.GetOrderResponse> DeleteAllOrderItemsAsync(
                string orderId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/orders/{orderId}/items")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public Models.GetOrderItemResponse GetOrderItem(
                string orderId,
                string itemId)
            => CoreHelper.RunTask(GetOrderItemAsync(orderId, itemId));

        /// <summary>
        /// GetOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public async Task<Models.GetOrderItemResponse> GetOrderItemAsync(
                string orderId,
                string itemId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/orders/{orderId}/items/{itemId}")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Template(_template => _template.Setup("itemId", itemId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the metadata from an order.
        /// </summary>
        /// <param name="orderId">Required parameter: The order id.</param>
        /// <param name="request">Required parameter: Request for updating the order metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public Models.GetOrderResponse UpdateOrderMetadata(
                string orderId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateOrderMetadataAsync(orderId, request, idempotencyKey));

        /// <summary>
        /// Updates the metadata from an order.
        /// </summary>
        /// <param name="orderId">Required parameter: The order id.</param>
        /// <param name="request">Required parameter: Request for updating the order metadata.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public async Task<Models.GetOrderResponse> UpdateOrderMetadataAsync(
                string orderId,
                Models.UpdateMetadataRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/Orders/{order_id}/metadata")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("order_id", orderId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// DeleteOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public Models.GetOrderItemResponse DeleteOrderItem(
                string orderId,
                string itemId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(DeleteOrderItemAsync(orderId, itemId, idempotencyKey));

        /// <summary>
        /// DeleteOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public async Task<Models.GetOrderItemResponse> DeleteOrderItemAsync(
                string orderId,
                string itemId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/orders/{orderId}/items/{itemId}")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Template(_template => _template.Setup("itemId", itemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets an order.
        /// </summary>
        /// <param name="orderId">Required parameter: Order id.</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public Models.GetOrderResponse GetOrder(
                string orderId)
            => CoreHelper.RunTask(GetOrderAsync(orderId));

        /// <summary>
        /// Gets an order.
        /// </summary>
        /// <param name="orderId">Required parameter: Order id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public async Task<Models.GetOrderResponse> GetOrderAsync(
                string orderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/orders/{order_id}")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("order_id", orderId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for order's code.</param>
        /// <param name="status">Optional parameter: Filter for order's status.</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range.</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id.</param>
        /// <returns>Returns the Models.ListOrderResponse response from the API call.</returns>
        public Models.ListOrderResponse GetOrders(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null)
            => CoreHelper.RunTask(GetOrdersAsync(page, size, code, status, createdSince, createdUntil, customerId));

        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <param name="page">Optional parameter: Page number.</param>
        /// <param name="size">Optional parameter: Page size.</param>
        /// <param name="code">Optional parameter: Filter for order's code.</param>
        /// <param name="status">Optional parameter: Filter for order's status.</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range.</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range.</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListOrderResponse response from the API call.</returns>
        public async Task<Models.ListOrderResponse> GetOrdersAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/orders")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("size", size))
                      .Query(_query => _query.Setup("code", code))
                      .Query(_query => _query.Setup("status", status))
                      .Query(_query => _query.Setup("created_since", createdSince.HasValue ? createdSince.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("created_until", createdUntil.HasValue ? createdUntil.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("customer_id", customerId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// UpdateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="request">Required parameter: Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public Models.GetOrderItemResponse UpdateOrderItem(
                string orderId,
                string itemId,
                Models.UpdateOrderItemRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateOrderItemAsync(orderId, itemId, request, idempotencyKey));

        /// <summary>
        /// UpdateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="itemId">Required parameter: Item Id.</param>
        /// <param name="request">Required parameter: Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public async Task<Models.GetOrderItemResponse> UpdateOrderItemAsync(
                string orderId,
                string itemId,
                Models.UpdateOrderItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/orders/{orderId}/items/{itemId}")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Template(_template => _template.Setup("itemId", itemId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CloseOrder EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Update Order Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public Models.GetOrderResponse CloseOrder(
                string id,
                Models.UpdateOrderStatusRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CloseOrderAsync(id, request, idempotencyKey));

        /// <summary>
        /// CloseOrder EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Update Order Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public async Task<Models.GetOrderResponse> CloseOrderAsync(
                string id,
                Models.UpdateOrderStatusRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/orders/{id}/closed")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new Order.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public Models.GetOrderResponse CreateOrder(
                Models.CreateOrderRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateOrderAsync(body, idempotencyKey));

        /// <summary>
        /// Creates a new Order.
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderResponse response from the API call.</returns>
        public async Task<Models.GetOrderResponse> CreateOrderAsync(
                Models.CreateOrderRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/orders")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// CreateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Order Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public Models.GetOrderItemResponse CreateOrderItem(
                string orderId,
                Models.CreateOrderItemRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateOrderItemAsync(orderId, request, idempotencyKey));

        /// <summary>
        /// CreateOrderItem EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id.</param>
        /// <param name="request">Required parameter: Order Item Model.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOrderItemResponse response from the API call.</returns>
        public async Task<Models.GetOrderItemResponse> CreateOrderItemAsync(
                string orderId,
                Models.CreateOrderItemRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOrderItemResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/orders/{orderId}/items")
                  .WithAuth("httpBasic")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}