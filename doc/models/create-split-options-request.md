
# Create Split Options Request

The Split Options Request

## Structure

`CreateSplitOptionsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Liable` | `bool?` | Optional | Liable options |
| `ChargeProcessingFee` | `bool?` | Optional | Charge processing fee |
| `ChargeRemainderFee` | `bool?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateSplitOptionsRequest createSplitOptionsRequest = new CreateSplitOptionsRequest
{
    Liable = false,
    ChargeProcessingFee = false,
    ChargeRemainderFee = false,
};
```

