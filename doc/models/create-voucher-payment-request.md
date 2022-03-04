
# Create Voucher Payment Request

The settings for creating a voucher payment

## Structure

`CreateVoucherPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | The text that will be shown on the voucher's statement |
| `CardId` | `string` | Optional | Card id |
| `CardToken` | `string` | Optional | Card token |
| `Card` | [`Models.CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Card info |

## Example (as JSON)

```json
{
  "statement_descriptor": null,
  "card_id": null,
  "card_token": null,
  "Card": null
}
```

