
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

## Example (as JSON)

```json
{
  "object": "feeCollection",
  "id": "id4",
  "status": "status4",
  "amount": "amount6",
  "created_at": "created_at2",
  "description": "description0",
  "payment_date": "payment_date8",
  "recipient_id": "recipient_id0"
}
```

