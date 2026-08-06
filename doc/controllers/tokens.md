# Tokens

```csharp
ITokensController tokensController = client.TokensController;
```

## Class Name

`TokensController`

## Methods

* [Create Token](../../doc/controllers/tokens.md#create-token)
* [Get Token](../../doc/controllers/tokens.md#get-token)


# Create Token

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateTokenAsync(
    string publicKey,
    Models.CreateTokenRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publicKey` | `string` | Template, Required | Public key |
| `request` | [`CreateTokenRequest`](../../doc/models/create-token-request.md) | Body, Required | Request for creating a token |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetTokenResponse>`](../../doc/models/get-token-response.md)

## Example Usage

```csharp
string publicKey = "public_key6";
CreateTokenRequest request = new CreateTokenRequest
{
    Type = "card",
    Card = null,
};

try
{
    GetTokenResponse result = await tokensController.CreateTokenAsync(
        publicKey,
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


# Get Token

Gets a token from its id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetTokenAsync(
    string id,
    string publicKey)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Token id |
| `publicKey` | `string` | Template, Required | Public key |

## Response Type

**200**

[`Task<Models.GetTokenResponse>`](../../doc/models/get-token-response.md)

## Example Usage

```csharp
string id = "id0";
string publicKey = "public_key6";
try
{
    GetTokenResponse result = await tokensController.GetTokenAsync(
        id,
        publicKey
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

