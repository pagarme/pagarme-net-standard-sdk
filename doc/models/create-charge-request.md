
# Create Charge Request

Request for creating a new charge

## Structure

`CreateChargeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Code |
| `Amount` | `int` | Required | The amount of the charge, in cents |
| `CustomerId` | `string` | Optional | The customer's id |
| `Customer` | [`CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Optional | Customer data |
| `Payment` | [`CreatePaymentRequest`](../../doc/models/create-payment-request.md) | Required | Payment data |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata |
| `DueAt` | `DateTime?` | Optional | The charge due date |
| `Antifraud` | [`CreateAntifraudRequest`](../../doc/models/create-antifraud-request.md) | Optional | - |
| `OrderId` | `string` | Required | Order Id |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

CreateChargeRequest createChargeRequest = new CreateChargeRequest
{
    Amount = 160,
    Payment = null,
    OrderId = "order_id8",
    Code = "code2",
    CustomerId = "customer_id2",
    Customer = null,
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata1",
        ["key1"] = "metadata0",
        ["key2"] = "metadata9",
    },
    DueAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

