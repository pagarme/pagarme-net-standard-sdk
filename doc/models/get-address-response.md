
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
| `Customer` | [`GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Line1` | `string` | Optional | Line 1 for address |
| `Line2` | `string` | Optional | Line 2 for address |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetAddressResponse getAddressResponse = new GetAddressResponse
{
    Id = "id8",
    Street = "street8",
    Number = "number4",
    Complement = "complement6",
    ZipCode = "zip_code2",
};
```

