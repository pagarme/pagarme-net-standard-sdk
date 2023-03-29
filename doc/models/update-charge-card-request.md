
# Update Charge Card Request

Request for updating card data

## Structure

`UpdateChargeCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdateSubscription` | `bool` | Required | Indicates if the subscriptions using this card must also be updated |
| `CardId` | `string` | Required | Card id |
| `Card` | [`Models.CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Card data |
| `Recurrence` | `bool` | Required | Indicates a recurrence |

## Example (as JSON)

```json
{
  "update_subscription": false,
  "card_id": "card_id4",
  "card": {
    "number": null,
    "holder_name": null,
    "exp_month": null,
    "exp_year": null,
    "cvv": null,
    "billing_address": null,
    "brand": null,
    "billing_address_id": null,
    "metadata": null,
    "type": null,
    "options": null,
    "holder_document": null,
    "private_label": null,
    "label": null,
    "id": null,
    "token": null
  },
  "recurrence": false
}
```

