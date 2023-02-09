
# Get Split Response

Split response

## Structure

`GetSplitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | Type |
| `Amount` | `int?` | Optional | Amount |
| `Recipient` | [`Models.GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `GatewayId` | `string` | Optional | The split rule gateway id |
| `Options` | [`Models.GetSplitOptionsResponse`](../../doc/models/get-split-options-response.md) | Optional | - |
| `Id` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "type": null,
  "amount": null,
  "recipient": null,
  "gateway_id": null,
  "options": null,
  "id": null
}
```

