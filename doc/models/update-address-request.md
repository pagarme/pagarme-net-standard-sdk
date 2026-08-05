
# Update Address Request

Request for updating an address

## Structure

`UpdateAddressRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Number` | `string` | Required | Number |
| `Complement` | `string` | Required | Complement |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Line2` | `string` | Required | Line 2 for address |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdateAddressRequest updateAddressRequest = new UpdateAddressRequest
{
    Number = "number8",
    Complement = "complement0",
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata9",
    },
    Line2 = "line_22",
};
```

