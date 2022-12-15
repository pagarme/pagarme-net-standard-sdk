
# Create Subscription Boleto Request

Information about fines and interest on the "boleto" used from payment

## Structure

`CreateSubscriptionBoletoRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Interest` | [`Models.CreateInterestRequest`](../../doc/models/create-interest-request.md) | Optional | - |
| `Fine` | [`Models.CreateFineRequest`](../../doc/models/create-fine-request.md) | Optional | - |
| `MaxDaysToPayPastDue` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "interest": null,
  "fine": null,
  "max_days_to_pay_past_due": null
}
```

