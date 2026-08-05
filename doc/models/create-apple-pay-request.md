
# Create Apple Pay Request

The ApplePay Token Payment Request

## Structure

`CreateApplePayRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Required | The token version |
| `Data` | `string` | Required | The cryptography data |
| `Header` | [`CreateApplePayHeaderRequest`](../../doc/models/create-apple-pay-header-request.md) | Required | The ApplePay header request |
| `Signature` | `string` | Required | Detached PKCS #7 signature, Base64 encoded as string |
| `MerchantIdentifier` | `string` | Required | ApplePay Merchant identifier |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateApplePayRequest createApplePayRequest = new CreateApplePayRequest
{
    Version = "version2",
    Data = "data6",
    Header = null,
    Signature = "signature4",
    MerchantIdentifier = "merchant_identifier0",
};
```

