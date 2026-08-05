
# Create Confirm Payment Request

## Structure

`CreateConfirmPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Required | Description |
| `Amount` | `int?` | Optional | Amount |
| `Code` | `string` | Required | Code reference |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateConfirmPaymentRequest createConfirmPaymentRequest = new CreateConfirmPaymentRequest
{
    Description = "description8",
    Code = "Code8",
    Amount = 222,
};
```

