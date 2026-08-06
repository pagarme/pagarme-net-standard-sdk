
# Get Movement Object Settlement Response

Generic response object for getting a MovementObjectSettlement.

## Structure

`GetMovementObjectSettlementResponse`

## Inherits From

[`GetMovementObjectBaseResponse`](../../doc/models/get-movement-object-base-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Product` | `string` | Optional | - |
| `Brand` | `string` | Optional | - |
| `PaymentDate` | `string` | Optional | - |
| `RecipientId` | `string` | Optional | - |
| `DocumentType` | `string` | Optional | - |
| `Document` | `string` | Optional | - |
| `ContractObligationId` | `string` | Optional | - |
| `LiquidationArrangementId` | `string` | Optional | - |
| `ExternalEnginePaymentId` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetMovementObjectSettlementResponse getMovementObjectSettlementResponse = new GetMovementObjectSettlementResponse
{
    Product = "product2",
    Brand = "brand6",
    PaymentDate = "payment_date4",
    RecipientId = "recipient_id8",
    DocumentType = "document_type0",
    Id = "id2",
    Status = "status4",
    Amount = "amount4",
    CreatedAt = "created_at0",
};
```

