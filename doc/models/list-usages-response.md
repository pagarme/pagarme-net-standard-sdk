
# List Usages Response

Response model for listing the usages from a subscription item

## Structure

`ListUsagesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetUsageResponse>`](../../doc/models/get-usage-response.md) | Optional | The usage objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id0",
      "quantity": 94,
      "description": "description0",
      "used_at": "2016-03-13T12:52:32.123Z",
      "created_at": "2016-03-13T12:52:32.123Z"
    }
  ],
  "paging": {
    "total": 6,
    "previous": "previous2",
    "next": "next8"
  }
}
```

