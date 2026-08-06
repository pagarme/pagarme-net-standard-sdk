
# Get Movement Object Base Response

Generic response object for getting a MovementObjectBase.

## Structure

`GetMovementObjectBaseResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MObject` | `string` | Optional | - |
| `Id` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `Amount` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `ChargeId` | `string` | Optional | - |
| `GatewayId` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetMovementObjectBaseResponse getMovementObjectBaseResponse = new GetMovementObjectSettlementResponse
{
    Product = "product2",
    Brand = "brand6",
    PaymentDate = "payment_date4",
    RecipientId = "recipient_id2",
    DocumentType = "document_type0",
    Id = "id2",
    Status = "status4",
    Amount = "amount4",
    CreatedAt = "created_at0",
};
```

