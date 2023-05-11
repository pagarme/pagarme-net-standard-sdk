
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
  "gateway_id": "gateway_id0",
  "amount": 46,
  "status": "status8",
  "success": false,
  "created_at": "2016-03-13T12:52:32.123Z",
  "transaction_type": "transaction"
}
```

