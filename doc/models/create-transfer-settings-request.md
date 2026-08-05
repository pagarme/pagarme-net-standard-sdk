
# Create Transfer Settings Request

Informações de transferência do recebedor

## Structure

`CreateTransferSettingsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransferEnabled` | `bool` | Required | - |
| `TransferInterval` | `string` | Required | - |
| `TransferDay` | `int` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateTransferSettingsRequest createTransferSettingsRequest = new CreateTransferSettingsRequest
{
    TransferEnabled = false,
    TransferInterval = "transfer_interval2",
    TransferDay = 128,
};
```

