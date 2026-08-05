
# List Addresses Response

Response object for listing addresses

## Structure

`ListAddressesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetAddressResponse>`](../../doc/models/get-address-response.md) | Optional | The address objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListAddressesResponse listAddressesResponse = new ListAddressesResponse
{
    Data = new List<GetAddressResponse>
    {
        null,
        new GetAddressResponse
        {
        },
    },
    Paging = null,
};
```

