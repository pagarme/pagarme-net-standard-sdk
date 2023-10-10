
# Create Usage Request

Request for creating a usage

## Structure

`CreateUsageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Quantity` | `int` | Required | - |
| `Description` | `string` | Required | - |
| `UsedAt` | `DateTime` | Required | - |
| `Code` | `string` | Optional | Identification code in the client system |
| `Group` | `string` | Optional | identification group in the client system |
| `Amount` | `int?` | Optional | Field used in item scheme type 'Percent' |

## Example (as JSON)

```json
{
  "quantity": 224,
  "description": "description8",
  "used_at": "2016-03-13T12:52:32.123Z",
  "code": "code0",
  "group": "group0",
  "amount": 110
}
```

