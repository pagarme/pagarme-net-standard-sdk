
# Create Debit Card Payment Request

The settings for creating a debit card payment

## Structure

`CreateDebitCardPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | The text that will be shown on the debit card's statement |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Debit card data |
| `CardId` | `string` | Optional | The debit card id |
| `CardToken` | `string` | Optional | The debit card token |
| `Recurrence` | `bool?` | Optional | Indicates a recurrence |
| `Authentication` | [`CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Optional | The payment authentication request |
| `Token` | [`CreateCardPaymentContactlessRequest`](../../doc/models/create-card-payment-contactless-request.md) | Optional | The Debit card payment token request |
| `InitiatedType` | `string` | Optional | - |
| `RecurrenceModel` | `string` | Optional | - |
| `PaymentOrigin` | [`CreatePaymentOriginRequest`](../../doc/models/create-payment-origin-request.md) | Optional | - |

## Example (as JSON)

```json
{
  "statement_descriptor": "statement_descriptor8",
  "card": {
    "number": "number6",
    "holder_name": "holder_name2",
    "exp_month": 228,
    "exp_year": 68,
    "cvv": "cvv4"
  },
  "card_id": "card_id4",
  "card_token": "card_token2",
  "recurrence": false
}
```

