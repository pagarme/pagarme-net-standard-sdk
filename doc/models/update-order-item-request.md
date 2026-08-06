
# Update Order Item Request

Update Order item Request

## Structure

`UpdateOrderItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | - |
| `Description` | `string` | Required | - |
| `Quantity` | `int` | Required | - |
| `Category` | `string` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateOrderItemRequest updateOrderItemRequest = new UpdateOrderItemRequest
{
    Amount = 202,
    Description = "description0",
    Quantity = 60,
    Category = "category8",
};
```

