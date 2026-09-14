
# Create Cancel Charge Request

Request for canceling a charge.

## Structure

`CreateCancelChargeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | The amount that will be canceled. |
| `SplitRules` | [`List<CreateCancelChargeSplitRulesRequest>`](../../doc/models/create-cancel-charge-split-rules-request.md) | Optional | The split rules request |
| `Split` | [`List<CreateSplitRequest>`](../../doc/models/create-split-request.md) | Optional | Splits |
| `OperationReference` | `string` | Required | - |
| `BankAccount` | [`CreateBankAccountRefundingDTO`](../../doc/models/create-bank-account-refunding-dto.md) | Optional | - |
| `Reason` | `string` | Optional | Cancellation reason |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateCancelChargeRequest createCancelChargeRequest = new CreateCancelChargeRequest
{
    OperationReference = "operation_reference0",
    Amount = 222,
    SplitRules = new List<CreateCancelChargeSplitRulesRequest>
    {
        null,
        new CreateCancelChargeSplitRulesRequest
        {
            Id = null,
            Amount = 0,
            Type = null,
        },
        new CreateCancelChargeSplitRulesRequest
        {
            Id = null,
            Amount = 0,
            Type = null,
        },
    },
    Split = new List<CreateSplitRequest>
    {
        null,
        new CreateSplitRequest
        {
            Type = null,
            Amount = 0,
            RecipientId = null,
        },
        new CreateSplitRequest
        {
            Type = null,
            Amount = 0,
            RecipientId = null,
        },
    },
    BankAccount = null,
    Reason = "reason4",
};
```

