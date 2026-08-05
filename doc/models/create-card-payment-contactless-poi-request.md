
# Create Card Payment Contactless POI Request

## Structure

`CreateCardPaymentContactlessPOIRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SystemName` | `string` | Required | system name |
| `Model` | `string` | Required | model |
| `Provider` | `string` | Required | provider |
| `SerialNumber` | `string` | Required | serial number |
| `VersionNumber` | `string` | Required | version number |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCardPaymentContactlessPOIRequest createCardPaymentContactlessPOIRequest = new CreateCardPaymentContactlessPOIRequest
{
    SystemName = "system_name4",
    Model = "model2",
    Provider = "provider4",
    SerialNumber = "serial_number8",
    VersionNumber = "version_number4",
};
```

