
# Get Anticipation Limit Response

Anticipation limit

## Structure

`GetAnticipationLimitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | Amount |
| `AnticipationFee` | `int?` | Optional | Anticipation fee |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetAnticipationLimitResponse getAnticipationLimitResponse = new GetAnticipationLimitResponse
{
    Amount = 160,
    AnticipationFee = 190,
};
```

