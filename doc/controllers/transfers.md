# Transfers

```csharp
ITransfersController transfersController = client.TransfersController;
```

## Class Name

`TransfersController`

## Methods

* [Create Transfer](../../doc/controllers/transfers.md#create-transfer)
* [Get Transfer by Id](../../doc/controllers/transfers.md#get-transfer-by-id)
* [Get Transfers](../../doc/controllers/transfers.md#get-transfers)


# Create Transfer

```csharp
CreateTransferAsync(
    Models.CreateTransfer request)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`CreateTransfer`](../../doc/models/create-transfer.md) | Body, Required | - |

## Response Type

**200**

[`Task<Models.GetTransfer>`](../../doc/models/get-transfer.md)

## Example Usage

```csharp
CreateTransfer request = new CreateTransfer
{
    Amount = 242,
    SourceId = "source_id0",
    TargetId = "target_id6",
};

try
{
    GetTransfer result = await transfersController.CreateTransferAsync(request);
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


# Get Transfer by Id

```csharp
GetTransferByIdAsync(
    string transferId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transferId` | `string` | Template, Required | - |

## Response Type

**200**

[`Task<Models.GetTransfer>`](../../doc/models/get-transfer.md)

## Example Usage

```csharp
string transferId = "transfer_id6";
try
{
    GetTransfer result = await transfersController.GetTransferByIdAsync(transferId);
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


# Get Transfers

Gets all transfers

```csharp
GetTransfersAsync()
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Response Type

**200**

[`Task<Models.ListTransfers>`](../../doc/models/list-transfers.md)

## Example Usage

```csharp
try
{
    ListTransfers result = await transfersController.GetTransfersAsync();
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

