
# Create Pricing Scheme Request

Request for creating a pricing scheme

## Structure

`CreatePricingSchemeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SchemeType` | `string` | Required | Scheme type |
| `PriceBrackets` | [`List<CreatePriceBracketRequest>`](../../doc/models/create-price-bracket-request.md) | Optional | Price brackets |
| `Price` | `int?` | Optional | Price |
| `MinimumPrice` | `int?` | Optional | Minimum price |
| `Percentage` | `double?` | Optional | percentual value used in pricing_scheme Percent |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreatePricingSchemeRequest createPricingSchemeRequest = new CreatePricingSchemeRequest
{
    SchemeType = "scheme_type8",
    PriceBrackets = new List<CreatePriceBracketRequest>
    {
        null,
        new CreatePriceBracketRequest
        {
            StartQuantity = 0,
            Price = 0,
        },
    },
    Price = 124,
    MinimumPrice = 28,
    Percentage = 5.66,
};
```

