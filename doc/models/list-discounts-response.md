
# List Discounts Response

## Structure

`ListDiscountsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetDiscountResponse>`](../../doc/models/get-discount-response.md) | Optional | The Discounts response |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListDiscountsResponse listDiscountsResponse = new ListDiscountsResponse
{
    Data = new List<GetDiscountResponse>
    {
        null,
        new GetDiscountResponse
        {
        },
    },
    Paging = null,
};
```

