
# Get Recipient Response

Recipient response

## Structure

`GetRecipientResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `Name` | `string` | Optional | Name |
| `Email` | `string` | Optional | Email |
| `Document` | `string` | Optional | Document |
| `Description` | `string` | Optional | Description |
| `Type` | `string` | Optional | Type |
| `Status` | `string` | Optional | Status |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `UpdatedAt` | `DateTime?` | Optional | Last update date |
| `DeletedAt` | `DateTime?` | Optional | Deletion date |
| `DefaultBankAccount` | [`GetBankAccountResponse`](../../doc/models/get-bank-account-response.md) | Optional | Default bank account |
| `GatewayRecipients` | [`List<GetGatewayRecipientResponse>`](../../doc/models/get-gateway-recipient-response.md) | Optional | Info about the recipient on the gateway |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `AutomaticAnticipationSettings` | [`GetAutomaticAnticipationResponse`](../../doc/models/get-automatic-anticipation-response.md) | Optional | - |
| `TransferSettings` | [`GetTransferSettingsResponse`](../../doc/models/get-transfer-settings-response.md) | Optional | - |
| `Code` | `string` | Optional | Recipient code |
| `PaymentMode` | `string` | Optional | Payment mode<br><br>**Default**: `"bank_transfer"` |
| `RegisterInformation` | [`GetRegisterInformationResponse`](../../doc/models/get-register-information-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "payment_mode": "bank_transfer",
  "id": "id4",
  "name": "name4",
  "email": "email2",
  "document": "document2",
  "description": "description6"
}
```

