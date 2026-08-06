
# Update Plan Request

Request for updating a plan

## Structure

`UpdatePlanRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Plan's name |
| `Description` | `string` | Required | Description |
| `Installments` | `List<int>` | Required | Number os installments |
| `StatementDescriptor` | `string` | Required | Text that will be shown on the credit card's statement |
| `Currency` | `string` | Required | Currency |
| `Interval` | `string` | Required | Interval |
| `IntervalCount` | `int` | Required | Interval count |
| `PaymentMethods` | `List<string>` | Required | Payment methods accepted by the plan |
| `BillingType` | `string` | Required | Billing type |
| `Status` | `string` | Required | Plan status |
| `Shippable` | `bool` | Required | Indicates if the plan is shippable |
| `BillingDays` | `List<int>` | Required | Billing days accepted by the plan |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |
| `MinimumPrice` | `int?` | Optional | Minimum price |
| `TrialPeriodDays` | `int?` | Optional | Number of trial period in days, where the customer will not be charged |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdatePlanRequest updatePlanRequest = new UpdatePlanRequest
{
    Name = "name8",
    Description = "description8",
    Installments = new List<int>
    {
        139,
        140,
        141,
    },
    StatementDescriptor = "statement_descriptor8",
    Currency = "currency8",
    Interval = "interval6",
    IntervalCount = 102,
    PaymentMethods = new List<string>
    {
        "payment_methods3",
        "payment_methods2",
    },
    BillingType = "billing_type8",
    Status = "status0",
    Shippable = false,
    BillingDays = new List<int>
    {
        103,
        104,
    },
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata5",
        ["key1"] = "metadata6",
        ["key2"] = "metadata7",
    },
    MinimumPrice = 156,
    TrialPeriodDays = 74,
};
```

