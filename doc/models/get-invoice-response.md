
# Get Invoice Response

Response object for getting an invoice

## Structure

`GetInvoiceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Code` | `string` | Optional | - |
| `Url` | `string` | Optional | - |
| `Amount` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `PaymentMethod` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `Items` | [`List<GetInvoiceItemResponse>`](../../doc/models/get-invoice-item-response.md) | Optional | - |
| `Customer` | [`GetCustomerResponse`](../../doc/models/get-customer-response.md) | Optional | - |
| `Charge` | [`GetChargeResponse`](../../doc/models/get-charge-response.md) | Optional | - |
| `Installments` | `int?` | Optional | - |
| `BillingAddress` | [`GetBillingAddressResponse`](../../doc/models/get-billing-address-response.md) | Optional | - |
| `Subscription` | [`GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Optional | - |
| `Cycle` | [`GetPeriodResponse`](../../doc/models/get-period-response.md) | Optional | - |
| `Shipping` | [`GetShippingResponse`](../../doc/models/get-shipping-response.md) | Optional | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `DueAt` | `DateTime?` | Optional | - |
| `CanceledAt` | `DateTime?` | Optional | - |
| `BillingAt` | `DateTime?` | Optional | - |
| `SeenAt` | `DateTime?` | Optional | - |
| `TotalDiscount` | `int?` | Optional | Total discounted value |
| `TotalIncrement` | `int?` | Optional | Total discounted value |
| `SubscriptionId` | `string` | Optional | Subscription Id |

## Example (as JSON)

```json
{
  "id": "id0",
  "code": "code8",
  "url": "url4",
  "amount": 168,
  "status": "status8"
}
```

