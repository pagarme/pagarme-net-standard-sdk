
# List Increments Response

## Structure

`ListIncrementsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetIncrementResponse>`](../../doc/models/get-increment-response.md) | Optional | The Increments response |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListIncrementsResponse listIncrementsResponse = new ListIncrementsResponse
{
    Data = new List<GetIncrementResponse>
    {
        null,
        new GetIncrementResponse
        {
        },
    },
    Paging = null,
};
```

