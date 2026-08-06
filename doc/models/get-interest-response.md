
# Get Interest Response

Interest Response

## Structure

`GetInterestResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Days` | `int?` | Optional | Days |
| `Type` | `string` | Optional | Type |
| `Amount` | `int?` | Optional | Amount |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetInterestResponse getInterestResponse = new GetInterestResponse
{
    Days = 82,
    Type = "\"percentage\" or \"flat\"",
    Amount = 156,
};
```

