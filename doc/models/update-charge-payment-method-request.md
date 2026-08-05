
# Update Charge Payment Method Request

Request for updating the payment method of a charge

## Structure

`UpdateChargePaymentMethodRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpdateSubscription` | `bool` | Required | Indicates if the payment method from the subscription must also be updated |
| `PaymentMethod` | `string` | Required | The new payment method |
| `CreditCard` | [`CreateCreditCardPaymentRequest`](../../doc/models/create-credit-card-payment-request.md) | Required | Credit card data |
| `DebitCard` | [`CreateDebitCardPaymentRequest`](../../doc/models/create-debit-card-payment-request.md) | Required | Debit card data |
| `Boleto` | [`CreateBoletoPaymentRequest`](../../doc/models/create-boleto-payment-request.md) | Required | Boleto data |
| `Voucher` | [`CreateVoucherPaymentRequest`](../../doc/models/create-voucher-payment-request.md) | Required | Voucher data |
| `Cash` | [`CreateCashPaymentRequest`](../../doc/models/create-cash-payment-request.md) | Required | Cash data |
| `BankTransfer` | [`CreateBankTransferPaymentRequest`](../../doc/models/create-bank-transfer-payment-request.md) | Required | Bank Transfer data |
| `PrivateLabel` | [`CreatePrivateLabelPaymentRequest`](../../doc/models/create-private-label-payment-request.md) | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateChargePaymentMethodRequest updateChargePaymentMethodRequest = new UpdateChargePaymentMethodRequest
{
    UpdateSubscription = false,
    PaymentMethod = null,
    CreditCard = new CreateCreditCardPaymentRequest
    {
        Installments = 1,
        StatementDescriptor = "statement_descriptor8",
        Card = null,
        CardId = "card_id4",
        CardToken = "card_token2",
        Capture = true,
        RecurrencyCycle = "\"first\" or \"subsequent\"",
    },
    DebitCard = null,
    Boleto = null,
    Voucher = new CreateVoucherPaymentRequest
    {
        StatementDescriptor = "statement_descriptor2",
        CardId = "card_id8",
        CardToken = "card_token8",
        Card = null,
        RecurrencyCycle = "\"first\" or \"subsequent\"",
    },
    Cash = null,
    BankTransfer = null,
    PrivateLabel = new CreatePrivateLabelPaymentRequest
    {
        Installments = 1,
        StatementDescriptor = "statement_descriptor0",
        Card = new CreateCardRequest
        {
        },
        CardId = "card_id6",
        CardToken = "card_token0",
        Capture = true,
        RecurrencyCycle = "\"first\" or \"subsequent\"",
    },
};
```

