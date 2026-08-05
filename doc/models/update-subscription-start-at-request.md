
# Update Subscription Start at Request

Request for updating the start date from a subscription

## Structure

`UpdateSubscriptionStartAtRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartAt` | `DateTime` | Required | The date when the subscription periods will start |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

UpdateSubscriptionStartAtRequest updateSubscriptionStartAtRequest = new UpdateSubscriptionStartAtRequest
{
    StartAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

