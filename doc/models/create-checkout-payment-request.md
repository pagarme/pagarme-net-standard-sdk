
# Create Checkout Payment Request

Checkout payment request

## Structure

`CreateCheckoutPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcceptedPaymentMethods` | `List<string>` | Required | Accepted Payment Methods |
| `AcceptedMultiPaymentMethods` | `object` | Required | Accepted Multi Payment Methods |
| `SuccessUrl` | `string` | Required | Success url |
| `DefaultPaymentMethod` | `string` | Optional | Default payment method |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation Id |
| `CreditCard` | [`CreateCheckoutCreditCardPaymentRequest`](../../doc/models/create-checkout-credit-card-payment-request.md) | Optional | Credit Card payment request |
| `DebitCard` | [`CreateCheckoutDebitCardPaymentRequest`](../../doc/models/create-checkout-debit-card-payment-request.md) | Optional | Debit Card payment request |
| `Boleto` | [`CreateCheckoutBoletoPaymentRequest`](../../doc/models/create-checkout-boleto-payment-request.md) | Optional | Boleto payment request |
| `CustomerEditable` | `bool?` | Optional | Customer is editable? |
| `ExpiresIn` | `int?` | Optional | Time in minutes for expiration |
| `SkipCheckoutSuccessPage` | `bool` | Required | Skip postpay success screen? |
| `BillingAddressEditable` | `bool` | Required | Billing Address is editable? |
| `BillingAddress` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Billing Address |
| `BankTransfer` | [`CreateCheckoutBankTransferRequest`](../../doc/models/create-checkout-bank-transfer-request.md) | Optional | Bank Transfer payment request |
| `AcceptedBrands` | `List<string>` | Required | Accepted Brands |
| `Pix` | [`CreateCheckoutPixPaymentRequest`](../../doc/models/create-checkout-pix-payment-request.md) | Optional | Pix payment request |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using PagarmeApiSDK.Standard.Utilities;
using System.Collections.Generic;

CreateCheckoutPaymentRequest createCheckoutPaymentRequest = new CreateCheckoutPaymentRequest
{
    AcceptedPaymentMethods = new List<string>
    {
        "accepted_payment_methods1",
    },
    AcceptedMultiPaymentMethods = new List<object>
    {
        ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    SuccessUrl = "success_url0",
    SkipCheckoutSuccessPage = false,
    BillingAddressEditable = false,
    BillingAddress = null,
    AcceptedBrands = new List<string>
    {
        "accepted_brands6",
    },
    DefaultPaymentMethod = "default_payment_method8",
    GatewayAffiliationId = "gateway_affiliation_id4",
    CreditCard = null,
    DebitCard = null,
    Boleto = null,
};
```

