# Charges

```csharp
IChargesController chargesController = client.ChargesController;
```

## Class Name

`ChargesController`

## Methods

* [Update Charge Metadata](../../doc/controllers/charges.md#update-charge-metadata)
* [Update Charge Payment Method](../../doc/controllers/charges.md#update-charge-payment-method)
* [Update Charge Card](../../doc/controllers/charges.md#update-charge-card)
* [Get Charges Summary](../../doc/controllers/charges.md#get-charges-summary)
* [Create Charge](../../doc/controllers/charges.md#create-charge)
* [Get Charge Transactions](../../doc/controllers/charges.md#get-charge-transactions)
* [Capture Charge](../../doc/controllers/charges.md#capture-charge)
* [Get Charge](../../doc/controllers/charges.md#get-charge)
* [Cancel Charge](../../doc/controllers/charges.md#cancel-charge)
* [Get Charges](../../doc/controllers/charges.md#get-charges)
* [Confirm Payment](../../doc/controllers/charges.md#confirm-payment)
* [Update Charge Due Date](../../doc/controllers/charges.md#update-charge-due-date)
* [Retry Charge](../../doc/controllers/charges.md#retry-charge)


# Update Charge Metadata

Updates the metadata from a charge

```csharp
UpdateChargeMetadataAsync(
    string chargeId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | The charge id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the charge metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
UpdateMetadataRequest request = new UpdateMetadataRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetChargeResponse result = await chargesController.UpdateChargeMetadataAsync(chargeId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Charge Payment Method

Updates a charge's payment method

```csharp
UpdateChargePaymentMethodAsync(
    string chargeId,
    Models.UpdateChargePaymentMethodRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.UpdateChargePaymentMethodRequest`](../../doc/models/update-charge-payment-method-request.md) | Body, Required | Request for updating the payment method from a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
UpdateChargePaymentMethodRequest request = new UpdateChargePaymentMethodRequest
{
    UpdateSubscription = false,
    PaymentMethod = "payment_method4",
    CreditCard = new CreateCreditCardPaymentRequest
    {
        Installments = 1,
        Capture = true,
        RecurrencyCycle = "\"first\" or \"subsequent\"",
    },
    DebitCard = new CreateDebitCardPaymentRequest
    {
    },
    Boleto = new CreateBoletoPaymentRequest
    {
        Retries = 10,
        Instructions = "instructions4",
        BillingAddress = new CreateAddressRequest
        {
            Street = "street8",
            Number = "number4",
            ZipCode = "zip_code2",
            Neighborhood = "neighborhood4",
            City = "city2",
            State = "state6",
            Country = "country2",
            Complement = "complement6",
            Line1 = "line_18",
            Line2 = "line_26",
        },
        DocumentNumber = "document_number0",
        StatementDescriptor = "statement_descriptor6",
    },
    Voucher = new CreateVoucherPaymentRequest
    {
        RecurrencyCycle = "\"first\" or \"subsequent\"",
    },
    Cash = new CreateCashPaymentRequest
    {
        Description = "description6",
        Confirm = false,
    },
    BankTransfer = new CreateBankTransferPaymentRequest
    {
        Bank = "bank4",
        Retries = 204,
    },
    PrivateLabel = new CreatePrivateLabelPaymentRequest
    {
        Installments = 1,
        Capture = true,
        RecurrencyCycle = "\"first\" or \"subsequent\"",
    },
};

try
{
    GetChargeResponse result = await chargesController.UpdateChargePaymentMethodAsync(chargeId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Charge Card

Updates the card from a charge

```csharp
UpdateChargeCardAsync(
    string chargeId,
    Models.UpdateChargeCardRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.UpdateChargeCardRequest`](../../doc/models/update-charge-card-request.md) | Body, Required | Request for updating a charge's card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
UpdateChargeCardRequest request = new UpdateChargeCardRequest
{
    UpdateSubscription = false,
    CardId = "card_id2",
    Card = new CreateCardRequest
    {
        Type = "credit",
    },
    Recurrence = false,
};

try
{
    GetChargeResponse result = await chargesController.UpdateChargeCardAsync(chargeId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Charges Summary

```csharp
GetChargesSummaryAsync(
    string status,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `string` | Query, Required | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.GetChargesSummaryResponse>`](../../doc/models/get-charges-summary-response.md)

## Example Usage

```csharp
string status = "status8";
try
{
    GetChargesSummaryResponse result = await chargesController.GetChargesSummaryAsync(status, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Charge

Creates a new charge

```csharp
CreateChargeAsync(
    Models.CreateChargeRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateChargeRequest`](../../doc/models/create-charge-request.md) | Body, Required | Request for creating a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
CreateChargeRequest request = new CreateChargeRequest
{
    Amount = 242,
    Payment = new CreatePaymentRequest
    {
        PaymentMethod = "payment_method2",
    },
    OrderId = "order_id0",
};

try
{
    GetChargeResponse result = await chargesController.CreateChargeAsync(request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Charge Transactions

```csharp
GetChargeTransactionsAsync(
    string chargeId,
    int? page = null,
    int? size = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge Id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListChargeTransactionsResponse>`](../../doc/models/list-charge-transactions-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
try
{
    ListChargeTransactionsResponse result = await chargesController.GetChargeTransactionsAsync(chargeId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Capture Charge

Captures a charge

```csharp
CaptureChargeAsync(
    string chargeId,
    Models.CreateCaptureChargeRequest request = null,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.CreateCaptureChargeRequest`](../../doc/models/create-capture-charge-request.md) | Body, Optional | Request for capturing a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
try
{
    GetChargeResponse result = await chargesController.CaptureChargeAsync(chargeId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Charge

Get a charge from its id

```csharp
GetChargeAsync(
    string chargeId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
try
{
    GetChargeResponse result = await chargesController.GetChargeAsync(chargeId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Cancel Charge

Cancel a charge

```csharp
CancelChargeAsync(
    string chargeId,
    Models.CreateCancelChargeRequest request = null,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `request` | [`Models.CreateCancelChargeRequest`](../../doc/models/create-cancel-charge-request.md) | Body, Optional | Request for cancelling a charge |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
try
{
    GetChargeResponse result = await chargesController.CancelChargeAsync(chargeId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Charges

Lists all charges

```csharp
GetChargesAsync(
    int? page = null,
    int? size = null,
    string code = null,
    string status = null,
    string paymentMethod = null,
    string customerId = null,
    string orderId = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Filter for charge's code |
| `status` | `string` | Query, Optional | Filter for charge's status |
| `paymentMethod` | `string` | Query, Optional | Filter for charge's payment method |
| `customerId` | `string` | Query, Optional | Filter for charge's customer id |
| `orderId` | `string` | Query, Optional | Filter for charge's order id |
| `createdSince` | `DateTime?` | Query, Optional | Filter for the beginning of the range for charge's creation |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for the end of the range for charge's creation |

## Response Type

[`Task<Models.ListChargesResponse>`](../../doc/models/list-charges-response.md)

## Example Usage

```csharp
try
{
    ListChargesResponse result = await chargesController.GetChargesAsync(null, null, null, null, null, null, null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Confirm Payment

```csharp
ConfirmPaymentAsync(
    string chargeId,
    Models.CreateConfirmPaymentRequest request = null,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | - |
| `request` | [`Models.CreateConfirmPaymentRequest`](../../doc/models/create-confirm-payment-request.md) | Body, Optional | Request for confirm payment |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
try
{
    GetChargeResponse result = await chargesController.ConfirmPaymentAsync(chargeId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Charge Due Date

Updates the due date from a charge

```csharp
UpdateChargeDueDateAsync(
    string chargeId,
    Models.UpdateChargeDueDateRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge Id |
| `request` | [`Models.UpdateChargeDueDateRequest`](../../doc/models/update-charge-due-date-request.md) | Body, Required | Request for updating the due date |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
UpdateChargeDueDateRequest request = new UpdateChargeDueDateRequest
{
};

try
{
    GetChargeResponse result = await chargesController.UpdateChargeDueDateAsync(chargeId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Retry Charge

Retries a charge

```csharp
RetryChargeAsync(
    string chargeId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `chargeId` | `string` | Template, Required | Charge id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetChargeResponse>`](../../doc/models/get-charge-response.md)

## Example Usage

```csharp
string chargeId = "charge_id8";
try
{
    GetChargeResponse result = await chargesController.RetryChargeAsync(chargeId, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

