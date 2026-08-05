
# Get Token Response

Token data

## Structure

`GetTokenResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `ExpiresAt` | `string` | Optional | - |
| `Card` | [`GetCardTokenResponse`](../../doc/models/get-card-token-response.md) | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetTokenResponse getTokenResponse = new GetTokenResponse
{
    Id = "id4",
    Type = "type6",
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ExpiresAt = "expires_at8",
    Card = null,
};
```

