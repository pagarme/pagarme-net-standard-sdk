
# Create Access Token Request

Request for creating a new Access Token

## Structure

`CreateAccessTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExpiresIn` | `int?` | Optional | Minutes to expire the token |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateAccessTokenRequest createAccessTokenRequest = new CreateAccessTokenRequest
{
    ExpiresIn = 204,
};
```

