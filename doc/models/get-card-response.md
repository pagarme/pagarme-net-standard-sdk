
# Get Card Response

Response object for getting a credit card

## Structure

`GetCardResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `LastFourDigits` | `string` | Optional | - |
| `Brand` | `string` | Optional | - |
| `HolderName` | `string` | Optional | - |
| `ExpMonth` | `int?` | Optional | - |
| `ExpYear` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `BillingAddress` | [`Models.GetBillingAddressResponse`](../../doc/models/get-billing-address-response.md) | Optional | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Type` | `string` | Optional | Card type |
| `HolderDocument` | `string` | Optional | Document number for the card's holder |
| `DeletedAt` | `DateTime?` | Optional | - |
| `FirstSixDigits` | `string` | Optional | First six digits |
| `Label` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "last_four_digits": "last_four_digits6",
  "brand": "brand4",
  "holder_name": "holder_name4",
  "exp_month": 42
}
```

