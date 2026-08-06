
# Create Managing Partner Request

Managing Partner Request

## Structure

`CreateManagingPartnerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Email` | `string` | Required | - |
| `Document` | `string` | Required | - |
| `MotherName` | `string` | Optional | - |
| `Birthdate` | `string` | Required | - |
| `MonthlyIncome` | `long` | Required | - |
| `ProfessionalOccupation` | `string` | Required | - |
| `SelfDeclaredLegalRepresentative` | `bool` | Required | - |
| `Address` | [`CreateRegisterInformationAddressRequest`](../../doc/models/create-register-information-address-request.md) | Required | - |
| `PhoneNumbers` | [`List<CreateRegisterInformationPhoneRequest>`](../../doc/models/create-register-information-phone-request.md) | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateManagingPartnerRequest createManagingPartnerRequest = new CreateManagingPartnerRequest
{
    Name = null,
    Email = null,
    Document = null,
    Birthdate = null,
    MonthlyIncome = 0L,
    ProfessionalOccupation = null,
    SelfDeclaredLegalRepresentative = false,
    Address = null,
    PhoneNumbers = new List<CreateRegisterInformationPhoneRequest>
    {
        null,
    },
    MotherName = "mother_name8",
};
```

