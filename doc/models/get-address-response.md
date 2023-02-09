
# Get Address Response

Response object for getting an Address

## Structure

`GetAddressResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Street` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `Complement` | `string` | Optional | - |
| `ZipCode` | `string` | Optional | - |
| `Neighborhood` | `string` | Optional | - |
| `City` | `string` | Optional | - |
| `State` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Line1` | `string` | Optional | Line 1 for address |
| `Line2` | `string` | Optional | Line 2 for address |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "street": null,
  "number": null,
  "complement": null,
  "zip_code": null,
  "neighborhood": null,
  "city": null,
  "state": null,
  "country": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "customer": null,
  "metadata": null,
  "line_1": null,
  "line_2": null,
  "deleted_at": null
}
```

