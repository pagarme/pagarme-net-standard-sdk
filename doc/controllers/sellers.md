# Sellers

```csharp
ISellersController sellersController = client.SellersController;
```

## Class Name

`SellersController`

## Methods

* [Create Seller](/doc/controllers/sellers.md#create-seller)
* [Update Seller Metadata](/doc/controllers/sellers.md#update-seller-metadata)
* [Update Seller](/doc/controllers/sellers.md#update-seller)
* [Delete Seller](/doc/controllers/sellers.md#delete-seller)
* [Get Seller by Id](/doc/controllers/sellers.md#get-seller-by-id)
* [Get Sellers](/doc/controllers/sellers.md#get-sellers)


# Create Seller

```csharp
CreateSellerAsync(
    Models.CreateSellerRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateSellerRequest`](/doc/models/create-seller-request.md) | Body, Required | Seller Model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSellerResponse>`](/doc/models/get-seller-response.md)

## Example Usage

```csharp
var request = new CreateSellerRequest();
request.Name = "name6";
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetSellerResponse result = await sellersController.CreateSellerAsync(request, null);
}
catch (ApiException e){};
```


# Update Seller Metadata

```csharp
UpdateSellerMetadataAsync(
    string sellerId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sellerId` | `string` | Template, Required | Seller Id |
| `request` | [`Models.UpdateMetadataRequest`](/doc/models/update-metadata-request.md) | Body, Required | Request for updating the charge metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSellerResponse>`](/doc/models/get-seller-response.md)

## Example Usage

```csharp
string sellerId = "seller_id8";
var request = new UpdateMetadataRequest();
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetSellerResponse result = await sellersController.UpdateSellerMetadataAsync(sellerId, request, null);
}
catch (ApiException e){};
```


# Update Seller

```csharp
UpdateSellerAsync(
    string id,
    Models.UpdateSellerRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | - |
| `request` | [`Models.UpdateSellerRequest`](/doc/models/update-seller-request.md) | Body, Required | Update Seller model |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSellerResponse>`](/doc/models/get-seller-response.md)

## Example Usage

```csharp
string id = "id0";
var request = new UpdateSellerRequest();
request.Name = "name6";
request.Code = "code4";
request.Description = "description6";
request.Document = "document0";
request.Status = "status8";
request.Type = "type4";
request.Address = new CreateAddressRequest();
request.Address.Street = "street2";
request.Address.Number = "number0";
request.Address.ZipCode = "zip_code6";
request.Address.Neighborhood = "neighborhood8";
request.Address.City = "city2";
request.Address.State = "state8";
request.Address.Country = "country6";
request.Address.Complement = "complement8";
request.Address.Metadata = new Dictionary<string, string>();
request.Address.Metadata.Add("key0", "metadata7");
request.Address.Line1 = "line_16";
request.Address.Line2 = "line_20";
request.Metadata = new Dictionary<string, string>();
request.Metadata.Add("key0", "metadata3");

try
{
    GetSellerResponse result = await sellersController.UpdateSellerAsync(id, request, null);
}
catch (ApiException e){};
```


# Delete Seller

```csharp
DeleteSellerAsync(
    string sellerId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sellerId` | `string` | Template, Required | Seller Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetSellerResponse>`](/doc/models/get-seller-response.md)

## Example Usage

```csharp
string sellerId = "sellerId4";

try
{
    GetSellerResponse result = await sellersController.DeleteSellerAsync(sellerId, null);
}
catch (ApiException e){};
```


# Get Seller by Id

```csharp
GetSellerByIdAsync(
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Seller Id |

## Response Type

[`Task<Models.GetSellerResponse>`](/doc/models/get-seller-response.md)

## Example Usage

```csharp
string id = "id0";

try
{
    GetSellerResponse result = await sellersController.GetSellerByIdAsync(id);
}
catch (ApiException e){};
```


# Get Sellers

```csharp
GetSellersAsync(
    int? page = null,
    int? size = null,
    string name = null,
    string document = null,
    string code = null,
    string status = null,
    string type = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `name` | `string` | Query, Optional | - |
| `document` | `string` | Query, Optional | - |
| `code` | `string` | Query, Optional | - |
| `status` | `string` | Query, Optional | - |
| `type` | `string` | Query, Optional | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ListSellerResponse>`](/doc/models/list-seller-response.md)

## Example Usage

```csharp
try
{
    ListSellerResponse result = await sellersController.GetSellersAsync(null, null, null, null, null, null, null, null, null);
}
catch (ApiException e){};
```

