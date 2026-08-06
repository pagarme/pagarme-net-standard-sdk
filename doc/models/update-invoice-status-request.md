
# Update Invoice Status Request

Invoice Update Status Request

## Structure

`UpdateInvoiceStatusRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | Status |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

UpdateInvoiceStatusRequest updateInvoiceStatusRequest = new UpdateInvoiceStatusRequest
{
    Status = "status2",
};
```

