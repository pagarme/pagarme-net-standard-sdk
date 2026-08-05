
# Get Transfer Settings Response

## Structure

`GetTransferSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransferEnabled` | `bool?` | Optional | - |
| `TransferInterval` | `string` | Optional | - |
| `TransferDay` | `int?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetTransferSettingsResponse getTransferSettingsResponse = new GetTransferSettingsResponse
{
    TransferEnabled = false,
    TransferInterval = "transfer_interval4",
    TransferDay = 156,
};
```

