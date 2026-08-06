
# Create Address Request

Request for creating a new Address

## Structure

`CreateAddressRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Required | Street |
| `Number` | `string` | Required | Number |
| `ZipCode` | `string` | Required | The zip code containing only numbers. No special characters or spaces. |
| `Neighborhood` | `string` | Required | Neighborhood |
| `City` | `string` | Required | City |
| `State` | `string` | Required | State |
| `Country` | `string` | Required | Country. Must be entered using ISO 3166-1 alpha-2 format. See https://pt.wikipedia.org/wiki/ISO_3166-1_alfa-2 |
| `Complement` | `string` | Required | Complement |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `Line1` | `string` | Required | Line 1 for address |
| `Line2` | `string` | Required | Line 2 for address |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateAddressRequest createAddressRequest = new CreateAddressRequest
{
    Street = "street6",
    Number = "number6",
    ZipCode = "zip_code0",
    Neighborhood = "neighborhood2",
    City = "city6",
    State = "state2",
    Country = "country0",
    Complement = "complement8",
    Line1 = "line_10",
    Line2 = "line_24",
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata7",
    },
};
```

