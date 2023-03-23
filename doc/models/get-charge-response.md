
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
| `LastTransaction` | [`Models.GetTransactionResponse`](../../doc/models/get-transaction-response.md) | Optional | - |
| `Invoice` | [`Models.GetInvoiceResponse`](../../doc/models/get-invoice-response.md) | Optional | - |
| `Order` | [`Models.GetOrderResponse`](../../doc/models/get-order-response.md) | Optional | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `PaidAt` | `DateTime?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `CanceledAmount` | `int?` | Optional | Canceled Amount |
| `PaidAmount` | `int?` | Optional | Paid amount |
| `InterestAndFinePaid` | `int?` | Optional | interest and fine paid |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |

## Example (as JSON)

```json
{
  "id": null,
  "code": null,
  "gateway_id": null,
  "amount": null,
  "status": null,
  "currency": null,
  "payment_method": null,
  "due_at": null,
  "created_at": null,
  "updated_at": null,
  "last_transaction": null,
  "invoice": null,
  "order": null,
  "customer": null,
  "metadata": null,
  "paid_at": null,
  "canceled_at": null,
  "canceled_amount": null,
  "paid_amount": null,
  "interest_and_fine_paid": null,
  "recurrency_cycle": null
}
```

