
# Update Price Bracket Request

Request for updating a price bracket

## Structure

`UpdatePriceBracketRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartQuantity` | `int` | Required | Start quantity of the bracket |
| `Price` | `int` | Required | Price |
| `EndQuantity` | `int?` | Optional | End quantity of the bracket |
| `OveragePrice` | `int?` | Optional | Overage price |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdatePriceBracketRequest updatePriceBracketRequest = new UpdatePriceBracketRequest
{
    StartQuantity = 160,
    Price = 98,
    EndQuantity = 168,
    OveragePrice = 182,
};
```

