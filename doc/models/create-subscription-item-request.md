
# Create Subscription Item Request

Request for creating a new subscription item

## Structure

`CreateSubscriptionItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Required | Item description |
| `PricingScheme` | [`CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Pricing scheme |
| `Id` | `string` | Required | Item id |
| `PlanItemId` | `string` | Required | Plan item id |
| `Discounts` | [`List<CreateDiscountRequest>`](../../doc/models/create-discount-request.md) | Required | Discounts for the item |
| `Name` | `string` | Required | Item name |
| `Cycles` | `int?` | Optional | Number of cycles which the item will be charged |
| `Quantity` | `int?` | Optional | Quantity of items |
| `MinimumPrice` | `int?` | Optional | Minimum price |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateSubscriptionItemRequest createSubscriptionItemRequest = new CreateSubscriptionItemRequest
{
    Description = null,
    PricingScheme = null,
    Id = null,
    PlanItemId = null,
    Discounts = new List<CreateDiscountRequest>
    {
        null,
    },
    Name = null,
    Cycles = 250,
    Quantity = 242,
    MinimumPrice = 2,
};
```

