
# List Balance Operation Response

Response object for listing BalanceOperation objects

## Structure

`ListBalanceOperationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | `List<string>` | Optional | The BalanceOperation object |
| `Paging` | [`Models.PagingResponse`](../../doc/models/paging-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    "data5",
    "data6"
  ],
  "paging": {
    "total": 6,
    "previous": "previous2",
    "next": "next8"
  }
}
```

