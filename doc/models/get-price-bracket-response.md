
# Get Price Bracket Response

Response object for getting a price bracket

## Structure

`GetPriceBracketResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartQuantity` | `int?` | Optional | - |
| `Price` | `int?` | Optional | - |
| `EndQuantity` | `int?` | Optional | - |
| `OveragePrice` | `int?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPriceBracketResponse getPriceBracketResponse = new GetPriceBracketResponse
{
    StartQuantity = 80,
    Price = 18,
    EndQuantity = 88,
    OveragePrice = 102,
};
```

