
# Create Token Request

Token data

## Structure

`CreateTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | Token type<br><br>**Default**: `"card"` |
| `Card` | [`CreateCardTokenRequest`](../../doc/models/create-card-token-request.md) | Required | Card data |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateTokenRequest createTokenRequest = new CreateTokenRequest
{
    Type = "card",
    Card = null,
};
```

