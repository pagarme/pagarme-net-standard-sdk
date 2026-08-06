
# Create Checkout Debit Card Payment Request

Checkout credit card payment request

## Structure

`CreateCheckoutDebitCardPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Card invoice text descriptor |
| `Authentication` | [`CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Required | Creates payment authentication |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCheckoutDebitCardPaymentRequest createCheckoutDebitCardPaymentRequest = new CreateCheckoutDebitCardPaymentRequest
{
    Authentication = null,
    StatementDescriptor = "statement_descriptor8",
};
```

