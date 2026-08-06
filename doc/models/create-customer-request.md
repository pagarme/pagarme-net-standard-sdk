
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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
{
    Name = "Tony Stark",
    Email = null,
    Document = null,
    Type = null,
    Address = null,
    Metadata = null,
    Phones = null,
    Code = null,
    Gender = "gender2",
    DocumentType = "document_type2",
};
```

