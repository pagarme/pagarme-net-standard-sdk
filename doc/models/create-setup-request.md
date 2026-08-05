
# Create Setup Request

Request for creating a Setup for a subscription. The setup is an order that will be created at the subscription creation.

## Structure

`CreateSetupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Setup amount |
| `Description` | `string` | Required | Description |
| `Payment` | [`CreatePaymentRequest`](../../doc/models/create-payment-request.md) | Required | Payment data |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateSetupRequest createSetupRequest = new CreateSetupRequest
{
    Amount = 222,
    Description = "description6",
    Payment = null,
};
```

