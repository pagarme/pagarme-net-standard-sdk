
# Create Google Pay Intermediate Signing Key Request

The GooglePay Intermediate Signing Key Request

## Structure

`CreateGooglePayIntermediateSigningKeyRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SignedKey` | `string` | Optional | Uma mensagem codificada em Base64 com a descrição de pagamento da chave. |
| `Signatures` | `List<string>` | Optional | Verifica se a origem da chave de assinatura intermediária é o Google. É codificada em Base64 e criada usando o ECDSA. |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateGooglePayIntermediateSigningKeyRequest createGooglePayIntermediateSigningKeyRequest = new CreateGooglePayIntermediateSigningKeyRequest
{
    SignedKey = "signed_key4",
    Signatures = new List<string>
    {
        "signatures6",
    },
};
```

