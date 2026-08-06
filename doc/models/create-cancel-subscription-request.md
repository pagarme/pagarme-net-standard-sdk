
# Create Cancel Subscription Request

Request for canceling a subscription

## Structure

`CreateCancelSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CancelPendingInvoices` | `bool` | Required | Indicates if the pending invoices must also be canceled.<br><br>**Default**: `true` |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateCancelSubscriptionRequest createCancelSubscriptionRequest = new CreateCancelSubscriptionRequest
{
    CancelPendingInvoices = true,
};
```

