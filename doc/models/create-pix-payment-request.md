
# Create Pix Payment Request

Contains information to create a pix payment

## Structure

`CreatePixPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExpiresAt` | `DateTime?` | Optional | Datetime when pix payment will expire |
| `ExpiresIn` | `int?` | Optional | Seconds until pix payment expires |
| `AdditionalInformation` | [`List<PixAdditionalInformation>`](../../doc/models/pix-additional-information.md) | Optional | Pix additional information |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

CreatePixPaymentRequest createPixPaymentRequest = new CreatePixPaymentRequest
{
    ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ExpiresIn = 54,
    AdditionalInformation = new List<PixAdditionalInformation>
    {
        null,
        new PixAdditionalInformation
        {
        },
        new PixAdditionalInformation
        {
        },
    },
};
```

