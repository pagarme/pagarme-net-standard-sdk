
# Get Charge Response

Response object for getting a charge

## Structure

`GetChargeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Code` | `string` | Required | - |
| `GatewayId` | `string` | Required | - |
| `Amount` | `int?` | Required | - |
| `Status` | `string` | Required | - |
| `Currency` | `string` | Required | - |
| `PaymentMethod` | `string` | Required | - |
| `DueAt` | `DateTime?` | Required | - |
| `CreatedAt` | `DateTime?` | Required | - |
| `UpdatedAt` | `DateTime?` | Required | - |
| `LastTransaction` | [`Models.GetTransactionResponse`](../../doc/models/get-transaction-response.md) | Required | - |
| `Invoice` | [`Models.GetInvoiceResponse`](../../doc/models/get-invoice-response.md) | Optional | - |
| `Order` | [`Models.GetOrderResponse`](../../doc/models/get-order-response.md) | Optional | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Required | - |
| `PaidAt` | `DateTime?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `CanceledAmount` | `int?` | Required | Canceled Amount |
| `PaidAmount` | `int?` | Required | Paid amount |
| `InterestAndFinePaid` | `int?` | Optional | interest and fine paid |
| `RecurrencyCycle` | `string` | Optional | Defines whether the card has been used one or more times. |

## Example (as JSON)

```json
{
  "id": "id0",
  "code": "code8",
  "gateway_id": "gateway_id0",
  "amount": 46,
  "status": "status8",
  "currency": "currency0",
  "payment_method": "payment_method0",
  "due_at": "2016-03-13T12:52:32.123Z",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "last_transaction": {
    "gateway_id": "gateway_id8",
    "amount": 12,
    "status": "status4",
    "success": false,
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
    "attempt_count": 244,
    "max_attempts": 232,
    "splits": [
      {
        "type": "type6",
        "amount": 200,
        "recipient": null,
        "gateway_id": "gateway_id6",
        "options": null,
        "id": "id4"
      },
      {
        "type": "type5",
        "amount": 201,
        "recipient": null,
        "gateway_id": "gateway_id5",
        "options": null,
        "id": "id5"
      }
    ],
    "next_attempt": null,
    "id": "id2",
    "gateway_response": {
      "code": "code2",
      "errors": [
        {
          "message": "message9"
        },
        {
          "message": "message0"
        }
      ]
    },
    "antifraud_response": {
      "status": "status2",
      "return_code": "return_code0",
      "return_message": "return_message8",
      "provider_name": "provider_name8",
      "score": "score0"
    },
    "metadata": null,
    "split": [
      {
        "type": "type0",
        "amount": 214,
        "recipient": null,
        "gateway_id": "gateway_id0",
        "options": null,
        "id": "id0"
      }
    ],
    "interest": null,
    "fine": null,
    "max_days_to_pay_past_due": null,
    "transaction_type": "transaction"
  },
  "invoice": null,
  "order": null,
  "customer": null,
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "paid_at": null,
  "canceled_at": null,
  "canceled_amount": 64,
  "paid_amount": 210,
  "interest_and_fine_paid": null,
  "recurrency_cycle": null
}
```

