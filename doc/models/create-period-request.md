
# Create Period Request

## Structure

`CreatePeriodRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EndAt` | `DateTime?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

CreatePeriodRequest createPeriodRequest = new CreatePeriodRequest
{
    EndAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

