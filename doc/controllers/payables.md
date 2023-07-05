# Payables

```csharp
IPayablesController payablesController = client.PayablesController;
```

## Class Name

`PayablesController`

## Methods

* [Get Payables](../../doc/controllers/payables.md#get-payables)
* [Get Payable by Id](../../doc/controllers/payables.md#get-payable-by-id)


# Get Payables

```csharp
GetPayablesAsync(
    string type = null,
    string splitId = null,
    string bulkAnticipationId = null,
    int? installment = null,
    string status = null,
    string recipientId = null,
    int? amount = null,
    string chargeId = null,
    string paymentDateUntil = null,
    DateTime? paymentDateSince = null,
    DateTime? updatedUntil = null,
    DateTime? updatedSince = null,
    DateTime? createdUntil = null,
    DateTime? createdSince = null,
    string liquidationArrangementId = null,
    int? page = null,
    int? size = null,
    long? gatewayId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | `string` | Query, Optional | - |
| `splitId` | `string` | Query, Optional | - |
| `bulkAnticipationId` | `string` | Query, Optional | - |
| `installment` | `int?` | Query, Optional | - |
| `status` | `string` | Query, Optional | - |
| `recipientId` | `string` | Query, Optional | - |
| `amount` | `int?` | Query, Optional | - |
| `chargeId` | `string` | Query, Optional | - |
| `paymentDateUntil` | `string` | Query, Optional | - |
| `paymentDateSince` | `DateTime?` | Query, Optional | - |
| `updatedUntil` | `DateTime?` | Query, Optional | - |
| `updatedSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `liquidationArrangementId` | `string` | Query, Optional | - |
| `page` | `int?` | Query, Optional | - |
| `size` | `int?` | Query, Optional | - |
| `gatewayId` | `long?` | Query, Optional | - |

## Response Type

[`Task<Models.ListPayablesResponse>`](../../doc/models/list-payables-response.md)

## Example Usage

```csharp
try
{
    ListPayablesResponse result = await payablesController.GetPayablesAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Payable by Id

```csharp
GetPayableByIdAsync(
    long id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `long` | Template, Required | - |

## Response Type

[`Task<Models.GetPayableResponse>`](../../doc/models/get-payable-response.md)

## Example Usage

```csharp
long id = 112L;
try
{
    GetPayableResponse result = await payablesController.GetPayableByIdAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

