
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
| `Customer` | [`GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | Customer |
| `Amount` | `int?` | Optional | Payment amount |
| `DefaultPaymentMethod` | `string` | Optional | Default Payment Method |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation Id |

## Example (as JSON)

```json
{
  "success_url": "success_url0",
  "payment_url": "payment_url8",
  "accepted_payment_methods": [
    "accepted_payment_methods1",
    "accepted_payment_methods2"
  ],
  "status": "status0",
  "customer": {
    "id": "id0",
    "name": "name0",
    "email": "email6",
    "delinquent": false,
    "created_at": "2016-03-13T12:52:32.123Z"
  }
}
```

