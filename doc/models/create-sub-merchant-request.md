
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

## Example (as JSON)

```json
{
  "payment_facilitator_code": "payment_facilitator_code2",
  "code": "code2",
  "name": "name4",
  "merchant_category_code": "merchant_category_code6",
  "document": "document2",
  "type": "type6",
  "phone": {
    "country_code": "country_code0",
    "number": "number8",
    "area_code": "area_code0",
    "Type": "Type0"
  },
  "address": {
    "street": "street6",
    "number": "number4",
    "zip_code": "zip_code0",
    "neighborhood": "neighborhood2",
    "city": "city6",
    "state": "state2",
    "country": "country0",
    "complement": "complement2",
    "metadata": {
      "key0": "metadata3",
      "key1": "metadata2",
      "key2": "metadata1"
    },
    "line_1": "line_10",
    "line_2": "line_24"
  },
  "legal_name": "legal_name2",
  "site_url": "site_url6"
}
```

