
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
  "expires_at": "2016-03-13T12:52:32.123Z",
  "expires_in": 226,
  "additional_information": [
    {
      "Name": "Name5",
      "Value": "Value7"
    },
    {
      "Name": "Name6",
      "Value": "Value6"
    }
  ]
}
```

