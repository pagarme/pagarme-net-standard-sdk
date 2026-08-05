
# Get Period Response

Response object for getting a period

## Structure

`GetPeriodResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartAt` | `DateTime?` | Optional | - |
| `EndAt` | `DateTime?` | Optional | - |
| `Id` | `string` | Optional | - |
| `BillingAt` | `DateTime?` | Optional | - |
| `Subscription` | [`GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Optional | - |
| `Status` | `string` | Optional | - |
| `Duration` | `int?` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `UpdatedAt` | `string` | Optional | - |
| `Cycle` | `int?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetPeriodResponse getPeriodResponse = new GetPeriodResponse
{
    StartAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Id = "id4",
    BillingAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Subscription = null,
};
```

