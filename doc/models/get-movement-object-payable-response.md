
# Get Movement Object Payable Response

## Structure

`GetMovementObjectPayableResponse`

## Inherits From

[`GetMovementObjectBaseResponse`](../../doc/models/get-movement-object-base-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Fee` | `string` | Optional | - |
| `AnticipationFee` | `string` | Required | - |
| `FraudCoverageFee` | `string` | Required | - |
| `Installment` | `string` | Required | - |
| `SplitId` | `string` | Required | - |
| `BulkAnticipationId` | `string` | Required | - |
| `AnticipationId` | `string` | Required | - |
| `RecipientId` | `string` | Required | - |
| `OriginatorModel` | `string` | Required | - |
| `OriginatorModelId` | `string` | Required | - |
| `PaymentDate` | `string` | Required | - |
| `OriginalPaymentDate` | `string` | Required | - |
| `PaymentMethod` | `string` | Required | - |
| `AccrualAt` | `string` | Required | - |
| `LiquidationArrangementId` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": "id2",
  "status": "status4",
  "amount": "amount4",
  "created_at": "created_at0",
  "fee": "fee2",
  "anticipation_fee": "anticipation_fee2",
  "fraud_coverage_fee": "fraud_coverage_fee8",
  "installment": "installment8",
  "split_id": "split_id2",
  "bulk_anticipation_id": "bulk_anticipation_id6",
  "anticipation_id": "anticipation_id0",
  "recipient_id": "recipient_id0",
  "originator_model": "originator_model6",
  "originator_model_id": "originator_model_id6",
  "payment_date": "payment_date2",
  "original_payment_date": "original_payment_date2",
  "payment_method": "payment_method0",
  "accrual_at": "accrual_at2",
  "liquidation_arrangement_id": "liquidation_arrangement_id4"
}
```

