
# Get Setup Response

Response object for getting the setup from a subscription

## Structure

`GetSetupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Amount` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetSetupResponse getSetupResponse = new GetSetupResponse
{
    Id = "id6",
    Description = "description6",
    Amount = 108,
    Status = "status8",
};
```

