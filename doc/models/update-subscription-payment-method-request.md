
# Update Subscription Payment Method Request

Request for updating a subscription's payment method

## Structure

`UpdateSubscriptionPaymentMethodRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentMethod` | `string` | Required | The new payment method |
| `CardId` | `string` | Required | Card id |
| `Card` | [`Models.CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Card data |
| `CardToken` | `string` | Optional | The Card Token |
| `Boleto` | [`Models.CreateSubscriptionBoletoRequest`](../../doc/models/create-subscription-boleto-request.md) | Optional | Information about fines and interest on the "boleto" used from payment |

## Example (as JSON)

```json
{
  "payment_method": null,
  "card_id": null,
  "card": {
    "type": "credit"
  }
}
```

