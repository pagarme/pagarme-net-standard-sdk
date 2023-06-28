# Customers

```csharp
ICustomersController customersController = client.CustomersController;
```

## Class Name

`CustomersController`

## Methods

* [Update Card](../../doc/controllers/customers.md#update-card)
* [Update Address](../../doc/controllers/customers.md#update-address)
* [Delete Access Token](../../doc/controllers/customers.md#delete-access-token)
* [Create Address](../../doc/controllers/customers.md#create-address)
* [Create Customer](../../doc/controllers/customers.md#create-customer)
* [Create Card](../../doc/controllers/customers.md#create-card)
* [Get Cards](../../doc/controllers/customers.md#get-cards)
* [Renew Card](../../doc/controllers/customers.md#renew-card)
* [Get Address](../../doc/controllers/customers.md#get-address)
* [Delete Address](../../doc/controllers/customers.md#delete-address)
* [Get Access Token](../../doc/controllers/customers.md#get-access-token)
* [Update Customer Metadata](../../doc/controllers/customers.md#update-customer-metadata)
* [Get Card](../../doc/controllers/customers.md#get-card)
* [Delete Access Tokens](../../doc/controllers/customers.md#delete-access-tokens)
* [Create Access Token](../../doc/controllers/customers.md#create-access-token)
* [Get Access Tokens](../../doc/controllers/customers.md#get-access-tokens)
* [Get Customers](../../doc/controllers/customers.md#get-customers)
* [Update Customer](../../doc/controllers/customers.md#update-customer)
* [Delete Card](../../doc/controllers/customers.md#delete-card)
* [Get Addresses](../../doc/controllers/customers.md#get-addresses)
* [Get Customer](../../doc/controllers/customers.md#get-customer)


# Update Card

Updates a card

```csharp
UpdateCardAsync(
    string customerId,
    string cardId,
    Models.UpdateCardRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `cardId` | `string` | Template, Required | Card id |
| `request` | [`Models.UpdateCardRequest`](../../doc/models/update-card-request.md) | Body, Required | Request for updating a card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

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
    BillingAddress = new CreateAddressRequest
    {
        Street = "street8",
        Number = "number4",
        ZipCode = "zip_code2",
        Neighborhood = "neighborhood4",
        City = "city8",
        State = "state4",
        Country = "country2",
        Complement = "complement6",
        Line1 = "line_18",
        Line2 = "line_26",
    },
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
    Label = "label6",
};

try
{
    GetCardResponse result = await customersController.UpdateCardAsync(customerId, cardId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `addressId` | `string` | Template, Required | Address Id |
| `request` | [`Models.UpdateAddressRequest`](../../doc/models/update-address-request.md) | Body, Required | Request for updating an address |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

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
    GetAddressResponse result = await customersController.UpdateAddressAsync(customerId, addressId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `tokenId` | `string` | Template, Required | Token Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetAccessTokenResponse>`](../../doc/models/get-access-token-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string tokenId = "token_id6";
try
{
    GetAccessTokenResponse result = await customersController.DeleteAccessTokenAsync(customerId, tokenId, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `request` | [`Models.CreateAddressRequest`](../../doc/models/create-address-request.md) | Body, Required | Request for creating an address |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

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
    GetAddressResponse result = await customersController.CreateAddressAsync(customerId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Customer

Creates a new customer

```csharp
CreateCustomerAsync(
    Models.CreateCustomerRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateCustomerRequest`](../../doc/models/create-customer-request.md) | Body, Required | Request for creating a customer |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetCustomerResponse>`](../../doc/models/get-customer-response.md)

## Example Usage

```csharp
CreateCustomerRequest request = new CreateCustomerRequest
{
    Name = "{\\n    \"name\": \"Tony Stark\"\\n}",
    Email = "email0",
    Document = "document0",
    Type = "type4",
    Address = new CreateAddressRequest
    {
        Street = "street2",
        Number = "number0",
        ZipCode = "zip_code6",
        Neighborhood = "neighborhood8",
        City = "city2",
        State = "state8",
        Country = "country6",
        Complement = "complement8",
        Line1 = "line_16",
        Line2 = "line_20",
    },
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
    Phones = new CreatePhonesRequest
    {
    },
    Code = "code4",
};

try
{
    GetCustomerResponse result = await customersController.CreateCustomerAsync(request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `request` | [`Models.CreateCardRequest`](../../doc/models/create-card-request.md) | Body, Required | Request for creating a card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

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
    GetCardResponse result = await customersController.CreateCardAsync(customerId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListCardsResponse>`](../../doc/models/list-cards-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    ListCardsResponse result = await customersController.GetCardsAsync(customerId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `cardId` | `string` | Template, Required | Card Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string cardId = "card_id4";
try
{
    GetCardResponse result = await customersController.RenewCardAsync(customerId, cardId, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Address

Get a customer's address

```csharp
GetAddressAsync(
    string customerId,
    string addressId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `addressId` | `string` | Template, Required | Address Id |

## Response Type

[`Task<Models.GetAddressResponse>`](../../doc/models/get-address-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string addressId = "address_id0";
try
{
    GetAddressResponse result = await customersController.GetAddressAsync(customerId, addressId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `addressId` | `string` | Template, Required | Address Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetAddressResponse>`](../../doc/models/get-address-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string addressId = "address_id0";
try
{
    GetAddressResponse result = await customersController.DeleteAddressAsync(customerId, addressId, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Access Token

Get a Customer's access token

```csharp
GetAccessTokenAsync(
    string customerId,
    string tokenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `tokenId` | `string` | Template, Required | Token Id |

## Response Type

[`Task<Models.GetAccessTokenResponse>`](../../doc/models/get-access-token-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string tokenId = "token_id6";
try
{
    GetAccessTokenResponse result = await customersController.GetAccessTokenAsync(customerId, tokenId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | The customer id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the customer metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

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
    GetCustomerResponse result = await customersController.UpdateCustomerMetadataAsync(customerId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Card

Get a customer's card

```csharp
GetCardAsync(
    string customerId,
    string cardId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `cardId` | `string` | Template, Required | Card id |

## Response Type

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string cardId = "card_id4";
try
{
    GetCardResponse result = await customersController.GetCardAsync(customerId, cardId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Access Tokens

Delete a Customer's access tokens

```csharp
DeleteAccessTokensAsync(
    string customerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Access Token

Creates a access token for a customer

```csharp
CreateAccessTokenAsync(
    string customerId,
    Models.CreateAccessTokenRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `request` | [`Models.CreateAccessTokenRequest`](../../doc/models/create-access-token-request.md) | Body, Required | Request for creating a access token |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetAccessTokenResponse>`](../../doc/models/get-access-token-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
CreateAccessTokenRequest request = new CreateAccessTokenRequest
{
};

try
{
    GetAccessTokenResponse result = await customersController.CreateAccessTokenAsync(customerId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListAccessTokensResponse>`](../../doc/models/list-access-tokens-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    ListAccessTokensResponse result = await customersController.GetAccessTokensAsync(customerId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Query, Optional | Name of the Customer |
| `document` | `string` | Query, Optional | Document of the Customer |
| `page` | `int?` | Query, Optional | Current page the the search<br>**Default**: `1` |
| `size` | `int?` | Query, Optional | Quantity pages of the search<br>**Default**: `10` |
| `email` | `string` | Query, Optional | Customer's email |
| `code` | `string` | Query, Optional | Customer's code |

## Response Type

[`Task<Models.ListCustomersResponse>`](../../doc/models/list-customers-response.md)

## Example Usage

```csharp
int? page = 1;
int? size = 10;
try
{
    ListCustomersResponse result = await customersController.GetCustomersAsync(null, null, page, size, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `request` | [`Models.UpdateCustomerRequest`](../../doc/models/update-customer-request.md) | Body, Required | Request for updating a customer |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetCustomerResponse>`](../../doc/models/get-customer-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
UpdateCustomerRequest request = new UpdateCustomerRequest
{
};

try
{
    GetCustomerResponse result = await customersController.UpdateCustomerAsync(customerId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |
| `cardId` | `string` | Template, Required | Card Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetCardResponse>`](../../doc/models/get-card-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
string cardId = "card_id4";
try
{
    GetCardResponse result = await customersController.DeleteCardAsync(customerId, cardId, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListAddressesResponse>`](../../doc/models/list-addresses-response.md)

## Example Usage

```csharp
string customerId = "customer_id8";
try
{
    ListAddressesResponse result = await customersController.GetAddressesAsync(customerId, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Customer

Get a customer

```csharp
GetCustomerAsync(
    string customerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `customerId` | `string` | Template, Required | Customer Id |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

