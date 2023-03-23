
# Get Shipping Response

Response object for getting the shipping data

## Structure

`GetShippingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | - |
| `Description` | `string` | Optional | - |
| `RecipientName` | `string` | Optional | - |
| `RecipientPhone` | `string` | Optional | - |
| `Address` | [`Models.GetAddressResponse`](../../doc/models/get-address-response.md) | Optional | - |
| `MaxDeliveryDate` | `DateTime?` | Optional | Data máxima de entrega |
| `EstimatedDeliveryDate` | `DateTime?` | Optional | Prazo estimado de entrega |
| `Type` | `string` | Optional | Shipping Type |

## Example (as JSON)

```json
{
  "amount": null,
  "description": null,
  "recipient_name": null,
  "recipient_phone": null,
  "address": null,
  "max_delivery_date": null,
  "estimated_delivery_date": null,
  "type": null
}
```

