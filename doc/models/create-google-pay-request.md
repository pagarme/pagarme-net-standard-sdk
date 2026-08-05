
# Create Google Pay Request

The GooglePay Token Payment Request

## Structure

`CreateGooglePayRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Optional | Informação sobre a versão do token. Único valor aceito é EC_v2 |
| `Data` | `string` | Optional | Dados de pagamento criptografados. Corresponde ao encryptedMessage do token Google. |
| `IntermediateSigningKey` | [`CreateGooglePayIntermediateSigningKeyRequest`](../../doc/models/create-google-pay-intermediate-signing-key-request.md) | Optional | The GooglePay intermediate signing key request |
| `Signature` | `string` | Optional | Assinatura dos dados de pagamento. Verifica se a origem da mensagem é o Google. Corresponde ao signature do token Google. |
| `SignedMessage` | `string` | Optional | - |
| `MerchantIdentifier` | `string` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

CreateGooglePayRequest createGooglePayRequest = new CreateGooglePayRequest
{
    Version = "version2",
    Data = "data6",
    IntermediateSigningKey = null,
    Signature = "signature4",
    SignedMessage = "signed_message2",
};
```

