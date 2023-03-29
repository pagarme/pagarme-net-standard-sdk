
# Get Credit Card Transaction Response

Response object for getting a credit card transaction

## Structure

`GetCreditCardTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Text that will appear on the credit card's statement |
| `AcquirerName` | `string` | Optional | Acquirer name |
| `AcquirerAffiliationCode` | `string` | Optional | Aquirer affiliation code |
| `AcquirerTid` | `string` | Optional | Acquirer TID |
| `AcquirerNsu` | `string` | Optional | Acquirer NSU |
| `AcquirerAuthCode` | `string` | Optional | Acquirer authorization code |
| `OperationType` | `string` | Optional | Operation type |
| `Card` | [`Models.GetCardResponse`](../../doc/models/get-card-response.md) | Optional | Card data |
| `AcquirerMessage` | `string` | Optional | Acquirer message |
| `AcquirerReturnCode` | `string` | Optional | Acquirer Return Code |
| `Installments` | `int?` | Optional | Number of installments |
| `ThreedAuthenticationUrl` | `string` | Optional | 3D-S authentication Url |
| `FundingSource` | `string` | Optional | Identify when a card is prepaid, credit or debit. |

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
  "transaction_type": "credit_card",
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
  "installments": null,
  "threed_authentication_url": null,
  "funding_source": null
}
```

