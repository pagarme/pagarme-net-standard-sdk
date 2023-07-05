
# Get Payable Response

Response object for getting an payable

## Structure

`GetPayableResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `Status` | `string` | Optional | - |
| `Amount` | `int?` | Optional | - |
| `Fee` | `int?` | Optional | - |
| `AnticipationFee` | `int?` | Optional | - |
| `FraudCoverageFee` | `int?` | Optional | - |
| `Installment` | `int?` | Optional | - |
| `GatewayId` | `int?` | Optional | - |
| `ChargeId` | `string` | Optional | - |
| `SplitId` | `string` | Optional | - |
| `BulkAnticipationId` | `string` | Optional | - |
| `AnticipationId` | `string` | Optional | - |
| `RecipientId` | `string` | Optional | - |
| `OriginatorModel` | `string` | Optional | - |
| `OriginatorModelId` | `string` | Optional | - |
| `PaymentDate` | `DateTime?` | Optional | - |
| `OriginalPaymentDate` | `DateTime?` | Optional | - |
| `Type` | `string` | Optional | - |
| `PaymentMethod` | `string` | Optional | - |
| `AccrualAt` | `DateTime?` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `LiquidationArrangementId` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": 112,
  "status": "status8",
  "amount": 46,
  "fee": 168,
  "anticipation_fee": 140
}
```

