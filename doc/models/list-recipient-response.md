
# List Recipient Response

Response for the listing recipient method

## Structure

`ListRecipientResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetRecipientResponse>`](../../doc/models/get-recipient-response.md) | Optional | Recipients |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListRecipientResponse listRecipientResponse = new ListRecipientResponse
{
    Data = new List<GetRecipientResponse>
    {
        null,
        new GetRecipientResponse
        {
        },
    },
    Paging = null,
};
```

