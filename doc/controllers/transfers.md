# Transfers

```csharp
ITransfersController transfersController = client.TransfersController;
```

## Class Name

`TransfersController`

## Methods

* [Get Transfers](../../doc/controllers/transfers.md#get-transfers)
* [Get Transfer by Id](../../doc/controllers/transfers.md#get-transfer-by-id)
* [Create Transfer](../../doc/controllers/transfers.md#create-transfer)


# Get Transfers

Gets all transfers

```csharp
GetTransfersAsync()
```

## Response Type

[`Task<Models.ListTransfers>`](../../doc/models/list-transfers.md)

## Example Usage

```csharp
try
{
    ListTransfers result = await transfersController.GetTransfersAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Transfer by Id

```csharp
GetTransferByIdAsync(
    string transferId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transferId` | `string` | Template, Required | - |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Transfer

```csharp
CreateTransferAsync(
    Models.CreateTransfer request)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateTransfer`](../../doc/models/create-transfer.md) | Body, Required | - |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

