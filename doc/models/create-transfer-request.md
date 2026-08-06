
# Create Transfer Request

Request for creating a transfer

## Structure

`CreateTransferRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Transfer amount |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateTransferRequest createTransferRequest = new CreateTransferRequest
{
    Amount = 192,
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
        ["key1"] = "metadata2",
    },
};
```

