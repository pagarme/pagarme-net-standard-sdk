
# Create Automatic Anticipation Settings Request

## Structure

`CreateAutomaticAnticipationSettingsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool` | Required | - |
| `Type` | `string` | Required | - |
| `VolumePercentage` | `int` | Required | - |
| `Delay` | `int` | Required | - |
| `Days` | `List<int>` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateAutomaticAnticipationSettingsRequest createAutomaticAnticipationSettingsRequest = new CreateAutomaticAnticipationSettingsRequest
{
    Enabled = false,
    Type = "type4",
    VolumePercentage = 24,
    Delay = 10,
    Days = new List<int>
    {
        242,
        243,
    },
};
```

