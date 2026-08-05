
# Update Order Status Request

## Structure

`UpdateOrderStatusRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | Order status |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateOrderStatusRequest updateOrderStatusRequest = new UpdateOrderStatusRequest
{
    Status = "status8",
};
```

