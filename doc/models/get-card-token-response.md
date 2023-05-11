
# Get Card Token Response

Card token data

## Structure

`GetCardTokenResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LastFourDigits` | `string` | Optional | - |
| `HolderName` | `string` | Optional | - |
| `HolderDocument` | `string` | Optional | - |
| `ExpMonth` | `int?` | Optional | - |
| `ExpYear` | `int?` | Optional | - |
| `Brand` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `Label` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "last_four_digits": "last_four_digits6",
  "holder_name": "holder_name4",
  "holder_document": "holder_document6",
  "exp_month": 42,
  "exp_year": 254
}
```

