
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

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateThreeDSecureRequest createThreeDSecureRequest = new CreateThreeDSecureRequest
{
    Mpi = "mpi2",
    Cavv = "cavv0",
    Eci = "eci4",
    TransactionId = "transaction_id2",
    SuccessUrl = "success_url6",
    DsTransactionId = "ds_transaction_id2",
};
```

