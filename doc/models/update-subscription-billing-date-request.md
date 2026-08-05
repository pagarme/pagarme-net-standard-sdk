
# Update Subscription Billing Date Request

Request for updating the due date from a subscription

## Structure

`UpdateSubscriptionBillingDateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NextBillingAt` | `DateTime` | Required | The date when the next subscription billing must occur |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

UpdateSubscriptionBillingDateRequest updateSubscriptionBillingDateRequest = new UpdateSubscriptionBillingDateRequest
{
    NextBillingAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

