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

[`Task<Models.ListBalanceOperationResponse>`](../../doc/models/list-balance-operation-response.md)

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
    ListBalanceOperationResponse result = await balanceOperationsController.GetBalanceOperationsAsync(status, createdSince, createdUntil);
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

