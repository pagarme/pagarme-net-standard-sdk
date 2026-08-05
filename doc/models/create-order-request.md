
# Create Order Request

Request for creating an order

## Structure

`CreateOrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<CreateOrderItemRequest>`](../../doc/models/create-order-item-request.md) | Required | Items |
| `Customer` | [`CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Required | Customer |
| `Payments` | [`List<CreatePaymentRequest>`](../../doc/models/create-payment-request.md) | Required | Payment data |
| `Code` | `string` | Required | The order code |
| `CustomerId` | `string` | Optional | The customer id |
| `Shipping` | [`CreateShippingRequest`](../../doc/models/create-shipping-request.md) | Optional | Shipping data |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `AntifraudEnabled` | `bool?` | Optional | Defines whether the order will go through anti-fraud |
| `Ip` | `string` | Optional | Ip address |
| `SessionId` | `string` | Optional | Session id |
| `Location` | [`CreateLocationRequest`](../../doc/models/create-location-request.md) | Optional | Request's location |
| `Device` | [`CreateDeviceRequest`](../../doc/models/create-device-request.md) | Optional | Device's informations |
| `Closed` | `bool` | Required | **Default**: `true` |
| `Currency` | `string` | Optional | Currency |
| `Antifraud` | [`CreateAntifraudRequest`](../../doc/models/create-antifraud-request.md) | Optional | - |
| `Submerchant` | [`CreateSubMerchantRequest`](../../doc/models/create-sub-merchant-request.md) | Optional | SubMerchant |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateOrderRequest createOrderRequest = new CreateOrderRequest
{
    Items = new List<CreateOrderItemRequest>
    {
        null,
    },
    Customer = new CreateCustomerRequest
    {
        Name = "Tony Stark",
        Email = null,
        Document = null,
        Type = null,
        Address = null,
        Metadata = null,
        Phones = null,
        Code = null,
        Gender = "gender6",
        DocumentType = "document_type8",
    },
    Payments = new List<CreatePaymentRequest>
    {
        null,
    },
    Code = null,
    Closed = true,
    CustomerId = "customer_id0",
    Shipping = null,
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata1",
        ["key1"] = "metadata2",
    },
    AntifraudEnabled = false,
    Ip = "ip6",
};
```

