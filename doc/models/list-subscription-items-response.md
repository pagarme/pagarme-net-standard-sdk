
# List Subscription Items Response

Response model for listing subscription items

## Structure

`ListSubscriptionItemsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md) | Optional | The subscription items |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListSubscriptionItemsResponse listSubscriptionItemsResponse = new ListSubscriptionItemsResponse
{
    Data = new List<GetSubscriptionItemResponse>
    {
        null,
        new GetSubscriptionItemResponse
        {
        },
        new GetSubscriptionItemResponse
        {
        },
    },
    Paging = null,
};
```

