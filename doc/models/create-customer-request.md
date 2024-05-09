
# Create Customer Request

Request for creating a new customer

## Structure

`CreateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name |
| `Email` | `string` | Required | Email |
| `Document` | `string` | Required | Document number. Only numbers, no special characters. |
| `Type` | `string` | Required | Person type. Can be either 'individual' or 'company' |
| `Address` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | The customer's address |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Phones` | [`CreatePhonesRequest`](../../doc/models/create-phones-request.md) | Required | - |
| `Code` | `string` | Required | Customer code |
| `Gender` | `string` | Optional | Customer Gender |
| `DocumentType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "name": "Tony Stark",
  "email": "email8",
  "document": "document8",
  "type": "type2",
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
  "metadata": {
    "key0": "metadata5"
  },
  "phones": {
    "home_phone": {
      "country_code": "country_code0",
      "number": "number2",
      "area_code": "area_code0",
      "Type": "Type0"
    },
    "mobile_phone": {
      "country_code": "country_code0",
      "number": "number8",
      "area_code": "area_code0",
      "Type": "Type0"
    }
  },
  "code": "code6",
  "gender": "gender8",
  "document_type": "document_type6"
}
```

