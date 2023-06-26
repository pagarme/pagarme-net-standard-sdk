# Recipients

```csharp
IRecipientsController recipientsController = client.RecipientsController;
```

## Class Name

`RecipientsController`

## Methods

* [Update Recipient](../../doc/controllers/recipients.md#update-recipient)
* [Create Anticipation](../../doc/controllers/recipients.md#create-anticipation)
* [Get Anticipation Limits](../../doc/controllers/recipients.md#get-anticipation-limits)
* [Get Recipients](../../doc/controllers/recipients.md#get-recipients)
* [Update Recipient Metadata](../../doc/controllers/recipients.md#update-recipient-metadata)
* [Get Transfer](../../doc/controllers/recipients.md#get-transfer)
* [Get Anticipation](../../doc/controllers/recipients.md#get-anticipation)
* [Update Recipient Transfer Settings](../../doc/controllers/recipients.md#update-recipient-transfer-settings)
* [Get Anticipations](../../doc/controllers/recipients.md#get-anticipations)
* [Update Recipient Default Bank Account](../../doc/controllers/recipients.md#update-recipient-default-bank-account)
* [Create Withdraw](../../doc/controllers/recipients.md#create-withdraw)
* [Get Balance](../../doc/controllers/recipients.md#get-balance)
* [Create Transfer](../../doc/controllers/recipients.md#create-transfer)
* [Create Recipient](../../doc/controllers/recipients.md#create-recipient)
* [Update Automatic Anticipation Settings](../../doc/controllers/recipients.md#update-automatic-anticipation-settings)
* [Get Recipient](../../doc/controllers/recipients.md#get-recipient)
* [Get Withdrawals](../../doc/controllers/recipients.md#get-withdrawals)
* [Get Withdraw by Id](../../doc/controllers/recipients.md#get-withdraw-by-id)
* [Get Transfers](../../doc/controllers/recipients.md#get-transfers)
* [Get Recipient by Code](../../doc/controllers/recipients.md#get-recipient-by-code)
* [Get Default Recipient](../../doc/controllers/recipients.md#get-default-recipient)


# Update Recipient

Updates a recipient

```csharp
UpdateRecipientAsync(
    string recipientId,
    Models.UpdateRecipientRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateRecipientRequest`](../../doc/models/update-recipient-request.md) | Body, Required | Recipient data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
UpdateRecipientRequest request = new UpdateRecipientRequest
{
    Name = "name6",
    Email = "email0",
    Description = "description6",
    Type = "type4",
    Status = "status8",
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientAsync(recipientId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Anticipation

Creates an anticipation

```csharp
CreateAnticipationAsync(
    string recipientId,
    Models.CreateAnticipationRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.CreateAnticipationRequest`](../../doc/models/create-anticipation-request.md) | Body, Required | Anticipation data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetAnticipationResponse>`](../../doc/models/get-anticipation-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
CreateAnticipationRequest request = new CreateAnticipationRequest
{
    Amount = 242,
    Timeframe = "timeframe8",
    PaymentDate = DateTime.ParseExact(
        "2016-03-13T12:52:32.123Z",
        "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};

try
{
    GetAnticipationResponse result = await recipientsController.CreateAnticipationAsync(recipientId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Anticipation Limits

Gets the anticipation limits for a recipient

```csharp
GetAnticipationLimitsAsync(
    string recipientId,
    string timeframe,
    DateTime paymentDate)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `timeframe` | `string` | Query, Required | Timeframe |
| `paymentDate` | `DateTime` | Query, Required | Anticipation payment date |

## Response Type

[`Task<Models.GetAnticipationLimitResponse>`](../../doc/models/get-anticipation-limit-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string timeframe = "timeframe2";
DateTime paymentDate = DateTime.ParseExact(
        "2016-03-13T12:52:32.123Z",
        "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
try
{
    GetAnticipationLimitResponse result = await recipientsController.GetAnticipationLimitsAsync(recipientId, timeframe, paymentDate);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Recipients

Retrieves paginated recipients information

```csharp
GetRecipientsAsync(
    int? page = null,
    int? size = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |

## Response Type

[`Task<Models.ListRecipientResponse>`](../../doc/models/list-recipient-response.md)

## Example Usage

```csharp
try
{
    ListRecipientResponse result = await recipientsController.GetRecipientsAsync(null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Recipient Metadata

Updates recipient metadata

```csharp
UpdateRecipientMetadataAsync(
    string recipientId,
    Models.UpdateMetadataRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
UpdateMetadataRequest request = new UpdateMetadataRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientMetadataAsync(recipientId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Transfer

Gets a transfer

```csharp
GetTransferAsync(
    string recipientId,
    string transferId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `transferId` | `string` | Template, Required | Transfer id |

## Response Type

[`Task<Models.GetTransferResponse>`](../../doc/models/get-transfer-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string transferId = "transfer_id6";
try
{
    GetTransferResponse result = await recipientsController.GetTransferAsync(recipientId, transferId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Anticipation

Gets an anticipation

```csharp
GetAnticipationAsync(
    string recipientId,
    string anticipationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `anticipationId` | `string` | Template, Required | Anticipation id |

## Response Type

[`Task<Models.GetAnticipationResponse>`](../../doc/models/get-anticipation-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string anticipationId = "anticipation_id0";
try
{
    GetAnticipationResponse result = await recipientsController.GetAnticipationAsync(recipientId, anticipationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Recipient Transfer Settings

```csharp
UpdateRecipientTransferSettingsAsync(
    string recipientId,
    Models.UpdateTransferSettingsRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient Identificator |
| `request` | [`Models.UpdateTransferSettingsRequest`](../../doc/models/update-transfer-settings-request.md) | Body, Required | - |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
UpdateTransferSettingsRequest request = new UpdateTransferSettingsRequest
{
    TransferEnabled = "transfer_enabled2",
    TransferInterval = "transfer_interval6",
    TransferDay = "transfer_day6",
};

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientTransferSettingsAsync(recipientId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Anticipations

Retrieves a paginated list of anticipations from a recipient

```csharp
GetAnticipationsAsync(
    string recipientId,
    int? page = null,
    int? size = null,
    string status = null,
    string timeframe = null,
    DateTime? paymentDateSince = null,
    DateTime? paymentDateUntil = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `status` | `string` | Query, Optional | Filter for anticipation status |
| `timeframe` | `string` | Query, Optional | Filter for anticipation timeframe |
| `paymentDateSince` | `DateTime?` | Query, Optional | Filter for start range for anticipation payment date |
| `paymentDateUntil` | `DateTime?` | Query, Optional | Filter for end range for anticipation payment date |
| `createdSince` | `DateTime?` | Query, Optional | Filter for start range for anticipation creation date |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for end range for anticipation creation date |

## Response Type

[`Task<Models.ListAnticipationResponse>`](../../doc/models/list-anticipation-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
try
{
    ListAnticipationResponse result = await recipientsController.GetAnticipationsAsync(recipientId, null, null, null, null, null, null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Recipient Default Bank Account

Updates the default bank account from a recipient

```csharp
UpdateRecipientDefaultBankAccountAsync(
    string recipientId,
    Models.UpdateRecipientBankAccountRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateRecipientBankAccountRequest`](../../doc/models/update-recipient-bank-account-request.md) | Body, Required | Bank account data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
UpdateRecipientBankAccountRequest request = new UpdateRecipientBankAccountRequest
{
    BankAccount = new CreateBankAccountRequest
    {
        HolderName = "holder_name6",
        HolderType = "holder_type2",
        HolderDocument = "holder_document4",
        Bank = "bank8",
        BranchNumber = "branch_number6",
        AccountNumber = "account_number0",
        AccountCheckDigit = "account_check_digit6",
        Type = "type0",
        Metadata = new Dictionary<string, string>
        {
            ["key0"] = "metadata9",
            ["key1"] = "metadata8",
        },
    },
    PaymentMode = "bank_transfer",
};

try
{
    GetRecipientResponse result = await recipientsController.UpdateRecipientDefaultBankAccountAsync(recipientId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Withdraw

```csharp
CreateWithdrawAsync(
    string recipientId,
    Models.CreateWithdrawRequest request)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `request` | [`Models.CreateWithdrawRequest`](../../doc/models/create-withdraw-request.md) | Body, Required | - |

## Response Type

[`Task<Models.GetWithdrawResponse>`](../../doc/models/get-withdraw-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
CreateWithdrawRequest request = new CreateWithdrawRequest
{
    Amount = 242,
};

try
{
    GetWithdrawResponse result = await recipientsController.CreateWithdrawAsync(recipientId, request);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Balance

Get balance information for a recipient

```csharp
GetBalanceAsync(
    string recipientId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |

## Response Type

[`Task<Models.GetBalanceResponse>`](../../doc/models/get-balance-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
try
{
    GetBalanceResponse result = await recipientsController.GetBalanceAsync(recipientId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Transfer

Creates a transfer for a recipient

```csharp
CreateTransferAsync(
    string recipientId,
    Models.CreateTransferRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient Id |
| `request` | [`Models.CreateTransferRequest`](../../doc/models/create-transfer-request.md) | Body, Required | Transfer data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetTransferResponse>`](../../doc/models/get-transfer-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
CreateTransferRequest request = new CreateTransferRequest
{
    Amount = 242,
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
};

try
{
    GetTransferResponse result = await recipientsController.CreateTransferAsync(recipientId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Recipient

Creates a new recipient

```csharp
CreateRecipientAsync(
    Models.CreateRecipientRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`Models.CreateRecipientRequest`](../../doc/models/create-recipient-request.md) | Body, Required | Recipient data |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
CreateRecipientRequest request = new CreateRecipientRequest
{
    Name = "name6",
    Email = "email0",
    Description = "description6",
    Document = "document0",
    Type = "type4",
    DefaultBankAccount = new CreateBankAccountRequest
    {
        HolderName = "holder_name0",
        HolderType = "holder_type6",
        HolderDocument = "holder_document8",
        Bank = "bank2",
        BranchNumber = "branch_number0",
        AccountNumber = "account_number4",
        AccountCheckDigit = "account_check_digit0",
        Type = "type4",
        Metadata = new Dictionary<string, string>
        {
            ["key0"] = "metadata5",
        },
    },
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata3",
    },
    Code = "code4",
    PaymentMode = "bank_transfer",
};

try
{
    GetRecipientResponse result = await recipientsController.CreateRecipientAsync(request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Automatic Anticipation Settings

Updates recipient metadata

```csharp
UpdateAutomaticAnticipationSettingsAsync(
    string recipientId,
    Models.UpdateAutomaticAnticipationSettingsRequest request,
    string idempotencyKey = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`Models.UpdateAutomaticAnticipationSettingsRequest`](../../doc/models/update-automatic-anticipation-settings-request.md) | Body, Required | Metadata |
| `idempotencyKey` | `string` | Header, Optional | - |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
UpdateAutomaticAnticipationSettingsRequest request = new UpdateAutomaticAnticipationSettingsRequest
{
};

try
{
    GetRecipientResponse result = await recipientsController.UpdateAutomaticAnticipationSettingsAsync(recipientId, request, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Recipient

Retrieves recipient information

```csharp
GetRecipientAsync(
    string recipientId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipiend id |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
try
{
    GetRecipientResponse result = await recipientsController.GetRecipientAsync(recipientId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Withdrawals

Gets a paginated list of transfers for the recipient

```csharp
GetWithdrawalsAsync(
    string recipientId,
    int? page = null,
    int? size = null,
    string status = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `page` | `int?` | Query, Optional | - |
| `size` | `int?` | Query, Optional | - |
| `status` | `string` | Query, Optional | - |
| `createdSince` | `DateTime?` | Query, Optional | - |
| `createdUntil` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.ListWithdrawals>`](../../doc/models/list-withdrawals.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
try
{
    ListWithdrawals result = await recipientsController.GetWithdrawalsAsync(recipientId, null, null, null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Withdraw by Id

```csharp
GetWithdrawByIdAsync(
    string recipientId,
    string withdrawalId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `withdrawalId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.GetWithdrawResponse>`](../../doc/models/get-withdraw-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
string withdrawalId = "withdrawal_id2";
try
{
    GetWithdrawResponse result = await recipientsController.GetWithdrawByIdAsync(recipientId, withdrawalId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Transfers

Gets a paginated list of transfers for the recipient

```csharp
GetTransfersAsync(
    string recipientId,
    int? page = null,
    int? size = null,
    string status = null,
    DateTime? createdSince = null,
    DateTime? createdUntil = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `page` | `int?` | Query, Optional | Page number |
| `size` | `int?` | Query, Optional | Page size |
| `status` | `string` | Query, Optional | Filter for transfer status |
| `createdSince` | `DateTime?` | Query, Optional | Filter for start range of transfer creation date |
| `createdUntil` | `DateTime?` | Query, Optional | Filter for end range of transfer creation date |

## Response Type

[`Task<Models.ListTransferResponse>`](../../doc/models/list-transfer-response.md)

## Example Usage

```csharp
string recipientId = "recipient_id0";
try
{
    ListTransferResponse result = await recipientsController.GetTransfersAsync(recipientId, null, null, null, null, null);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Recipient by Code

Retrieves recipient information

```csharp
GetRecipientByCodeAsync(
    string code)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `code` | `string` | Template, Required | Recipient code |

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
string code = "code8";
try
{
    GetRecipientResponse result = await recipientsController.GetRecipientByCodeAsync(code);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Default Recipient

```csharp
GetDefaultRecipientAsync()
```

## Response Type

[`Task<Models.GetRecipientResponse>`](../../doc/models/get-recipient-response.md)

## Example Usage

```csharp
try
{
    GetRecipientResponse result = await recipientsController.GetDefaultRecipientAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

