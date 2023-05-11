
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
| `Card` | [`Models.GetCardResponse`](../../doc/models/get-card-response.md) | Optional | Card data |

## Example (as JSON)

```json
{
  "gateway_id": "gateway_id4",
  "amount": 24,
  "status": "status2",
  "success": false,
  "created_at": "2016-03-13T12:52:32.123Z",
  "transaction_type": "voucher",
  "statement_descriptor": "statement_descriptor0",
  "acquirer_name": "acquirer_name4",
  "acquirer_affiliation_code": "acquirer_affiliation_code8",
  "acquirer_tid": "acquirer_tid0",
  "acquirer_nsu": "acquirer_nsu0"
}
```

