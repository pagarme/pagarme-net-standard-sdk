
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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateRecipientRequest createRecipientRequest = new CreateRecipientRequest
{
    DefaultBankAccount = null,
    Metadata = null,
    Code = null,
    PaymentMode = "bank_transfer",
    Name = "name2",
    Email = "email4",
    Description = "description2",
    Document = "document4",
    Type = "type8",
};
```

