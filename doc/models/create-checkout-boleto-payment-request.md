
# Create Checkout Boleto Payment Request

## Structure

`CreateCheckoutBoletoPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `string` | Required | Bank identifier |
| `Instructions` | `string` | Required | Instructions |
| `DueAt` | `DateTime` | Required | Due date |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

CreateCheckoutBoletoPaymentRequest createCheckoutBoletoPaymentRequest = new CreateCheckoutBoletoPaymentRequest
{
    Bank = "bank6",
    Instructions = "instructions6",
    DueAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

