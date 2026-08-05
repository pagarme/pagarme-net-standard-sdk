
# Create Cancel Charge Split Rules Request

Creates a refund with split rules

## Structure

`CreateCancelChargeSplitRulesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The split rule gateway id |
| `Amount` | `int` | Required | The split rule amount |
| `Type` | `string` | Required | The amount type (flat ou percentage) |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCancelChargeSplitRulesRequest createCancelChargeSplitRulesRequest = new CreateCancelChargeSplitRulesRequest
{
    Id = "id0",
    Amount = 140,
    Type = "type0",
};
```

