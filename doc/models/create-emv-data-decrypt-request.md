
# Create Emv Data Decrypt Request

## Structure

`CreateEmvDataDecryptRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cipher` | `string` | Required | Emv Decrypt cipher type |
| `Dukpt` | [`CreateEmvDataDukptDecryptRequest`](../../doc/models/create-emv-data-dukpt-decrypt-request.md) | Optional | Dukpt data request |
| `Tags` | [`List<CreateEmvDataTlvDecryptRequest>`](../../doc/models/create-emv-data-tlv-decrypt-request.md) | Required | Encrypted tags list |

## Example (as JSON)

```json
{
  "cipher": "cipher2",
  "tags": [
    {
      "tag": "tag4",
      "lenght": "lenght2",
      "value": "value2"
    }
  ],
  "dukpt": {
    "ksn": "ksn0"
  }
}
```

