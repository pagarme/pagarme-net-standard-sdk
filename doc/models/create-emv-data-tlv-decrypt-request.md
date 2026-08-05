
# Create Emv Data Tlv Decrypt Request

## Structure

`CreateEmvDataTlvDecryptRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tag` | `string` | Required | Emv tag |
| `Lenght` | `string` | Required | Emv lenght |
| `MValue` | `string` | Required | Emv value |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateEmvDataTlvDecryptRequest createEmvDataTlvDecryptRequest = new CreateEmvDataTlvDecryptRequest
{
    Tag = "tag8",
    Lenght = "lenght4",
    MValue = "value6",
};
```

