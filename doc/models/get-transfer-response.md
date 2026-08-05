
# Get Transfer Response

Transfer response

## Structure

`GetTransferResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Id |
| `Amount` | `int?` | Optional | Transfer amount |
| `Status` | `string` | Optional | Transfer status |
| `CreatedAt` | `DateTime?` | Optional | Transfer creation date |
| `UpdatedAt` | `DateTime?` | Optional | Transfer last update date |
| `BankAccount` | [`GetBankAccountResponse`](../../doc/models/get-bank-account-response.md) | Optional | Bank account |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

GetTransferResponse getTransferResponse = new GetTransferResponse
{
    Id = "id8",
    Amount = 244,
    Status = "status0",
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

