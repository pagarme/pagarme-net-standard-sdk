
# Get Payment Authentication Response

Payment Authentication response

## Structure

`GetPaymentAuthenticationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | - |
| `ThreedSecure` | [`GetThreeDSecureResponse`](../../doc/models/get-three-d-secure-response.md) | Optional | 3D-S payment authentication response |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPaymentAuthenticationResponse getPaymentAuthenticationResponse = new GetPaymentAuthenticationResponse
{
    Type = "type0",
    ThreedSecure = null,
};
```

