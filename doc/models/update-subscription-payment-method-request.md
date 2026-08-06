
# Update Subscription Payment Method Request

Request for updating a subscription's payment method

## Structure

`UpdateSubscriptionPaymentMethodRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentMethod` | `string` | Required | The new payment method |
| `CardId` | `string` | Required | Card id |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Card data |
| `CardToken` | `string` | Optional | The Card Token |
| `Boleto` | [`CreateSubscriptionBoletoRequest`](../../doc/models/create-subscription-boleto-request.md) | Optional | Information about fines and interest on the "boleto" used from payment |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateSubscriptionPaymentMethodRequest updateSubscriptionPaymentMethodRequest = new UpdateSubscriptionPaymentMethodRequest
{
    PaymentMethod = null,
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
    CardToken = "card_token2",
    Boleto = null,
    IndirectAcceptor = "indirect_acceptor4",
};
```

