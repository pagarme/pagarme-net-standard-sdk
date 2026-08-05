
# Get Antifraud Response

## Structure

`GetAntifraudResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Optional | - |
| `ReturnCode` | `string` | Optional | - |
| `ReturnMessage` | `string` | Optional | - |
| `ProviderName` | `string` | Optional | - |
| `Score` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetAntifraudResponse getAntifraudResponse = new GetAntifraudResponse
{
    Status = "status0",
    ReturnCode = "return_code8",
    ReturnMessage = "return_message4",
    ProviderName = "provider_name4",
    Score = "score8",
};
```

