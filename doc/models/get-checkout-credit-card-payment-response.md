
# Get Checkout Credit Card Payment Response

## Structure

`GetCheckoutCreditCardPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Descrição na fatura |
| `Installments` | [`List<GetCheckoutCardInstallmentOptionsResponse>`](../../doc/models/get-checkout-card-installment-options-response.md) | Optional | Parcelas |
| `Authentication` | [`GetPaymentAuthenticationResponse`](../../doc/models/get-payment-authentication-response.md) | Optional | Payment Authentication response |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

GetCheckoutCreditCardPaymentResponse getCheckoutCreditCardPaymentResponse = new GetCheckoutCreditCardPaymentResponse
{
    StatementDescriptor = "statementDescriptor2",
    Installments = new List<GetCheckoutCardInstallmentOptionsResponse>
    {
        null,
        new GetCheckoutCardInstallmentOptionsResponse
        {
            Number = null,
            Total = null,
        },
        new GetCheckoutCardInstallmentOptionsResponse
        {
            Number = null,
            Total = null,
        },
    },
    Authentication = null,
};
```

