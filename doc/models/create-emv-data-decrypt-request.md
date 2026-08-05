
# Create Emv Data Decrypt Request

## Structure

`CreateEmvDataDecryptRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cipher` | `string` | Required | Emv Decrypt cipher type |
| `Dukpt` | [`CreateEmvDataDukptDecryptRequest`](../../doc/models/create-emv-data-dukpt-decrypt-request.md) | Optional | Dukpt data request |
| `Tags` | [`List<CreateEmvDataTlvDecryptRequest>`](../../doc/models/create-emv-data-tlv-decrypt-request.md) | Required | Encrypted tags list |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateEmvDataDecryptRequest createEmvDataDecryptRequest = new CreateEmvDataDecryptRequest
{
    Cipher = null,
    Tags = new List<CreateEmvDataTlvDecryptRequest>
    {
        null,
    },
    Dukpt = null,
};
```

