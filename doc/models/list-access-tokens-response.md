
# List Access Tokens Response

Response object for listing access tokens

## Structure

`ListAccessTokensResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetAccessTokenResponse>`](../../doc/models/get-access-token-response.md) | Optional | The access token objects |
| `Paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

ListAccessTokensResponse listAccessTokensResponse = new ListAccessTokensResponse
{
    Data = new List<GetAccessTokenResponse>
    {
        null,
        new GetAccessTokenResponse
        {
        },
    },
    Paging = null,
};
```

