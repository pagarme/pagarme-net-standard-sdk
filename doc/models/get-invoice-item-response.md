
# Get Invoice Item Response

Response object for getting an invoice item

## Structure

`GetInvoiceItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | - |
| `Description` | `string` | Optional | - |
| `PricingScheme` | [`GetPricingSchemeResponse`](../../doc/models/get-pricing-scheme-response.md) | Optional | - |
| `PriceBracket` | [`GetPriceBracketResponse`](../../doc/models/get-price-bracket-response.md) | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `SubscriptionItemId` | `string` | Optional | Subscription Item Id |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetInvoiceItemResponse getInvoiceItemResponse = new GetInvoiceItemResponse
{
    Amount = 176,
    Description = "description4",
    PricingScheme = null,
    PriceBracket = null,
    Quantity = 194,
};
```

