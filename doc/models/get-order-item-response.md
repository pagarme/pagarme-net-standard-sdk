
# Get Order Item Response

Response object for getting an order item

## Structure

`GetOrderItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Id |
| `Amount` | `int` | Required | - |
| `Description` | `string` | Required | - |
| `Quantity` | `int` | Required | - |
| `GetSellerResponse` | [`Models.GetSellerResponse`](/doc/models/get-seller-response.md) | Optional | Seller data |
| `Category` | `string` | Required | Category |
| `Code` | `string` | Required | Code |

## Example (as JSON)

```json
{
  "id": "id0",
  "amount": 46,
  "description": "description0",
  "quantity": 68,
  "GetSellerResponse": null,
  "category": "category2",
  "code": "code8"
}
```

