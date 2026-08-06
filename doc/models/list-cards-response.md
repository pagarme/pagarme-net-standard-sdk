
# List Cards Response

Response object for listing cards

## Structure

`ListCardsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetCardResponse>`](../../doc/models/get-card-response.md) | Optional | The card objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListCardsResponse listCardsResponse = new ListCardsResponse
{
    Data = new List<GetCardResponse>
    {
        null,
        new GetCardResponse
        {
        },
        new GetCardResponse
        {
        },
    },
    Paging = null,
};
```

