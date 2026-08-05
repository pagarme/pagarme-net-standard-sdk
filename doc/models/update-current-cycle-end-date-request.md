
# Update Current Cycle End Date Request

Request to update the end date of the current subscription cycle

## Structure

`UpdateCurrentCycleEndDateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EndAt` | `DateTime?` | Optional | Current cycle end date |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

UpdateCurrentCycleEndDateRequest updateCurrentCycleEndDateRequest = new UpdateCurrentCycleEndDateRequest
{
    EndAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

