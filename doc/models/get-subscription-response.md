
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
| `CurrentCycle` | [`GetPeriodResponse`](../../doc/models/get-period-response.md) | Optional | - |
| `PaymentMethod` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Installments` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `Customer` | [`GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Card` | [`GetCardResponse`](../../doc/models/get-card-response.md) | Optional | - |
| `Items` | [`List<GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md) | Optional | - |
| `StatementDescriptor` | `string` | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Setup` | [`GetSetupResponse`](../../doc/models/get-setup-response.md) | Optional | - |
| `GatewayAffiliationId` | `string` | Optional | Affiliation Code |
| `NextBillingAt` | `DateTime?` | Optional | - |
| `BillingDay` | `int?` | Optional | - |
| `MinimumPrice` | `int?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `Discounts` | [`List<GetDiscountResponse>`](../../doc/models/get-discount-response.md) | Optional | Subscription discounts |
| `Increments` | [`List<GetIncrementResponse>`](../../doc/models/get-increment-response.md) | Optional | Subscription increments |
| `BoletoDueDays` | `int?` | Optional | Days until boleto expires |
| `Split` | [`GetSubscriptionSplitResponse`](../../doc/models/get-subscription-split-response.md) | Optional | Subscription's split response |
| `Boleto` | [`GetSubscriptionBoletoResponse`](../../doc/models/get-subscription-boleto-response.md) | Optional | - |
| `ManualBilling` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "boleto": {
    "interest": {
      "days": 2,
      "type": "percentage",
      "amount": 20
    },
    "fine": {
      "days": 2,
      "type": "flat",
      "amount": 10
    },
    "max_days_to_pay_past_due": 2
  },
  "id": "id4",
  "code": "code2",
  "start_at": "2016-03-13T12:52:32.123Z",
  "interval": "interval2",
  "interval_count": 224
}
```

