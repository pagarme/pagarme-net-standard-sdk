
# List Plans Response

Response object for listing plans

## Structure

`ListPlansResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetPlanResponse>`](../../doc/models/get-plan-response.md) | Optional | The plan objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListPlansResponse listPlansResponse = new ListPlansResponse
{
    Data = new List<GetPlanResponse>
    {
        null,
    },
    Paging = null,
};
```

