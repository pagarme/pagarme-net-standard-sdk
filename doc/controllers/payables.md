# Payables

```csharp
IPayablesController payablesController = client.PayablesController;
```

## Class Name

`PayablesController`


# Get Payables

```csharp
GetPayablesAsync(
    string type = null,
    string splitId = null,
    string bulkAnticipationId = null,
    string status = null,
    string recipientId = null,
    string chargeId = null,
    string paymentDateUntil = null,
    DateTime? paymentDateSince = null,
    DateTime? updatedUntil = null,
    DateTime? updatedSince = null,
    DateTime? createdUntil = null,
    DateTime? createdSince = null,
    string liquidationArrangementId = null,
    int? size = null,
    long? gatewayId = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | `string` | Query, Optional | - |
| `splitId` | `string` | Query, Optional | - |
| `bulkAnticipationId` | `string` | Query, Optional | - |
| `status` | `string` | Query, Optional | - |
| `recipientId` | `string` | Query, Optional | - |
| `chargeId` | `string` | Query, Optional | - |
| `paymentDateUntil` | `string` | Query, Optional | - |
| `paymentDateSince` | `DateTime?` | Query, Optional | - |
| `updatedUntil` | `DateTime?` | Query, Optional | - |
| `updatedSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `liquidationArrangementId` | `string` | Query, Optional | - |
| `size` | `int?` | Query, Optional | - |
| `gatewayId` | `long?` | Query, Optional | - |

## Response Type

**200**

[`Task<Models.ListPayablesResponse>`](../../doc/models/list-payables-response.md)

## Example Usage

```csharp
try
{
    ListPayablesResponse result = await payablesController.GetPayablesAsync();
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

