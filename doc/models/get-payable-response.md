
# Get Payable Response

Response object for getting an payable

## Structure

`GetPayableResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Status` | `string` | Required | - |
| `Amount` | `int` | Required | - |
| `Fee` | `int` | Required | - |
| `AnticipationFee` | `int` | Required | - |
| `FraudCoverageFee` | `int` | Required | - |
| `Installment` | `int` | Required | - |
| `GatewayId` | `int` | Required | - |
| `ChargeId` | `string` | Required | - |
| `SplitId` | `string` | Required | - |
| `BulkAnticipationId` | `string` | Required | - |
| `AnticipationId` | `string` | Required | - |
| `RecipientId` | `string` | Required | - |
| `OriginatorModel` | `string` | Required | - |
| `OriginatorModelId` | `string` | Required | - |
| `PaymentDate` | `DateTime` | Required | - |
| `OriginalPaymentDate` | `DateTime` | Required | - |
| `Type` | `string` | Required | - |
| `PaymentMethod` | `string` | Required | - |
| `AccrualAt` | `DateTime` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `LiquidationArrangementId` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": 112,
  "status": "status8",
  "amount": 46,
  "fee": 168,
  "anticipation_fee": 140,
  "fraud_coverage_fee": 86,
  "installment": 188,
  "gateway_id": 196,
  "charge_id": "charge_id8",
  "split_id": "split_id2",
  "bulk_anticipation_id": "bulk_anticipation_id4",
  "anticipation_id": "anticipation_id0",
  "recipient_id": "recipient_id0",
  "originator_model": "originator_model4",
  "originator_model_id": "originator_model_id4",
  "payment_date": "2016-03-13T12:52:32.123Z",
  "original_payment_date": "2016-03-13T12:52:32.123Z",
  "type": "type0",
  "payment_method": "payment_method0",
  "accrual_at": "2016-03-13T12:52:32.123Z",
  "created_at": "2016-03-13T12:52:32.123Z",
  "liquidation_arrangement_id": "liquidation_arrangement_id6"
}
```

