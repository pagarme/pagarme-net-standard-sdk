
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
| `DefaultBankAccount` | [`Models.GetBankAccountResponse`](../../doc/models/get-bank-account-response.md) | Optional | Default bank account |
| `GatewayRecipients` | [`List<Models.GetGatewayRecipientResponse>`](../../doc/models/get-gateway-recipient-response.md) | Optional | Info about the recipient on the gateway |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `AutomaticAnticipationSettings` | [`Models.GetAutomaticAnticipationResponse`](../../doc/models/get-automatic-anticipation-response.md) | Optional | - |
| `TransferSettings` | [`Models.GetTransferSettingsResponse`](../../doc/models/get-transfer-settings-response.md) | Optional | - |
| `Code` | `string` | Optional | Recipient code |
| `PaymentMode` | `string` | Optional | Payment mode<br>**Default**: `"bank_transfer"` |

## Example (as JSON)

```json
{
  "payment_mode": "bank_transfer",
  "id": "id0",
  "name": "name0",
  "email": "email6",
  "document": "document6",
  "description": "description0"
}
```

