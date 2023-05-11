
# Get Transfer Response

Transfer response

## Structure

`GetTransferResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `Amount` | `int?` | Optional | Transfer amount |
| `Status` | `string` | Optional | Transfer status |
| `CreatedAt` | `DateTime?` | Optional | Transfer creation date |
| `UpdatedAt` | `DateTime?` | Optional | Transfer last update date |
| `BankAccount` | [`Models.GetBankAccountResponse`](../../doc/models/get-bank-account-response.md) | Optional | Bank account |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |

## Example (as JSON)

```json
{
  "id": "id0",
  "amount": 46,
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z"
}
```

