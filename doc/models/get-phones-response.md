
# Get Phones Response

## Structure

`GetPhonesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HomePhone` | [`GetPhoneResponse`](../../doc/models/get-phone-response.md) | Optional | - |
| `MobilePhone` | [`GetPhoneResponse`](../../doc/models/get-phone-response.md) | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPhonesResponse getPhonesResponse = new GetPhonesResponse
{
    HomePhone = null,
    MobilePhone = null,
};
```

