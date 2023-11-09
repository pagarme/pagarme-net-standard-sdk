
# Get Subscription Item Response

## Structure

`GetSubscriptionItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `PricingScheme` | [`GetPricingSchemeResponse`](../../doc/models/get-pricing-scheme-response.md) | Optional | - |
| `Discounts` | [`List<GetDiscountResponse>`](../../doc/models/get-discount-response.md) | Optional | - |
| `Increments` | [`List<GetIncrementResponse>`](../../doc/models/get-increment-response.md) | Optional | - |
| `Subscription` | [`GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Optional | - |
| `Name` | `string` | Optional | Item name |
| `Quantity` | `int?` | Optional | - |
| `Cycles` | `int?` | Optional | - |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id2",
  "description": "description8",
  "status": "status6",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z"
}
```

