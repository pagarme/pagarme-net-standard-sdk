
# Get Balance Response

Balance

## Structure

`GetBalanceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | Currency |
| `AvailableAmount` | `long` | Required | Amount available for transferring |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `TransferredAmount` | `long` | Required | - |
| `WaitingFundsAmount` | `long` | Required | - |

## Example (as JSON)

```json
{
  "currency": "currency0",
  "available_amount": 182,
  "recipient": null,
  "transferred_amount": 228,
  "waiting_funds_amount": 252
}
```

