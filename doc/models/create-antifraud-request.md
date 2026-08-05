
# Create Antifraud Request

## Structure

`CreateAntifraudRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | - |
| `Clearsale` | [`CreateClearSaleRequest`](../../doc/models/create-clear-sale-request.md) | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateAntifraudRequest createAntifraudRequest = new CreateAntifraudRequest
{
    Type = "type0",
    Clearsale = null,
};
```

