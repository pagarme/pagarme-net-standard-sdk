
# List Invoices Response

Response object for listing invoices

## Structure

`ListInvoicesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetInvoiceResponse>`](../../doc/models/get-invoice-response.md) | Optional | The Invoice objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListInvoicesResponse listInvoicesResponse = new ListInvoicesResponse
{
    Data = new List<GetInvoiceResponse>
    {
        null,
    },
    Paging = null,
};
```

