
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

## Example (as JSON)

```json
{
  "email": "email4",
  "document": "document6",
  "type": "type8",
  "phone_numbers": [
    {
      "ddd": "ddd4",
      "number": "number2",
      "type": "type0"
    }
  ],
  "site_url": "site_url4"
}
```

