
# Create Phones Request

## Structure

`CreatePhonesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HomePhone` | [`CreatePhoneRequest`](../../doc/models/create-phone-request.md) | Optional | - |
| `MobilePhone` | [`CreatePhoneRequest`](../../doc/models/create-phone-request.md) | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreatePhonesRequest createPhonesRequest = new CreatePhonesRequest
{
    HomePhone = null,
    MobilePhone = null,
};
```

