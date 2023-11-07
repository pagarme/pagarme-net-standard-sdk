
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
| `Splits` | [`List<GetSplitResponse>`](../../doc/models/get-split-response.md) | Optional | Splits |
| `NextAttempt` | `DateTime?` | Optional | Date and time of the next attempt |
| `TransactionType` | `string` | Optional | - |
| `Id` | `string` | Optional | Código da transação |
| `GatewayResponse` | [`GetGatewayResponseResponse`](../../doc/models/get-gateway-response-response.md) | Optional | The Gateway Response |
| `AntifraudResponse` | [`GetAntifraudResponse`](../../doc/models/get-antifraud-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Split` | [`List<GetSplitResponse>`](../../doc/models/get-split-response.md) | Optional | - |
| `Interest` | [`GetInterestResponse`](../../doc/models/get-interest-response.md) | Optional | - |
| `Fine` | [`GetFineResponse`](../../doc/models/get-fine-response.md) | Optional | - |
| `MaxDaysToPayPastDue` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "gateway_id": "gateway_id8",
  "amount": 40,
  "status": "status6",
  "success": false,
  "created_at": "2016-03-13T12:52:32.123Z",
  "qr_code": "qr_code0",
  "qr_code_url": "qr_code_url6",
  "expires_at": "2016-03-13T12:52:32.123Z",
  "additional_information": [
    {
      "Name": "Name0",
      "Value": "Value2"
    },
    {
      "Name": "Name0",
      "Value": "Value2"
    }
  ],
  "end_to_end_id": "end_to_end_id6"
}
```

