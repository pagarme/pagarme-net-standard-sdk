
# Update Subscription Card Request

Request for updating the card from a subscription

## Structure

`UpdateSubscriptionCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Credit card data |
| `CardId` | `string` | Required | Credit card id |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateSubscriptionCardRequest updateSubscriptionCardRequest = new UpdateSubscriptionCardRequest
{
    Card = new CreateCardRequest
    {
        Number = "number6",
        HolderName = "holder_name2",
        ExpMonth = 228,
        ExpYear = 68,
        Cvv = "cvv4",
        Type = "credit",
    },
    CardId = null,
    IndirectAcceptor = "indirect_acceptor6",
};
```

