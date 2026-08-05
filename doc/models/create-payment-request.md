
# Create Payment Request

Payment data

## Structure

`CreatePaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentMethod` | `string` | Required | Payment method |
| `CreditCard` | [`CreateCreditCardPaymentRequest`](../../doc/models/create-credit-card-payment-request.md) | Optional | Settings for credit card payment |
| `DebitCard` | [`CreateDebitCardPaymentRequest`](../../doc/models/create-debit-card-payment-request.md) | Optional | Settings for debit card payment |
| `Boleto` | [`CreateBoletoPaymentRequest`](../../doc/models/create-boleto-payment-request.md) | Optional | Settings for boleto payment |
| `Currency` | `string` | Optional | Currency. Must be informed using 3 characters |
| `Voucher` | [`CreateVoucherPaymentRequest`](../../doc/models/create-voucher-payment-request.md) | Optional | Settings for voucher payment |
| `Split` | [`List<CreateSplitRequest>`](../../doc/models/create-split-request.md) | Optional | Splits |
| `BankTransfer` | [`CreateBankTransferPaymentRequest`](../../doc/models/create-bank-transfer-payment-request.md) | Optional | Settings for bank transfer payment |
| `GatewayAffiliationId` | `string` | Optional | Gateway affiliation code |
| `Amount` | `int?` | Optional | The amount of the payment, in cents |
| `Checkout` | [`CreateCheckoutPaymentRequest`](../../doc/models/create-checkout-payment-request.md) | Optional | Settings for checkout payment |
| `CustomerId` | `string` | Optional | Customer Id |
| `Customer` | [`CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Optional | Customer |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `Cash` | [`CreateCashPaymentRequest`](../../doc/models/create-cash-payment-request.md) | Optional | Settings for cash payment |
| `PrivateLabel` | [`CreatePrivateLabelPaymentRequest`](../../doc/models/create-private-label-payment-request.md) | Optional | Settings for private label payment |
| `Pix` | [`CreatePixPaymentRequest`](../../doc/models/create-pix-payment-request.md) | Optional | Settings for pix payment |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreatePaymentRequest createPaymentRequest = new CreatePaymentRequest
{
    PaymentMethod = "payment_method6",
    CreditCard = null,
    DebitCard = null,
    Boleto = null,
    Currency = "currency4",
    Voucher = null,
};
```

