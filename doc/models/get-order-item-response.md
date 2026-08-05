
# Get Order Item Response

Response object for getting an order item

## Structure

`GetOrderItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `Type` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Amount` | `int?` | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `Category` | `string` | Optional | Category |
| `Code` | `string` | Optional | Code |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetOrderItemResponse getOrderItemResponse = new GetOrderItemResponse
{
    Id = "id4",
    Type = "type6",
    Description = "description6",
    Amount = 212,
    Quantity = 70,
};
```

