
# Get Credit Card Transaction Response

Response object for getting a credit card transaction

## Structure

`GetCreditCardTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementDescriptor` | `string` | Optional | Text that will appear on the credit card's statement |
| `AcquirerName` | `string` | Optional | Acquirer name |
| `AcquirerAffiliationCode` | `string` | Optional | Aquirer affiliation code |
| `AcquirerTid` | `string` | Optional | Acquirer TID |
| `AcquirerNsu` | `string` | Optional | Acquirer NSU |
| `AcquirerAuthCode` | `string` | Optional | Acquirer authorization code |
| `OperationType` | `string` | Optional | Operation type |
| `Card` | [`GetCardResponse`](../../doc/models/get-card-response.md) | Optional | Card data |
| `AcquirerMessage` | `string` | Optional | Acquirer message |
| `AcquirerReturnCode` | `string` | Optional | Acquirer Return Code |
| `Installments` | `int?` | Optional | Number of installments |
| `ThreedAuthenticationUrl` | `string` | Optional | 3D-S authentication Url |
| `FundingSource` | `string` | Optional | Identify when a card is prepaid, credit or debit. |
| `RetryInfo` | [`GetRetryTransactionInformationResponse`](../../doc/models/get-retry-transaction-information-response.md) | Optional | Retry transaction information |
| `BrandId` | `string` | Optional | - |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetCreditCardTransactionResponse getCreditCardTransactionResponse = new GetCreditCardTransactionResponse
{
    StatementDescriptor = "statement_descriptor6",
    AcquirerName = "acquirer_name0",
    AcquirerAffiliationCode = "acquirer_affiliation_code2",
    AcquirerTid = "acquirer_tid4",
    AcquirerNsu = "acquirer_nsu4",
    GatewayId = "gateway_id8",
    Amount = 40,
    Status = "status6",
    Success = false,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

