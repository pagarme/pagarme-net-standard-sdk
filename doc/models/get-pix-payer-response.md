
# Get Pix Payer Response

Pix payer data.

## Structure

`GetPixPayerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Document` | `string` | Optional | - |
| `DocumentType` | `string` | Optional | - |
| `BankAccount` | [`GetPixBankAccountResponse`](../../doc/models/get-pix-bank-account-response.md) | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPixPayerResponse getPixPayerResponse = new GetPixPayerResponse
{
    Name = "name0",
    Document = "document6",
    DocumentType = "document_type8",
    BankAccount = null,
};
```

