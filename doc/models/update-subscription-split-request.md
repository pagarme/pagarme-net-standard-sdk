
# Update Subscription Split Request

## Structure

`UpdateSubscriptionSplitRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool` | Required | Defines if the split is enabled |
| `Rules` | [`List<CreateSplitRequest>`](../../doc/models/create-split-request.md) | Required | Split |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdateSubscriptionSplitRequest updateSubscriptionSplitRequest = new UpdateSubscriptionSplitRequest
{
    Enabled = false,
    Rules = new List<CreateSplitRequest>
    {
        null,
    },
};
```

