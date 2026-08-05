
# Update Pricing Scheme Request

Request for updating a pricing scheme

## Structure

`UpdatePricingSchemeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SchemeType` | `string` | Required | Scheme type |
| `PriceBrackets` | [`List<UpdatePriceBracketRequest>`](../../doc/models/update-price-bracket-request.md) | Required | Price brackets |
| `Price` | `int?` | Optional | Price |
| `MinimumPrice` | `int?` | Optional | Minimum price |
| `Percentage` | `double?` | Optional | percentual value used in pricing_scheme Percent |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdatePricingSchemeRequest updatePricingSchemeRequest = new UpdatePricingSchemeRequest
{
    SchemeType = null,
    PriceBrackets = new List<UpdatePriceBracketRequest>
    {
        null,
    },
    Price = 180,
    MinimumPrice = 84,
    Percentage = 238.06,
};
```

