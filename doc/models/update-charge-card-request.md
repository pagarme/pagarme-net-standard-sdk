
# Update Charge Card Request

Request for updating card data

## Structure

`UpdateChargeCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdateSubscription` | `bool` | Required | Indicates if the subscriptions using this card must also be updated |
| `CardId` | `string` | Required | Card id |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Card data |
| `Recurrence` | `bool` | Required | Indicates a recurrence |
| `InitiatedType` | `string` | Optional | - |
| `RecurrenceModel` | `string` | Optional | - |
| `PaymentOrigin` | [`CreatePaymentOriginRequest`](../../doc/models/create-payment-origin-request.md) | Optional | - |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateChargeCardRequest updateChargeCardRequest = new UpdateChargeCardRequest
{
    UpdateSubscription = false,
    CardId = null,
    Card = new CreateCardRequest
    {
        Number = "number6",
        HolderName = "holder_name2",
        ExpMonth = 228,
        ExpYear = 68,
        Cvv = "cvv4",
        Type = "credit",
    },
    Recurrence = false,
    InitiatedType = "initiated_type4",
    RecurrenceModel = "recurrence_model2",
    PaymentOrigin = null,
    IndirectAcceptor = "indirect_acceptor8",
};
```

