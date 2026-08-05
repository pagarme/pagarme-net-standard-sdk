
# Create Register Information Address Request

Register Information Address

## Structure

`CreateRegisterInformationAddressRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Required | - |
| `Complementary` | `string` | Required | - |
| `StreetNumber` | `string` | Required | - |
| `Neighborhood` | `string` | Required | - |
| `City` | `string` | Required | - |
| `State` | `string` | Required | - |
| `ZipCode` | `string` | Required | - |
| `ReferencePoint` | `string` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateRegisterInformationAddressRequest createRegisterInformationAddressRequest = new CreateRegisterInformationAddressRequest
{
    Street = "street8",
    Complementary = "complementary0",
    StreetNumber = "street_number8",
    Neighborhood = "neighborhood4",
    City = "city8",
    State = "state4",
    ZipCode = "zip_code2",
    ReferencePoint = "reference_point2",
};
```

