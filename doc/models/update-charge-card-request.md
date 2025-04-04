
# Update Charge Card Request

Request for updating card data

## Structure

`UpdateChargeCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdateSubscription` | `bool` | Required | Indicates if the subscriptions using this card must also be updated |
| `CardId` | `string` | Required | Card id |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Card data |
| `Recurrence` | `bool` | Required | Indicates a recurrence |
| `InitiatedType` | `string` | Optional | - |
| `RecurrenceModel` | `string` | Optional | - |
| `PaymentOrigin` | [`CreatePaymentOriginRequest`](../../doc/models/create-payment-origin-request.md) | Optional | - |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example (as JSON)

```json
{
  "update_subscription": false,
  "card_id": "card_id2",
  "card": {
    "type": "credit",
    "number": "number6",
    "holder_name": "holder_name2",
    "exp_month": 228,
    "exp_year": 68,
    "cvv": "cvv4"
  },
  "recurrence": false,
  "initiated_type": "initiated_type8",
  "recurrence_model": "recurrence_model6",
  "payment_origin": {
    "brand_id": "brand_id8",
    "charge_id": "charge_id2"
  },
  "indirect_acceptor": "indirect_acceptor2"
}
```

