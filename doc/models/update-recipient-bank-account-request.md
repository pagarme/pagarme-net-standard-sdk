
# Update Recipient Bank Account Request

Updates the default bank account for a recipient

## Structure

`UpdateRecipientBankAccountRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAccount` | [`CreateBankAccountRequest`](../../doc/models/create-bank-account-request.md) | Required | Bank account |
| `PaymentMode` | `string` | Required | Payment mode<br><br>**Default**: `"bank_transfer"` |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateRecipientBankAccountRequest updateRecipientBankAccountRequest = new UpdateRecipientBankAccountRequest
{
    BankAccount = null,
    PaymentMode = "bank_transfer",
};
```

