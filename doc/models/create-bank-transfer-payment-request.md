
# Create Bank Transfer Payment Request

Request for creating a bank transfer payment

## Structure

`CreateBankTransferPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `string` | Required | Bank |
| `Retries` | `int` | Required | Number of retries |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateBankTransferPaymentRequest createBankTransferPaymentRequest = new CreateBankTransferPaymentRequest
{
    Bank = "bank6",
    Retries = 20,
};
```

