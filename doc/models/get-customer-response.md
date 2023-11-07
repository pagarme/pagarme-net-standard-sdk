
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
| `Address` | [`GetAddressResponse`](../../doc/models/get-address-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Phones` | [`GetPhonesResponse`](../../doc/models/get-phones-response.md) | Optional | - |
| `FbId` | `long?` | Optional | - |
| `Code` | `string` | Optional | Código de referência do cliente no sistema da loja. Max: 52 caracteres |
| `DocumentType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id4",
  "name": "name4",
  "email": "email2",
  "delinquent": false,
  "created_at": "2016-03-13T12:52:32.123Z"
}
```

