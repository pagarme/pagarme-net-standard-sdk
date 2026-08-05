
# Get Balance Response

Balance

## Structure

`GetBalanceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Optional | Currency (official ISO 4217 currency names) |
| `AvailableAmount` | `long?` | Optional | Amount available for transferring in cents |
| `Recipient` | [`GetRecipientResponse`](../../doc/models/get-recipient-response.md) | Optional | Recipient |
| `TransferredAmount` | `long?` | Optional | Amount transfered in cents |
| `WaitingFundsAmount` | `long?` | Optional | Amount waiting in cents |
| `PaymentProfileId` | `string` | Required | Operational id of merchant in payments operations (new) |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetBalanceResponse getBalanceResponse = new GetBalanceResponse
{
    PaymentProfileId = "pp_abcdefghoj20klmn09k",
    Currency = "BRL",
    AvailableAmount = 4996L,
    Recipient = new GetRecipientResponse
    {
        Id = "re_abcdefghoj20klmn09k",
        Name = "Lojista Recebedor LTDA",
        Email = "email@stone.com.br",
        Document = "01032644222100",
        Description = null,
        Type = null,
        Status = "active",
        CreatedAt = DateTime.ParseExact("2026-06-22T19:13:52Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        UpdatedAt = null,
        DeletedAt = null,
        Code = null,
        PaymentMode = null,
    },
    TransferredAmount = null,
    WaitingFundsAmount = 0L,
};
```

