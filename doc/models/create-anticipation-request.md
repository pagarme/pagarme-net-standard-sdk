
# Create Anticipation Request

Request for creating an anticipation

## Structure

`CreateAnticipationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Amount requested for the anticipation |
| `Timeframe` | `string` | Required | Timeframe |
| `PaymentDate` | `DateTime` | Required | Payment date |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

CreateAnticipationRequest createAnticipationRequest = new CreateAnticipationRequest
{
    Amount = 84,
    Timeframe = "timeframe2",
    PaymentDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

