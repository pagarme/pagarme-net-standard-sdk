
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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateDebitCardPaymentRequest createDebitCardPaymentRequest = new CreateDebitCardPaymentRequest
{
    StatementDescriptor = "statement_descriptor0",
    Card = null,
    CardId = "card_id6",
    CardToken = "card_token0",
    Recurrence = false,
};
```

