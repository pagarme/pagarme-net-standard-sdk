
# Create Register Information Base Request

Request object for RegisterInformation.

## Structure

`CreateRegisterInformationBaseRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Required | - |
| `Document` | `string` | Required | - |
| `Type` | `string` | Required | "individual" ou "corporation" |
| `SiteUrl` | `string` | Optional | - |
| `PhoneNumbers` | [`List<CreateRegisterInformationPhoneRequest>`](../../doc/models/create-register-information-phone-request.md) | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateRegisterInformationBaseRequest createRegisterInformationBaseRequest = new CreateRegisterInformationBaseRequest
{
    Email = null,
    Document = null,
    Type = null,
    PhoneNumbers = new List<CreateRegisterInformationPhoneRequest>
    {
        null,
    },
    SiteUrl = "site_url6",
};
```

