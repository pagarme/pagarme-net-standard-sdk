
# Create Card Token Request

Card token data

## Structure

`CreateCardTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Number` | `string` | Required | Credit card number |
| `HolderName` | `string` | Required | Holder name, as written on the card |
| `ExpMonth` | `int` | Required | The expiration month |
| `ExpYear` | `int` | Required | The expiration year, that can be informed with 2 or 4 digits |
| `Cvv` | `string` | Required | The card's security code |
| `Brand` | `string` | Required | Card brand |
| `Label` | `string` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCardTokenRequest createCardTokenRequest = new CreateCardTokenRequest
{
    Number = "number8",
    HolderName = "holder_name0",
    ExpMonth = 182,
    ExpYear = 114,
    Cvv = "cvv2",
    Brand = "brand8",
    Label = "label4",
};
```

