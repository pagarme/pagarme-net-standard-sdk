
# Create Transaction Report File Request

## Structure

`CreateTransactionReportFileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `StartAt` | `DateTime?` | Optional | - |
| `EndAt` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

CreateTransactionReportFileRequest createTransactionReportFileRequest = new CreateTransactionReportFileRequest
{
    Name = "name2",
    StartAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndAt = "end_at8",
};
```

