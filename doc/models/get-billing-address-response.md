
# Get Billing Address Response

Response object for getting a billing address

## Structure

`GetBillingAddressResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `ZipCode` | `string` | Optional | - |
| `Neighborhood` | `string` | Optional | - |
| `City` | `string` | Optional | - |
| `State` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Complement` | `string` | Optional | - |
| `Line1` | `string` | Optional | Line 1 for address |
| `Line2` | `string` | Optional | Line 2 for address |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetBillingAddressResponse getBillingAddressResponse = new GetBillingAddressResponse
{
    Street = "street8",
    Number = "number4",
    ZipCode = "zip_code2",
    Neighborhood = "neighborhood4",
    City = "city8",
};
```

