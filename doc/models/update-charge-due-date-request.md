
# Update Charge Due Date Request

Request for updating a charge due date

## Structure

`UpdateChargeDueDateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DueAt` | `DateTime?` | Optional | The charge's new due date |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

UpdateChargeDueDateRequest updateChargeDueDateRequest = new UpdateChargeDueDateRequest
{
    DueAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

