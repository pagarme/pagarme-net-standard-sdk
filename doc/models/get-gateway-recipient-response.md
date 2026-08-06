
# Get Gateway Recipient Response

Information about the recipient on the gateway

## Structure

`GetGatewayRecipientResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Gateway` | `string` | Optional | Gateway name |
| `Status` | `string` | Optional | Status of the recipient on the gateway |
| `Pgid` | `string` | Optional | Recipient id on the gateway |
| `CreatedAt` | `string` | Optional | Creation date |
| `UpdatedAt` | `string` | Optional | Last update date |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetGatewayRecipientResponse getGatewayRecipientResponse = new GetGatewayRecipientResponse
{
    Gateway = "gateway0",
    Status = "status2",
    Pgid = "pgid6",
    CreatedAt = "created_at8",
    UpdatedAt = "updated_at6",
};
```

