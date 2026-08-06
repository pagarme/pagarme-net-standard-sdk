
# Create Checkout Bank Transfer Request

Checkout bank transfer payment request

## Structure

`CreateCheckoutBankTransferRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `List<string>` | Required | Bank |
| `Retries` | `int` | Required | Number of retries for processing |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateCheckoutBankTransferRequest createCheckoutBankTransferRequest = new CreateCheckoutBankTransferRequest
{
    Bank = new List<string>
    {
        "bank1",
        "bank2",
        "bank3",
    },
    Retries = 56,
};
```

