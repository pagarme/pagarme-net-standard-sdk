
# Get Invoice Item Response

Response object for getting an invoice item

## Structure

`GetInvoiceItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | - |
| `Description` | `string` | Optional | - |
| `PricingScheme` | [`Models.GetPricingSchemeResponse`](../../doc/models/get-pricing-scheme-response.md) | Optional | - |
| `PriceBracket` | [`Models.GetPriceBracketResponse`](../../doc/models/get-price-bracket-response.md) | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `SubscriptionItemId` | `string` | Optional | Subscription Item Id |

## Example (as JSON)

```json
{
  "amount": null,
  "description": null,
  "pricing_scheme": null,
  "price_bracket": null,
  "quantity": null,
  "name": null,
  "subscription_item_id": null
}
```

