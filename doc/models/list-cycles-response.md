
# List Cycles Response

Response object for listing subscription cycles

## Structure

`ListCyclesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetPeriodResponse>`](../../doc/models/get-period-response.md) | Optional | The subscription cycles objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListCyclesResponse listCyclesResponse = new ListCyclesResponse
{
    Data = new List<GetPeriodResponse>
    {
        null,
        new GetPeriodResponse
        {
        },
        new GetPeriodResponse
        {
        },
    },
    Paging = null,
};
```

