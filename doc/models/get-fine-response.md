
# Get Fine Response

Fine Response

## Structure

`GetFineResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Days` | `int?` | Optional | Days |
| `Type` | `string` | Optional | Type |
| `Amount` | `int?` | Optional | Amount |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetFineResponse getFineResponse = new GetFineResponse
{
    Days = 20,
    Type = "\"percentage\" or \"flat\"",
    Amount = 94,
};
```

