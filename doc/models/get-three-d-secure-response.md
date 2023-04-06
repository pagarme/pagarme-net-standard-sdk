
# Get Three D Secure Response

3D-S payment authentication response

## Structure

`GetThreeDSecureResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mpi` | `string` | Optional | MPI Vendor |
| `Eci` | `string` | Optional | Electronic Commerce Indicator (ECI) (Opcional) |
| `Cavv` | `string` | Optional | Online payment cryptogram, definido pelo 3-D Secure. |
| `TransactionId` | `string` | Optional | Identificador da transação (XID) |
| `SuccessUrl` | `string` | Optional | Url de redirecionamento de sucessso |

## Example (as JSON)

```json
{
  "mpi": "mpi2",
  "eci": "eci0",
  "cavv": "cavv4",
  "transaction_Id": "transaction_Id4",
  "success_url": "success_url2"
}
```

