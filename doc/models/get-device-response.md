
# Get Device Response

Response object for geetting an order device

## Structure

`GetDeviceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Platform` | `string` | Optional | Device's platform name |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetDeviceResponse getDeviceResponse = new GetDeviceResponse
{
    Platform = "platform0",
};
```

