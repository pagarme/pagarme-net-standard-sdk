
# List Transfers

## Structure

`ListTransfers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetTransfer>`](../../doc/models/get-transfer.md) | Required | The Increments response |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Required | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListTransfers listTransfers = new ListTransfers
{
    Data = new List<GetTransfer>
    {
        null,
    },
    Paging = null,
};
```

