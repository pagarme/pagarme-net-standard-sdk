
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

## Example (as JSON)

```json
{
  "name": "name0",
  "email": "email6",
  "document": "document6",
  "type": "type0",
  "mother_name": "mother_name6"
}
```

