
# Get Boleto Transaction Response

Response object for getting a boleto transaction

## Structure

`GetBoletoTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | - |
| `Barcode` | `string` | Optional | - |
| `NossoNumero` | `string` | Optional | - |
| `Bank` | `string` | Optional | - |
| `DocumentNumber` | `string` | Optional | - |
| `Instructions` | `string` | Optional | - |
| `BillingAddress` | [`GetBillingAddressResponse`](../../doc/models/get-billing-address-response.md) | Optional | - |
| `DueAt` | `DateTime?` | Optional | - |
| `QrCode` | `string` | Optional | - |
| `Line` | `string` | Optional | - |
| `PdfPassword` | `string` | Optional | - |
| `Pdf` | `string` | Optional | - |
| `PaidAt` | `DateTime?` | Optional | - |
| `PaidAmount` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `CreditAt` | `DateTime?` | Optional | - |
| `StatementDescriptor` | `string` | Optional | Soft Descriptor |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetBoletoTransactionResponse getBoletoTransactionResponse = new GetBoletoTransactionResponse
{
    Url = "url2",
    Barcode = "barcode2",
    NossoNumero = "nosso_numero8",
    Bank = "bank6",
    DocumentNumber = "document_number8",
    GatewayId = "gateway_id8",
    Amount = 40,
    Status = "status6",
    Success = false,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

