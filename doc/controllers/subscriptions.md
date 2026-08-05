# Subscriptions

```csharp
ISubscriptionsController subscriptionsController = client.SubscriptionsController;
```

## Class Name

`SubscriptionsController`

## Methods

* [Cancel Subscription](../../doc/controllers/subscriptions.md#cancel-subscription)
* [Create an Usage](../../doc/controllers/subscriptions.md#create-an-usage)
* [Create Discount](../../doc/controllers/subscriptions.md#create-discount)
* [Create Increment](../../doc/controllers/subscriptions.md#create-increment)
* [Create Subscription](../../doc/controllers/subscriptions.md#create-subscription)
* [Create Subscription Item](../../doc/controllers/subscriptions.md#create-subscription-item)
* [Create Usage](../../doc/controllers/subscriptions.md#create-usage)
* [Delete Discount](../../doc/controllers/subscriptions.md#delete-discount)
* [Delete Increment](../../doc/controllers/subscriptions.md#delete-increment)
* [Delete Subscription Item](../../doc/controllers/subscriptions.md#delete-subscription-item)
* [Delete Usage](../../doc/controllers/subscriptions.md#delete-usage)
* [Get Discount by Id](../../doc/controllers/subscriptions.md#get-discount-by-id)
* [Get Discounts](../../doc/controllers/subscriptions.md#get-discounts)
* [Get Increment by Id](../../doc/controllers/subscriptions.md#get-increment-by-id)
* [Get Increments](../../doc/controllers/subscriptions.md#get-increments)
* [Get Subscription](../../doc/controllers/subscriptions.md#get-subscription)
* [Get Subscription Cycle by Id](../../doc/controllers/subscriptions.md#get-subscription-cycle-by-id)
* [Get Subscription Cycles](../../doc/controllers/subscriptions.md#get-subscription-cycles)
* [Get Subscription Item](../../doc/controllers/subscriptions.md#get-subscription-item)
* [Get Subscription Items](../../doc/controllers/subscriptions.md#get-subscription-items)
* [Get Subscriptions](../../doc/controllers/subscriptions.md#get-subscriptions)
* [Get Usage Report](../../doc/controllers/subscriptions.md#get-usage-report)
* [Get Usages](../../doc/controllers/subscriptions.md#get-usages)
* [Renew Subscription](../../doc/controllers/subscriptions.md#renew-subscription)
* [Update Current Cycle Status](../../doc/controllers/subscriptions.md#update-current-cycle-status)
* [Update Latest Period End At](../../doc/controllers/subscriptions.md#update-latest-period-end-at)
* [Update Split Subscription](../../doc/controllers/subscriptions.md#update-split-subscription)
* [Update Subscription Affiliation Id](../../doc/controllers/subscriptions.md#update-subscription-affiliation-id)
* [Update Subscription Billing Date](../../doc/controllers/subscriptions.md#update-subscription-billing-date)
* [Update Subscription Card](../../doc/controllers/subscriptions.md#update-subscription-card)
* [Update Subscription Due Days](../../doc/controllers/subscriptions.md#update-subscription-due-days)
* [Update Subscription Item](../../doc/controllers/subscriptions.md#update-subscription-item)
* [Update Subscription Metadata](../../doc/controllers/subscriptions.md#update-subscription-metadata)
* [Update Subscription Minium Price](../../doc/controllers/subscriptions.md#update-subscription-minium-price)
* [Update Subscription Payment Method](../../doc/controllers/subscriptions.md#update-subscription-payment-method)
* [Update Subscription Start At](../../doc/controllers/subscriptions.md#update-subscription-start-at)


# Cancel Subscription

Cancels a subscription

```csharp
CancelSubscriptionAsync(
    string subscriptionId,
    Models.CreateCancelSubscriptionRequest request = null,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`CreateCancelSubscriptionRequest`](../../doc/models/create-cancel-subscription-request.md) | Body, Optional | Request for cancelling a subscription |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
CreateCancelSubscriptionRequest request = new CreateCancelSubscriptionRequest
{
    CancelPendingInvoices = true,
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.CancelSubscriptionAsync(
        subscriptionId,
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


# Create an Usage

Create Usage

```csharp
CreateAnUsageAsync(
    string subscriptionId,
    string itemId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `itemId` | `string` | Template, Required | Item id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetUsageResponse>`](../../doc/models/get-usage-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
try
{
    GetUsageResponse result = await subscriptionsController.CreateAnUsageAsync(
        subscriptionId,
        itemId
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


# Create Discount

Creates a discount

```csharp
CreateDiscountAsync(
    string subscriptionId,
    Models.CreateDiscountRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`CreateDiscountRequest`](../../doc/models/create-discount-request.md) | Body, Required | Request for creating a discount |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
CreateDiscountRequest request = new CreateDiscountRequest
{
    MValue = 185.28,
    DiscountType = "discount_type4",
    ItemId = "item_id6",
};

try
{
    GetDiscountResponse result = await subscriptionsController.CreateDiscountAsync(
        subscriptionId,
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


# Create Increment

Creates a increment

```csharp
CreateIncrementAsync(
    string subscriptionId,
    Models.CreateIncrementRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`CreateIncrementRequest`](../../doc/models/create-increment-request.md) | Body, Required | Request for creating a increment |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
CreateIncrementRequest request = new CreateIncrementRequest
{
    MValue = 185.28,
    IncrementType = "increment_type8",
    ItemId = "item_id6",
};

try
{
    GetIncrementResponse result = await subscriptionsController.CreateIncrementAsync(
        subscriptionId,
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


# Create Subscription

Creates a new subscription

```csharp
CreateSubscriptionAsync(
    Models.CreateSubscriptionRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateSubscriptionRequest`](../../doc/models/create-subscription-request.md) | Body, Required | Request for creating a subscription |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
CreateSubscriptionRequest body = new CreateSubscriptionRequest
{
    Customer = new CreateCustomerRequest
    {
        Name = "Tony Stark",
        Email = null,
        Document = null,
        Type = null,
        Address = null,
        Metadata = null,
        Phones = null,
        Code = null,
    },
    Card = new CreateCardRequest
    {
        Type = "credit",
    },
    Code = null,
    PaymentMethod = null,
    BillingType = null,
    StatementDescriptor = null,
    Description = null,
    Currency = null,
    Interval = null,
    IntervalCount = 0,
    PricingScheme = null,
    Items = new List<CreateSubscriptionItemRequest>
    {
        new CreateSubscriptionItemRequest
        {
            Description = null,
            PricingScheme = null,
            Id = null,
            PlanItemId = null,
            Discounts = new List<CreateDiscountRequest>
            {
                null,
            },
            Name = null,
        },
    },
    Shipping = null,
    Discounts = new List<CreateDiscountRequest>
    {
        null,
    },
    Metadata = null,
    Increments = new List<CreateIncrementRequest>
    {
        null,
    },
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.CreateSubscriptionAsync(body);
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


# Create Subscription Item

Creates a new Subscription item

```csharp
CreateSubscriptionItemAsync(
    string subscriptionId,
    Models.CreateSubscriptionItemRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`CreateSubscriptionItemRequest`](../../doc/models/create-subscription-item-request.md) | Body, Required | Request for creating a subscription item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
CreateSubscriptionItemRequest request = new CreateSubscriptionItemRequest
{
    Description = null,
    PricingScheme = null,
    Id = null,
    PlanItemId = null,
    Discounts = new List<CreateDiscountRequest>
    {
        null,
    },
    Name = null,
};

try
{
    GetSubscriptionItemResponse result = await subscriptionsController.CreateSubscriptionItemAsync(
        subscriptionId,
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


# Create Usage

Creates a usage

```csharp
CreateUsageAsync(
    string subscriptionId,
    string itemId,
    Models.CreateUsageRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `itemId` | `string` | Template, Required | Item id |
| `body` | [`CreateUsageRequest`](../../doc/models/create-usage-request.md) | Body, Required | Request for creating a usage |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetUsageResponse>`](../../doc/models/get-usage-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
CreateUsageRequest body = new CreateUsageRequest
{
    Quantity = 156,
    Description = "description4",
    UsedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};

try
{
    GetUsageResponse result = await subscriptionsController.CreateUsageAsync(
        subscriptionId,
        itemId,
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


# Delete Discount

Deletes a discount

```csharp
DeleteDiscountAsync(
    string subscriptionId,
    string discountId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `discountId` | `string` | Template, Required | Discount Id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string discountId = "discount_id8";
try
{
    GetDiscountResponse result = await subscriptionsController.DeleteDiscountAsync(
        subscriptionId,
        discountId
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


# Delete Increment

Deletes a increment

```csharp
DeleteIncrementAsync(
    string subscriptionId,
    string incrementId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `incrementId` | `string` | Template, Required | Increment id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string incrementId = "increment_id8";
try
{
    GetIncrementResponse result = await subscriptionsController.DeleteIncrementAsync(
        subscriptionId,
        incrementId
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


# Delete Subscription Item

Deletes a subscription item

```csharp
DeleteSubscriptionItemAsync(
    string subscriptionId,
    string subscriptionItemId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `subscriptionItemId` | `string` | Template, Required | Subscription item id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string subscriptionItemId = "subscription_item_id4";
try
{
    GetSubscriptionItemResponse result = await subscriptionsController.DeleteSubscriptionItemAsync(
        subscriptionId,
        subscriptionItemId
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


# Delete Usage

Deletes a usage

```csharp
DeleteUsageAsync(
    string subscriptionId,
    string itemId,
    string usageId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `itemId` | `string` | Template, Required | The subscription item id |
| `usageId` | `string` | Template, Required | The usage id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetUsageResponse>`](../../doc/models/get-usage-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
string usageId = "usage_id0";
try
{
    GetUsageResponse result = await subscriptionsController.DeleteUsageAsync(
        subscriptionId,
        itemId,
        usageId
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


# Get Discount by Id

```csharp
GetDiscountByIdAsync(
    string subscriptionId,
    string discountId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `discountId` | `string` | Template, Required | - |

## Response Type

**200**

[`Task<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string discountId = "discountId0";
try
{
    GetDiscountResponse result = await subscriptionsController.GetDiscountByIdAsync(
        subscriptionId,
        discountId
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


# Get Discounts

```csharp
GetDiscountsAsync(
    string subscriptionId,
    int page,
    int size)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `page` | `int` | Query, Required | Page number |
| `size` | `int` | Query, Required | Page size |

## Response Type

**200**

[`Task<Models.ListDiscountsResponse>`](../../doc/models/list-discounts-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
int page = 30;
int size = 18;
try
{
    ListDiscountsResponse result = await subscriptionsController.GetDiscountsAsync(
        subscriptionId,
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


# Get Increment by Id

```csharp
GetIncrementByIdAsync(
    string subscriptionId,
    string incrementId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription Id |
| `incrementId` | `string` | Template, Required | The increment Id |

## Response Type

**200**

[`Task<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string incrementId = "increment_id8";
try
{
    GetIncrementResponse result = await subscriptionsController.GetIncrementByIdAsync(
        subscriptionId,
        incrementId
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


# Get Increments

```csharp
GetIncrementsAsync(
    string subscriptionId,
    int? page = null,
    int? size = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

**200**

[`Task<Models.ListIncrementsResponse>`](../../doc/models/list-increments-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
try
{
    ListIncrementsResponse result = await subscriptionsController.GetIncrementsAsync(subscriptionId);
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


# Get Subscription

Gets a subscription

```csharp
GetSubscriptionAsync(
    string subscriptionId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
try
{
    GetSubscriptionResponse result = await subscriptionsController.GetSubscriptionAsync(subscriptionId);
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


# Get Subscription Cycle by Id

```csharp
GetSubscriptionCycleByIdAsync(
    string subscriptionId,
    string cycleId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `cycleId` | `string` | Template, Required | - |

## Response Type

**200**

[`Task<Models.GetPeriodResponse>`](../../doc/models/get-period-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string cycleId = "cycleId0";
try
{
    GetPeriodResponse result = await subscriptionsController.GetSubscriptionCycleByIdAsync(
        subscriptionId,
        cycleId
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


# Get Subscription Cycles

```csharp
GetSubscriptionCyclesAsync(
    string subscriptionId,
    string page,
    string size)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `page` | `string` | Query, Required | Page number |
| `size` | `string` | Query, Required | Page size |

## Response Type

**200**

[`Task<Models.ListCyclesResponse>`](../../doc/models/list-cycles-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string page = "page8";
string size = "size0";
try
{
    ListCyclesResponse result = await subscriptionsController.GetSubscriptionCyclesAsync(
        subscriptionId,
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


# Get Subscription Item

Get Subscription Item

```csharp
GetSubscriptionItemAsync(
    string subscriptionId,
    string itemId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `itemId` | `string` | Template, Required | Item id |

## Response Type

**200**

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
try
{
    GetSubscriptionItemResponse result = await subscriptionsController.GetSubscriptionItemAsync(
        subscriptionId,
        itemId
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


# Get Subscription Items

Get Subscription Items

```csharp
GetSubscriptionItemsAsync(
    string subscriptionId,
    int? page = null,
    int? size = null,
    string name = null,
    string code = null,
    string status = null,
    string description = null,
    string createdSince = null,
    string createdUntil = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `name` | `string` | Query, Optional | The item name |
| `code` | `string` | Query, Optional | Identification code in the client system |
| `status` | `string` | Query, Optional | The item statis |
| `description` | `string` | Query, Optional | The item description |
| `createdSince` | `string` | Query, Optional | Filter for item's creation date start range |
| `createdUntil` | `string` | Query, Optional | Filter for item's creation date end range |

## Response Type

**200**

[`Task<Models.ListSubscriptionItemsResponse>`](../../doc/models/list-subscription-items-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
try
{
    ListSubscriptionItemsResponse result = await subscriptionsController.GetSubscriptionItemsAsync(subscriptionId);
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


# Get Subscriptions

Gets all subscriptions

```csharp
GetSubscriptionsAsync(
    int? page = null,
    int? size = null,
    string code = null,
    string billingType = null,
    string customerId = null,
    string planId = null,
    string cardId = null,
    string status = null,
    DateTime? nextBillingSince = null,
    DateTime? nextBillingUntil = null,
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
| `code` | `string` | Query, Optional | Filter for subscription's code |
| `billingType` | `string` | Query, Optional | Filter for subscription's billing type |
| `customerId` | `string` | Query, Optional | Filter for subscription's customer id |
| `planId` | `string` | Query, Optional | Filter for subscription's plan id |
| `cardId` | `string` | Query, Optional | Filter for subscription's card id |
| `status` | `string` | Query, Optional | Filter for subscription's status |
| `nextBillingSince` | `DateTime?` | Query, Optional | Filter for subscription's next billing date start range |
| `nextBillingUntil` | `DateTime?` | Query, Optional | Filter for subscription's next billing date end range |
| `createdSince` | `DateTime?` | Query, Optional | Filter for subscription's creation date start range |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for subscriptions creation date end range |

## Response Type

**200**

[`Task<Models.ListSubscriptionsResponse>`](../../doc/models/list-subscriptions-response.md)

## Example Usage

```csharp
try
{
    ListSubscriptionsResponse result = await subscriptionsController.GetSubscriptionsAsync();
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


# Get Usage Report

```csharp
GetUsageReportAsync(
    string subscriptionId,
    string periodId)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription Id |
| `periodId` | `string` | Template, Required | The period Id |

## Response Type

**200**

[`Task<Models.GetUsageReportResponse>`](../../doc/models/get-usage-report-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string periodId = "period_id0";
try
{
    GetUsageReportResponse result = await subscriptionsController.GetUsageReportAsync(
        subscriptionId,
        periodId
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


# Get Usages

Lists all usages from a subscription item

```csharp
GetUsagesAsync(
    string subscriptionId,
    string itemId,
    int? page = null,
    int? size = null,
    string code = null,
    string mGroup = null,
    DateTime? usedSince = null,
    DateTime? usedUntil = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `itemId` | `string` | Template, Required | The subscription item id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `code` | `string` | Query, Optional | Identification code in the client system |
| `mGroup` | `string` | Query, Optional | Identification group in the client system |
| `usedSince` | `DateTime?` | Query, Optional | - |
| `usedUntil` | `DateTime?` | Query, Optional | - |

## Response Type

**200**

[`Task<Models.ListUsagesResponse>`](../../doc/models/list-usages-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
try
{
    ListUsagesResponse result = await subscriptionsController.GetUsagesAsync(
        subscriptionId,
        itemId
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


# Renew Subscription

```csharp
RenewSubscriptionAsync(
    string subscriptionId,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | - |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetPeriodResponse>`](../../doc/models/get-period-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
try
{
    GetPeriodResponse result = await subscriptionsController.RenewSubscriptionAsync(subscriptionId);
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


# Update Current Cycle Status

```csharp
UpdateCurrentCycleStatusAsync(
    string subscriptionId,
    Models.UpdateCurrentCycleStatusRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `request` | [`UpdateCurrentCycleStatusRequest`](../../doc/models/update-current-cycle-status-request.md) | Body, Required | Request for updating the end date of the subscription current status |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

`Task`

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateCurrentCycleStatusRequest request = new UpdateCurrentCycleStatusRequest
{
    Status = "status8",
};

try
{
    await subscriptionsController.UpdateCurrentCycleStatusAsync(
        subscriptionId,
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


# Update Latest Period End At

```csharp
UpdateLatestPeriodEndAtAsync(
    string subscriptionId,
    Models.UpdateCurrentCycleEndDateRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | - |
| `request` | [`UpdateCurrentCycleEndDateRequest`](../../doc/models/update-current-cycle-end-date-request.md) | Body, Required | Request for updating the end date of the current signature cycle |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateCurrentCycleEndDateRequest request = new UpdateCurrentCycleEndDateRequest
{
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateLatestPeriodEndAtAsync(
        subscriptionId,
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


# Update Split Subscription

```csharp
UpdateSplitSubscriptionAsync(
    string id,
    Models.UpdateSubscriptionSplitRequest request)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Template, Required | Subscription's id |
| `request` | [`UpdateSubscriptionSplitRequest`](../../doc/models/update-subscription-split-request.md) | Body, Required | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string id = "id0";
UpdateSubscriptionSplitRequest request = new UpdateSubscriptionSplitRequest
{
    Enabled = false,
    Rules = new List<CreateSplitRequest>
    {
        null,
    },
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSplitSubscriptionAsync(
        id,
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


# Update Subscription Affiliation Id

```csharp
UpdateSubscriptionAffiliationIdAsync(
    string subscriptionId,
    Models.UpdateSubscriptionAffiliationIdRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | - |
| `request` | [`UpdateSubscriptionAffiliationIdRequest`](../../doc/models/update-subscription-affiliation-id-request.md) | Body, Required | Request for updating a subscription affiliation id |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateSubscriptionAffiliationIdRequest request = new UpdateSubscriptionAffiliationIdRequest
{
    GatewayAffiliationId = "gateway_affiliation_id2",
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionAffiliationIdAsync(
        subscriptionId,
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


# Update Subscription Billing Date

Updates the billing date from a subscription

```csharp
UpdateSubscriptionBillingDateAsync(
    string subscriptionId,
    Models.UpdateSubscriptionBillingDateRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `request` | [`UpdateSubscriptionBillingDateRequest`](../../doc/models/update-subscription-billing-date-request.md) | Body, Required | Request for updating the subscription billing date |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateSubscriptionBillingDateRequest request = new UpdateSubscriptionBillingDateRequest
{
    NextBillingAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionBillingDateAsync(
        subscriptionId,
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


# Update Subscription Card

Updates the credit card from a subscription

```csharp
UpdateSubscriptionCardAsync(
    string subscriptionId,
    Models.UpdateSubscriptionCardRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`UpdateSubscriptionCardRequest`](../../doc/models/update-subscription-card-request.md) | Body, Required | Request for updating a card |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateSubscriptionCardRequest request = new UpdateSubscriptionCardRequest
{
    Card = new CreateCardRequest
    {
        Type = "credit",
    },
    CardId = null,
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionCardAsync(
        subscriptionId,
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


# Update Subscription Due Days

Updates the boleto due days from a subscription

```csharp
UpdateSubscriptionDueDaysAsync(
    string subscriptionId,
    Models.UpdateSubscriptionDueDaysRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `request` | [`UpdateSubscriptionDueDaysRequest`](../../doc/models/update-subscription-due-days-request.md) | Body, Required | - |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateSubscriptionDueDaysRequest request = new UpdateSubscriptionDueDaysRequest
{
    BoletoDueDays = 226,
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionDueDaysAsync(
        subscriptionId,
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


# Update Subscription Item

Updates a subscription item

```csharp
UpdateSubscriptionItemAsync(
    string subscriptionId,
    string itemId,
    Models.UpdateSubscriptionItemRequest body,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `itemId` | `string` | Template, Required | Item id |
| `body` | [`UpdateSubscriptionItemRequest`](../../doc/models/update-subscription-item-request.md) | Body, Required | Request for updating a subscription item |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionItemResponse>`](../../doc/models/get-subscription-item-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
string itemId = "item_id0";
UpdateSubscriptionItemRequest body = new UpdateSubscriptionItemRequest
{
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
    Name = null,
};

try
{
    GetSubscriptionItemResponse result = await subscriptionsController.UpdateSubscriptionItemAsync(
        subscriptionId,
        itemId,
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


# Update Subscription Metadata

Updates the metadata from a subscription

```csharp
UpdateSubscriptionMetadataAsync(
    string subscriptionId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `request` | [`UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Request for updating the subscrption metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateMetadataRequest request = new UpdateMetadataRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionMetadataAsync(
        subscriptionId,
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


# Update Subscription Minium Price

Atualização do valor mínimo da assinatura

```csharp
UpdateSubscriptionMiniumPriceAsync(
    string subscriptionId,
    Models.UpdateSubscriptionMinimumPriceRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription Id |
| `request` | [`UpdateSubscriptionMinimumPriceRequest`](../../doc/models/update-subscription-minimum-price-request.md) | Body, Required | Request da requisição com o valor mínimo que será configurado |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateSubscriptionMinimumPriceRequest request = new UpdateSubscriptionMinimumPriceRequest
{
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionMiniumPriceAsync(
        subscriptionId,
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


# Update Subscription Payment Method

Updates the payment method from a subscription

```csharp
UpdateSubscriptionPaymentMethodAsync(
    string subscriptionId,
    Models.UpdateSubscriptionPaymentMethodRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | Subscription id |
| `request` | [`UpdateSubscriptionPaymentMethodRequest`](../../doc/models/update-subscription-payment-method-request.md) | Body, Required | Request for updating the paymentmethod from a subscription |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateSubscriptionPaymentMethodRequest request = new UpdateSubscriptionPaymentMethodRequest
{
    PaymentMethod = null,
    CardId = null,
    Card = new CreateCardRequest
    {
        Type = "credit",
    },
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionPaymentMethodAsync(
        subscriptionId,
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


# Update Subscription Start At

Updates the start at date from a subscription

```csharp
UpdateSubscriptionStartAtAsync(
    string subscriptionId,
    Models.UpdateSubscriptionStartAtRequest request,
    string idempotencyKey = null)
```

## Authentication

This endpoint requires [httpBasic](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `string` | Template, Required | The subscription id |
| `request` | [`UpdateSubscriptionStartAtRequest`](../../doc/models/update-subscription-start-at-request.md) | Body, Required | Request for updating the subscription start date |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

**200**

[`Task<Models.GetSubscriptionResponse>`](../../doc/models/get-subscription-response.md)

## Example Usage

```csharp
string subscriptionId = "subscription_id0";
UpdateSubscriptionStartAtRequest request = new UpdateSubscriptionStartAtRequest
{
    StartAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};

try
{
    GetSubscriptionResponse result = await subscriptionsController.UpdateSubscriptionStartAtAsync(
        subscriptionId,
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

