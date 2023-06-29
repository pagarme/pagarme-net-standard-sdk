
# Get Movement Object Fee Collection Response

Generic response object for getting a MovementObjectFeeCollection.

## Structure

`GetMovementObjectFeeCollectionResponse`

## Inherits From

[`GetBalanceOperationResponse`](../../doc/models/get-balance-operation-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `PaymentDate` | `string` | Optional | - |
| `RecipientId` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id4",
  "status": "status4",
  "balance_amount": "balance_amount4",
  "balance_old_amount": "balance_old_amount2",
  "type": "type6",
  "movement_object": "FeeCollection",
  "description": "description0",
  "payment_date": "payment_date8",
  "recipient_id": "recipient_id0"
}
```

