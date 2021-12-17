
# Create Seller Request

## Structure

`CreateSellerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name |
| `Code` | `string` | Optional | Seller's code identification |
| `Description` | `string` | Optional | Description |
| `Document` | `string` | Optional | Document number (individual / company) |
| `Address` | [`Models.CreateAddressRequest`](/doc/models/create-address-request.md) | Optional | Address |
| `Type` | `string` | Optional | Person type (individual / company) |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |

## Example (as JSON)

```json
{
  "name": "name0",
  "code": null,
  "description": null,
  "document": null,
  "address": null,
  "type": null,
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  }
}
```

