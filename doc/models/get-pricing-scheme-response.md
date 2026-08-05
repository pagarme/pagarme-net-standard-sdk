
# Get Pricing Scheme Response

Response object for getting a pricing scheme

## Structure

`GetPricingSchemeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Price` | `int?` | Optional | - |
| `SchemeType` | `string` | Optional | - |
| `PriceBrackets` | [`List<GetPriceBracketResponse>`](../../doc/models/get-price-bracket-response.md) | Optional | - |
| `MinimumPrice` | `int?` | Optional | - |
| `Percentage` | `double?` | Optional | percentual value used in pricing_scheme Percent |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

GetPricingSchemeResponse getPricingSchemeResponse = new GetPricingSchemeResponse
{
    Price = 34,
    SchemeType = "scheme_type2",
    PriceBrackets = new List<GetPriceBracketResponse>
    {
        null,
    },
    MinimumPrice = 130,
    Percentage = 35.4,
};
```

