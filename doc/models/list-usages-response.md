
# List Usages Response

Response model for listing the usages from a subscription item

## Structure

`ListUsagesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetUsageResponse>`](../../doc/models/get-usage-response.md) | Optional | The usage objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListUsagesResponse listUsagesResponse = new ListUsagesResponse
{
    Data = new List<GetUsageResponse>
    {
        null,
    },
    Paging = null,
};
```

