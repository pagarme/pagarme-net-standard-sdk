
# Create Withdraw Request

## Structure

`CreateWithdrawRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateWithdrawRequest createWithdrawRequest = new CreateWithdrawRequest
{
    Amount = 46,
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata5",
        ["key1"] = "metadata6",
    },
};
```

