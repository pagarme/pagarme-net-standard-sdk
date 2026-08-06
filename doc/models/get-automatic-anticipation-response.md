
# Get Automatic Anticipation Response

## Structure

`GetAutomaticAnticipationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | - |
| `Type` | `string` | Optional | - |
| `VolumePercentage` | `int?` | Optional | - |
| `Delay` | `int?` | Optional | - |
| `Days` | `List<int>` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

GetAutomaticAnticipationResponse getAutomaticAnticipationResponse = new GetAutomaticAnticipationResponse
{
    Enabled = false,
    Type = "type4",
    VolumePercentage = 86,
    Delay = 204,
    Days = new List<int>
    {
        180,
        181,
        182,
    },
};
```

