
# Create Address Request

Request for creating a new Address

## Structure

`CreateAddressRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Required | Street |
| `Number` | `string` | Required | Number |
| `ZipCode` | `string` | Required | The zip code containing only numbers. No special characters or spaces. |
| `Neighborhood` | `string` | Required | Neighborhood |
| `City` | `string` | Required | City |
| `State` | `string` | Required | State |
| `Country` | `string` | Required | Country. Must be entered using ISO 3166-1 alpha-2 format. See https://pt.wikipedia.org/wiki/ISO_3166-1_alfa-2 |
| `Complement` | `string` | Required | Complement |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `Line1` | `string` | Required | Line 1 for address |
| `Line2` | `string` | Required | Line 2 for address |

## Example (as JSON)

```json
{
  "street": "street6",
  "number": "number6",
  "zip_code": "zip_code0",
  "neighborhood": "neighborhood2",
  "city": "city6",
  "state": "state8",
  "country": "country0",
  "complement": "complement8",
  "metadata": {
    "key0": "metadata7"
  },
  "line_1": "line_10",
  "line_2": "line_24"
}
```

