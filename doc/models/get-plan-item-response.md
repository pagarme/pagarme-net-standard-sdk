
# Get Plan Item Response

Response object for getting a plan item

## Structure

`GetPlanItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `PricingScheme` | [`Models.GetPricingSchemeResponse`](../../doc/models/get-pricing-scheme-response.md) | Optional | - |
| `Description` | `string` | Optional | - |
| `Plan` | [`Models.GetPlanResponse`](../../doc/models/get-plan-response.md) | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `Cycles` | `int?` | Optional | - |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "name": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "pricing_scheme": null,
  "description": null,
  "plan": null,
  "quantity": null,
  "cycles": null,
  "deleted_at": null
}
```

