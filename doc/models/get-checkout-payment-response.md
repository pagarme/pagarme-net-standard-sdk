
# Get Checkout Payment Response

Resposta das configurações de pagamento do checkout

## Structure

`GetCheckoutPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Amount` | `int?` | Optional | Valor em centavos |
| `DefaultPaymentMethod` | `string` | Optional | Meio de pagamento padrão no checkout |
| `SuccessUrl` | `string` | Optional | Url de redirecionamento de sucesso após o checkou |
| `PaymentUrl` | `string` | Optional | Url para pagamento usando o checkout |
| `GatewayAffiliationId` | `string` | Optional | Código da afiliação onde o pagamento será processado no gateway |
| `AcceptedPaymentMethods` | `List<string>` | Optional | Meios de pagamento aceitos no checkout |
| `Status` | `string` | Optional | Status do checkout |
| `SkipCheckoutSuccessPage` | `bool?` | Optional | Pular tela de sucesso pós-pagamento? |
| `CreatedAt` | `DateTime?` | Optional | Data de criação |
| `UpdatedAt` | `DateTime?` | Optional | Data de atualização |
| `CanceledAt` | `DateTime?` | Optional | Data de cancelamento |
| `CustomerEditable` | `bool?` | Optional | Torna o objeto customer editável |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | Dados do comprador |
| `Billingaddress` | [`Models.GetAddressResponse`](../../doc/models/get-address-response.md) | Optional | Dados do endereço de cobrança |
| `CreditCard` | [`Models.GetCheckoutCreditCardPaymentResponse`](../../doc/models/get-checkout-credit-card-payment-response.md) | Optional | Configurações de cartão de crédito |
| `Boleto` | [`Models.GetCheckoutBoletoPaymentResponse`](../../doc/models/get-checkout-boleto-payment-response.md) | Optional | Configurações de boleto |
| `BillingAddressEditable` | `bool?` | Optional | Indica se o billing address poderá ser editado |
| `Shipping` | [`Models.GetShippingResponse`](../../doc/models/get-shipping-response.md) | Optional | Configurações  de entrega |
| `Shippable` | `bool?` | Optional | Indica se possui entrega |
| `ClosedAt` | `DateTime?` | Optional | Data de fechamento |
| `ExpiresAt` | `DateTime?` | Optional | Data de expiração |
| `Currency` | `string` | Optional | Moeda |
| `DebitCard` | [`Models.GetCheckoutDebitCardPaymentResponse`](../../doc/models/get-checkout-debit-card-payment-response.md) | Optional | Configurações de cartão de débito |
| `BankTransfer` | [`Models.GetCheckoutBankTransferPaymentResponse`](../../doc/models/get-checkout-bank-transfer-payment-response.md) | Optional | Bank transfer payment response |
| `AcceptedBrands` | `List<string>` | Optional | Accepted Brands |
| `Pix` | [`Models.GetCheckoutPixPaymentResponse`](../../doc/models/get-checkout-pix-payment-response.md) | Optional | Pix payment response |

## Example (as JSON)

```json
{
  "id": "id0",
  "amount": 46,
  "default_payment_method": "default_payment_method0",
  "success_url": "success_url2",
  "payment_url": "payment_url6"
}
```

