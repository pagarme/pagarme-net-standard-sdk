
# Get Movement Object Refund Response

Generic response object for getting a MovementObjectRefund.

## Structure

`GetMovementObjectRefundResponse`

## Inherits From

[`GetBalanceOperationResponse`](../../doc/models/get-balance-operation-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FraudCoverageFee` | `string` | Optional | - |
| `ChargeFeeRecipientId` | `string` | Optional | - |
| `BankAccountId` | `string` | Optional | - |
| `LocalTransactionId` | `string` | Optional | - |
| `UpdatedAt` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id2",
  "status": "status4",
  "balance_amount": "balance_amount2",
  "balance_old_amount": "balance_old_amount0",
  "type": "type8",
  "movement_object": "refund",
  "fraud_coverage_fee": "fraud_coverage_fee2",
  "charge_fee_recipient_id": "charge_fee_recipient_id4",
  "bank_account_id": "bank_account_id0",
  "local_transaction_id": "local_transaction_id6",
  "updated_at": "updated_at4"
}
```

