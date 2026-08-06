
# Get Register Information Address Response

Response object for getting an RegisterInformationAddress

## Structure

`GetRegisterInformationAddressResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Optional | - |
| `Complementary` | `string` | Optional | - |
| `StreetNumber` | `string` | Optional | - |
| `Neighborhood` | `string` | Optional | - |
| `City` | `string` | Optional | - |
| `State` | `string` | Optional | - |
| `ZipCode` | `string` | Optional | - |
| `ReferencePoint` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetRegisterInformationAddressResponse getRegisterInformationAddressResponse = new GetRegisterInformationAddressResponse
{
    Street = "street4",
    Complementary = "complementary6",
    StreetNumber = "street_number4",
    Neighborhood = "neighborhood0",
    City = "city4",
};
```

