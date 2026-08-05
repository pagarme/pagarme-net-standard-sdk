
# Get Checkout Bank Transfer Payment Response

Bank transfer checkout response

## Structure

`GetCheckoutBankTransferPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | `List<string>` | Optional | bank list response |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

GetCheckoutBankTransferPaymentResponse getCheckoutBankTransferPaymentResponse = new GetCheckoutBankTransferPaymentResponse
{
    Bank = new List<string>
    {
        "bank3",
        "bank4",
    },
};
```

