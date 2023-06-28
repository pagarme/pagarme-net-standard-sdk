
# Get Movement Object Transfer Response

## Structure

`GetMovementObjectTransferResponse`

## Inherits From

[`GetMovementObjectBaseResponse`](../../doc/models/get-movement-object-base-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceType` | `string` | Required | - |
| `SourceId` | `string` | Required | - |
| `TargetType` | `string` | Required | - |
| `TargetId` | `string` | Required | - |
| `Fee` | `string` | Required | - |
| `FundingDate` | `string` | Required | - |
| `FundingEstimatedDate` | `string` | Required | - |
| `BankAccount` | `string` | Required | - |

## Example (as JSON)

```json
{
  "object": "GetMovementObjectTransferResponse",
  "id": "id6",
  "status": "status2",
  "amount": "amount8",
  "created_at": "created_at4",
  "source_type": "source_type0",
  "source_id": "source_id6",
  "target_type": "target_type2",
  "target_id": "target_id0",
  "fee": "fee2",
  "funding_date": "funding_date2",
  "funding_estimated_date": "funding_estimated_date8",
  "bank_account": "bank_account4"
}
```

