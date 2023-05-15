
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
| `Address` | [`Models.CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | The customer's address |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Phones` | [`Models.CreatePhonesRequest`](../../doc/models/create-phones-request.md) | Required | - |
| `Code` | `string` | Required | Customer code |
| `Gender` | `string` | Optional | Customer Gender |
| `DocumentType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "name": "{\n    \"name\": \"Tony Stark\"\n}",
  "email": "email6",
  "document": "document6",
  "type": "type0",
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
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "phones": {
    "home_phone": {
      "country_code": "country_code8",
      "number": "number0",
      "area_code": "area_code2"
    },
    "mobile_phone": {
      "country_code": "country_code8",
      "number": "number4",
      "area_code": "area_code8"
    }
  },
  "code": "code8",
  "gender": "gender6",
  "document_type": "document_type8"
}
```

