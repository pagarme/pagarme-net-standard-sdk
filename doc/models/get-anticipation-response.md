
# Get Anticipation Response

Anticipation

## Structure

`GetAnticipationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `RequestedAmount` | `int?` | Optional | Requested amount |
| `ApprovedAmount` | `int?` | Optional | Approved amount |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `Pgid` | `string` | Optional | Anticipation id on the gateway |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `UpdatedAt` | `DateTime?` | Optional | Last update date |
| `PaymentDate` | `DateTime?` | Optional | Payment date |
| `Status` | `string` | Optional | Status |
| `Timeframe` | `string` | Optional | Timeframe |

## Example (as JSON)

```json
{
  "id": null,
  "requested_amount": null,
  "approved_amount": null,
  "recipient": null,
  "pgid": null,
  "created_at": null,
  "updated_at": null,
  "payment_date": null,
  "status": null,
  "timeframe": null
}
```

