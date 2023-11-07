
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
| `Recipient` | [`GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `Pgid` | `string` | Optional | Anticipation id on the gateway |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `UpdatedAt` | `DateTime?` | Optional | Last update date |
| `PaymentDate` | `DateTime?` | Optional | Payment date |
| `Status` | `string` | Optional | Status |
| `Timeframe` | `string` | Optional | Timeframe |

## Example (as JSON)

```json
{
  "id": "id8",
  "requested_amount": 130,
  "approved_amount": 184,
  "recipient": {
    "id": "id8",
    "name": "name8",
    "email": "email8",
    "document": "document8",
    "description": "description2"
  },
  "pgid": "pgid4"
}
```

