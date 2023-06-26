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
    string status,
    DateTime createdSince,
    DateTime createdUntil)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `string` | Query, Required | - |
| `createdSince` | `DateTime` | Query, Required | - |
| `createdUntil` | `DateTime` | Query, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string status = "status8";
DateTime createdSince = DateTime.ParseExact(
        "2016-03-13T12:52:32.123Z",
        "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
DateTime createdUntil = DateTime.ParseExact(
        "2016-03-13T12:52:32.123Z",
        "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
try
{
    await balanceOperationsController.GetBalanceOperationsAsync(status, createdSince, createdUntil);
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
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string id = "id0";
try
{
    await balanceOperationsController.GetBalanceOperationByIdAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

