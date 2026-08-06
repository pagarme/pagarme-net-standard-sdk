
# Update Subscription Item Request

Request for updating a subscription item

## Structure

`UpdateSubscriptionItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Required | Description |
| `Status` | `string` | Required | Status |
| `PricingScheme` | [`UpdatePricingSchemeRequest`](../../doc/models/update-pricing-scheme-request.md) | Required | Pricing scheme |
| `Name` | `string` | Required | Item name |
| `Cycles` | `int?` | Optional | Number of cycles that the item will be charged |
| `Quantity` | `int?` | Optional | Quantity |
| `MinimumPrice` | `int?` | Optional | Minimum price |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdateSubscriptionItemRequest updateSubscriptionItemRequest = new UpdateSubscriptionItemRequest
{
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
    Name = null,
    Cycles = 64,
    Quantity = 44,
    MinimumPrice = 56,
};
```

