
# Get Debit Card Transaction Response

Response object for getting a debit card transaction

## Structure

`GetDebitCardTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Text that will appear on the debit card's statement |
| `AcquirerName` | `string` | Optional | Acquirer name |
| `AcquirerAffiliationCode` | `string` | Optional | Aquirer affiliation code |
| `AcquirerTid` | `string` | Optional | Acquirer TID |
| `AcquirerNsu` | `string` | Optional | Acquirer NSU |
| `AcquirerAuthCode` | `string` | Optional | Acquirer authorization code |
| `OperationType` | `string` | Optional | Operation type |
| `Card` | [`Models.GetCardResponse`](../../doc/models/get-card-response.md) | Optional | Card data |
| `AcquirerMessage` | `string` | Optional | Acquirer message |
| `AcquirerReturnCode` | `string` | Optional | Acquirer Return Code |
| `Mpi` | `string` | Optional | Merchant Plugin |
| `Eci` | `string` | Optional | Electronic Commerce Indicator (ECI) |
| `AuthenticationType` | `string` | Optional | Authentication type |
| `ThreedAuthenticationUrl` | `string` | Optional | 3D-S Authentication Url |

## Example (as JSON)

```json
{
  "gateway_id": null,
  "amount": null,
  "status": null,
  "success": null,
  "created_at": null,
  "updated_at": null,
  "attempt_count": null,
  "max_attempts": null,
  "splits": null,
  "next_attempt": null,
  "transaction_type": "debit_card",
  "id": null,
  "gateway_response": null,
  "antifraud_response": null,
  "metadata": null,
  "split": null,
  "interest": null,
  "fine": null,
  "max_days_to_pay_past_due": null,
  "statement_descriptor": null,
  "acquirer_name": null,
  "acquirer_affiliation_code": null,
  "acquirer_tid": null,
  "acquirer_nsu": null,
  "acquirer_auth_code": null,
  "operation_type": null,
  "card": null,
  "acquirer_message": null,
  "acquirer_return_code": null,
  "mpi": null,
  "eci": null,
  "authentication_type": null,
  "threed_authentication_url": null
}
```

