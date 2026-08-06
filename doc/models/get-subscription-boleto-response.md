
# Get Subscription Boleto Response

Response object for getting a boleto

## Structure

`GetSubscriptionBoletoResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Interest` | [`GetInterestResponse`](../../doc/models/get-interest-response.md) | Optional | Interest |
| `Fine` | [`GetFineResponse`](../../doc/models/get-fine-response.md) | Optional | Fine |
| `MaxDaysToPayPastDue` | `int?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetSubscriptionBoletoResponse getSubscriptionBoletoResponse = new GetSubscriptionBoletoResponse
{
    Interest = new GetInterestResponse
    {
        Days = 2,
        Type = "percentage",
        Amount = 20,
    },
    Fine = new GetFineResponse
    {
        Days = 2,
        Type = "flat",
        Amount = 10,
    },
    MaxDaysToPayPastDue = 2,
};
```

