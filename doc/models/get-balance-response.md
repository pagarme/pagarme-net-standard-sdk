
# Get Balance Response

Balance

## Structure

`GetBalanceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Optional | Currency |
| `AvailableAmount` | `long?` | Optional | Amount available for transferring |
| `Recipient` | [`GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `TransferredAmount` | `long?` | Optional | - |
| `WaitingFundsAmount` | `long?` | Optional | - |

## Example (as JSON)

```json
{
  "currency": "currency2",
  "available_amount": 96,
  "recipient": {
    "id": "id8",
    "name": "name8",
    "email": "email8",
    "document": "document8",
    "description": "description2"
  },
  "transferred_amount": 142,
  "waiting_funds_amount": 174
}
```

