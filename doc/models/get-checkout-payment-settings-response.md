
# Get Checkout Payment Settings Response

Checkout Payment Settings Response

## Structure

`GetCheckoutPaymentSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuccessUrl` | `string` | Optional | Success Url |
| `PaymentUrl` | `string` | Optional | Payment Url |
| `AcceptedPaymentMethods` | `List<string>` | Optional | Accepted Payment Methods |
| `Status` | `string` | Optional | Status |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | Customer |
| `Amount` | `int?` | Optional | Payment amount |
| `DefaultPaymentMethod` | `string` | Optional | Default Payment Method |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation Id |

## Example (as JSON)

```json
{
  "success_url": null,
  "payment_url": null,
  "accepted_payment_methods": null,
  "status": null,
  "customer": null,
  "amount": null,
  "default_payment_method": null,
  "gateway_affiliation_id": null
}
```

