
# Create Private Label Payment Request

The settings for creating a private label payment

## Structure

`CreatePrivateLabelPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Installments` | `int?` | Optional | Number of installments<br><br>**Default**: `1` |
| `StatementDescriptor` | `string` | Optional | The text that will be shown on the private label's statement |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Card data |
| `CardId` | `string` | Optional | The Card id |
| `CardToken` | `string` | Optional | - |
| `Recurrence` | `bool?` | Optional | Indicates a recurrence |
| `Capture` | `bool?` | Optional | Indicates if the operation should be only authorization or auth and capture.<br><br>**Default**: `true` |
| `ExtendedLimitEnabled` | `bool?` | Optional | Indicates whether the extended label (private label) is enabled |
| `ExtendedLimitCode` | `string` | Optional | Extended Limit Code |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreatePrivateLabelPaymentRequest createPrivateLabelPaymentRequest = new CreatePrivateLabelPaymentRequest
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

