
# Get Checkout Boleto Payment Response

## Structure

`GetCheckoutBoletoPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DueAt` | `DateTime?` | Optional | Data de vencimento do boleto |
| `Instructions` | `string` | Optional | Instruções do boleto |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetCheckoutBoletoPaymentResponse getCheckoutBoletoPaymentResponse = new GetCheckoutBoletoPaymentResponse
{
    DueAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Instructions = "instructions6",
};
```

