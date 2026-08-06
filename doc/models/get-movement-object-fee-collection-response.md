
# Get Movement Object Fee Collection Response

Generic response object for getting a MovementObjectFeeCollection.

## Structure

`GetMovementObjectFeeCollectionResponse`

## Inherits From

[`GetMovementObjectBaseResponse`](../../doc/models/get-movement-object-base-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `PaymentDate` | `string` | Optional | - |
| `RecipientId` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetMovementObjectFeeCollectionResponse getMovementObjectFeeCollectionResponse = new GetMovementObjectFeeCollectionResponse
{
    Description = "description0",
    PaymentDate = "payment_date8",
    RecipientId = "recipient_id0",
    Id = "id2",
    Status = "status4",
    Amount = "amount4",
    CreatedAt = "created_at0",
};
```

