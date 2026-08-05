
# Update Card Request

Request for updating a card

## Structure

`UpdateCardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HolderName` | `string` | Required | Holder name |
| `ExpMonth` | `int` | Required | Expiration month |
| `ExpYear` | `int` | Required | Expiration year |
| `BillingAddressId` | `string` | Optional | Id of the address to be used as billing address |
| `BillingAddress` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Billing address |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Label` | `string` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdateCardRequest updateCardRequest = new UpdateCardRequest
{
    HolderName = "holder_name8",
    ExpMonth = 80,
    ExpYear = 216,
    BillingAddress = null,
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata9",
        ["key1"] = "metadata8",
        ["key2"] = "metadata7",
    },
    Label = "label2",
    BillingAddressId = "billing_address_id8",
};
```

