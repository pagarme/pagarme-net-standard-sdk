
# Create Cash Payment Request

## Structure

`CreateCashPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Required | Description |
| `Confirm` | `bool` | Required | Indicates whether cash collection will be confirmed in the act of creation |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCashPaymentRequest createCashPaymentRequest = new CreateCashPaymentRequest
{
    Description = "description4",
    Confirm = false,
};
```

