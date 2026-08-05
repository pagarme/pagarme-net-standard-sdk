
# Get Subscription Split Response

## Structure

`GetSubscriptionSplitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Defines if the split is enabled |
| `Rules` | [`List<GetSplitResponse>`](../../doc/models/get-split-response.md) | Optional | Split |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

GetSubscriptionSplitResponse getSubscriptionSplitResponse = new GetSubscriptionSplitResponse
{
    Enabled = false,
    Rules = new List<GetSplitResponse>
    {
        null,
        new GetSplitResponse
        {
        },
    },
};
```

