
# Create Register Information Individual Request

## Structure

`CreateRegisterInformationIndividualRequest`

## Inherits From

[`CreateRegisterInformationBaseRequest`](../../doc/models/create-register-information-base-request.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `MotherName` | `string` | Optional | - |
| `Birthdate` | `string` | Required | - |
| `MonthlyIncome` | `long` | Required | - |
| `ProfessionalOccupation` | `string` | Required | - |
| `Address` | [`CreateRegisterInformationAddressRequest`](../../doc/models/create-register-information-address-request.md) | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateRegisterInformationIndividualRequest createRegisterInformationIndividualRequest = new CreateRegisterInformationIndividualRequest
{
    Email = "email4",
    Document = "document6",
    Type = "type8",
    PhoneNumbers = new List<CreateRegisterInformationPhoneRequest>
    {
        null,
        new CreateRegisterInformationPhoneRequest
        {
            Ddd = null,
            Number = null,
            Type = null,
        },
    },
    Name = "name2",
    Birthdate = "birthdate6",
    MonthlyIncome = 20L,
    ProfessionalOccupation = "professional_occupation6",
    Address = null,
    MotherName = "mother_name8",
    SiteUrl = "site_url4",
};
```

