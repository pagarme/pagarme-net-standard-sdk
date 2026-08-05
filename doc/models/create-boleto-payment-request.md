
# Create Boleto Payment Request

Contains the settings for creating a boleto payment

## Structure

`CreateBoletoPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Retries` | `int` | Required | Number of retries |
| `Bank` | `string` | Optional | The bank code, containing three characters. The available codes are on the API specification |
| `Instructions` | `string` | Required | The instructions field that will be printed on the boleto. |
| `DueAt` | `DateTime?` | Optional | Boleto due date |
| `BillingAddress` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Card's billing address |
| `BillingAddressId` | `string` | Optional | The address id for the billing address |
| `NossoNumero` | `string` | Optional | Customer identification number with the bank |
| `DocumentNumber` | `string` | Required | Boleto identification |
| `StatementDescriptor` | `string` | Required | Soft Descriptor |
| `Interest` | [`CreateInterestRequest`](../../doc/models/create-interest-request.md) | Optional | - |
| `Fine` | [`CreateFineRequest`](../../doc/models/create-fine-request.md) | Optional | - |
| `MaxDaysToPayPastDue` | `int?` | Optional | - |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Globalization;

CreateBoletoPaymentRequest createBoletoPaymentRequest = new CreateBoletoPaymentRequest
{
    Retries = 192,
    Instructions = "instructions6",
    BillingAddress = null,
    DocumentNumber = "document_number2",
    StatementDescriptor = "statement_descriptor8",
    Bank = "bank6",
    DueAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    BillingAddressId = "billing_address_id4",
    NossoNumero = "nosso_numero8",
    Interest = null,
};
```

