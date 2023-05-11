
# List Recipient Response

Response for the listing recipient method

## Structure

`ListRecipientResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md) | Optional | Recipients |
| `Paging` | [`Models.PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id5",
      "name": "name5",
      "email": "email9",
      "document": "document9",
      "description": "description5"
    },
    {
      "id": "id6",
      "name": "name6",
      "email": "email0",
      "document": "document0",
      "description": "description6"
    }
  ],
  "paging": {
    "total": 6,
    "previous": "previous2",
    "next": "next8"
  }
}
```

