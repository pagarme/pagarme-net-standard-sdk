
# Create Split Request

Split

## Structure

`CreateSplitRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | Split type |
| `Amount` | `int` | Required | Amount |
| `RecipientId` | `string` | Required | Recipient id |
| `Options` | [`CreateSplitOptionsRequest`](../../doc/models/create-split-options-request.md) | Optional | The split options request |
| `SplitRuleId` | `string` | Optional | Rule code used in cancellation. |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateSplitRequest createSplitRequest = new CreateSplitRequest
{
    Type = "type8",
    Amount = 166,
    RecipientId = "recipient_id8",
    Options = null,
    SplitRuleId = "split_rule_id4",
};
```

