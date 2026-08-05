
# Create KYC Link Response

KYC Link

## Structure

`CreateKYCLinkResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Base64` | `string` | Optional | Base64 |
| `Url` | `string` | Optional | URL |
| `ExpirationDate` | `string` | Optional | Expiration Date |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateKYCLinkResponse createKYCLinkResponse = new CreateKYCLinkResponse
{
    Base64 = "base648",
    Url = "url4",
    ExpirationDate = "expiration_date4",
};
```

