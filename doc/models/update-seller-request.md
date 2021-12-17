
# Update Seller Request

## Structure

`UpdateSellerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Seller name |
| `Code` | `string` | Required | Seller code |
| `Description` | `string` | Required | Seller description |
| `Document` | `string` | Required | Seller document CPF or CNPJ |
| `Status` | `string` | Required | - |
| `Type` | `string` | Required | - |
| `Address` | [`Models.CreateAddressRequest`](/doc/models/create-address-request.md) | Required | - |
| `Metadata` | `Dictionary<string, string>` | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "code": "code8",
  "description": "description0",
  "document": "document6",
  "status": "status8",
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
  }
}
```

