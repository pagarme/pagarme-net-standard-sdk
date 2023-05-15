
# Create Credit Card Payment Request

The settings for creating a credit card payment

## Structure

`CreateCreditCardPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Installments` | `int?` | Optional | Number of installments<br>**Default**: `1` |
| `StatementDescriptor` | `string` | Optional | The text that will be shown on the credit card's statement |
| `Card` | [`Models.CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Credit card data |
| `CardId` | `string` | Optional | The credit card id |
| `CardToken` | `string` | Optional | - |
| `Recurrence` | `bool?` | Optional | Indicates a recurrence |
| `Capture` | `bool?` | Optional | Indicates if the operation should be only authorization or auth and capture.<br>**Default**: `true` |
| `ExtendedLimitEnabled` | `bool?` | Optional | Indicates whether the extended label (private label) is enabled |
| `ExtendedLimitCode` | `string` | Optional | Extended Limit Code |
| `MerchantCategoryCode` | `long?` | Optional | Customer business segment code |
| `Authentication` | [`Models.CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Optional | The payment authentication request |
| `Contactless` | [`Models.CreateCardPaymentContactlessRequest`](../../doc/models/create-card-payment-contactless-request.md) | Optional | The Credit card payment contactless request |
| `AutoRecovery` | `bool?` | Optional | Indicates whether a particular payment will enter the offline retry flow |
| `OperationType` | `string` | Optional | AuthOnly, AuthAndCapture, PreAuth |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |

## Example (as JSON)

```json
{
  "installments": 1,
  "capture": true,
  "recurrency_cycle": "\"first\" or \"subsequent\"",
  "statement_descriptor": "statement_descriptor0",
  "card": {
    "number": "number6",
    "holder_name": "holder_name2",
    "exp_month": 228,
    "exp_year": 68,
    "cvv": "cvv4"
  },
  "card_id": "card_id4",
  "card_token": "card_token0"
}
```

