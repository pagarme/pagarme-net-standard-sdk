
# List Payables Response

Response object for listing payable objects

## Structure

`ListPayablesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<GetPayableResponse>`](../../doc/models/get-payable-response.md) | Optional | The payable object |
| `Paging` | [`CursorPagingResponse`](../../doc/models/cursor-paging-response.md) | Required | Cursor paging response |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListPayablesResponse listPayablesResponse = new ListPayablesResponse
{
    Paging = new CursorPagingResponse
    {
        ForwardCursor = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkYWxhcGlDdXJzb3IiOiJleUpoYkdjaU9pSklVekkxTmlJc0luUjVjQ0k2SWtwWFZDSjkuZXlKcFlYUWlPaUl4TnpnMU9UTXpNVGN6SWl3aVpYaHdJam94TnpnMU9UTTJOemN6TENKcFpDSTZJalF6TWpVeU1ETXhOREFpZlEuTmtrUk85Slg3eC1YMVFLZ0ZIYkw3VGw4ZVV0NkR1ZWVQVlk5a0pHNXhxNCIsImlhdCI6MTc4NTkzMzE3MywiZXhwIjoxNzg1OTM2NzczfQ.5qM-BQbArZKXbfen5NnEXq6gbhyP-DrgsG1SMrpF4Y4",
    },
    Data = new List<GetPayableResponse>
    {
        new GetPayableResponse
        {
            Id = "5b71f2a8b472ef521b224b75fd13c14e09d37822fd100f2cd425ef5aea02f5bf",
            Status = "paid",
            Amount = 1100,
            GatewayId = null,
            ChargeId = "ch_123",
            SplitId = null,
            BulkAnticipationId = null,
            RecipientId = "re_cixm61j7e00doin6de8ocgttb",
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
            PaymentProfileId = "pp_03gd2e0o5kj37ujs38zgw9s9v",
            Fee = 0,
            AnticipationFee = 0,
            FraudCoverageFee = 0,
            Installment = 44,
            AnticipationId = "anticipation_id0",
            PaymentDate = DateTime.ParseExact("2025-08-18T03:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Type = "credit",
            AccrualAt = DateTime.ParseExact("2023-08-21T12:51:28Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            LiquidationArrangementId = null,
        },
    },
};
```

