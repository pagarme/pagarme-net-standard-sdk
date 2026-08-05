
# List Charge Transactions Response

Response object for listing charge transactions

## Structure

`ListChargeTransactionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetTransactionResponse>`](../../doc/models/get-transaction-response.md) | Optional | The charge transactions objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListChargeTransactionsResponse listChargeTransactionsResponse = new ListChargeTransactionsResponse
{
    Data = new List<GetTransactionResponse>
    {
        null,
    },
    Paging = null,
};
```

