
# Create Three D Secure Request

Creates a 3D-S authentication payment

## Structure

`CreateThreeDSecureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mpi` | `string` | Required | The MPI Vendor (MerchantPlugin) |
| `Cavv` | `string` | Optional | The Cardholder Authentication Verification value |
| `Eci` | `string` | Optional | The Electronic Commerce Indicator value |
| `TransactionId` | `string` | Optional | The TransactionId value (XID) |
| `SuccessUrl` | `string` | Optional | The success URL after the authentication |
| `DsTransactionId` | `string` | Optional | Directory Service Transaction Identifier |
| `Version` | `string` | Optional | ThreeDSecure Version |

## Example (as JSON)

```json
{
  "mpi": "mpi4",
  "cavv": "cavv2",
  "eci": "eci6",
  "transaction_id": "transaction_id4",
  "success_url": "success_url8",
  "ds_transaction_id": "ds_transaction_id4"
}
```

