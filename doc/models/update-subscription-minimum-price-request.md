
# Update Subscription Minimum Price Request

Atualização do valor mínimo da assinatura

## Structure

`UpdateSubscriptionMinimumPriceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MinimumPrice` | `int?` | Optional | Valor mínimo da assinatura |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateSubscriptionMinimumPriceRequest updateSubscriptionMinimumPriceRequest = new UpdateSubscriptionMinimumPriceRequest
{
    MinimumPrice = 134,
};
```

