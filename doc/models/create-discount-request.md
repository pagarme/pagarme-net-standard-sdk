
# Create Discount Request

Request for creating a new discount

## Structure

`CreateDiscountRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `double` | Required | The discount value |
| `DiscountType` | `string` | Required | Discount type. Can be either flat or percentage. |
| `ItemId` | `string` | Required | The item where the discount will be applied |
| `Cycles` | `int?` | Optional | Number of cycles that the discount will be applied |
| `Description` | `string` | Optional | Description |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateDiscountRequest createDiscountRequest = new CreateDiscountRequest
{
    MValue = 66.94,
    DiscountType = "discount_type0",
    ItemId = "item_id8",
    Cycles = 194,
    Description = "description8",
};
```

