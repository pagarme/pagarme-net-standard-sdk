
# Create Card Payload Request

## Structure

`CreateCardPayloadRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | - |
| `GooglePay` | [`CreateGooglePayRequest`](../../doc/models/create-google-pay-request.md) | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCardPayloadRequest createCardPayloadRequest = new CreateCardPayloadRequest
{
    Type = "type2",
    GooglePay = null,
};
```

