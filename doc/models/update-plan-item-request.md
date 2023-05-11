
# Update Plan Item Request

Request for updating a plan item

## Structure

`UpdatePlanItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Item name |
| `Description` | `string` | Required | Description |
| `Status` | `string` | Required | Item status |
| `PricingScheme` | [`Models.UpdatePricingSchemeRequest`](../../doc/models/update-pricing-scheme-request.md) | Required | Pricing scheme |
| `Quantity` | `int?` | Optional | Quantity |
| `Cycles` | `int?` | Optional | Number of cycles that the item will be charged |

## Example (as JSON)

```json
{
  "name": "name0",
  "description": "description0",
  "status": "status8",
  "pricing_scheme": {
    "scheme_type": "scheme_type8",
    "price_brackets": [
      {
        "start_quantity": 119,
        "price": 57,
        "end_quantity": 127,
        "overage_price": 141
      }
    ],
    "price": 166,
    "minimum_price": 6,
    "percentage": 251.76
  },
  "quantity": 68,
  "cycles": 168
}
```

