
# Update Address Request

Request for updating an address

## Structure

`UpdateAddressRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Number` | `string` | Required | Number |
| `Complement` | `string` | Required | Complement |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Line2` | `string` | Required | Line 2 for address |

## Example (as JSON)

```json
{
  "number": "number6",
  "complement": "complement8",
  "metadata": {
    "key0": "metadata7",
    "key1": "metadata8"
  },
  "line_2": "line_24"
}
```

