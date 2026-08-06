
# Create Checkout Pix Payment Request

Checkout pix payment request

## Structure

`CreateCheckoutPixPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExpiresAt` | `DateTime?` | Optional | Expires at |
| `ExpiresIn` | `int?` | Optional | Expires in |
| `AdditionalInformation` | [`List<PixAdditionalInformation>`](../../doc/models/pix-additional-information.md) | Optional | Additional information |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

CreateCheckoutPixPaymentRequest createCheckoutPixPaymentRequest = new CreateCheckoutPixPaymentRequest
{
    ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ExpiresIn = 68,
    AdditionalInformation = new List<PixAdditionalInformation>
    {
        null,
        new PixAdditionalInformation
        {
        },
    },
};
```

