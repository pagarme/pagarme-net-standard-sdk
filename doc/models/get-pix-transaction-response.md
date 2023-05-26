
# Get Pix Transaction Response

Response object when getting a pix transaction

## Structure

`GetPixTransactionResponse`

## Inherits From

[`GetTransactionResponse`](../../doc/models/get-transaction-response.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QrCode` | `string` | Optional | - |
| `QrCodeUrl` | `string` | Optional | - |
| `ExpiresAt` | `DateTime?` | Optional | - |
| `AdditionalInformation` | [`List<Models.PixAdditionalInformation>`](../../doc/models/pix-additional-information.md) | Optional | - |
| `EndToEndId` | `string` | Optional | - |
| `Payer` | [`Models.GetPixPayerResponse`](../../doc/models/get-pix-payer-response.md) | Optional | - |
| `PixProviderTid` | `string` | Optional | Pix provider TID |

## Example (as JSON)

```json
{
  "gateway_id": "gateway_id6",
  "amount": 190,
  "status": "status4",
  "success": false,
  "created_at": "2016-03-13T12:52:32.123Z",
  "transaction_type": "pix",
  "qr_code": "qr_code6",
  "qr_code_url": "qr_code_url2",
  "expires_at": "2016-03-13T12:52:32.123Z",
  "additional_information": [
    {
      "Name": "Name5",
      "Value": "Value7"
    },
    {
      "Name": "Name6",
      "Value": "Value6"
    }
  ],
  "end_to_end_id": "end_to_end_id0"
}
```

