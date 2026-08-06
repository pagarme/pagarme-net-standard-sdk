
# Get Checkout Debit Card Payment Response

## Structure

`GetCheckoutDebitCardPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Descrição na fatura |
| `Authentication` | [`GetPaymentAuthenticationResponse`](../../doc/models/get-payment-authentication-response.md) | Optional | Payment Authentication response object data |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetCheckoutDebitCardPaymentResponse getCheckoutDebitCardPaymentResponse = new GetCheckoutDebitCardPaymentResponse
{
    StatementDescriptor = "statement_descriptor6",
    Authentication = null,
};
```

