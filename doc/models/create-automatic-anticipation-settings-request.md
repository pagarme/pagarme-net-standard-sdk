
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

## Example (as JSON)

```json
{
  "enabled": false,
  "type": "type8",
  "volume_percentage": 208,
  "delay": 82,
  "days": [
    58,
    59
  ]
}
```

