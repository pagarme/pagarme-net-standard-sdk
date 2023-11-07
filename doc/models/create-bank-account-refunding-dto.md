
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

## Example (as JSON)

```json
{
  "holder_name": "holder_name2",
  "holder_type": "holder_type8",
  "holder_document": "holder_document0",
  "bank": "bank4",
  "branch_number": "branch_number2",
  "branch_check_digit": "branch_check_digit2",
  "account_number": "account_number6",
  "account_check_digit": "account_check_digit2",
  "type": "type4"
}
```

