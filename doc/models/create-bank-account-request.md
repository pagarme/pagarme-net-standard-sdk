
# Create Bank Account Request

Request for creating a bank account

## Structure

`CreateBankAccountRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HolderName` | `string` | Required | Bank account holder name |
| `HolderType` | `string` | Required | Bank account holder type |
| `HolderDocument` | `string` | Required | Bank account holder document |
| `Bank` | `string` | Required | Bank |
| `BranchNumber` | `string` | Required | Branch number |
| `BranchCheckDigit` | `string` | Optional | Branch check digit |
| `AccountNumber` | `string` | Required | Account number |
| `AccountCheckDigit` | `string` | Required | Account check digit |
| `Type` | `string` | Required | Bank account type |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `PixKey` | `string` | Optional | Pix key |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateBankAccountRequest createBankAccountRequest = new CreateBankAccountRequest
{
    HolderName = "holder_name6",
    HolderType = "holder_type2",
    HolderDocument = "holder_document6",
    Bank = "bank8",
    BranchNumber = "branch_number6",
    AccountNumber = "account_number0",
    AccountCheckDigit = "account_check_digit6",
    Type = "type0",
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
        ["key1"] = "metadata4",
    },
    BranchCheckDigit = "branch_check_digit4",
    PixKey = "pix_key6",
};
```

