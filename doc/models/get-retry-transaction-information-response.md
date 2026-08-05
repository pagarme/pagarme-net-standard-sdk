
# Get Retry Transaction Information Response

Response object for getting an RetryTransactionInformation

## Structure

`GetRetryTransactionInformationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BrandFailureReturnCode` | `string` | Required | - |
| `TransactionLimit` | `int?` | Required | - |
| `TransactionDateLimit` | `DateTime?` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetRetryTransactionInformationResponse getRetryTransactionInformationResponse = new GetRetryTransactionInformationResponse
{
    BrandFailureReturnCode = "brand_failure_return_code0",
    TransactionLimit = 158,
    TransactionDateLimit = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

