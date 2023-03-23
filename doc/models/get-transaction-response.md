
# Get Transaction Response

Generic response object for getting a transaction.

## Structure

`GetTransactionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GatewayId` | `string` | Optional | Gateway transaction id |
| `Amount` | `int?` | Optional | Amount in cents |
| `Status` | `string` | Optional | Transaction status |
| `Success` | `bool?` | Optional | Indicates if the transaction ocurred successfuly |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `UpdatedAt` | `DateTime?` | Optional | Last update date |
| `AttemptCount` | `int?` | Optional | Number of attempts tried |
| `MaxAttempts` | `int?` | Optional | Max attempts |
| `Splits` | [`List<Models.GetSplitResponse>`](../../doc/models/get-split-response.md) | Optional | Splits |
| `NextAttempt` | `DateTime?` | Optional | Date and time of the next attempt |
| `TransactionType` | `string` | Optional | - |
| `Id` | `string` | Optional | Código da transação |
| `GatewayResponse` | [`Models.GetGatewayResponseResponse`](../../doc/models/get-gateway-response-response.md) | Optional | The Gateway Response |
| `AntifraudResponse` | [`Models.GetAntifraudResponse`](../../doc/models/get-antifraud-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Split` | [`List<Models.GetSplitResponse>`](../../doc/models/get-split-response.md) | Optional | - |
| `Interest` | [`Models.GetInterestResponse`](../../doc/models/get-interest-response.md) | Optional | - |
| `Fine` | [`Models.GetFineResponse`](../../doc/models/get-fine-response.md) | Optional | - |
| `MaxDaysToPayPastDue` | `int?` | Optional | - |

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
  "transaction_type": "transaction",
  "id": null,
  "gateway_response": null,
  "antifraud_response": null,
  "metadata": null,
  "split": null,
  "interest": null,
  "fine": null,
  "max_days_to_pay_past_due": null
}
```

