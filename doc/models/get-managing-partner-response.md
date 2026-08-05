
# Get Managing Partner Response

Response object for getting an ManagingPartnerResponse

## Structure

`GetManagingPartnerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `Document` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `MotherName` | `string` | Optional | - |
| `Birthdate` | `string` | Optional | - |
| `MonthlyIncome` | `string` | Optional | - |
| `ProfessionalOccupation` | `string` | Optional | - |
| `SelfDeclaredRepresentative` | `bool?` | Optional | - |
| `Address` | [`GetRegisterInformationAddressResponse`](../../doc/models/get-register-information-address-response.md) | Optional | - |
| `PhoneNumbers` | [`List<GetPhoneNumberResponse>`](../../doc/models/get-phone-number-response.md) | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetManagingPartnerResponse getManagingPartnerResponse = new GetManagingPartnerResponse
{
    Name = "name8",
    Email = "email8",
    Document = "document2",
    Type = "type8",
    MotherName = "mother_name4",
};
```

