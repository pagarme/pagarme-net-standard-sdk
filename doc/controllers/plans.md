# Plans

```csharp
IPlansController plansController = client.PlansController;
```

## Class Name

`PlansController`

## Methods

* [Get Plan](../../doc/controllers/plans.md#get-plan)
* [Update Plan](../../doc/controllers/plans.md#update-plan)
* [Update Plan Metadata](../../doc/controllers/plans.md#update-plan-metadata)
* [Delete Plan Item](../../doc/controllers/plans.md#delete-plan-item)
* [Get Plans](../../doc/controllers/plans.md#get-plans)
* [Get Plan Item](../../doc/controllers/plans.md#get-plan-item)
* [Delete Plan](../../doc/controllers/plans.md#delete-plan)
* [Update Plan Item](../../doc/controllers/plans.md#update-plan-item)
* [Create Plan Item](../../doc/controllers/plans.md#create-plan-item)
* [Create Plan](../../doc/controllers/plans.md#create-plan)


# Get Plan

Gets a plan

```csharp
GetPlanAsync(
    string planId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `request` | [`Models.UpdatePlanRequest`](../../doc/models/update-plan-request.md) | Body, Required | Request for updating a plan |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

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
    GetPlanResponse result = await plansController.UpdatePlanAsync(planId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | The plan id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the plan metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

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
    GetPlanResponse result = await plansController.UpdatePlanMetadataAsync(planId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";
try
{
    GetPlanItemResponse result = await plansController.DeletePlanItemAsync(planId, planItemId, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

[`Task<Models.ListPlansResponse>`](../../doc/models/list-plans-response.md)

## Example Usage

```csharp
try
{
    ListPlansResponse result = await plansController.GetPlansAsync(null, null, null, null, null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Plan Item

Gets a plan item

```csharp
GetPlanItemAsync(
    string planId,
    string planItemId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";
try
{
    GetPlanItemResponse result = await plansController.GetPlanItemAsync(planId, planItemId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Plan

Deletes a plan

```csharp
DeletePlanAsync(
    string planId,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
try
{
    GetPlanResponse result = await plansController.DeletePlanAsync(planId, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `planItemId` | `string` | Template, Required | Plan item id |
| `body` | [`Models.UpdatePlanItemRequest`](../../doc/models/update-plan-item-request.md) | Body, Required | Request for updating the plan item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
string planItemId = "plan_item_id0";
UpdatePlanItemRequest body = new UpdatePlanItemRequest
{
    Name = "name6",
    Description = "description4",
    Status = "status2",
    PricingScheme = new UpdatePricingSchemeRequest
    {
        SchemeType = "scheme_type2",
        PriceBrackets = new List<Models.UpdatePriceBracketRequest>
        {
            new UpdatePriceBracketRequest
            {
                StartQuantity = 31,
                Price = 225,
            },
        },
    },
};

try
{
    GetPlanItemResponse result = await plansController.UpdatePlanItemAsync(planId, planItemId, body, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `planId` | `string` | Template, Required | Plan id |
| `request` | [`Models.CreatePlanItemRequest`](../../doc/models/create-plan-item-request.md) | Body, Required | Request for creating a plan item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanItemResponse>`](../../doc/models/get-plan-item-response.md)

## Example Usage

```csharp
string planId = "plan_id8";
CreatePlanItemRequest request = new CreatePlanItemRequest
{
    Name = "name6",
    PricingScheme = new CreatePricingSchemeRequest
    {
        SchemeType = "scheme_type2",
    },
    Id = "id6",
    Description = "description6",
};

try
{
    GetPlanItemResponse result = await plansController.CreatePlanItemAsync(planId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Plan

Creates a new plan

```csharp
CreatePlanAsync(
    Models.CreatePlanRequest body,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.CreatePlanRequest`](../../doc/models/create-plan-request.md) | Body, Required | Request for creating a plan |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetPlanResponse>`](../../doc/models/get-plan-response.md)

## Example Usage

```csharp
CreatePlanRequest body = new CreatePlanRequest
{
    Name = "name6",
    Description = "description4",
    StatementDescriptor = "statement_descriptor6",
    Items = new List<Models.CreatePlanItemRequest>
    {
        new CreatePlanItemRequest
        {
            Name = "name3",
            PricingScheme = new CreatePricingSchemeRequest
            {
                SchemeType = "scheme_type5",
            },
            Id = "id3",
            Description = "description3",
        },
    },
    Shippable = false,
    PaymentMethods = new List<string>
    {
        "payment_methods9",
    },
    Installments = new List<int>
    {
        207,
    },
    Currency = "currency6",
    Interval = "interval6",
    IntervalCount = 170,
    BillingDays = new List<int>
    {
        201,
        200,
    },
    BillingType = "billing_type0",
    PricingScheme = new CreatePricingSchemeRequest
    {
        SchemeType = "scheme_type2",
    },
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata7",
        ["key1"] = "metadata8",
    },
};

try
{
    GetPlanResponse result = await plansController.CreatePlanAsync(body, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

