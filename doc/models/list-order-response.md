
# List Order Response

Response object for listing order objects

## Structure

`ListOrderResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetOrderResponse>`](../../doc/models/get-order-response.md) | Optional | The order object |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListOrderResponse listOrderResponse = new ListOrderResponse
{
    Data = new List<GetOrderResponse>
    {
        null,
        new GetOrderResponse
        {
        },
        new GetOrderResponse
        {
        },
    },
    Paging = null,
};
```

