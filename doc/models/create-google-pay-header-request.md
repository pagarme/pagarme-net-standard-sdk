
# Create Google Pay Header Request

The GooglePay header request

## Structure

`CreateGooglePayHeaderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EphemeralPublicKey` | `string` | Required | X.509 encoded key bytes, Base64 encoded as a string |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateGooglePayHeaderRequest createGooglePayHeaderRequest = new CreateGooglePayHeaderRequest
{
    EphemeralPublicKey = "ephemeral_public_key2",
};
```

