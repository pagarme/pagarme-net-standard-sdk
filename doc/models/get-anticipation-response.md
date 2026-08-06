
# Get Anticipation Response

Anticipation

## Structure

`GetAnticipationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `RequestedAmount` | `int?` | Optional | Requested amount |
| `ApprovedAmount` | `int?` | Optional | Approved amount |
| `Recipient` | [`GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `Pgid` | `string` | Optional | Anticipation id on the gateway |
| `CreatedAt` | `DateTime?` | Optional | Creation date |
| `UpdatedAt` | `DateTime?` | Optional | Last update date |
| `PaymentDate` | `DateTime?` | Optional | Payment date |
| `Status` | `string` | Optional | Status |
| `Timeframe` | `string` | Optional | Timeframe |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetAnticipationResponse getAnticipationResponse = new GetAnticipationResponse
{
    Id = "id6",
    RequestedAmount = 186,
    ApprovedAmount = 240,
    Recipient = null,
    Pgid = "pgid2",
};
```

