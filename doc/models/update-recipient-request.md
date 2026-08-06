
# Update Recipient Request

Request for updating a Recipient

## Structure

`UpdateRecipientRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name |
| `Email` | `string` | Required | Email |
| `Description` | `string` | Required | Description |
| `Type` | `string` | Required | Type |
| `Status` | `string` | Required | Status |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

UpdateRecipientRequest updateRecipientRequest = new UpdateRecipientRequest
{
    Name = "name4",
    Email = "email2",
    Description = "description4",
    Type = "type4",
    Status = "status6",
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata1",
        ["key1"] = "metadata0",
    },
};
```

