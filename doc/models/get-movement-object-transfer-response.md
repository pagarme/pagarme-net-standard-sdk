
# Get Movement Object Transfer Response

## Structure

`GetMovementObjectTransferResponse`

## Inherits From

[`GetBalanceOperationResponse`](../../doc/models/get-balance-operation-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceType` | `string` | Optional | - |
| `SourceId` | `string` | Optional | - |
| `TargetType` | `string` | Optional | - |
| `TargetId` | `string` | Optional | - |
| `Fee` | `string` | Optional | - |
| `FundingDate` | `string` | Optional | - |
| `FundingEstimatedDate` | `string` | Optional | - |
| `BankAccount` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id6",
  "status": "status2",
  "balance_amount": "balance_amount4",
  "balance_old_amount": "balance_old_amount6",
  "type": "type4",
  "movement_object": "transfer",
  "source_type": "source_type0",
  "source_id": "source_id6",
  "target_type": "target_type2",
  "target_id": "target_id0",
  "fee": "fee2"
}
```

