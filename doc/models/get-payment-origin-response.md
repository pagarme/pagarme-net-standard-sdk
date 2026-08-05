
# Get Payment Origin Response

## Structure

`GetPaymentOriginResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargeId` | `string` | Optional | - |
| `BrandId` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetPaymentOriginResponse getPaymentOriginResponse = new GetPaymentOriginResponse
{
    ChargeId = "charge_id4",
    BrandId = "brand_id0",
};
```

