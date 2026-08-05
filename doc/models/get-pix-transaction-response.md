
# Get Pix Transaction Response

Response object when getting a pix transaction

## Structure

`GetPixTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QrCode` | `string` | Optional | - |
| `QrCodeUrl` | `string` | Optional | - |
| `ExpiresAt` | `DateTime?` | Optional | - |
| `AdditionalInformation` | [`List<PixAdditionalInformation>`](../../doc/models/pix-additional-information.md) | Optional | - |
| `EndToEndId` | `string` | Optional | - |
| `Payer` | [`GetPixPayerResponse`](../../doc/models/get-pix-payer-response.md) | Optional | - |
| `PixProviderTid` | `string` | Optional | Pix provider TID |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

GetPixTransactionResponse getPixTransactionResponse = new GetPixTransactionResponse
{
    QrCode = "qr_code6",
    QrCodeUrl = "qr_code_url2",
    ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    AdditionalInformation = new List<PixAdditionalInformation>
    {
        null,
        new PixAdditionalInformation
        {
        },
    },
    EndToEndId = "end_to_end_id0",
    GatewayId = "gateway_id8",
    Amount = 40,
    Status = "status6",
    Success = false,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

