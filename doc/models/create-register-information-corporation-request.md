
# Create Register Information Corporation Request

## Structure

`CreateRegisterInformationCorporationRequest`

## Inherits From

[`CreateRegisterInformationBaseRequest`](../../doc/models/create-register-information-base-request.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CompanyName` | `string` | Required | - |
| `TradingName` | `string` | Required | - |
| `AnnualRevenue` | `long` | Required | - |
| `CorporationType` | `string` | Optional | - |
| `FoundingDate` | `string` | Optional | - |
| `Cnae` | `string` | Optional | - |
| `ManagingPartners` | [`List<CreateManagingPartnerRequest>`](../../doc/models/create-managing-partner-request.md) | Required | - |
| `MainAddress` | [`CreateRegisterInformationAddressRequest`](../../doc/models/create-register-information-address-request.md) | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateRegisterInformationCorporationRequest createRegisterInformationCorporationRequest = new CreateRegisterInformationCorporationRequest
{
    Email = null,
    Document = null,
    Type = null,
    PhoneNumbers = new List<CreateRegisterInformationPhoneRequest>
    {
        null,
    },
    CompanyName = null,
    TradingName = null,
    AnnualRevenue = 0L,
    ManagingPartners = new List<CreateManagingPartnerRequest>
    {
        new CreateManagingPartnerRequest
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
            MotherName = "mother_name0",
        },
    },
    MainAddress = null,
    CorporationType = "corporation_type0",
    FoundingDate = "founding_date0",
    Cnae = "cnae0",
    SiteUrl = "site_url4",
};
```

