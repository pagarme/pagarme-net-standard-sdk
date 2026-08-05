
# Create Emv Decrypt Request

## Structure

`CreateEmvDecryptRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IccData` | `string` | Required | - |
| `CardSequenceNumber` | `string` | Required | - |
| `Data` | [`CreateEmvDataDecryptRequest`](../../doc/models/create-emv-data-decrypt-request.md) | Required | - |
| `Poi` | [`CreateCardPaymentContactlessPOIRequest`](../../doc/models/create-card-payment-contactless-poi-request.md) | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateEmvDecryptRequest createEmvDecryptRequest = new CreateEmvDecryptRequest
{
    IccData = null,
    CardSequenceNumber = null,
    Data = new CreateEmvDataDecryptRequest
    {
        Cipher = null,
        Tags = new List<CreateEmvDataTlvDecryptRequest>
        {
            null,
        },
        Dukpt = null,
    },
    Poi = null,
};
```

