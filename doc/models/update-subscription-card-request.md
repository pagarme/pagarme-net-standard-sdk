
# Update Subscription Card Request

Request for updating the card from a subscription

## Structure

`UpdateSubscriptionCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Credit card data |
| `CardId` | `string` | Required | Credit card id |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example (as JSON)

```json
{
  "card": {
    "type": "credit",
    "number": "number6",
    "holder_name": "holder_name2",
    "exp_month": 228,
    "exp_year": 68,
    "cvv": "cvv4"
  },
  "card_id": "card_id0",
  "indirect_acceptor": "indirect_acceptor0"
}
```

