
# Get Usage Report Response

## Structure

`GetUsageReportResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | - |
| `UsageReportUrl` | `string` | Optional | - |
| `GroupedReportUrl` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetUsageReportResponse getUsageReportResponse = new GetUsageReportResponse
{
    Url = "url2",
    UsageReportUrl = "usage_report_url0",
    GroupedReportUrl = "grouped_report_url0",
};
```

