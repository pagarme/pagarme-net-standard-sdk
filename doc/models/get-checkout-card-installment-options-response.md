
# Get Checkout Card Installment Options Response

## Structure

`GetCheckoutCardInstallmentOptionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Number` | `long?` | Required | Número de parcelas |
| `Total` | `int?` | Required | Valor total da compra |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetCheckoutCardInstallmentOptionsResponse getCheckoutCardInstallmentOptionsResponse = new GetCheckoutCardInstallmentOptionsResponse
{
    Number = 40L,
    Total = 188,
};
```

