
# Get Safety Pay Transaction Response

Response object for getting a safety pay transaction

## Structure

`GetSafetyPayTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | Payment url |
| `BankTid` | `string` | Optional | Transaction identifier on bank |
| `PaidAt` | `DateTime?` | Optional | Payment date |
| `PaidAmount` | `int?` | Optional | Paid amount |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetSafetyPayTransactionResponse getSafetyPayTransactionResponse = new GetSafetyPayTransactionResponse
{
    Url = "url0",
    BankTid = "bank_tid0",
    PaidAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    PaidAmount = 4,
    GatewayId = "gateway_id8",
    Amount = 40,
    Status = "status6",
    Success = false,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

