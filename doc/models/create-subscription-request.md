
# Create Subscription Request

Request for creating a subcription

## Structure

`CreateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Required | Customer |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Required | Card |
| `Code` | `string` | Required | Subscription code |
| `PaymentMethod` | `string` | Required | Payment method |
| `BillingType` | `string` | Required | Billing type |
| `StatementDescriptor` | `string` | Required | Statement descriptor for credit card subscriptions |
| `Description` | `string` | Required | Subscription description |
| `Currency` | `string` | Required | Currency |
| `Interval` | `string` | Required | Interval |
| `IntervalCount` | `int` | Required | Interval count |
| `PricingScheme` | [`CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Subscription pricing scheme |
| `Items` | [`List<CreateSubscriptionItemRequest>`](../../doc/models/create-subscription-item-request.md) | Required | Subscription items |
| `Shipping` | [`CreateShippingRequest`](../../doc/models/create-shipping-request.md) | Required | Shipping |
| `Discounts` | [`List<CreateDiscountRequest>`](../../doc/models/create-discount-request.md) | Required | Discounts |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `Setup` | [`CreateSetupRequest`](../../doc/models/create-setup-request.md) | Optional | Setup data |
| `PlanId` | `string` | Optional | Plan id |
| `CustomerId` | `string` | Optional | Customer id |
| `CardId` | `string` | Optional | Card id |
| `BillingDay` | `int?` | Optional | Billing day |
| `Installments` | `int?` | Optional | Number of installments |
| `StartAt` | `DateTime?` | Optional | Subscription start date |
| `MinimumPrice` | `int?` | Optional | Subscription minimum price |
| `Cycles` | `int?` | Optional | Number of cycles |
| `CardToken` | `string` | Optional | Card token |
| `GatewayAffiliationId` | `string` | Optional | Gateway Affiliation code |
| `Quantity` | `int?` | Optional | Quantity |
| `BoletoDueDays` | `int?` | Optional | Days until boleto expires |
| `Increments` | [`List<CreateIncrementRequest>`](../../doc/models/create-increment-request.md) | Required | Increments |
| `Period` | [`CreatePeriodRequest`](../../doc/models/create-period-request.md) | Optional | - |
| `Submerchant` | [`CreateSubMerchantRequest`](../../doc/models/create-sub-merchant-request.md) | Optional | SubMerchant |
| `Split` | [`CreateSubscriptionSplitRequest`](../../doc/models/create-subscription-split-request.md) | Optional | Subscription's split |
| `Boleto` | [`CreateSubscriptionBoletoRequest`](../../doc/models/create-subscription-boleto-request.md) | Optional | Information about fines and interest on the "boleto" used from payment |
| `IndirectAcceptor` | `string` | Optional | Business model identifier |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateSubscriptionRequest createSubscriptionRequest = new CreateSubscriptionRequest
{
    Customer = new CreateCustomerRequest
    {
        Name = "Tony Stark",
        Email = null,
        Document = null,
        Type = null,
        Address = null,
        Metadata = null,
        Phones = null,
        Code = null,
        Gender = "gender6",
        DocumentType = "document_type8",
    },
    Card = new CreateCardRequest
    {
        Number = "number6",
        HolderName = "holder_name2",
        ExpMonth = 228,
        ExpYear = 68,
        Cvv = "cvv4",
        Type = "credit",
    },
    Code = null,
    PaymentMethod = null,
    BillingType = null,
    StatementDescriptor = null,
    Description = null,
    Currency = null,
    Interval = null,
    IntervalCount = 0,
    PricingScheme = null,
    Items = new List<CreateSubscriptionItemRequest>
    {
        new CreateSubscriptionItemRequest
        {
            Description = null,
            PricingScheme = null,
            Id = null,
            PlanItemId = null,
            Discounts = new List<CreateDiscountRequest>
            {
                null,
            },
            Name = null,
            Cycles = 214,
            Quantity = 22,
            MinimumPrice = 222,
        },
    },
    Shipping = null,
    Discounts = new List<CreateDiscountRequest>
    {
        null,
    },
    Metadata = null,
    Increments = new List<CreateIncrementRequest>
    {
        null,
    },
    Setup = null,
    PlanId = "plan_id8",
    CustomerId = "customer_id4",
    CardId = "card_id2",
    BillingDay = 226,
};
```

