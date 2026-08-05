
# Get Phone Number Response

Response object for getting an PhoneNumberResponse

## Structure

`GetPhoneNumberResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ddd` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `Type` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPhoneNumberResponse getPhoneNumberResponse = new GetPhoneNumberResponse
{
    Ddd = "ddd4",
    Number = "number8",
    Type = "type0",
};
```

