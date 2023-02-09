
# Get Checkout Credit Card Payment Response

## Structure

`GetCheckoutCreditCardPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Descrição na fatura |
| `Installments` | [`List<Models.GetCheckoutCardInstallmentOptionsResponse>`](../../doc/models/get-checkout-card-installment-options-response.md) | Optional | Parcelas |
| `Authentication` | [`Models.GetPaymentAuthenticationResponse`](../../doc/models/get-payment-authentication-response.md) | Optional | Payment Authentication response |

## Example (as JSON)

```json
{
  "statementDescriptor": null,
  "installments": null,
  "authentication": null
}
```

