
# Create Shipping Request

Shipping data

## Structure

`CreateShippingRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Shipping amount |
| `Description` | `string` | Required | Description |
| `RecipientName` | `string` | Required | Recipient name |
| `RecipientPhone` | `string` | Required | Recipient phone number |
| `AddressId` | `string` | Required | The id of the address that will be used for shipping |
| `Address` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Address data |
| `MaxDeliveryDate` | `DateTime?` | Optional | Data máxima de entrega |
| `EstimatedDeliveryDate` | `DateTime?` | Optional | Prazo estimado de entrega |
| `Type` | `string` | Required | Shipping type |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

CreateShippingRequest createShippingRequest = new CreateShippingRequest
{
    Amount = 44,
    Description = "description0",
    RecipientName = "recipient_name8",
    RecipientPhone = "recipient_phone2",
    AddressId = "address_id0",
    Address = null,
    Type = "type0",
    MaxDeliveryDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EstimatedDeliveryDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

