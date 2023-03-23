
# Get Bank Account Response

## Structure

`GetBankAccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `HolderName` | `string` | Optional | Holder name |
| `HolderType` | `string` | Optional | Holder type |
| `Bank` | `string` | Optional | Bank |
| `BranchNumber` | `string` | Optional | Branch number |
| `BranchCheckDigit` | `string` | Optional | Branch check digit |
| `AccountNumber` | `string` | Optional | Account number |
| `AccountCheckDigit` | `string` | Optional | Account check digit |
| `Type` | `string` | Optional | Bank account type |
| `Status` | `string` | Optional | Bank account status |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `UpdatedAt` | `DateTime?` | Optional | Last update date |
| `DeletedAt` | `DateTime?` | Optional | Deletion date |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `PixKey` | `string` | Optional | Pix Key |

## Example (as JSON)

```json
{
  "id": null,
  "holder_name": null,
  "holder_type": null,
  "bank": null,
  "branch_number": null,
  "branch_check_digit": null,
  "account_number": null,
  "account_check_digit": null,
  "type": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "deleted_at": null,
  "recipient": null,
  "metadata": null,
  "pix_key": null
}
```

