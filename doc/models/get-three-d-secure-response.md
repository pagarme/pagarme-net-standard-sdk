
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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetThreeDSecureResponse getThreeDSecureResponse = new GetThreeDSecureResponse
{
    Mpi = "mpi4",
    Eci = "eci6",
    Cavv = "cavv2",
    TransactionId = "transaction_Id2",
    SuccessUrl = "success_url8",
};
```

