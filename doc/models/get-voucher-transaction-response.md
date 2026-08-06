
# Get Voucher Transaction Response

Response for voucher transactions

## Structure

`GetVoucherTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Text that will appear on the voucher's statement |
| `AcquirerName` | `string` | Optional | Acquirer name |
| `AcquirerAffiliationCode` | `string` | Optional | Acquirer affiliation code |
| `AcquirerTid` | `string` | Optional | Acquirer TID |
| `AcquirerNsu` | `string` | Optional | Acquirer NSU |
| `AcquirerAuthCode` | `string` | Optional | Acquirer authorization code |
| `AcquirerMessage` | `string` | Optional | acquirer_message |
| `AcquirerReturnCode` | `string` | Optional | Acquirer return code |
| `OperationType` | `string` | Optional | Operation type |
| `Card` | [`GetCardResponse`](../../doc/models/get-card-response.md) | Optional | Card data |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetVoucherTransactionResponse getVoucherTransactionResponse = new GetVoucherTransactionResponse
{
    StatementDescriptor = "statement_descriptor4",
    AcquirerName = "acquirer_name8",
    AcquirerAffiliationCode = "acquirer_affiliation_code4",
    AcquirerTid = "acquirer_tid6",
    AcquirerNsu = "acquirer_nsu6",
    GatewayId = "gateway_id8",
    Amount = 40,
    Status = "status6",
    Success = false,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

