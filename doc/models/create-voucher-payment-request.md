
# Create Voucher Payment Request

The settings for creating a voucher payment

## Structure

`CreateVoucherPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | The text that will be shown on the voucher's statement |
| `CardId` | `string` | Optional | Card id |
| `CardToken` | `string` | Optional | Card token |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Card info |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateVoucherPaymentRequest createVoucherPaymentRequest = new CreateVoucherPaymentRequest
{
    StatementDescriptor = "statement_descriptor4",
    CardId = "card_id0",
    CardToken = "card_token6",
    Card = null,
    RecurrencyCycle = "\"first\" or \"subsequent\"",
};
```

