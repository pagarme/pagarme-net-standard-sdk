
# Get Card Token Response

Card token data

## Structure

`GetCardTokenResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LastFourDigits` | `string` | Optional | - |
| `HolderName` | `string` | Optional | - |
| `HolderDocument` | `string` | Optional | - |
| `ExpMonth` | `int?` | Optional | - |
| `ExpYear` | `int?` | Optional | - |
| `Brand` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `Label` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetCardTokenResponse getCardTokenResponse = new GetCardTokenResponse
{
    LastFourDigits = "last_four_digits8",
    HolderName = "holder_name8",
    HolderDocument = "holder_document6",
    ExpMonth = 232,
    ExpYear = 64,
};
```

