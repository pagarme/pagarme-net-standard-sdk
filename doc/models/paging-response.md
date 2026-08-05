
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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

PagingResponse pagingResponse = new PagingResponse
{
    Total = 66,
    Previous = "previous0",
    Next = "next0",
};
```

