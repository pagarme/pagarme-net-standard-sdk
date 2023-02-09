
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
  "id": null,
  "amount": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "bank_account": null,
  "metadata": null
}
```

