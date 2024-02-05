
# Get Register Information Response

Response object for getting an RegisterInformationResponse

## Structure

`GetRegisterInformationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Optional | - |
| `Document` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `SiteUrl` | `string` | Optional | - |
| `PhoneNumbers` | [`List<GetPhoneNumberResponse>`](../../doc/models/get-phone-number-response.md) | Optional | - |
| `Name` | `string` | Optional | - |
| `MotherName` | `string` | Optional | - |
| `Birthdate` | `string` | Optional | - |
| `MonthlyIncome` | `string` | Optional | - |
| `ProfessionalOccupation` | `string` | Optional | - |
| `Address` | [`GetRegisterInformationAddressResponse`](../../doc/models/get-register-information-address-response.md) | Optional | - |
| `CompanyName` | `string` | Optional | - |
| `TradingName` | `string` | Optional | - |
| `AnnualRevenue` | `string` | Optional | - |
| `CorporationType` | `string` | Optional | - |
| `FoundingDate` | `string` | Optional | - |
| `Cnae` | `string` | Optional | - |
| `MainAddress` | [`GetRegisterInformationAddressResponse`](../../doc/models/get-register-information-address-response.md) | Optional | - |
| `ManagingPartners` | [`List<GetManagingPartnerResponse>`](../../doc/models/get-managing-partner-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "email": "email2",
  "document": "document2",
  "type": "type6",
  "site_url": "site_url6",
  "phone_numbers": [
    {
      "ddd": "ddd4",
      "number": "number2",
      "type": "type0"
    },
    {
      "ddd": "ddd4",
      "number": "number2",
      "type": "type0"
    }
  ]
}
```

