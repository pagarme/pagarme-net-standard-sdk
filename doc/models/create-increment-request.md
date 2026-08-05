
# Create Increment Request

Request for creating a new increment

## Structure

`CreateIncrementRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `double` | Required | The increment value |
| `IncrementType` | `string` | Required | Increment type. Can be either flat or percentage. |
| `ItemId` | `string` | Required | The item where the increment will be applied |
| `Cycles` | `int?` | Optional | Number of cycles that the increment will be applied |
| `Description` | `string` | Optional | Description |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateIncrementRequest createIncrementRequest = new CreateIncrementRequest
{
    MValue = 84.78,
    IncrementType = "increment_type8",
    ItemId = "item_id4",
    Cycles = 202,
    Description = "description4",
};
```

