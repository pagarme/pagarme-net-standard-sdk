
# Create Transfer

## Structure

`CreateTransfer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | - |
| `SourceId` | `string` | Required | - |
| `TargetId` | `string` | Required | - |
| `Metadata` | `List<string>` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateTransfer createTransfer = new CreateTransfer
{
    Amount = 130,
    SourceId = "source_id6",
    TargetId = "target_id8",
    Metadata = new List<string>
    {
        "metadata1",
    },
};
```

