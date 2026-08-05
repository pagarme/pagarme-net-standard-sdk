
# Get Checkout Payment Settings Response

Checkout Payment Settings Response

## Structure

`GetCheckoutPaymentSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuccessUrl` | `string` | Optional | Success Url |
| `PaymentUrl` | `string` | Optional | Payment Url |
| `AcceptedPaymentMethods` | `List<string>` | Optional | Accepted Payment Methods |
| `Status` | `string` | Optional | Status |
| `Customer` | [`GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | Customer |
| `Amount` | `int?` | Optional | Payment amount |
| `DefaultPaymentMethod` | `string` | Optional | Default Payment Method |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation Id |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

GetCheckoutPaymentSettingsResponse getCheckoutPaymentSettingsResponse = new GetCheckoutPaymentSettingsResponse
{
    SuccessUrl = "success_url8",
    PaymentUrl = "payment_url0",
    AcceptedPaymentMethods = new List<string>
    {
        "accepted_payment_methods9",
        "accepted_payment_methods0",
        "accepted_payment_methods1",
    },
    Status = "status8",
    Customer = null,
};
```

