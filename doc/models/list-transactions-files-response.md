
# List Transactions Files Response

Response object for listing of transactions files

## Structure

`ListTransactionsFilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetTransactionReportFileResponse>`](../../doc/models/get-transaction-report-file-response.md) | Optional | - |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListTransactionsFilesResponse listTransactionsFilesResponse = new ListTransactionsFilesResponse
{
    Data = new List<GetTransactionReportFileResponse>
    {
        null,
    },
    Paging = null,
};
```

