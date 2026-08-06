
# Create Plan Request

Request for creating a plan

## Structure

`CreatePlanRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Plan's name |
| `Description` | `string` | Required | Description |
| `StatementDescriptor` | `string` | Required | Text that will be printed on the credit card's statement |
| `Items` | [`List<CreatePlanItemRequest>`](../../doc/models/create-plan-item-request.md) | Required | Plan items |
| `Shippable` | `bool` | Required | Indicates if the plan is shippable |
| `PaymentMethods` | `List<string>` | Required | Allowed payment methods for the plan |
| `Installments` | `List<int>` | Required | Number of installments |
| `Currency` | `string` | Required | Currency |
| `Interval` | `string` | Required | Interval |
| `IntervalCount` | `int` | Required | Interval counts between two charges. For instance, if the interval is 'month' and count is 2, the customer will be charged once every two months. |
| `BillingDays` | `List<int>` | Required | Allowed billings days for the subscription, in case the plan type is 'exact_day' |
| `BillingType` | `string` | Required | Billing type |
| `PricingScheme` | [`CreatePricingSchemeRequest`](../../doc/models/create-pricing-scheme-request.md) | Required | Plan's pricing scheme |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `MinimumPrice` | `int?` | Optional | Minimum price that will be charged |
| `Cycles` | `int?` | Optional | Number of cycles |
| `Quantity` | `int?` | Optional | Quantity |
| `TrialPeriodDays` | `int?` | Optional | Trial period, where the customer will not be charged. |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreatePlanRequest createPlanRequest = new CreatePlanRequest
{
    Name = null,
    Description = null,
    StatementDescriptor = null,
    Items = new List<CreatePlanItemRequest>
    {
        null,
    },
    Shippable = false,
    PaymentMethods = null,
    Installments = null,
    Currency = null,
    Interval = null,
    IntervalCount = 0,
    BillingDays = null,
    BillingType = null,
    PricingScheme = null,
    Metadata = null,
    MinimumPrice = 56,
    Cycles = 48,
    Quantity = 188,
    TrialPeriodDays = 174,
};
```

