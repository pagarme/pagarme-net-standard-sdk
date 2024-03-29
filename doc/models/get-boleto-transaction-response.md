
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

## Example (as JSON)

```json
{
  "gateway_id": "gateway_id8",
  "amount": 40,
  "status": "status6",
  "success": false,
  "created_at": "2016-03-13T12:52:32.123Z",
  "url": "url0",
  "barcode": "barcode4",
  "nosso_numero": "nosso_numero6",
  "bank": "bank4",
  "document_number": "document_number0"
}
```

