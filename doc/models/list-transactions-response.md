
# List Transactions Response

Response object for listing transactions

## Structure

`ListTransactionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetTransactionResponse>`](../../doc/models/get-transaction-response.md) | Optional | The transaction objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListTransactionsResponse listTransactionsResponse = new ListTransactionsResponse
{
    Data = new List<GetTransactionResponse>
    {
        null,
    },
    Paging = null,
};
```

