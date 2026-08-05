
# Get Split Options Response

## Structure

`GetSplitOptionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Liable` | `bool?` | Optional | - |
| `ChargeProcessingFee` | `bool?` | Optional | - |
| `ChargeRemainderFee` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetSplitOptionsResponse getSplitOptionsResponse = new GetSplitOptionsResponse
{
    Liable = false,
    ChargeProcessingFee = false,
    ChargeRemainderFee = "charge_remainder_fee6",
};
```

