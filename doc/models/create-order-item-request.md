
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
| `Category` | `string` | Required | Category |
| `Code` | `string` | Optional | The item code passed by the client |

## Example (as JSON)

```json
{
  "amount": 102,
  "description": "description4",
  "quantity": 216,
  "category": "category4",
  "code": "code4"
}
```

