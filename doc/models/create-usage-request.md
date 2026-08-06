
# Create Usage Request

Request for creating a usage

## Structure

`CreateUsageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Quantity` | `int` | Required | - |
| `Description` | `string` | Required | - |
| `UsedAt` | `DateTime` | Required | - |
| `Code` | `string` | Optional | Identification code in the client system |
| `Group` | `string` | Optional | identification group in the client system |
| `Amount` | `int?` | Optional | Field used in item scheme type 'Percent' |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

CreateUsageRequest createUsageRequest = new CreateUsageRequest
{
    Quantity = 254,
    Description = "description6",
    UsedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Code = "code4",
    MGroup = "group4",
    Amount = 140,
};
```

