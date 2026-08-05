
# Update Customer Request

Request for updating a customer

## Structure

`UpdateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name |
| `Email` | `string` | Optional | Email |
| `Document` | `string` | Optional | Document number |
| `Type` | `string` | Optional | Person type |
| `Address` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Optional | Address |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `Phones` | [`CreatePhonesRequest`](../../doc/models/create-phones-request.md) | Optional | - |
| `Code` | `string` | Optional | Código de referência do cliente no sistema da loja. Max: 52 caracteres |
| `Gender` | `string` | Optional | Gênero do cliente |
| `DocumentType` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateCustomerRequest updateCustomerRequest = new UpdateCustomerRequest
{
    Name = "name4",
    Email = "email2",
    Document = "document8",
    Type = "type4",
    Address = null,
};
```

