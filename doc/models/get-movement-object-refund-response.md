
# Get Movement Object Refund Response

Generic response object for getting a MovementObjectRefund.

## Structure

`GetMovementObjectRefundResponse`

## Inherits From

[`GetMovementObjectBaseResponse`](../../doc/models/get-movement-object-base-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FraudCoverageFee` | `string` | Optional | - |
| `ChargeFeeRecipientId` | `string` | Optional | - |
| `BankAccountId` | `string` | Optional | - |
| `LocalTransactionId` | `string` | Optional | - |
| `UpdatedAt` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetMovementObjectRefundResponse getMovementObjectRefundResponse = new GetMovementObjectRefundResponse
{
    FraudCoverageFee = "fraud_coverage_fee2",
    ChargeFeeRecipientId = "charge_fee_recipient_id0",
    BankAccountId = "bank_account_id4",
    LocalTransactionId = "local_transaction_id0",
    UpdatedAt = "updated_at0",
    Id = "id2",
    Status = "status4",
    Amount = "amount4",
    CreatedAt = "created_at0",
};
```

