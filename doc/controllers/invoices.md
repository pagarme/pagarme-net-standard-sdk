# Invoices

```csharp
IInvoicesController invoicesController = client.InvoicesController;
```

## Class Name

`InvoicesController`

## Methods

* [Cancel Invoice](../../doc/controllers/invoices.md#cancel-invoice)
* [Create Invoice](../../doc/controllers/invoices.md#create-invoice)
* [Get Invoice](../../doc/controllers/invoices.md#get-invoice)
* [Get Invoices](../../doc/controllers/invoices.md#get-invoices)
* [Get Partial Invoice](../../doc/controllers/invoices.md#get-partial-invoice)
* [Update Invoice Metadata](../../doc/controllers/invoices.md#update-invoice-metadata)
* [Update Invoice Status](../../doc/controllers/invoices.md#update-invoice-status)


# Cancel Invoice

Cancels an invoice

```csharp
CancelInvoiceAsync(
    string invoiceId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invoiceId` | `string` | Template, Required | Invoice id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetInvoiceResponse>`](../../doc/models/get-invoice-response.md)

## Example Usage

```csharp
string invoiceId = "invoice_id0";
try
{
    GetInvoiceResponse result = await invoicesController.CancelInvoiceAsync(invoiceId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
}
```


# Create Invoice

Create an Invoice

```csharp
CreateInvoiceAsync(
    string subscriptionId,
    string cycleId,
    Models.CreateInvoiceRequest request = null,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `cycleId` | `string` | Template, Required | Cycle Id |
| `request` | [`CreateInvoiceRequest`](../../doc/models/create-invoice-request.md) | Body, Optional | - |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetInvoiceResponse>`](../../doc/models/get-invoice-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string cycleId = "cycle_id6";
try
{
    GetInvoiceResponse result = await invoicesController.CreateInvoiceAsync(
        subscriptionId,
        cycleId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
}
```


# Get Invoice

Gets an invoice

```csharp
GetInvoiceAsync(
    string invoiceId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invoiceId` | `string` | Template, Required | Invoice Id |

## Response Type

**200**

[`Task<Models.GetInvoiceResponse>`](../../doc/models/get-invoice-response.md)

## Example Usage

```csharp
string invoiceId = "invoice_id0";
try
{
    GetInvoiceResponse result = await invoicesController.GetInvoiceAsync(invoiceId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
}
```


# Get Invoices

Gets all invoices

```csharp
GetInvoicesAsync(
    int? page = null,
    int? size = null,
    string code = null,
    string customerId = null,
    string subscriptionId = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null,
    string status = null,
    DateTime? dueSince = null,
    DateTime? dueUntil = null,
    string customerDocument = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Filter for Invoice's code |
| `customerId` | `string` | Query, Optional | Filter for Invoice's customer id |
| `subscriptionId` | `string` | Query, Optional | Filter for Invoice's subscription id |
| `createdSince` | `DateTime?` | Query, Optional | Filter for Invoice's creation date start range |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for Invoices creation date end range |
| `status` | `string` | Query, Optional | Filter for Invoice's status |
| `dueSince` | `DateTime?` | Query, Optional | Filter for Invoice's due date start range |
| `dueUntil` | `DateTime?` | Query, Optional | Filter for Invoice's due date end range |
| `customerDocument` | `string` | Query, Optional | - |

## Response Type

**200**

[`Task<Models.ListInvoicesResponse>`](../../doc/models/list-invoices-response.md)

## Example Usage

```csharp
try
{
    ListInvoicesResponse result = await invoicesController.GetInvoicesAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
}
```


# Get Partial Invoice

```csharp
GetPartialInvoiceAsync(
    string subscriptionId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |

## Response Type

**200**

[`Task<Models.GetInvoiceResponse>`](../../doc/models/get-invoice-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
try
{
    GetInvoiceResponse result = await invoicesController.GetPartialInvoiceAsync(subscriptionId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
}
```


# Update Invoice Metadata

Updates the metadata from an invoice

```csharp
UpdateInvoiceMetadataAsync(
    string invoiceId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invoiceId` | `string` | Template, Required | The invoice id |
| `request` | [`UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the invoice metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetInvoiceResponse>`](../../doc/models/get-invoice-response.md)

## Example Usage

```csharp
string invoiceId = "invoice_id0";
UpdateMetadataRequest request = new UpdateMetadataRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetInvoiceResponse result = await invoicesController.UpdateInvoiceMetadataAsync(
        invoiceId,
        request
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
}
```


# Update Invoice Status

Updates the status from an invoice

```csharp
UpdateInvoiceStatusAsync(
    string invoiceId,
    Models.UpdateInvoiceStatusRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invoiceId` | `string` | Template, Required | Invoice Id |
| `request` | [`UpdateInvoiceStatusRequest`](../../doc/models/update-invoice-status-request.md) | Body, Required | Request for updating an invoice's status |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetInvoiceResponse>`](../../doc/models/get-invoice-response.md)

## Example Usage

```csharp
string invoiceId = "invoice_id0";
UpdateInvoiceStatusRequest request = new UpdateInvoiceStatusRequest
{
    Status = "status8",
};

try
{
    GetInvoiceResponse result = await invoicesController.UpdateInvoiceStatusAsync(
        invoiceId,
        request
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorException)
    {
       // TODO: Handle ErrorException exception here
    }
}
```

