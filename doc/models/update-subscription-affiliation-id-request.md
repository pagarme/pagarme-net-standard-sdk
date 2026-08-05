
# Update Subscription Affiliation Id Request

Request for updating a Subscription Affiliation Id

## Structure

`UpdateSubscriptionAffiliationIdRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GatewayAffiliationId` | `string` | Required | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateSubscriptionAffiliationIdRequest updateSubscriptionAffiliationIdRequest = new UpdateSubscriptionAffiliationIdRequest
{
    GatewayAffiliationId = "gateway_affiliation_id6",
};
```

