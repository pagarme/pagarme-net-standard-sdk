# Customers

```csharp
ICustomersController customersController = client.CustomersController;
```

## Class Name

`CustomersController`

## Methods

* [Create Access Token](../../doc/controllers/customers.md#create-access-token)
* [Create Address](../../doc/controllers/customers.md#create-address)
* [Create Card](../../doc/controllers/customers.md#create-card)
* [Create Customer](../../doc/controllers/customers.md#create-customer)
* [Delete Access Token](../../doc/controllers/customers.md#delete-access-token)
* [Delete Access Tokens](../../doc/controllers/customers.md#delete-access-tokens)
* [Delete Address](../../doc/controllers/customers.md#delete-address)
* [Delete Card](../../doc/controllers/customers.md#delete-card)
* [Get Access Token](../../doc/controllers/customers.md#get-access-token)
* [Get Access Tokens](../../doc/controllers/customers.md#get-access-tokens)
* [Get Address](../../doc/controllers/customers.md#get-address)
* [Get Addresses](../../doc/controllers/customers.md#get-addresses)
* [Get Card](../../doc/controllers/customers.md#get-card)
* [Get Cards](../../doc/controllers/customers.md#get-cards)
* [Get Customer](../../doc/controllers/customers.md#get-customer)
* [Get Customers](../../doc/controllers/customers.md#get-customers)
* [Renew Card](../../doc/controllers/customers.md#renew-card)
* [Update Address](../../doc/controllers/customers.md#update-address)
* [Update Card](../../doc/controllers/customers.md#update-card)
* [Update Customer](../../doc/controllers/customers.md#update-customer)
* [Update Customer Metadata](../../doc/controllers/customers.md#update-customer-metadata)


# Create Access Token

Creates a access token for a customer

```csharp
CreateAccessTokenAsync(
    string customerId,
    Models.CreateAccessTokenRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `request` | [`CreateAccessTokenRequest`](../../doc/models/create-access-token-request.md) | Body, Required | Request for creating a access token |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetAccessTokenResponse>`](../../doc/models/get-access-token-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
CreateAccessTokenRequest request = new CreateAccessTokenRequest
{
};

try
{
    GetAccessTokenResponse result = await customersController.CreateAccessTokenAsync(
        customerId,
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


# Create Address

Creates a new address for a customer

```csharp
CreateAddressAsync(
    string customerId,
    Models.CreateAddressRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `request` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Body, Required | Request for creating an address |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetAddressResponse>`](../../doc/models/get-address-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
CreateAddressRequest request = new CreateAddressRequest
{
    Street = "street6",
    Number = "number4",
    ZipCode = "zip_code0",
    Neighborhood = "neighborhood2",
    City = "city6",
    State = "state2",
    Country = "country0",
    Complement = "complement2",
    Line1 = "line_10",
    Line2 = "line_24",
};

try
{
    GetAddressResponse result = await customersController.CreateAddressAsync(
        customerId,
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


# Create Card

Creates a new card for a customer

```csharp
CreateCardAsync(
    string customerId,
    Models.CreateCardRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `request` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Body, Required | Request for creating a card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
CreateCardRequest request = new CreateCardRequest
{
    Type = "credit",
};

try
{
    GetCardResponse result = await customersController.CreateCardAsync(
        customerId,
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


# Create Customer

Creates a new customer

```csharp
CreateCustomerAsync(
    Models.CreateCustomerRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Body, Required | Request for creating a customer |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetCustomerResponse>`](../../doc/models/get-customer-response.md)

## Example Usage

```csharp
CreateCustomerRequest request = new CreateCustomerRequest
{
    Name = "Tony Stark",
    Email = null,
    Document = null,
    Type = null,
    Address = null,
    Metadata = null,
    Phones = null,
    Code = null,
};

try
{
    GetCustomerResponse result = await customersController.CreateCustomerAsync(request);
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


# Delete Access Token

Delete a customer's access token

```csharp
DeleteAccessTokenAsync(
    string customerId,
    string tokenId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `tokenId` | `string` | Template, Required | Token Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetAccessTokenResponse>`](../../doc/models/get-access-token-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string tokenId = "token_id6";
try
{
    GetAccessTokenResponse result = await customersController.DeleteAccessTokenAsync(
        customerId,
        tokenId
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


# Delete Access Tokens

Delete a Customer's access tokens

```csharp
DeleteAccessTokensAsync(
    string customerId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |

## Response Type

**200**

[`Task<Models.ListAccessTokensResponse>`](../../doc/models/list-access-tokens-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    ListAccessTokensResponse result = await customersController.DeleteAccessTokensAsync(customerId);
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


# Delete Address

Delete a Customer's address

```csharp
DeleteAddressAsync(
    string customerId,
    string addressId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `addressId` | `string` | Template, Required | Address Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetAddressResponse>`](../../doc/models/get-address-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string addressId = "address_id0";
try
{
    GetAddressResponse result = await customersController.DeleteAddressAsync(
        customerId,
        addressId
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


# Delete Card

Delete a customer's card

```csharp
DeleteCardAsync(
    string customerId,
    string cardId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `cardId` | `string` | Template, Required | Card Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string cardId = "card_id4";
try
{
    GetCardResponse result = await customersController.DeleteCardAsync(
        customerId,
        cardId
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


# Get Access Token

Get a Customer's access token

```csharp
GetAccessTokenAsync(
    string customerId,
    string tokenId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `tokenId` | `string` | Template, Required | Token Id |

## Response Type

**200**

[`Task<Models.GetAccessTokenResponse>`](../../doc/models/get-access-token-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string tokenId = "token_id6";
try
{
    GetAccessTokenResponse result = await customersController.GetAccessTokenAsync(
        customerId,
        tokenId
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


# Get Access Tokens

Get all access tokens from a customer

```csharp
GetAccessTokensAsync(
    string customerId,
    int? page = null,
    int? size = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

**200**

[`Task<Models.ListAccessTokensResponse>`](../../doc/models/list-access-tokens-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    ListAccessTokensResponse result = await customersController.GetAccessTokensAsync(customerId);
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


# Get Address

Get a customer's address

```csharp
GetAddressAsync(
    string customerId,
    string addressId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `addressId` | `string` | Template, Required | Address Id |

## Response Type

**200**

[`Task<Models.GetAddressResponse>`](../../doc/models/get-address-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string addressId = "address_id0";
try
{
    GetAddressResponse result = await customersController.GetAddressAsync(
        customerId,
        addressId
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


# Get Addresses

Gets all adressess from a customer

```csharp
GetAddressesAsync(
    string customerId,
    int? page = null,
    int? size = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

**200**

[`Task<Models.ListAddressesResponse>`](../../doc/models/list-addresses-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    ListAddressesResponse result = await customersController.GetAddressesAsync(customerId);
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


# Get Card

Get a customer's card

```csharp
GetCardAsync(
    string customerId,
    string cardId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `cardId` | `string` | Template, Required | Card id |

## Response Type

**200**

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string cardId = "card_id4";
try
{
    GetCardResponse result = await customersController.GetCardAsync(
        customerId,
        cardId
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


# Get Cards

Get all cards from a customer

```csharp
GetCardsAsync(
    string customerId,
    int? page = null,
    int? size = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

**200**

[`Task<Models.ListCardsResponse>`](../../doc/models/list-cards-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    ListCardsResponse result = await customersController.GetCardsAsync(customerId);
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


# Get Customer

Get a customer

```csharp
GetCustomerAsync(
    string customerId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |

## Response Type

**200**

[`Task<Models.GetCustomerResponse>`](../../doc/models/get-customer-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    GetCustomerResponse result = await customersController.GetCustomerAsync(customerId);
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


# Get Customers

Get all Customers

```csharp
GetCustomersAsync(
    string name = null,
    string document = null,
    int? page = 1,
    int? size = 10,
    string email = null,
    string code = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Query, Optional | Name of the Customer |
| `document` | `string` | Query, Optional | Document of the Customer |
| `page` | `int?` | Query, Optional | Current page the the search<br><br>**Default**: `1` |
| `size` | `int?` | Query, Optional | Quantity pages of the search<br><br>**Default**: `10` |
| `email` | `string` | Query, Optional | Customer's email |
| `code` | `string` | Query, Optional | Customer's code |

## Response Type

**200**

[`Task<Models.ListCustomersResponse>`](../../doc/models/list-customers-response.md)

## Example Usage

```csharp
int? page = 1;
int? size = 10;
try
{
    ListCustomersResponse result = await customersController.GetCustomersAsync(
        null,
        null,
        page,
        size
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


# Renew Card

Renew a card

```csharp
RenewCardAsync(
    string customerId,
    string cardId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `cardId` | `string` | Template, Required | Card Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string cardId = "card_id4";
try
{
    GetCardResponse result = await customersController.RenewCardAsync(
        customerId,
        cardId
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


# Update Address

Updates an address

```csharp
UpdateAddressAsync(
    string customerId,
    string addressId,
    Models.UpdateAddressRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `addressId` | `string` | Template, Required | Address Id |
| `request` | [`UpdateAddressRequest`](../../doc/models/update-address-request.md) | Body, Required | Request for updating an address |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetAddressResponse>`](../../doc/models/get-address-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string addressId = "address_id0";
UpdateAddressRequest request = new UpdateAddressRequest
{
    Number = "number4",
    Complement = "complement2",
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
    Line2 = "line_24",
};

try
{
    GetAddressResponse result = await customersController.UpdateAddressAsync(
        customerId,
        addressId,
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


# Update Card

Updates a card

```csharp
UpdateCardAsync(
    string customerId,
    string cardId,
    Models.UpdateCardRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `cardId` | `string` | Template, Required | Card id |
| `request` | [`UpdateCardRequest`](../../doc/models/update-card-request.md) | Body, Required | Request for updating a card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string cardId = "card_id4";
UpdateCardRequest request = new UpdateCardRequest
{
    HolderName = "holder_name2",
    ExpMonth = 10,
    ExpYear = 30,
    BillingAddress = null,
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
    Label = "label6",
};

try
{
    GetCardResponse result = await customersController.UpdateCardAsync(
        customerId,
        cardId,
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


# Update Customer

Updates a customer

```csharp
UpdateCustomerAsync(
    string customerId,
    Models.UpdateCustomerRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `request` | [`UpdateCustomerRequest`](../../doc/models/update-customer-request.md) | Body, Required | Request for updating a customer |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetCustomerResponse>`](../../doc/models/get-customer-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
UpdateCustomerRequest request = new UpdateCustomerRequest
{
};

try
{
    GetCustomerResponse result = await customersController.UpdateCustomerAsync(
        customerId,
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


# Update Customer Metadata

Updates the metadata a customer

```csharp
UpdateCustomerMetadataAsync(
    string customerId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | The customer id |
| `request` | [`UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the customer metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetCustomerResponse>`](../../doc/models/get-customer-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
UpdateMetadataRequest request = new UpdateMetadataRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetCustomerResponse result = await customersController.UpdateCustomerMetadataAsync(
        customerId,
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

