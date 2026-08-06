
# List Withdrawals

## Structure

`ListWithdrawals`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetWithdrawResponse>`](../../doc/models/get-withdraw-response.md) | Required | The Increments response |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Required | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListWithdrawals listWithdrawals = new ListWithdrawals
{
    Data = new List<GetWithdrawResponse>
    {
        null,
    },
    Paging = null,
};
```

