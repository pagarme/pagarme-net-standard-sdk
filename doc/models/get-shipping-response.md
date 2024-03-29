
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
| `Address` | [`GetAddressResponse`](../../doc/models/get-address-response.md) | Optional | - |
| `MaxDeliveryDate` | `DateTime?` | Optional | Data máxima de entrega |
| `EstimatedDeliveryDate` | `DateTime?` | Optional | Prazo estimado de entrega |
| `Type` | `string` | Optional | Shipping Type |

## Example (as JSON)

```json
{
  "amount": 214,
  "description": "description8",
  "recipient_name": "recipient_name6",
  "recipient_phone": "recipient_phone0",
  "address": {
    "id": "id6",
    "street": "street6",
    "number": "number4",
    "complement": "complement2",
    "zip_code": "zip_code0"
  }
}
```

