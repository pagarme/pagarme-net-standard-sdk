
# Create Recipient Request

Request for creating a recipient

## Structure

`CreateRecipientRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Recipient name. Required if the register_information field isn't populated. |
| `Email` | `string` | Optional | Recipient email. Required if the register_information field isn't populated. |
| `Description` | `string` | Optional | Recipient description |
| `Document` | `string` | Optional | Recipient document number. Required if the register_information field isn't populated. |
| `Type` | `string` | Optional | Recipient type. Required if the register_information field isn't populated. |
| `DefaultBankAccount` | [`CreateBankAccountRequest`](../../doc/models/create-bank-account-request.md) | Required | Bank account |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `TransferSettings` | [`CreateTransferSettingsRequest`](../../doc/models/create-transfer-settings-request.md) | Optional | Receiver Transfer Information |
| `Code` | `string` | Required | Recipient code |
| `PaymentMode` | `string` | Required | Payment mode<br><br>**Default**: `"bank_transfer"` |
| `RegisterInformation` | [`CreateRegisterInformationBaseRequest`](../../doc/models/create-register-information-base-request.md) | Optional | Register Information |

## Example (as JSON)

```json
{
  "default_bank_account": {
    "holder_name": "holder_name4",
    "holder_type": "holder_type0",
    "holder_document": "holder_document2",
    "bank": "bank6",
    "branch_number": "branch_number4",
    "branch_check_digit": "branch_check_digit4",
    "account_number": "account_number8",
    "account_check_digit": "account_check_digit4",
    "type": "type2",
    "metadata": {
      "key0": "metadata5",
      "key1": "metadata4",
      "key2": "metadata3"
    },
    "pix_key": "pix_key8"
  },
  "metadata": {
    "key0": "metadata3"
  },
  "code": "code4",
  "payment_mode": "bank_transfer",
  "name": "name6",
  "email": "email0",
  "description": "description6",
  "document": "document0",
  "type": "type4"
}
```

