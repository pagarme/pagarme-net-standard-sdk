
# Get Pix Bank Account Response

Payer's bank details.

## Structure

`GetPixBankAccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankName` | `string` | Optional | - |
| `Ispb` | `string` | Optional | - |
| `BranchCode` | `string` | Optional | - |
| `AccountNumber` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPixBankAccountResponse getPixBankAccountResponse = new GetPixBankAccountResponse
{
    BankName = "bank_name4",
    Ispb = "ispb4",
    BranchCode = "branch_code8",
    AccountNumber = "account_number0",
};
```

