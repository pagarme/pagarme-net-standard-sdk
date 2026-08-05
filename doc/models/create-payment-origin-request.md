
# Create Payment Origin Request

Request object for PaymentOrigin

## Structure

`CreatePaymentOriginRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BrandId` | `string` | Optional | - |
| `ChargeId` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreatePaymentOriginRequest createPaymentOriginRequest = new CreatePaymentOriginRequest
{
    BrandId = "brand_id8",
    ChargeId = "charge_id2",
};
```

