
# Create Register Information Phone Request

Register Information Phone

## Structure

`CreateRegisterInformationPhoneRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ddd` | `string` | Required | - |
| `Number` | `string` | Required | - |
| `Type` | `string` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateRegisterInformationPhoneRequest createRegisterInformationPhoneRequest = new CreateRegisterInformationPhoneRequest
{
    Ddd = "ddd2",
    Number = "number0",
    Type = "type8",
};
```

