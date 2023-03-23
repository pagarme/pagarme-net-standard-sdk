
# Get Subscription Response

## Structure

`GetSubscriptionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Code` | `string` | Optional | - |
| `StartAt` | `DateTime?` | Optional | - |
| `Interval` | `string` | Optional | - |
| `IntervalCount` | `int?` | Optional | - |
| `BillingType` | `string` | Optional | - |
| `CurrentCycle` | [`Models.GetPeriodResponse`](../../doc/models/get-period-response.md) | Optional | - |
| `PaymentMethod` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Installments` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `Customer` | [`Models.GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Card` | [`Models.GetCardResponse`](../../doc/models/get-card-response.md) | Optional | - |
| `Items` | [`List<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md) | Optional | - |
| `StatementDescriptor` | `string` | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Setup` | [`Models.GetSetupResponse`](../../doc/models/get-setup-response.md) | Optional | - |
| `GatewayAffiliationId` | `string` | Optional | Affiliation Code |
| `NextBillingAt` | `DateTime?` | Optional | - |
| `BillingDay` | `int?` | Optional | - |
| `MinimumPrice` | `int?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `Discounts` | [`List<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md) | Optional | Subscription discounts |
| `Increments` | [`List<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md) | Optional | Subscription increments |
| `BoletoDueDays` | `int?` | Optional | Days until boleto expires |
| `Split` | [`Models.GetSubscriptionSplitResponse`](../../doc/models/get-subscription-split-response.md) | Optional | Subscription's split response |
| `Boleto` | [`Models.GetSubscriptionBoletoResponse`](../../doc/models/get-subscription-boleto-response.md) | Optional | - |
| `ManualBilling` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "code": null,
  "start_at": null,
  "interval": null,
  "interval_count": null,
  "billing_type": null,
  "current_cycle": null,
  "payment_method": null,
  "currency": null,
  "installments": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "customer": null,
  "card": null,
  "items": null,
  "statement_descriptor": null,
  "metadata": null,
  "setup": null,
  "gateway_affiliation_id": null,
  "next_billing_at": null,
  "billing_day": null,
  "minimum_price": null,
  "canceled_at": null,
  "discounts": null,
  "increments": null,
  "boleto_due_days": null,
  "split": null,
  "boleto": null,
  "manual_billing": null
}
```

