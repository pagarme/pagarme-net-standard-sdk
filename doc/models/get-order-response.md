
# Get Order Response

Response object for getting an Order

## Structure

`GetOrderResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Code` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Items` | [`List<Models.GetOrderItemResponse>`](../../doc/models/get-order-item-response.md) | Optional | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `Charges` | [`List<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md) | Optional | - |
| `InvoiceUrl` | `string` | Optional | - |
| `Shipping` | [`Models.GetShippingResponse`](../../doc/models/get-shipping-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Checkouts` | [`List<Models.GetCheckoutPaymentResponse>`](../../doc/models/get-checkout-payment-response.md) | Optional | Checkout Payment Settings Response |
| `Ip` | `string` | Optional | Ip address |
| `SessionId` | `string` | Optional | Session id |
| `Location` | [`Models.GetLocationResponse`](../../doc/models/get-location-response.md) | Optional | Location |
| `Device` | [`Models.GetDeviceResponse`](../../doc/models/get-device-response.md) | Optional | Device's informations |
| `Closed` | `bool?` | Optional | Indicates whether the order is closed |

## Example (as JSON)

```json
{
  "id": "id0",
  "code": "code8",
  "currency": "currency0",
  "items": [
    {
      "id": "id7",
      "amount": 13,
      "description": "description7",
      "quantity": 127,
      "category": "category5"
    },
    {
      "id": "id8",
      "amount": 14,
      "description": "description8",
      "quantity": 128,
      "category": "category6"
    }
  ],
  "customer": {
    "id": "id0",
    "name": "name0",
    "email": "email6",
    "delinquent": false,
    "created_at": "2016-03-13T12:52:32.123Z"
  }
}
```

