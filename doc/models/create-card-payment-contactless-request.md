
# Create Card Payment Contactless Request

The card payment contactless request

## Structure

`CreateCardPaymentContactlessRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The authentication type |
| `ApplePay` | [`CreateApplePayRequest`](../../doc/models/create-apple-pay-request.md) | Optional | The ApplePay encrypted request |
| `GooglePay` | [`CreateGooglePayRequest`](../../doc/models/create-google-pay-request.md) | Optional | The GooglePay encrypted request |
| `Emv` | [`CreateEmvDecryptRequest`](../../doc/models/create-emv-decrypt-request.md) | Optional | The Emv encrypted request |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCardPaymentContactlessRequest createCardPaymentContactlessRequest = new CreateCardPaymentContactlessRequest
{
    Type = "type2",
    ApplePay = null,
    GooglePay = null,
    Emv = null,
};
```

