
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
  "start_at": "2016-03-13T12:52:32.123Z",
  "end_at": "2016-03-13T12:52:32.123Z",
  "id": "id0",
  "billing_at": "2016-03-13T12:52:32.123Z",
  "subscription": {
    "id": "id4",
    "code": "code2",
    "start_at": "2016-03-13T12:52:32.123Z",
    "interval": "interval2",
    "interval_count": 234
  }
}
```

