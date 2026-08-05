
# Create Order Item Request

Request for creating an order item

## Structure

`CreateOrderItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Amount |
| `Description` | `string` | Required | Description |
| `Quantity` | `int` | Required | Quantity |
| `Category` | `string` | Required | Category |
| `Code` | `string` | Optional | The item code passed by the client |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateOrderItemRequest createOrderItemRequest = new CreateOrderItemRequest
{
    Amount = 154,
    Description = "description6",
    Quantity = 12,
    Category = "category4",
    Code = "code4",
};
```

