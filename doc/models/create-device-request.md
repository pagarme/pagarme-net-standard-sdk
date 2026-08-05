
# Create Device Request

Request for creating a device

## Structure

`CreateDeviceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Platform` | `string` | Optional | Device's platform |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateDeviceRequest createDeviceRequest = new CreateDeviceRequest
{
    Platform = "platform2",
};
```

