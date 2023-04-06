
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

## Example (as JSON)

```json
{
  "gateway": "gateway0",
  "status": "status8",
  "pgid": "pgid4",
  "created_at": "created_at2",
  "updated_at": "updated_at4"
}
```

