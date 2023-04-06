
# Update Charge Payment Method Request

Request for updating the payment method of a charge

## Structure

`UpdateChargePaymentMethodRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdateSubscription` | `bool` | Required | Indicates if the payment method from the subscription must also be updated |
| `PaymentMethod` | `string` | Required | The new payment method |
| `CreditCard` | [`Models.CreateCreditCardPaymentRequest`](../../doc/models/create-credit-card-payment-request.md) | Required | Credit card data |
| `DebitCard` | [`Models.CreateDebitCardPaymentRequest`](../../doc/models/create-debit-card-payment-request.md) | Required | Debit card data |
| `Boleto` | [`Models.CreateBoletoPaymentRequest`](../../doc/models/create-boleto-payment-request.md) | Required | Boleto data |
| `Voucher` | [`Models.CreateVoucherPaymentRequest`](../../doc/models/create-voucher-payment-request.md) | Required | Voucher data |
| `Cash` | [`Models.CreateCashPaymentRequest`](../../doc/models/create-cash-payment-request.md) | Required | Cash data |
| `BankTransfer` | [`Models.CreateBankTransferPaymentRequest`](../../doc/models/create-bank-transfer-payment-request.md) | Required | Bank Transfer data |
| `PrivateLabel` | [`Models.CreatePrivateLabelPaymentRequest`](../../doc/models/create-private-label-payment-request.md) | Required | - |

## Example (as JSON)

```json
{
  "update_subscription": null,
  "payment_method": null,
  "credit_card": {
    "installments": 1,
    "capture": true,
    "recurrency_cycle": "\"first\" or \"subsequent\""
  },
  "debit_card": null,
  "boleto": null,
  "voucher": {
    "recurrency_cycle": "\"first\" or \"subsequent\""
  },
  "cash": null,
  "bank_transfer": null,
  "private_label": {
    "installments": 1,
    "capture": true,
    "recurrency_cycle": "\"first\" or \"subsequent\""
  }
}
```

