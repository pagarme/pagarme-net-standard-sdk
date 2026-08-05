
# Get Usage Response

Response object for getting a usage

## Structure

`GetUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `Quantity` | `int?` | Optional | Quantity |
| `Description` | `string` | Optional | Description |
| `UsedAt` | `DateTime?` | Optional | Used at |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `Status` | `string` | Optional | Status |
| `DeletedAt` | `DateTime?` | Optional | - |
| `SubscriptionItem` | [`GetSubscriptionItemResponse`](../../doc/models/get-subscription-item-response.md) | Optional | Subscription item |
| `Code` | `string` | Optional | Identification code in the client system |
| `Group` | `string` | Optional | Identification group in the client system |
| `Amount` | `int?` | Optional | Field used in item scheme type 'Percent' |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetUsageResponse getUsageResponse = new GetUsageResponse
{
    Id = "id6",
    Quantity = 226,
    Description = "description6",
    UsedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

