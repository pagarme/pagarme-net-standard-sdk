
# Get Period Response

Response object for getting a period

## Structure

`GetPeriodResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartAt` | `DateTime?` | Optional | - |
| `EndAt` | `DateTime?` | Optional | - |
| `Id` | `string` | Optional | - |
| `BillingAt` | `DateTime?` | Optional | - |
| `Subscription` | [`Models.GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Optional | - |
| `Status` | `string` | Optional | - |
| `Duration` | `int?` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `UpdatedAt` | `string` | Optional | - |
| `Cycle` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "start_at": null,
  "end_at": null,
  "id": null,
  "billing_at": null,
  "subscription": null,
  "status": null,
  "duration": null,
  "created_at": null,
  "updated_at": null,
  "cycle": null
}
```

