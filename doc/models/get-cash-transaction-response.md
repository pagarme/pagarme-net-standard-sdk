
# Get Cash Transaction Response

Response object for getting a cash transaction

## Structure

`GetCashTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | Description |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetCashTransactionResponse getCashTransactionResponse = new GetCashTransactionResponse
{
    Description = "description6",
    GatewayId = "gateway_id8",
    Amount = 40,
    Status = "status6",
    Success = false,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

