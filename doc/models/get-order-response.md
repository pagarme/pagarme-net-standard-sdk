
# Get Order Response

Response object for getting an Order

## Structure

`GetOrderResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
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
  "code": null,
  "currency": null,
  "items": null,
  "customer": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "charges": null,
  "invoice_url": null,
  "shipping": null,
  "metadata": null,
  "checkouts": null,
  "ip": null,
  "session_id": null,
  "location": null,
  "device": null,
  "closed": null
}
```

