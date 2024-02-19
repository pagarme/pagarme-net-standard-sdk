# Orders

```csharp
IOrdersController ordersController = client.OrdersController;
```

## Class Name

`OrdersController`

## Methods

* [Get Orders](../../doc/controllers/orders.md#get-orders)
* [Update Order Item](../../doc/controllers/orders.md#update-order-item)
* [Delete All Order Items](../../doc/controllers/orders.md#delete-all-order-items)
* [Delete Order Item](../../doc/controllers/orders.md#delete-order-item)
* [Close Order](../../doc/controllers/orders.md#close-order)
* [Create Order](../../doc/controllers/orders.md#create-order)
* [Create Order Item](../../doc/controllers/orders.md#create-order-item)
* [Get Order Item](../../doc/controllers/orders.md#get-order-item)
* [Update Order Metadata](../../doc/controllers/orders.md#update-order-metadata)
* [Get Order](../../doc/controllers/orders.md#get-order)


# Get Orders

Gets all orders

```csharp
GetOrdersAsync(
    int? page = null,
    int? size = null,
    string code = null,
    string status = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null,
    string customerId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Filter for order's code |
| `status` | `string` | Query, Optional | Filter for order's status |
| `createdSince` | `DateTime?` | Query, Optional | Filter for order's creation date start range |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for order's creation date end range |
| `customerId` | `string` | Query, Optional | Filter for order's customer id |

## Response Type

[`Task<Models.ListOrderResponse>`](../../doc/models/list-order-response.md)

## Example Usage

```csharp
try
{
    ListOrderResponse result = await ordersController.GetOrdersAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Order Item

```csharp
UpdateOrderItemAsync(
    string orderId,
    string itemId,
    Models.UpdateOrderItemRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `itemId` | `string` | Template, Required | Item Id |
| `request` | [`UpdateOrderItemRequest`](../../doc/models/update-order-item-request.md) | Body, Required | Item Model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
string itemId = "itemId8";
UpdateOrderItemRequest request = new UpdateOrderItemRequest
{
    Amount = 242,
    Description = "description6",
    Quantity = 100,
    Category = "category4",
};

try
{
    GetOrderItemResponse result = await ordersController.UpdateOrderItemAsync(
        orderId,
        itemId,
        request
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete All Order Items

```csharp
DeleteAllOrderItemsAsync(
    string orderId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
try
{
    GetOrderResponse result = await ordersController.DeleteAllOrderItemsAsync(orderId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Order Item

```csharp
DeleteOrderItemAsync(
    string orderId,
    string itemId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `itemId` | `string` | Template, Required | Item Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
string itemId = "itemId8";
try
{
    GetOrderItemResponse result = await ordersController.DeleteOrderItemAsync(
        orderId,
        itemId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Close Order

```csharp
CloseOrderAsync(
    string id,
    Models.UpdateOrderStatusRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Order Id |
| `request` | [`UpdateOrderStatusRequest`](../../doc/models/update-order-status-request.md) | Body, Required | Update Order Model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string id = "id0";
UpdateOrderStatusRequest request = new UpdateOrderStatusRequest
{
    Status = "status8",
};

try
{
    GetOrderResponse result = await ordersController.CloseOrderAsync(
        id,
        request
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Order

Creates a new Order

```csharp
CreateOrderAsync(
    Models.CreateOrderRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateOrderRequest`](../../doc/models/create-order-request.md) | Body, Required | Request for creating an order |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
CreateOrderRequest body = new CreateOrderRequest
{
    Items = new List<Models.CreateOrderItemRequest>
    {
        new CreateOrderItemRequest
        {
            Amount = 164,
            Description = "description2",
            Quantity = 22,
            Category = "category6",
        },
    },
    Customer = new CreateCustomerRequest
    {
        Name = "{\n    \"name\": \"Tony Stark\"\n}",
        Email = "email6",
        Document = "document6",
        Type = "type0",
        Address = new CreateAddressRequest
        {
            Street = "street6",
            Number = "number4",
            ZipCode = "zip_code0",
            Neighborhood = "neighborhood2",
            City = "city6",
            State = "state2",
            Country = "country0",
            Complement = "complement2",
            Line1 = "line_10",
            Line2 = "line_24",
        },
        Metadata = new Dictionary<string, string>
        {
            ["key0"] = "metadata3",
        },
        Phones = new CreatePhonesRequest
        {
        },
        Code = "code8",
    },
    Payments = new List<Models.CreatePaymentRequest>
    {
        new CreatePaymentRequest
        {
            PaymentMethod = "payment_method8",
        },
    },
    Code = "code4",
    Closed = true,
};

try
{
    GetOrderResponse result = await ordersController.CreateOrderAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Order Item

```csharp
CreateOrderItemAsync(
    string orderId,
    Models.CreateOrderItemRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `request` | [`CreateOrderItemRequest`](../../doc/models/create-order-item-request.md) | Body, Required | Order Item Model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
CreateOrderItemRequest request = new CreateOrderItemRequest
{
    Amount = 242,
    Description = "description6",
    Quantity = 100,
    Category = "category4",
};

try
{
    GetOrderItemResponse result = await ordersController.CreateOrderItemAsync(
        orderId,
        request
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Order Item

```csharp
GetOrderItemAsync(
    string orderId,
    string itemId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order Id |
| `itemId` | `string` | Template, Required | Item Id |

## Response Type

[`Task<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
string itemId = "itemId8";
try
{
    GetOrderItemResponse result = await ordersController.GetOrderItemAsync(
        orderId,
        itemId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Order Metadata

Updates the metadata from an order

```csharp
UpdateOrderMetadataAsync(
    string orderId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | The order id |
| `request` | [`UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the order metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string orderId = "order_id6";
UpdateMetadataRequest request = new UpdateMetadataRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetOrderResponse result = await ordersController.UpdateOrderMetadataAsync(
        orderId,
        request
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Order

Gets an order

```csharp
GetOrderAsync(
    string orderId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | Order id |

## Response Type

[`Task<Models.GetOrderResponse>`](../../doc/models/get-order-response.md)

## Example Usage

```csharp
string orderId = "order_id6";
try
{
    GetOrderResponse result = await ordersController.GetOrderAsync(orderId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

