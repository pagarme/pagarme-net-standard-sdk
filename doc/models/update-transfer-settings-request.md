
# Update Transfer Settings Request

## Structure

`UpdateTransferSettingsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransferEnabled` | `string` | Required | - |
| `TransferInterval` | `string` | Required | - |
| `TransferDay` | `string` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateTransferSettingsRequest updateTransferSettingsRequest = new UpdateTransferSettingsRequest
{
    TransferEnabled = "transfer_enabled8",
    TransferInterval = "transfer_interval2",
    TransferDay = "transfer_day2",
};
```

