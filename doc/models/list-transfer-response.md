
# List Transfer Response

List of paginated transfer objects

## Structure

`ListTransferResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetTransferResponse>`](../../doc/models/get-transfer-response.md) | Optional | Transfers |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListTransferResponse listTransferResponse = new ListTransferResponse
{
    Data = new List<GetTransferResponse>
    {
        null,
    },
    Paging = null,
};
```

