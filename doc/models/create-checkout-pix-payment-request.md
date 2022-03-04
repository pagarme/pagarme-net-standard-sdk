
# Create Checkout Pix Payment Request

Checkout pix payment request

## Structure

`CreateCheckoutPixPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExpiresAt` | `DateTime?` | Optional | Expires at |
| `ExpiresIn` | `int?` | Optional | Expires in |
| `AdditionalInformation` | [`List<Models.PixAdditionalInformation>`](../../doc/models/pix-additional-information.md) | Optional | Additional information |

## Example (as JSON)

```json
{
  "expires_at": null,
  "expires_in": null,
  "additional_information": null
}
```

