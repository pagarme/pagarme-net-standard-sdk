
# Create Interest Request

Interest Request

## Structure

`CreateInterestRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Days` | `int` | Required | Days |
| `Type` | `string` | Required | Type |
| `Amount` | `int` | Required | Amount |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateInterestRequest createInterestRequest = new CreateInterestRequest
{
    Days = 0,
    Type = "\"percentage\" or \"flat\"",
    Amount = 0,
};
```

