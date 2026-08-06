
# Create Phone Request

## Structure

`CreatePhoneRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CountryCode` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `AreaCode` | `string` | Optional | - |
| `Type` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreatePhoneRequest createPhoneRequest = new CreatePhoneRequest
{
    CountryCode = "country_code2",
    Number = "number4",
    AreaCode = "area_code8",
    Type = "Type8",
};
```

