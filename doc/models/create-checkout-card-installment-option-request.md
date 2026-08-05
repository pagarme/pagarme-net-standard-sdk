
# Create Checkout Card Installment Option Request

Options for card installment

## Structure

`CreateCheckoutCardInstallmentOptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Number` | `int` | Required | Installment quantity |
| `Total` | `int` | Required | Total amount |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCheckoutCardInstallmentOptionRequest createCheckoutCardInstallmentOptionRequest = new CreateCheckoutCardInstallmentOptionRequest
{
    Number = 68,
    Total = 176,
};
```

