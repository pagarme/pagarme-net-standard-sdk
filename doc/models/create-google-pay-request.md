
# Create Google Pay Request

The GooglePay Token Payment Request

## Structure

`CreateGooglePayRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Required | Informação sobre a versão do token. Único valor aceito é EC_v2 |
| `Data` | `string` | Required | Dados de pagamento criptografados. Corresponde ao encryptedMessage do token Google. |
| `IntermediateSigningKey` | [`CreateGooglePayIntermediateSigningKeyRequest`](../../doc/models/create-google-pay-intermediate-signing-key-request.md) | Required | The GooglePay intermediate signing key request |
| `Signature` | `string` | Required | Assinatura dos dados de pagamento. Verifica se a origem da mensagem é o Google. Corresponde ao signature do token Google. |
| `SignedMessage` | `string` | Required | - |

## Example (as JSON)

```json
{
  "version": "version6",
  "data": "data0",
  "intermediate_signing_key": {
    "signed_key": "signed_key0",
    "signatures": [
      "signatures2",
      "signatures3",
      "signatures4"
    ]
  },
  "signature": "signature8",
  "signed_message": "signed_message6"
}
```

