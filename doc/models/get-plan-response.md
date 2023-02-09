
# Get Plan Response

Response object for getting a plan

## Structure

`GetPlanResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Url` | `string` | Optional | - |
| `StatementDescriptor` | `string` | Optional | - |
| `Interval` | `string` | Optional | - |
| `IntervalCount` | `int?` | Optional | - |
| `BillingType` | `string` | Optional | - |
| `PaymentMethods` | `List<string>` | Optional | - |
| `Installments` | `List<int>` | Optional | - |
| `Status` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `Items` | [`List<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md) | Optional | - |
| `BillingDays` | `List<int>` | Optional | - |
| `Shippable` | `bool?` | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `TrialPeriodDays` | `int?` | Optional | - |
| `MinimumPrice` | `int?` | Optional | - |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "name": null,
  "description": null,
  "url": null,
  "statement_descriptor": null,
  "interval": null,
  "interval_count": null,
  "billing_type": null,
  "payment_methods": null,
  "installments": null,
  "status": null,
  "currency": null,
  "created_at": null,
  "updated_at": null,
  "items": null,
  "billing_days": null,
  "shippable": null,
  "metadata": null,
  "trial_period_days": null,
  "minimum_price": null,
  "deleted_at": null
}
```

