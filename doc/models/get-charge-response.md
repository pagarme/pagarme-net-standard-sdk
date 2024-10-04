
# Get Charge Response

Response object for getting a charge

## Structure

`GetChargeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Code` | `string` | Optional | - |
| `GatewayId` | `string` | Optional | - |
| `Amount` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `PaymentMethod` | `string` | Optional | - |
| `DueAt` | `DateTime?` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `LastTransaction` | [`GetTransactionResponse`](../../doc/models/get-transaction-response.md) | Optional | - |
| `Invoice` | [`GetInvoiceResponse`](../../doc/models/get-invoice-response.md) | Optional | - |
| `Order` | [`GetOrderResponse`](../../doc/models/get-order-response.md) | Optional | - |
| `Customer` | [`GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `PaidAt` | `DateTime?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `CanceledAmount` | `int?` | Optional | Canceled Amount |
| `PaidAmount` | `int?` | Optional | Paid amount |
| `InterestAndFinePaid` | `int?` | Optional | interest and fine paid |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |
| `PaymentOrigin` | [`GetPaymentOriginResponse`](../../doc/models/get-payment-origin-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "recurrency_cycle": "\"first\" or \"subsequent\"",
  "id": "id0",
  "code": "code8",
  "gateway_id": "gateway_id0",
  "amount": 164,
  "status": "status2"
}
```

