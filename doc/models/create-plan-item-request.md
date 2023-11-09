
# Create Plan Item Request

Request for creating a plan item

## Structure

`CreatePlanItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Item name |
| `PricingScheme` | [`CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Item's pricing scheme |
| `Id` | `string` | Required | Item's id |
| `Description` | `string` | Required | Item's description |
| `Cycles` | `int?` | Optional | Number of cycles where the item will be charged |
| `Quantity` | `int?` | Optional | Quantity |

## Example (as JSON)

```json
{
  "name": "name0",
  "pricing_scheme": {
    "scheme_type": "scheme_type8",
    "price_brackets": [
      {
        "start_quantity": 144,
        "price": 174,
        "end_quantity": 152,
        "overage_price": 166
      },
      {
        "start_quantity": 144,
        "price": 174,
        "end_quantity": 152,
        "overage_price": 166
      },
      {
        "start_quantity": 144,
        "price": 174,
        "end_quantity": 152,
        "overage_price": 166
      }
    ],
    "price": 166,
    "minimum_price": 6,
    "percentage": 251.76
  },
  "id": "id0",
  "description": "description0",
  "cycles": 52,
  "quantity": 184
}
```

