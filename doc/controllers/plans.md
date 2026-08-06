# Plans

```csharp
IPlansController plansController = client.PlansController;
```

## Class Name

`PlansController`

## Methods

* [Create Plan](../../doc/controllers/plans.md#create-plan)
* [Create Plan Item](../../doc/controllers/plans.md#create-plan-item)
* [Delete Plan](../../doc/controllers/plans.md#delete-plan)
* [Delete Plan Item](../../doc/controllers/plans.md#delete-plan-item)
* [Get Plan](../../doc/controllers/plans.md#get-plan)
* [Get Plan Item](../../doc/controllers/plans.md#get-plan-item)
* [Get Plans](../../doc/controllers/plans.md#get-plans)
* [Update Plan](../../doc/controllers/plans.md#update-plan)
* [Update Plan Item](../../doc/controllers/plans.md#update-plan-item)
* [Update Plan Metadata](../../doc/controllers/plans.md#update-plan-metadata)


# Create Plan

Creates a new plan

```csharp
CreatePlanAsync(
    Models.CreatePlanRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreatePlanRequest`](../../doc/models/create-plan-request.md) | Body, Required | Request for creating a plan |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
CreatePlanRequest body = new CreatePlanRequest
{
    Name = null,
    Description = null,
    StatementDescriptor = null,
    Items = new List<CreatePlanItemRequest>
    {
        null,
    },
    Shippable = false,
    PaymentMethods = null,
    Installments = null,
    Currency = null,
    Interval = null,
    IntervalCount = 0,
    BillingDays = null,
    BillingType = null,
    PricingScheme = null,
    Metadata = null,
};

try
{
    GetPlanResponse result = await plansController.CreatePlanAsync(body);
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


# Create Plan Item

Adds a new item to a plan

```csharp
CreatePlanItemAsync(
    string planId,
    Models.CreatePlanItemRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `request` | [`CreatePlanItemRequest`](../../doc/models/create-plan-item-request.md) | Body, Required | Request for creating a plan item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
CreatePlanItemRequest request = new CreatePlanItemRequest
{
    Name = "name6",
    PricingScheme = null,
    Id = "id6",
    Description = "description6",
};

try
{
    GetPlanItemResponse result = await plansController.CreatePlanItemAsync(
        planId,
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


# Delete Plan

Deletes a plan

```csharp
DeletePlanAsync(
    string planId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
try
{
    GetPlanResponse result = await plansController.DeletePlanAsync(planId);
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


# Delete Plan Item

Removes an item from a plan

```csharp
DeletePlanItemAsync(
    string planId,
    string planItemId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";
try
{
    GetPlanItemResponse result = await plansController.DeletePlanItemAsync(
        planId,
        planItemId
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


# Get Plan

Gets a plan

```csharp
GetPlanAsync(
    string planId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |

## Response Type

**200**

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
try
{
    GetPlanResponse result = await plansController.GetPlanAsync(planId);
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


# Get Plan Item

Gets a plan item

```csharp
GetPlanItemAsync(
    string planId,
    string planItemId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |

## Response Type

**200**

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";
try
{
    GetPlanItemResponse result = await plansController.GetPlanItemAsync(
        planId,
        planItemId
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


# Get Plans

Gets all plans

```csharp
GetPlansAsync(
    int? page = null,
    int? size = null,
    string name = null,
    string status = null,
    string billingType = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `name` | `string` | Query, Optional | Filter for Plan's name |
| `status` | `string` | Query, Optional | Filter for Plan's status |
| `billingType` | `string` | Query, Optional | Filter for plan's billing type |
| `createdSince` | `DateTime?` | Query, Optional | Filter for plan's creation date start range |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for plan's creation date end range |

## Response Type

**200**

[`Task<Models.ListPlansResponse>`](../../doc/models/list-plans-response.md)

## Example Usage

```csharp
try
{
    ListPlansResponse result = await plansController.GetPlansAsync();
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


# Update Plan

Updates a plan

```csharp
UpdatePlanAsync(
    string planId,
    Models.UpdatePlanRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `request` | [`UpdatePlanRequest`](../../doc/models/update-plan-request.md) | Body, Required | Request for updating a plan |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
UpdatePlanRequest request = new UpdatePlanRequest
{
    Name = "name6",
    Description = "description6",
    Installments = new List<int>
    {
        151,
        152,
    },
    StatementDescriptor = "statement_descriptor6",
    Currency = "currency6",
    Interval = "interval4",
    IntervalCount = 114,
    PaymentMethods = new List<string>
    {
        "payment_methods1",
        "payment_methods0",
        "payment_methods9",
    },
    BillingType = "billing_type0",
    Status = "status8",
    Shippable = false,
    BillingDays = new List<int>
    {
        115,
    },
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetPlanResponse result = await plansController.UpdatePlanAsync(
        planId,
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


# Update Plan Item

Updates a plan item

```csharp
UpdatePlanItemAsync(
    string planId,
    string planItemId,
    Models.UpdatePlanItemRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |
| `body` | [`UpdatePlanItemRequest`](../../doc/models/update-plan-item-request.md) | Body, Required | Request for updating the plan item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";
UpdatePlanItemRequest body = new UpdatePlanItemRequest
{
    Name = null,
    Description = null,
    Status = null,
    PricingScheme = new UpdatePricingSchemeRequest
    {
        SchemeType = null,
        PriceBrackets = new List<UpdatePriceBracketRequest>
        {
            null,
        },
    },
};

try
{
    GetPlanItemResponse result = await plansController.UpdatePlanItemAsync(
        planId,
        planItemId,
        body
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


# Update Plan Metadata

Updates the metadata from a plan

```csharp
UpdatePlanMetadataAsync(
    string planId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | The plan id |
| `request` | [`UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the plan metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
UpdateMetadataRequest request = new UpdateMetadataRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetPlanResponse result = await plansController.UpdatePlanMetadataAsync(
        planId,
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

