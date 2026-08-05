
# Create Location Request

Request for creating a location

## Structure

`CreateLocationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Latitude` | `string` | Required | Latitude |
| `Longitude` | `string` | Required | Longitude |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateLocationRequest createLocationRequest = new CreateLocationRequest
{
    Latitude = "latitude0",
    Longitude = "longitude0",
};
```

