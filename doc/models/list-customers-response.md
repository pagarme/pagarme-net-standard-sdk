
# List Customers Response

Response for listing the customers

## Structure

`ListCustomersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetCustomerResponse>`](../../doc/models/get-customer-response.md) | Optional | The customer object |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListCustomersResponse listCustomersResponse = new ListCustomersResponse
{
    Data = new List<GetCustomerResponse>
    {
        null,
    },
    Paging = null,
};
```

