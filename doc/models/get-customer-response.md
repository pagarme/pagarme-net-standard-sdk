
# Get Customer Response

Response object for getting a customer

## Structure

`GetCustomerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `Delinquent` | `bool?` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `Document` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `FbAccessToken` | `string` | Optional | - |
| `Address` | [`Models.GetAddressResponse`](../../doc/models/get-address-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Phones` | [`Models.GetPhonesResponse`](../../doc/models/get-phones-response.md) | Optional | - |
| `FbId` | `long?` | Optional | - |
| `Code` | `string` | Optional | Código de referência do cliente no sistema da loja. Max: 52 caracteres |
| `DocumentType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "name": null,
  "email": null,
  "delinquent": null,
  "created_at": null,
  "updated_at": null,
  "document": null,
  "type": null,
  "fb_access_token": null,
  "address": null,
  "metadata": null,
  "phones": null,
  "fb_id": null,
  "code": null,
  "document_type": null
}
```

