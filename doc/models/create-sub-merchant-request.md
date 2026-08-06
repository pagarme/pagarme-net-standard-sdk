
# Create Sub Merchant Request

SubMerchant

## Structure

`CreateSubMerchantRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentFacilitatorCode` | `string` | Required | Payment Facilitator Code |
| `Code` | `string` | Required | Code |
| `Name` | `string` | Required | Name |
| `MerchantCategoryCode` | `string` | Required | Merchant Category Code |
| `Document` | `string` | Required | Document number. Only numbers, no special characters. |
| `Type` | `string` | Required | Document type. Can be either 'individual' or 'company' |
| `Phone` | [`CreatePhoneRequest`](../../doc/models/create-phone-request.md) | Required | Phone |
| `Address` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Address |
| `LegalName` | `string` | Required | Legal name |
| `SiteUrl` | `string` | Required | Site Url |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateSubMerchantRequest createSubMerchantRequest = new CreateSubMerchantRequest
{
    PaymentFacilitatorCode = "payment_facilitator_code2",
    Code = "code2",
    Name = "name4",
    MerchantCategoryCode = "merchant_category_code4",
    Document = "document2",
    Type = "type6",
    Phone = null,
    Address = null,
    LegalName = "legal_name2",
    SiteUrl = "site_url6",
};
```

