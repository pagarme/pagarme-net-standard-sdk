
# List Charges Response

Response object for listing charges

## Structure

`ListChargesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetChargeResponse>`](../../doc/models/get-charge-response.md) | Optional | The charge objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListChargesResponse listChargesResponse = new ListChargesResponse
{
    Data = new List<GetChargeResponse>
    {
        null,
    },
    Paging = null,
};
```

