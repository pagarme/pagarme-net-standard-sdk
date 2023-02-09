
# Get Pricing Scheme Response

Response object for getting a pricing scheme

## Structure

`GetPricingSchemeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Price` | `int?` | Optional | - |
| `SchemeType` | `string` | Optional | - |
| `PriceBrackets` | [`List<Models.GetPriceBracketResponse>`](../../doc/models/get-price-bracket-response.md) | Optional | - |
| `MinimumPrice` | `int?` | Optional | - |
| `Percentage` | `double?` | Optional | percentual value used in pricing_scheme Percent |

## Example (as JSON)

```json
{
  "price": null,
  "scheme_type": null,
  "price_brackets": null,
  "minimum_price": null,
  "percentage": null
}
```

