
# Get Usage Response

Response object for getting a usage

## Structure

`GetUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `Quantity` | `int?` | Optional | Quantity |
| `Description` | `string` | Optional | Description |
| `UsedAt` | `DateTime?` | Optional | Used at |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `Status` | `string` | Optional | Status |
| `DeletedAt` | `DateTime?` | Optional | - |
| `SubscriptionItem` | [`Models.GetSubscriptionItemResponse`](../../doc/models/get-subscription-item-response.md) | Optional | Subscription item |
| `Code` | `string` | Optional | Identification code in the client system |
| `Group` | `string` | Optional | Identification group in the client system |
| `Amount` | `int?` | Optional | Field used in item scheme type 'Percent' |

## Example (as JSON)

```json
{
  "id": null,
  "quantity": null,
  "description": null,
  "used_at": null,
  "created_at": null,
  "status": null,
  "deleted_at": null,
  "subscription_item": null,
  "code": null,
  "group": null,
  "amount": null
}
```

