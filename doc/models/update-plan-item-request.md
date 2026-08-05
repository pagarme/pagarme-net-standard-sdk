
# Update Plan Item Request

Request for updating a plan item

## Structure

`UpdatePlanItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Item name |
| `Description` | `string` | Required | Description |
| `Status` | `string` | Required | Item status |
| `PricingScheme` | [`UpdatePricingSchemeRequest`](../../doc/models/update-pricing-scheme-request.md) | Required | Pricing scheme |
| `Quantity` | `int?` | Optional | Quantity |
| `Cycles` | `int?` | Optional | Number of cycles that the item will be charged |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdatePlanItemRequest updatePlanItemRequest = new UpdatePlanItemRequest
{
    Name = null,
    Description = null,
    Status = null,
    PricingScheme = new UpdatePricingSchemeRequest
    {
        SchemeType = null,
        PriceBrackets = new List<UpdatePriceBracketRequest>
        {
            null,
        },
        Price = 166,
        MinimumPrice = 6,
        Percentage = 251.76,
    },
    Quantity = 174,
    Cycles = 194,
};
```

