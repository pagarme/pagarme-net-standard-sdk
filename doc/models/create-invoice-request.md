
# Create Invoice Request

Request for creating a new Invoice

## Structure

`CreateInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metadata` | `Dictionary<string, string>` | Required | Metadata |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

CreateInvoiceRequest createInvoiceRequest = new CreateInvoiceRequest
{
    Metadata = new Dictionary<string, string>
    {
        ["key0"] = "metadata9",
        ["key1"] = "metadata8",
        ["key2"] = "metadata7",
    },
};
```

