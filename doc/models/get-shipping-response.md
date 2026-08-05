
# Get Shipping Response

Response object for getting the shipping data

## Structure

`GetShippingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | - |
| `Description` | `string` | Optional | - |
| `RecipientName` | `string` | Optional | - |
| `RecipientPhone` | `string` | Optional | - |
| `Address` | [`GetAddressResponse`](../../doc/models/get-address-response.md) | Optional | - |
| `MaxDeliveryDate` | `DateTime?` | Optional | Data máxima de entrega |
| `EstimatedDeliveryDate` | `DateTime?` | Optional | Prazo estimado de entrega |
| `Type` | `string` | Optional | Shipping Type |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetShippingResponse getShippingResponse = new GetShippingResponse
{
    Amount = 228,
    Description = "description8",
    RecipientName = "recipient_name0",
    RecipientPhone = "recipient_phone4",
    Address = null,
};
```

