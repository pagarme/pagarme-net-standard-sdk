
# Create Fine Request

Fine Request

## Structure

`CreateFineRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Days` | `int` | Required | Days |
| `Type` | `string` | Required | Type |
| `Amount` | `int` | Required | Amount |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateFineRequest createFineRequest = new CreateFineRequest
{
    Days = 0,
    Type = "\"percentage\" or \"flat\"",
    Amount = 0,
};
```

