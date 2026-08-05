
# List Anticipation Response

Anticipations

## Structure

`ListAnticipationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetAnticipationResponse>`](../../doc/models/get-anticipation-response.md) | Optional | Anticipations |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListAnticipationResponse listAnticipationResponse = new ListAnticipationResponse
{
    Data = new List<GetAnticipationResponse>
    {
        null,
        new GetAnticipationResponse
        {
        },
        new GetAnticipationResponse
        {
        },
    },
    Paging = null,
};
```

