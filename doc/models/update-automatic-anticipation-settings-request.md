
# Update Automatic Anticipation Settings Request

## Structure

`UpdateAutomaticAnticipationSettingsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | - |
| `Type` | `string` | Optional | - |
| `VolumePercentage` | `int?` | Optional | - |
| `Delay` | `int?` | Optional | - |
| `Days` | `int?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateAutomaticAnticipationSettingsRequest updateAutomaticAnticipationSettingsRequest = new UpdateAutomaticAnticipationSettingsRequest
{
    Enabled = false,
    Type = "type4",
    VolumePercentage = 178,
    Delay = 112,
    Days = 20,
};
```

