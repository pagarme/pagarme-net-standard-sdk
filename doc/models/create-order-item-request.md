
# Create Order Item Request

Request for creating an order item

## Structure

`CreateOrderItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Amount |
| `Description` | `string` | Required | Description |
| `Quantity` | `int` | Required | Quantity |
| `Seller` | [`Models.CreateSellerRequest`](/doc/models/create-seller-request.md) | Optional | Item seller |
| `SellerId` | `string` | Optional | seller identificator |
| `Category` | `string` | Required | Category |
| `Code` | `string` | Optional | The item code passed by the client |

## Example (as JSON)

```json
{
  "amount": 46,
  "description": "description0",
  "quantity": 68,
  "seller": null,
  "seller_id": null,
  "category": "category2",
  "code": null
}
```

