
# Get Movement Object Transfer Response

## Structure

`GetMovementObjectTransferResponse`

## Inherits From

[`GetMovementObjectBaseResponse`](../../doc/models/get-movement-object-base-response.md)

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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetMovementObjectTransferResponse getMovementObjectTransferResponse = new GetMovementObjectTransferResponse
{
    SourceType = "source_type6",
    SourceId = "source_id0",
    TargetType = "target_type8",
    TargetId = "target_id4",
    Fee = "fee8",
    Id = "id2",
    Status = "status4",
    Amount = "amount4",
    CreatedAt = "created_at0",
};
```

