
# Create Bank Account Refunding DTO

Bank Account

## Structure

`CreateBankAccountRefundingDTO`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HolderName` | `string` | Required | Nome/razão social do favorecido |
| `HolderType` | `string` | Required | Tipo de titular (pessoa física ou jurídica) |
| `HolderDocument` | `string` | Required | CPF ou CNPJ do favorecido |
| `Bank` | `string` | Required | Dígitos que identificam cada banco. |
| `BranchNumber` | `string` | Required | Número da agência bancária |
| `BranchCheckDigit` | `string` | Required | Dígito da agência bancária |
| `AccountNumber` | `string` | Required | Número da conta |
| `AccountCheckDigit` | `string` | Required | Dígito verificador da conta |
| `Type` | `string` | Required | Tipo de conta |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateBankAccountRefundingDTO createBankAccountRefundingDTO = new CreateBankAccountRefundingDTO
{
    HolderName = "holder_name4",
    HolderType = "holder_type0",
    HolderDocument = "holder_document8",
    Bank = "bank6",
    BranchNumber = "branch_number4",
    BranchCheckDigit = "branch_check_digit4",
    AccountNumber = "account_number2",
    AccountCheckDigit = "account_check_digit4",
    Type = "type2",
};
```

