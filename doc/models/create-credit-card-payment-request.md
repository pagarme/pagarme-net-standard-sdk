
# Create Credit Card Payment Request

The settings for creating a credit card payment

## Structure

`CreateCreditCardPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Installments` | `int?` | Optional | Number of installments<br><br>**Default**: `1` |
| `StatementDescriptor` | `string` | Optional | The text that will be shown on the credit card's statement |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Credit card data |
| `CardId` | `string` | Optional | The credit card id |
| `CardToken` | `string` | Optional | - |
| `Recurrence` | `bool?` | Optional | Indicates a recurrence |
| `Capture` | `bool?` | Optional | Indicates if the operation should be only authorization or auth and capture.<br><br>**Default**: `true` |
| `ExtendedLimitEnabled` | `bool?` | Optional | Indicates whether the extended label (private label) is enabled |
| `ExtendedLimitCode` | `string` | Optional | Extended Limit Code |
| `MerchantCategoryCode` | `long?` | Optional | Customer business segment code |
| `Authentication` | [`CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Optional | The payment authentication request |
| `Contactless` | [`CreateCardPaymentContactlessRequest`](../../doc/models/create-card-payment-contactless-request.md) | Optional | The Credit card payment contactless request |
| `AutoRecovery` | `bool?` | Optional | Indicates whether a particular payment will enter the offline retry flow |
| `OperationType` | `string` | Optional | AuthOnly, AuthAndCapture, PreAuth |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |
| `Payload` | [`CreateCardPayloadRequest`](../../doc/models/create-card-payload-request.md) | Optional | - |
| `InitiatedType` | `string` | Optional | - |
| `RecurrenceModel` | `string` | Optional | - |
| `PaymentOrigin` | [`CreatePaymentOriginRequest`](../../doc/models/create-payment-origin-request.md) | Optional | - |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCreditCardPaymentRequest createCreditCardPaymentRequest = new CreateCreditCardPaymentRequest
{
    Installments = 1,
    StatementDescriptor = "statement_descriptor2",
    Card = null,
    CardId = "card_id2",
    CardToken = "card_token8",
    Capture = true,
    RecurrencyCycle = "\"first\" or \"subsequent\"",
};
```

