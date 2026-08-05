
# Get Location Response

Response object for geetting an order location request

## Structure

`GetLocationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Latitude` | `string` | Optional | Latitude |
| `Longitude` | `string` | Optional | Longitude |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetLocationResponse getLocationResponse = new GetLocationResponse
{
    Latitude = "latitude2",
    Longitude = "longitude8",
};
```

