
# Create Subscription Boleto Request

Information about fines and interest on the "boleto" used from payment

## Structure

`CreateSubscriptionBoletoRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Interest` | [`CreateInterestRequest`](../../doc/models/create-interest-request.md) | Optional | - |
| `Fine` | [`CreateFineRequest`](../../doc/models/create-fine-request.md) | Optional | - |
| `MaxDaysToPayPastDue` | `int?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateSubscriptionBoletoRequest createSubscriptionBoletoRequest = new CreateSubscriptionBoletoRequest
{
    Interest = null,
    Fine = null,
    MaxDaysToPayPastDue = 250,
};
```

