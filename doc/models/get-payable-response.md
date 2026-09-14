
# Get Payable Response

Response object for getting an payable

## Structure

`GetPayableResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Payable Identifier |
| `Status` | `string` | Required | Payable status |
| `Amount` | `int` | Required | Payable amount in cents |
| `Fee` | `int?` | Optional | Payable fee amount in cents |
| `AnticipationFee` | `int?` | Optional | Antecipation fee amount in cents |
| `FraudCoverageFee` | `int?` | Optional | Fraud coverage fee amount in cents |
| `Installment` | `int?` | Optional | Number of installment |
| `GatewayId` | `string` | Required | Payment gateway identifier<br><br>**Default**: `"null"` |
| `ChargeId` | `string` | Required | Charge identifier<br><br>**Default**: `"null"` |
| `SplitId` | `string` | Required | **Default**: `"null"` |
| `BulkAnticipationId` | `string` | Required | **Default**: `"null"` |
| `AnticipationId` | `string` | Optional | - |
| `RecipientId` | `string` | Required | Recipient identifier |
| `OriginatorModel` | `string` | Required | **Default**: `"null"` |
| `OriginatorModelId` | `string` | Required | Originator model identifier<br><br>**Default**: `"null"` |
| `PaymentDate` | `DateTime?` | Optional | Payment Date |
| `OriginalPaymentDate` | `DateTime?` | Required | Original Payment Date |
| `Type` | `string` | Optional | Type of payable |
| `PaymentMethod` | `string` | Required | Payment method of transaction<br><br>**Default**: `"null"` |
| `AccrualAt` | `DateTime?` | Optional | Date issuer identify payment |
| `CreatedAt` | `DateTime` | Required | Creation date |
| `LiquidationArrangementId` | `string` | Optional | **Default**: `"null"` |
| `SettlementId` | `string` | Required | Settlement identifier  (new in v7.x)<br><br>**Default**: `"null"` |
| `PaymentProfileId` | `string` | Required | Operational identifier of merchant inside of payment platform (new in v7.x)<br><br>**Default**: `"null"` |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetPayableResponse getPayableResponse = new GetPayableResponse
{
    Id = "5b71f2a8b472ef521b224b75fd13c14e09d37822fd100f2cd425ef5aea02f5bf",
    Status = "paid",
    Amount = 1100,
    GatewayId = null,
    ChargeId = "ch_123",
    SplitId = null,
    BulkAnticipationId = null,
    RecipientId = "re_abcde123fghijk789",
    OriginatorModel = "ownership_assignment",
    OriginatorModelId = null,
    OriginalPaymentDate = DateTime.ParseExact("2025-08-21T03:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    PaymentMethod = "credit_card",
    CreatedAt = DateTime.ParseExact("2025-08-20T10:30:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    SettlementId = "03002e00-edde-6d4c-dd9e-ffaaafac08de",
    PaymentProfileId = "pp_abcde123fghijk789",
    Fee = 0,
    AnticipationFee = 0,
    FraudCoverageFee = 0,
    Installment = 44,
    PaymentDate = DateTime.ParseExact("2025-08-18T03:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Type = "credit",
    AccrualAt = DateTime.ParseExact("2023-08-21T12:51:28Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LiquidationArrangementId = null,
};
```

