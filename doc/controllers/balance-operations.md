# Balance Operations

```csharp
IBalanceOperationsController balanceOperationsController = client.BalanceOperationsController;
```

## Class Name

`BalanceOperationsController`

## Methods

* [Get Balance Operations](../../doc/controllers/balance-operations.md#get-balance-operations)
* [Get Balance Operation by Id](../../doc/controllers/balance-operations.md#get-balance-operation-by-id)


# Get Balance Operations

```csharp
GetBalanceOperationsAsync(
    string status = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `string` | Query, Optional | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ListBalanceOperationResponse>`](../../doc/models/list-balance-operation-response.md)

## Example Usage

```csharp
try
{
    ListBalanceOperationResponse result = await balanceOperationsController.GetBalanceOperationsAsync(null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Balance Operation by Id

```csharp
GetBalanceOperationByIdAsync(
    long id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `long` | Template, Required | - |

## Response Type

[`Task<Models.GetBalanceOperationResponse>`](../../doc/models/get-balance-operation-response.md)

## Example Usage

```csharp
long id = 112L;
try
{
    GetBalanceOperationResponse result = await balanceOperationsController.GetBalanceOperationByIdAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

