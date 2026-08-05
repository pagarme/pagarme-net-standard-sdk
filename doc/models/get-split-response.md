
# Get Split Response

Split response

## Structure

`GetSplitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | Type |
| `Amount` | `int?` | Optional | Amount |
| `Recipient` | [`GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `GatewayId` | `string` | Optional | The split rule gateway id |
| `Options` | [`GetSplitOptionsResponse`](../../doc/models/get-split-options-response.md) | Optional | - |
| `Id` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetSplitResponse getSplitResponse = new GetSplitResponse
{
    Type = "type0",
    Amount = 42,
    Recipient = null,
    GatewayId = "gateway_id0",
    Options = null,
};
```

