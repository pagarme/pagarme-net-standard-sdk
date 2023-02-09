
# Get Balance Response

Balance

## Structure

`GetBalanceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Optional | Currency |
| `AvailableAmount` | `long?` | Optional | Amount available for transferring |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `TransferredAmount` | `long?` | Optional | - |
| `WaitingFundsAmount` | `long?` | Optional | - |

## Example (as JSON)

```json
{
  "currency": null,
  "available_amount": null,
  "recipient": null,
  "transferred_amount": null,
  "waiting_funds_amount": null
}
```

