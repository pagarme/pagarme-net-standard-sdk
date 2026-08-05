
# Create Checkout Credit Card Payment Request

Checkout card payment request

## Structure

`CreateCheckoutCreditCardPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Card invoice text descriptor |
| `Installments` | [`List<CreateCheckoutCardInstallmentOptionRequest>`](../../doc/models/create-checkout-card-installment-option-request.md) | Optional | Payment installment options |
| `Authentication` | [`CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Optional | Creates payment authentication |
| `Capture` | `bool?` | Optional | Authorize and capture? |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateCheckoutCreditCardPaymentRequest createCheckoutCreditCardPaymentRequest = new CreateCheckoutCreditCardPaymentRequest
{
    StatementDescriptor = "statement_descriptor8",
    Installments = new List<CreateCheckoutCardInstallmentOptionRequest>
    {
        null,
        new CreateCheckoutCardInstallmentOptionRequest
        {
            Number = 0,
            Total = 0,
        },
    },
    Authentication = null,
    Capture = false,
};
```

