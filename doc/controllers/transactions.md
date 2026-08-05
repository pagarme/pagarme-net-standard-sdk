# Transactions

```csharp
ITransactionsController transactionsController = client.TransactionsController;
```

## Class Name

`TransactionsController`


# Get Transaction

```csharp
GetTransactionAsync(
    string transactionId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionId` | `string` | Template, Required | - |

## Response Type

**200**

[`Task<Models.GetTransactionResponse>`](../../doc/models/get-transaction-response.md)

## Example Usage

```csharp
string transactionId = "transaction_id8";
try
{
    GetTransactionResponse result = await transactionsController.GetTransactionAsync(transactionId);
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

