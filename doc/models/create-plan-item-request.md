
# Create Plan Item Request

Request for creating a plan item

## Structure

`CreatePlanItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Item name |
| `PricingScheme` | [`CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Item's pricing scheme |
| `Id` | `string` | Required | Item's id |
| `Description` | `string` | Required | Item's description |
| `Cycles` | `int?` | Optional | Number of cycles where the item will be charged |
| `Quantity` | `int?` | Optional | Quantity |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreatePlanItemRequest createPlanItemRequest = new CreatePlanItemRequest
{
    Name = "name8",
    PricingScheme = null,
    Id = "id8",
    Description = "description8",
    Cycles = 78,
    Quantity = 158,
};
```

