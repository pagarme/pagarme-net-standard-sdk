
# Paging Response

Object used for returning lists of objects with pagination

## Structure

`PagingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Total` | `int?` | Optional | Total number of pages |
| `Previous` | `string` | Optional | Previous page |
| `Next` | `string` | Optional | Next page |

## Example (as JSON)

```json
{
  "total": 80,
  "previous": "previous2",
  "next": "next2"
}
```

