
# List Subscriptions Response

Response object for listing subscriptions

## Structure

`ListSubscriptionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md) | Optional | The subscription objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListSubscriptionsResponse listSubscriptionsResponse = new ListSubscriptionsResponse
{
    Data = new List<GetSubscriptionResponse>
    {
        null,
        new GetSubscriptionResponse
        {
        },
        new GetSubscriptionResponse
        {
        },
    },
    Paging = null,
};
```

