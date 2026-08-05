
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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetMovementObjectPayableResponse getMovementObjectPayableResponse = new GetMovementObjectPayableResponse
{
    AnticipationFee = "anticipation_fee4",
    FraudCoverageFee = "fraud_coverage_fee2",
    Installment = "installment2",
    SplitId = "split_id6",
    BulkAnticipationId = "bulk_anticipation_id0",
    AnticipationId = "anticipation_id6",
    RecipientId = "recipient_id6",
    OriginatorModel = "originator_model0",
    OriginatorModelId = "originator_model_id0",
    PaymentDate = "payment_date6",
    OriginalPaymentDate = "original_payment_date6",
    PaymentMethod = "payment_method4",
    AccrualAt = "accrual_at6",
    LiquidationArrangementId = "liquidation_arrangement_id8",
    Fee = "fee6",
    Id = "id2",
    Status = "status4",
    Amount = "amount4",
    CreatedAt = "created_at0",
};
```

