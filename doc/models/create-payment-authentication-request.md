
# Create Payment Authentication Request

The payment authentication request

## Structure

`CreatePaymentAuthenticationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The Authentication type |
| `ThreedSecure` | [`CreateThreeDSecureRequest`](../../doc/models/create-three-d-secure-request.md) | Required | The 3D-S authentication object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreatePaymentAuthenticationRequest createPaymentAuthenticationRequest = new CreatePaymentAuthenticationRequest
{
    Type = "type6",
    ThreedSecure = null,
};
```

