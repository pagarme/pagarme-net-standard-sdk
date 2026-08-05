
# Get Gateway Response Response

The Transaction Gateway Response

## Structure

`GetGatewayResponseResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | The error code |
| `Errors` | [`List<GetGatewayErrorResponse>`](../../doc/models/get-gateway-error-response.md) | Optional | The gateway response errors list |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

GetGatewayResponseResponse getGatewayResponseResponse = new GetGatewayResponseResponse
{
    Code = "code4",
    Errors = new List<GetGatewayErrorResponse>
    {
        null,
    },
};
```

