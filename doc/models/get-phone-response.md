
# Get Phone Response

## Structure

`GetPhoneResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CountryCode` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `AreaCode` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPhoneResponse getPhoneResponse = new GetPhoneResponse
{
    CountryCode = "country_code2",
    Number = "number0",
    AreaCode = "area_code2",
};
```

